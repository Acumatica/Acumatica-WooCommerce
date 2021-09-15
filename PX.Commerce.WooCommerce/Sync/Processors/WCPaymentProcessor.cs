using PX.Commerce.Core;
using PX.Commerce.Core.API;
using PX.Commerce.Objects;
using PX.Commerce.WooCommerce.API.REST.Client.DataRepository;
using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order;
using PX.Commerce.WooCommerce.API.REST.Domain.Enums;
using PX.Commerce.WooCommerce.API.REST.Filters;
using PX.Commerce.WooCommerce.WC;
using PX.Commerce.WooCommerce.WC.DAC;
using PX.Commerce.WooCommerce.WC.Descriptor;
using PX.Common;
using PX.Data;
using PX.Objects.AR;
using PX.Objects.Common;
using PX.Objects.GL;
using PX.Objects.SO;
using System;
using System.Collections.Generic;
using System.Linq;
using static PX.Commerce.WooCommerce.WC.Descriptor.Constants;

namespace PX.Commerce.WooCommerce.Sync.Processors
{
    public class WCPaymentEntityBucket : EntityBucketBase, IEntityBucket
    {
        public IMappedEntity Primary => Payment;
        public IMappedEntity[] Entities => new IMappedEntity[] { Primary };

        public MappedPayment Payment;
        public MappedOrder Order;
    }

    [BCProcessor(typeof(WCConnector), BCEntitiesAttribute.Payment, BCCaptions.Payment,
        IsInternal = false,
        Direction = SyncDirection.Import,
        PrimaryDirection = SyncDirection.Import,
        PrimarySystem = PrimarySystem.Extern,
        PrimaryGraph = typeof(ARPaymentEntry),
        ExternTypes = new Type[] { typeof(OrdersTransactionData) },
        LocalTypes = new Type[] { typeof(Payment) },
        AcumaticaPrimaryType = typeof(ARPayment),
        AcumaticaPrimarySelect = typeof(Search<ARPayment.refNbr, Where<ARPayment.docType, Equal<ARDocType.payment>>>),
        URL = "post.php?post={0}&action=edit",
        Requires = new string[] { BCEntitiesAttribute.Order })]
    [BCProcessorRealtime(PushSupported = false, HookSupported = false)]
    public class WCPaymentProcessor : BCProcessorSingleBase<WCPaymentProcessor, WCPaymentEntityBucket, MappedPayment>, IProcessor
    {
        private const string AUTHNET_CAPTURE_TRANS_ID = "_wc_authorize_net_cim_credit_card_capture_trans_id";
        private const string YES = "yes";

        protected OrderRestDataProvider orderDataProvider;
        protected OrderPaymentRestDataProvider orderPaymentDataProvider;

        public WCHelper helper = CreateInstance<WCHelper>();

        #region Constructor
        public override void Initialise(IConnector iconnector, ConnectorOperation operation)
        {
            base.Initialise(iconnector, operation);
            var client = WCConnector.GetRestClient(GetBindingExt<BCBindingWooCommerce>());
            orderDataProvider = new OrderRestDataProvider(client);
            orderPaymentDataProvider = new OrderPaymentRestDataProvider(client);

            helper.Initialize(this);
        }
        #endregion

        #region Pull
        public override MappedPayment PullEntity(Guid? localID, Dictionary<string, object> fields)
        {
            Payment impl = cbapi.GetByID<Payment>(localID);
            if (impl == null) return null;

            MappedPayment obj = new MappedPayment(impl, impl.SyncID, impl.SyncTime);

            return obj;
        }

        public override MappedPayment PullEntity(string externID, string jsonObject)
        {
            OrdersTransactionData data = orderPaymentDataProvider.GetByID(externID.KeySplit(1));
            if (data == null) return null;

            MappedPayment obj = new MappedPayment(data,
                                                  new object[] { data.OrderId, data.Id }.KeyCombine(),
                                                  data.DateCreatedUT.ToDate(),
                                                  data.CalculateHash());

            return obj;
        }

        public override IEnumerable<MappedPayment> PullSimilar(IExternEntity entity, out string uniqueField)
        {
            var externEntity = (OrdersTransactionData)entity;

            uniqueField = externEntity.Id.ToString();
            if (string.IsNullOrEmpty(uniqueField))
                return null;

            List<MappedPayment> result = new List<MappedPayment>();
            foreach (ARRegister item in helper.PaymentByExternalRef.Select(uniqueField))
            {
                Payment data = new Payment() { SyncID = item.NoteID, SyncTime = item.LastModifiedDateTime };
                result.Add(new MappedPayment(data, data.SyncID, data.SyncTime));
            }
            return result;
        }
        #endregion

        #region Import
        public override void FetchBucketsForImport(DateTime? minDateTime, DateTime? maxDateTime, PXFilterRow[] filters)
        {
            FilterOrders filter = new FilterOrders();
            if (minDateTime != null) filter.CreatedAfter = minDateTime;

            IEnumerable<OrderData> orders = orderDataProvider.GetAll();
            foreach (OrderData data in orders)
            {
                if (!string.IsNullOrWhiteSpace(data.PaymentMethod)
                && data.Status != OrderStatuses.Failed)
                {
                    data.Transactions = new List<OrdersTransactionData>();
                    var trans1 = helper.CreateOrderTransactionData(data);
                    trans1.paymentEvent = helper.GetLastEvent(trans1);
                    data.Transactions.Add(trans1);
                    if (data.Metadata.Any(a => a.Key == AUTHNET_CAPTURE_TRANS_ID))
                    {
                        var trans2 = helper.CreateOrderTransactionData(data);
                        trans2.paymentEvent = OrderPaymentEvent.Capture;
                        data.Transactions.Add(trans2);
                    }
                    foreach (OrdersTransactionData tranData in data.Transactions)
                    {

                        WCPaymentEntityBucket bucket = CreateBucket();

                        MappedOrder order = bucket.Order = bucket.Order.Set(data, data.Id?.ToString(), data.DateModifiedGmt.ToDate());
                        EntityStatus orderStatus = EnsureStatus(order);

                        OrderPaymentEvent lastEvent = tranData.paymentEvent;

                        MappedPayment obj = bucket.Payment = bucket.Payment.Set(tranData, new Object[] { data.Id, tranData.Id }.KeyCombine(), data.DateCreatedUT.ToDate(), data.CalculateHash()).With(_ => { _.ParentID = order.SyncID; return _; });
                        EntityStatus status = EnsureStatus(obj, SyncDirection.Import);
                    }
                    if (helper.CreatePaymentfromOrder(data.PaymentMethod))
                    {
                        OrdersTransactionData tranData = helper.CreateOrderTransactionData(data);
                        WCPaymentEntityBucket bucket = CreateBucket();

                        MappedOrder order = bucket.Order = bucket.Order.Set(data, data.Id?.ToString(), data.DateModifiedGmt.ToDate());
                        EntityStatus orderStatus = EnsureStatus(order);

                        MappedPayment obj = bucket.Payment = bucket.Payment.Set(tranData, data.Id.ToString(), data.DateModifiedGmt.ToDate(), data.CalculateHash());
                        EntityStatus status = EnsureStatus(obj, SyncDirection.Import);
                    }
                }
            }
        }

        public override EntityStatus GetBucketForImport(WCPaymentEntityBucket bucket, BCSyncStatus syncstatus)
        {
            if (syncstatus.ExternID.HasParent())
            {
                var data = orderPaymentDataProvider.GetByID(syncstatus.ExternID.KeySplit(0));
                if (data == null) return EntityStatus.None;

                OrderData orderData = orderDataProvider.GetByID(data.OrderId);
                if (orderData.Metadata.Any(a => a.Key == AUTHNET_CAPTURE_TRANS_ID))
                {
                    data.paymentEvent = OrderPaymentEvent.Capture;
                }

                data.PaymentMethod = orderData.PaymentMethod;
                MappedPayment obj = bucket.Payment = bucket.Payment.Set(data, new object[] { data.OrderId, data.Id }.KeyCombine(), data.DateCreatedUT.ToDate(), data.CalculateHash());
                EntityStatus status = EnsureStatus(obj, SyncDirection.Import);

                MappedOrder order = bucket.Order = bucket.Order.Set(orderData, orderData.Id?.ToString(), orderData.DateModifiedGmt.ToDate());
                EnsureStatus(order);

                return status;
            }
            else
            {
                OrderData orderData = orderDataProvider.GetByID(syncstatus.ExternID);
                if (!string.IsNullOrWhiteSpace(orderData.PaymentMethod) /*&& helper.CreatePaymentfromOrder(orderData.PaymentMethod)*/)
                {
                    OrdersTransactionData data = helper.CreateOrderTransactionData(orderData);
                    MappedPayment obj = bucket.Payment = bucket.Payment.Set(data, data.Id.ToString(), orderData.DateModifiedGmt.ToDate(), data.CalculateHash());
                    EntityStatus status = EnsureStatus(obj, SyncDirection.Import);
                    MappedOrder order = bucket.Order = bucket.Order.Set(orderData, orderData.Id?.ToString(), orderData.DateModifiedGmt.ToDate());
                    EnsureStatus(order);
                    return status;
                }
                return EntityStatus.None;
            }
        }

        public override void MapBucketImport(WCPaymentEntityBucket bucket, IMappedEntity existing)
        {
            MappedPayment obj = bucket.Payment;

            OrdersTransactionData data = obj.Extern;
            Payment impl = obj.Local = new Payment();
            BCBinding binding = GetBinding();
            BCBindingExt bindingExt = GetBindingExt<BCBindingExt>();

            PXResult<SOOrder, PX.Objects.AR.Customer, PX.Objects.CR.Location, BCSyncStatus> result = PXSelectJoin<SOOrder,
                InnerJoin<PX.Objects.AR.Customer, On<PX.Objects.AR.Customer.bAccountID, Equal<SOOrder.customerID>>,
                InnerJoin<PX.Objects.CR.Location, On<PX.Objects.CR.Location.locationID, Equal<SOOrder.customerLocationID>>,
                InnerJoin<BCSyncStatus, On<SOOrder.noteID, Equal<BCSyncStatus.localID>>>>>,
                Where<BCSyncStatus.connectorType, Equal<Current<BCEntity.connectorType>>,
                    And<BCSyncStatus.bindingID, Equal<Current<BCEntity.bindingID>>,
                    And<BCSyncStatus.entityType, Equal<Required<BCEntity.entityType>>,
                    And<BCSyncStatus.externID, Equal<Required<BCSyncStatus.externID>>>>>>>
                .Select(this, BCEntitiesAttribute.Order, data.OrderId).Select(r => (PXResult<SOOrder, PX.Objects.AR.Customer, PX.Objects.CR.Location, BCSyncStatus>)r).FirstOrDefault();
            if (result == null) throw new PXException(BCMessages.OrderNotSyncronized, data.OrderId);
            SOOrder order = result.GetItem<SOOrder>();
            PX.Objects.AR.Customer customer = result.GetItem<PX.Objects.AR.Customer>();
            PX.Objects.CR.Location location = result.GetItem<PX.Objects.CR.Location>();

            //Product
            impl.Type = PX.Objects.AR.Messages.Prepayment.ValueField();
            impl.CustomerID = customer.AcctCD.ValueField();
            impl.CustomerLocationID = location.LocationCD.ValueField();
            impl.CurrencyID = data.Currency.ValueField();
            var date = data.DateCreatedUT.ToString().ToDate(PXTimeZoneInfo.FindSystemTimeZoneById(bindingExt.OrderTimeZone));
            if (date.HasValue)
                impl.ApplicationDate = new DateTime(date.Value.Date.Ticks).ValueField();

            impl.PaymentAmount = data.Amount.ValueField();
            impl.BranchID = Branch.PK.Find(this, binding.BranchID)?.BranchCD?.ValueField();
            impl.Hold = false.ValueField();

            BCPaymentMethods methodMapping = helper.GetPaymentMethodMapping(data.PaymentMethod, bucket.Order?.Extern?.PaymentMethod, data.Currency, out string cashAcount);
            if (((MappedPayment)existing)?.Local != null && ((MappedPayment)existing)?.Local.PaymentMethod != methodMapping?.PaymentMethodID?.Trim()?.ValueField())
                impl.PaymentMethod = ((MappedPayment)existing)?.Local.PaymentMethod;
            else
                impl.PaymentMethod = methodMapping?.PaymentMethodID?.Trim()?.ValueField();
            impl.CashAccount = cashAcount?.Trim()?.ValueField();
            impl.NeedRelease = methodMapping?.ReleasePayments ?? false;

            impl.Description = PXMessages.LocalizeFormat(WCMessages.PaymentDescription, binding.BindingName, methodMapping.StorePaymentMethod, data.OrderId, data.Id).ValueField();

            impl.ExternalRef = data.Id.ToString().ValueField();
            impl.PaymentRef = helper.ParseTransactionNumber(data, out bool isCreditCardTransaction).ValueField();

            //Credit Card:
            if (!string.IsNullOrWhiteSpace(methodMapping?.ProcessingCenterID) && isCreditCardTransaction)
            {
                var lastEvent = helper.GetLastEvent(data);
                var paymentToken = data.Metadata.FirstOrDefault(s => s.Key.Equals("_wc_authorize_net_cim_credit_card_payment_token", StringComparison.InvariantCultureIgnoreCase));

                helper.AddCreditCardProcessingInfo(methodMapping, impl, lastEvent, paymentToken?.Value ?? string.Empty);
            }

            //Calculated Unpaid Balance
            decimal curyUnpaidBalance = order.CuryOrderTotal ?? 0m;
            foreach (SOAdjust adj in PXSelect<SOAdjust,
                            Where<SOAdjust.adjdOrderType, Equal<Required<SOOrder.orderType>>,
                                And<SOAdjust.adjdOrderNbr, Equal<Required<SOOrder.orderNbr>>>>>.Select(this, order.OrderType, order.OrderNbr))
            {
                curyUnpaidBalance -= adj.CuryAdjdAmt ?? 0m;
            }

            //If we have applied already, than skip

            if (existing as MappedPayment == null
                || ((MappedPayment)existing).Local == null
                || ((MappedPayment)existing).Local.OrdersToApply == null
                || !((MappedPayment)existing).Local.OrdersToApply.Any(d => d.OrderType?.Value == order.OrderType && d.OrderNbr?.Value == order.OrderNbr))
            {
                decimal applicationAmount = 0m;
                if (bucket.Order.Extern.Status != OrderStatuses.Refunded)
                    applicationAmount = data.Amount > curyUnpaidBalance ? curyUnpaidBalance : data.Amount;

                //Order to Apply
                PaymentOrderDetail detail = new PaymentOrderDetail();
                detail.OrderType = order.OrderType.ValueField();
                detail.OrderNbr = order.OrderNbr.ValueField();
                detail.AppliedToOrder = applicationAmount.ValueField();
                impl.OrdersToApply = new List<PaymentOrderDetail>(new[] { detail });
            }
        }

        public override void SaveBucketImport(WCPaymentEntityBucket bucket, IMappedEntity existing, string operation)
        {
            MappedPayment obj = bucket.Payment;
            Boolean needRelease = obj.Local.NeedRelease;

            BCSyncStatus orderStatus = PXSelectJoin<BCSyncStatus,
                InnerJoin<SOOrder, On<SOOrder.noteID, Equal<BCSyncStatus.localID>,
                    And<SOOrder.lastModifiedDateTime, Equal<BCSyncStatus.localTS>>>>,
                Where<BCSyncStatus.syncID, Equal<Required<BCSyncStatus.syncID>>>>.Select(this, bucket.Order.SyncID);

            Payment impl = null;


            if (obj.Extern.paymentEvent == OrderPaymentEvent.Capture && existing?.Local != null)
            {
                impl = cbapi.Invoke<Payment, CardOperation>(existing.Local as Payment, action: new CardOperation()
                {
                    TranType = CCTranTypeCode.PriorAuthorizedCapture.ValueField(),
                    TranNbr = helper.ParseTransactionNumber(obj.Extern, out bool isCreditCardTran).ValueField()
                });
                bucket.Payment.AddLocal(null, obj.LocalID, impl.SyncTime);
            }
            else
            {
                impl = cbapi.Put<Payment>(obj.Local, obj.LocalID);
                bucket.Payment.AddLocal(impl, impl.SyncID, impl.SyncTime);
            }

            if (needRelease && impl.Status?.Value == PX.Objects.AR.Messages.Balanced)
            {
                impl = cbapi.Invoke<Payment, ReleasePayment>(impl);
                bucket.Payment.AddLocal(null, obj.LocalID, impl.SyncTime);
            }

            UpdateStatus(obj, operation);

            if (orderStatus?.LocalID != null) //Payment save updates the order, we need to change the saved timestamp.
            {
                orderStatus.LocalTS = BCSyncExactTimeAttribute.SelectDateTime<SOOrder.lastModifiedDateTime>(orderStatus.LocalID.Value);
                orderStatus = (BCSyncStatus)Statuses.Cache.Update(orderStatus);
            }

            var authNet = obj.Extern.Metadata.SingleOrDefault(s => s.Key == PaymentCaptureKey.AuthNet);
            if (existing != null && obj.Local.Status.Value == PX.Objects.AR.Messages.CCHold
                && obj.Extern.Metadata.Any(m => m.Key == AUTHNET_CAPTURE_TRANS_ID) && authNet?.Value == YES
                && !string.IsNullOrWhiteSpace(obj.Extern.PaymentInstrumentToken))
            {
                impl = cbapi.Invoke(existing.Local as Payment, action: new CardOperation()
                {
                    TranType = CCTranTypeCode.PriorAuthorizedCapture.ValueField(),
                    TranNbr = helper.ParseTransactionNumber(obj.Extern, out _).ValueField()
                });
                bucket.Payment.AddLocal(null, obj.LocalID, impl.SyncTime);
            }
        }

        #endregion

        #region Export
        public override void FetchBucketsForExport(DateTime? minDateTime, DateTime? maxDateTime, PXFilterRow[] filters)
        {
        }

        public override EntityStatus GetBucketForExport(WCPaymentEntityBucket bucket, BCSyncStatus syncstatus)
        {
            Payment impl = cbapi.GetByID<Payment>(syncstatus.LocalID);
            if (impl == null) return EntityStatus.None;

            bucket.Payment = bucket.Payment.Set(impl, impl.SyncID, impl.SyncTime);
            EntityStatus status = EnsureStatus(bucket.Payment, SyncDirection.Export);

            return status;
        }

        public override void MapBucketExport(WCPaymentEntityBucket bucket, IMappedEntity existing)
        {
        }
        public override void SaveBucketExport(WCPaymentEntityBucket bucket, IMappedEntity existing, string operation)
        {
        }
        #endregion

    }
}
