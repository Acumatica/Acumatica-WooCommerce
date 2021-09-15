using PX.Api.ContractBased.Models;
using PX.Commerce.Core;
using PX.Commerce.Core.API;
using PX.Commerce.Objects;
using PX.Commerce.WooCommerce.API.REST.Client.DataRepository;
using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Customer;
using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order;
using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Product;
using PX.Commerce.WooCommerce.API.REST.Domain.Enums;
using PX.Commerce.WooCommerce.API.REST.Filters;
using PX.Commerce.WooCommerce.Sync.Buckets;
using PX.Commerce.WooCommerce.WC;
using PX.Commerce.WooCommerce.WC.DAC;
using PX.Commerce.WooCommerce.WC.Descriptor;
using PX.Common;
using PX.Data;
using PX.Objects.AR;
using PX.Objects.Common;
using PX.Objects.CS;
using PX.Objects.GL;
using PX.Objects.IN;
using PX.Objects.SO;
using System;
using System.Collections.Generic;
using System.Linq;
using static PX.Commerce.WooCommerce.WC.Descriptor.Constants;
using BillingAddressData = PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order.BillingAddressData;
using Country = PX.Objects.CS.Country;
using ShippingAddressData = PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order.ShippingAddressData;
using State = PX.Objects.CS.State;

namespace PX.Commerce.WooCommerce.Sync.Processors
{
    public class BCSalesOrderRestrictor : BCBaseRestrictor, IRestrictor
    {
        public FilterResult RestrictExport(IProcessor processor, IMappedEntity mapped)
        {
            return base.Restrict(mapped, delegate (MappedOrder obj)
            {
                return null;
            });
        }

        public virtual FilterResult RestrictImport(IProcessor processor, IMappedEntity mapped)
        {
            #region Orders
            return base.Restrict(mapped, delegate (MappedOrder obj)
            {
                if (obj.IsNew && obj.Extern != null
                    && (obj.Extern.Status == OrderStatuses.Cancelled
                        //|| obj.Extern.Status == OrderStatuses.Refunded
                        || obj.Extern.Status == OrderStatuses.Failed
                        || obj.Extern.Status == OrderStatuses.Trash))
                {
                    return new FilterResult(FilterStatus.Filtered,
                        PXMessages.LocalizeFormatNoPrefixNLA(BCMessages.LogOrderSkippedExtStatusNotSupported, obj.Extern.Id, obj.Extern.Status.ToString()));
                }
                return null;
            });
            #endregion
        }
    }

    [BCProcessor(typeof(WCConnector), BCEntitiesAttribute.Order, BCCaptions.Order,
        IsInternal = false,
        Direction = SyncDirection.Import,
        PrimaryDirection = SyncDirection.Import,
        PrimarySystem = PrimarySystem.Extern,
        PrimaryGraph = typeof(SOOrderEntry),
        ExternTypes = new Type[] { typeof(OrderData) },
        LocalTypes = new Type[] { typeof(SalesOrder) },
        DetailTypes = new string[] { BCEntitiesAttribute.OrderLine, BCCaptions.OrderLine, BCEntitiesAttribute.OrderAddress, BCCaptions.OrderAddress },
        AcumaticaPrimaryType = typeof(SOOrder),
        AcumaticaPrimarySelect = typeof(Search2<SOOrder.orderNbr,
            InnerJoin<BCBindingExt, On<BCBindingExt.orderType, Equal<SOOrder.orderType>>,
            InnerJoin<BCBinding, On<BCBindingExt.bindingID, Equal<BCBinding.bindingID>>>>,
            Where<BCBinding.connectorType, Equal<Current<BCSyncStatusEdit.connectorType>>,
                And<BCBinding.bindingID, Equal<Current<BCSyncStatusEdit.bindingID>>>>>),
        URL = "post.php?post={0}&action=edit",
        Requires = new string[] { BCEntitiesAttribute.Customer, BCEntitiesAttribute.StockItem }
    )]

    public class WCSalesOrderProcessor : WCOrderBaseProcessor<WCSalesOrderProcessor, WCSalesOrderBucket, MappedOrder>
    {
        private const string AUTHNET_CAPTURE_TRANS_ID = "_wc_authorize_net_cim_credit_card_capture_trans_id";
        protected CustomerDataProvider customerDataProvider;

        protected ProductRestDataProvider productDataProvider;

        protected CouponDataProvider couponDataProvider;

        protected TaxClasesProvider taxClassDataProvider;
        protected OrderNotesDataProvider orderNotesDataProvider;
        protected List<BCShippingMappings> shippingMappings;

        protected Dictionary<int, string> prodClasses = new Dictionary<int, string>();

        public PXSelect<State, Where<State.name, Equal<Required<State.name>>, Or<State.stateID, Equal<Required<State.stateID>>>>> states;
        public WCPaymentProcessor paymentProcessor = PXGraph.CreateInstance<WCPaymentProcessor>();

        #region Initialization
        public override void Initialise(IConnector iconnector, ConnectorOperation operation)
        {
            base.Initialise(iconnector, operation);

            var client = WCConnector.GetRestClient(GetBindingExt<BCBindingWooCommerce>());
            productDataProvider = new ProductRestDataProvider(client);

            customerDataProvider = new CustomerDataProvider(client);
            taxClassDataProvider = new TaxClasesProvider(client);
            orderNotesDataProvider = new OrderNotesDataProvider(client);
            couponDataProvider = new CouponDataProvider(client);
            if (GetEntity(BCEntitiesAttribute.Payment)?.IsActive == true)
            {
                paymentProcessor.Initialise(iconnector, operation.Clone().With(_ => { _.EntityType = BCEntitiesAttribute.Payment; return _; }));
            }

        }
        #endregion

        #region Common
        public override MappedOrder PullEntity(Guid? localID, Dictionary<string, object> fields)
        {
            SalesOrder impl = cbapi.GetByID<SalesOrder>(localID);
            if (impl == null) return null;

            MappedOrder obj = new MappedOrder(impl, impl.SyncID, impl.SyncTime);

            return obj;
        }
        public override MappedOrder PullEntity(string externID, string jsonObject)
        {
            OrderData data = orderDataProvider.GetByID(externID);
            if (data == null) return null;

            MappedOrder obj = new MappedOrder(data, data.Id?.ToString(), data.DateModifiedGmt.ToDate());

            return obj;
        }

        public override IEnumerable<MappedOrder> PullSimilar(IExternEntity entity, out string uniqueField)
        {
            uniqueField = ((OrderData)entity)?.Id?.ToString();
            if (string.IsNullOrEmpty(uniqueField))
                return null;

            uniqueField = APIHelper.ReferenceMake(uniqueField, GetBinding().BindingName);

            var currentBindingExt = GetBindingExt<BCBindingExt>();
            List<MappedOrder> result = new List<MappedOrder>();
            List<string> orderTypes = new List<string>() { currentBindingExt?.OrderType };
            if (!string.IsNullOrWhiteSpace(currentBindingExt.OtherSalesOrderTypes))
            {
                //Support exported order type searching
                var exportedOrderTypes = currentBindingExt.OtherSalesOrderTypes?.Split(',').Where(i => i != currentBindingExt.OrderType);
                if (exportedOrderTypes.Count() > 0)
                    orderTypes.AddRange(exportedOrderTypes);
            }
            foreach (SOOrder item in helper.OrderByTypesAndCustomerRefNbr.Select(orderTypes.ToArray(), uniqueField))
            {
                SalesOrder data = new SalesOrder() { SyncID = item.NoteID, SyncTime = item.LastModifiedDateTime, ExternalRef = item.CustomerRefNbr?.ValueField() };
                result.Add(new MappedOrder(data, data.SyncID, data.SyncTime));
            }
            return result;
        }
        public override IEnumerable<MappedOrder> PullSimilar(ILocalEntity entity, out string uniqueField)
        {
            uniqueField = ((SalesOrder)entity)?.ExternalRef?.Value;
            if (string.IsNullOrEmpty(uniqueField))
                return null;

            uniqueField = APIHelper.ReferenceParse(uniqueField, GetBinding().BindingName);

            OrderData data = orderDataProvider.GetByID(uniqueField);
            if (data == null) return null;

            List<MappedOrder> result = new List<MappedOrder>();
            result.Add(new MappedOrder(data, data.Id.ToString(), data.DateModified.ToDate()));
            return result;
        }

        public override void ControlDirection(WCSalesOrderBucket bucket, BCSyncStatus status, ref bool shouldImport, ref bool shouldExport, ref bool skipSync, ref bool skipForce)
        {
            MappedOrder order = bucket.Order;

            string primarySystem = this.GetEntity()?.PrimarySystem;


            if ((shouldImport || Operation.SyncMethod == SyncMode.Force)
                && !order.IsNew
                && order?.ExternID != null
                && order?.LocalID != null
                && (order.Local?.Status?.Value == PX.Objects.SO.Messages.Completed || order.Local?.Status?.Value == PX.Objects.SO.Messages.Cancelled))
            {
                if ((status.Status == BCSyncStatusAttribute.Synchronized) &&
                        order?.Extern?.Status == OrderStatuses.Completed)
                {
                    skipForce = true;
                    skipSync = true;
                    status.LastOperation = BCSyncOperationAttribute.ManuallySynced;
                    status.LastErrorMessage = null;
                    UpdateStatus(order, status.LastOperation, status.LastErrorMessage);
                    shouldImport = false;// if order is canceled or completed in ERP and Fullfilled in External System then skip import and mark order as synchronized
                }
                else if (order?.Extern?.OrderRefunds.Count > 0)
                {
                    var orderTotal = order.Extern.TotalInDecimal;
                    if (order.Extern.TaxLines?.Count > 0 && this.GetBindingExt<BCBindingExt>().TaxSynchronization == false)
                        orderTotal -= order.Extern.TotalTaxInDecimal;
                    var itemTotals = order.Extern.LineItems.Sum(s => s.Quantity);
                    if (!string.IsNullOrEmpty(order?.Local.ExternalRefundRef?.Value))// to check if there were any refunds processed before order was completed
                    {
                        var refundsBeforeOrderCompleted = order.Local.ExternalRefundRef.Value?.Split(";".ToCharArray())?.ToList();
                        if (refundsBeforeOrderCompleted != null)
                        {
                            var refunds = order.Extern.Refunds.SelectMany(x => x.LineItems).ToList();
                            orderTotal -= refunds.Sum(x => x.TotalInDecimal.Abs());
                            itemTotals -= refunds.Sum(x => x.Quantity.Abs());
                        }
                    }

                    var refundItem = GetBindingExt<BCBindingExt>()?.RefundAmountItemID != null
                        ? InventoryItem.PK.Find(this, GetBindingExt<BCBindingExt>()?.RefundAmountItemID)
                        : throw new PXException(WCMessages.NoRefundItem);
                    //We should prevent order from sync if it is updated by refunds
                    if (orderTotal == order.Local.OrderTotal?.Value && itemTotals == (order.Local?.Details?.Where(x => x.InventoryID?.Value != refundItem?.InventoryCD?.Trim())?.Sum(x => x.OrderQty?.Value ?? 0) ?? 0))
                    {
                        DateTime? orderdate = order.Extern.DateModified.ToDate();
                        DateTime? refundDate = order.Extern.Refunds.Max(x => x.DateCreatedUT).ToDate();

                        if (orderdate != null && refundDate != null && Math.Abs((orderdate - refundDate).Value.TotalSeconds) < 10)
                        {
                            skipForce = true;
                            skipSync = true;
                            shouldImport = false;
                            UpdateStatus(order, status.LastOperation, status.LastErrorMessage);
                        }
                    }
                }
            }
            if (shouldExport && !string.IsNullOrEmpty(order.Local?.ExternalRefundRef?.Value))
            {
                shouldExport = false; // prevent export if refunds were processed
                UpdateStatus(order, status.LastOperation, status.LastErrorMessage);
                skipSync = true;
            }

        }

        public override Boolean ControlModification(IMappedEntity mapped, BCSyncStatus status, string operation)
        {
            if (mapped is MappedOrder)
            {
                MappedOrder order = mapped as MappedOrder;
                if (operation == BCSyncOperationAttribute.ExternChanged && !order.IsNew && order?.Extern != null && status?.PendingSync == false)
                {
                    //We should prevent order from sync if it is updated by shipment
                    if (order.Extern.Status == OrderStatuses.Completed && order.LocalID != null)
                    {
                        return false;
                    }
                }
            }

            return base.ControlModification(mapped, status, operation);
        }

        #endregion

        #region Import
        public override void FetchBucketsForImport(DateTime? minDateTime, DateTime? maxDateTime, PXFilterRow[] filters)
        {
            FilterOrders filter = new FilterOrders();
            if (minDateTime != null) filter.CreatedAfter = minDateTime;

            IEnumerable<OrderData> datas = orderDataProvider.GetAll(filter);

            int countNum = 0;
            List<IMappedEntity> mappedList = new List<IMappedEntity>();
            foreach (OrderData data in datas)
            {
                IMappedEntity obj = new MappedOrder(data, data.Id?.ToString(), data.DateModifiedGmt.ToDate());

                mappedList.Add(obj);
                countNum++;
                if (countNum % BatchFetchCount == 0)
                {
                    ProcessMappedListForImport(ref mappedList);
                }
            }
            if (mappedList.Any())
            {
                ProcessMappedListForImport(ref mappedList);
            }
        }

        public override EntityStatus GetBucketForImport(WCSalesOrderBucket bucket, BCSyncStatus syncstatus)
        {
            OrderData data = orderDataProvider.GetByID(syncstatus.ExternID);
            if (data == null || data.Status.Equals(OrderStatuses.Trash)) return EntityStatus.None;

            if (data.OrderRefunds != null && data.OrderRefunds.Any())
                data.Refunds = orderRefundsRestDataProvider.GetByParentId(data.Id.ToString());
            else
                data.Refunds = new List<RefundData>();



            MappedOrder obj = bucket.Order = bucket.Order.Set(data, data.Id?.ToString(), data.DateModifiedGmt.ToDate());
            EntityStatus status = EnsureStatus(obj, SyncDirection.Import);

            if (status != EntityStatus.Pending && status != EntityStatus.Syncronized && Operation.SyncMethod != SyncMode.Force)
                return status;

            if (data.CustomerId > 0)
            {
                CustomerData customer = customerDataProvider.GetCustomerById(data.CustomerId.Value);
                MappedCustomer customerObj = bucket.Customer = bucket.Customer.Set(customer, data.CustomerId?.ToString(), customer.DateModified.ToDate());
                EntityStatus customerStatus = EnsureStatus(customerObj);
            }

            if (GetEntity(BCEntitiesAttribute.Payment)?.IsActive == true
                && !string.IsNullOrWhiteSpace(data.PaymentMethod)
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
                    OrderPaymentEvent lastEvent = tranData.paymentEvent;
                    tranData.PaymentMethod = data.PaymentMethod;
                    MappedPayment paymentObj = new MappedPayment(tranData, data.Id.ToString(), data.DateModifiedGmt.ToDate(), tranData.CalculateHash());

                    EntityStatus paymentStatus = EnsureStatus(paymentObj, SyncDirection.Import);

                    if (paymentStatus == EntityStatus.Pending)
                    {
                        bucket.Payments.Add(paymentObj);
                    }
                }
            }
            return status;
        }

        public override void MapBucketImport(WCSalesOrderBucket bucket, IMappedEntity existing)
        {
            MappedOrder obj = bucket.Order;
            var currentBinding = GetBinding();
            var currentBindingExt = GetBindingExt<BCBindingExt>();
            OrderData data = obj.Extern;
            SalesOrder impl = obj.Local = new SalesOrder();
            SalesOrder presented = existing?.Local as SalesOrder;
            decimal? refundedDiscount = 0m;
            decimal exceededRefundAmount = 0;
            decimal? totalFloatingRefundedAmount = 0;

            //Set Refund Status
            data.RefundStatus = GetRefundStatus(data);


            // we can update only open orders
            if (presented != null && presented.Status?.Value != PX.Objects.SO.Messages.Open && presented.Status?.Value != PX.Objects.SO.Messages.Hold
                && presented.Status?.Value != BCObjectsMessages.RiskHold && presented.Status?.Value != PX.Objects.SO.Messages.CreditHold && presented.Status?.Value != PX.Objects.SO.Messages.PendingProcessing)
            {
                throw new PXException(BCMessages.OrderStatusDoesNotAllowModification, presented.OrderNbr?.Value);
            }
            var description = PXMessages.LocalizeFormat(WCMessages.OrderDescription, currentBinding.BindingName, data.Id.ToString(), data.Status?.ToString());
            impl.Description = description.ValueField();
            if (presented != null && data.RefundStatus == RefundStatus.Full)
            {
                return;// if order is fully refunded cancel  the order
            }
            impl.Custom = GetCustomFieldsForImport();

            #region SalesOrder

            impl.OrderType = currentBindingExt.OrderType.ValueField();
            impl.ExternalOrderOrigin = currentBinding.BindingName.ValueField();

            var date = data.DateCreatedUT.ToString().ToDate(PXTimeZoneInfo.FindSystemTimeZoneById(currentBindingExt.OrderTimeZone));
            if (date != null)
                impl.Date = new DateTime(date.Value.Date.Ticks).ValueField();
            impl.RequestedOn = impl.Date;

            impl.CurrencyID = data.Currency.ValueField();
            impl.ExternalRef = APIHelper.ReferenceMake(data.Id, currentBinding.BindingName).ValueField();

            #region Notes
            string note = string.Empty;
            var notes = orderNotesDataProvider.GetByParentId(data.Id.ToString());
            if (!string.IsNullOrWhiteSpace(data.CustomerNote))
                note += string.Concat("Customer Notes:", Environment.NewLine, data.CustomerNote, Environment.NewLine, Environment.NewLine);

            var notesToCustomer = notes.Where(n => n.CustomerNote.HasValue && n.CustomerNote.Value && !string.IsNullOrWhiteSpace(n.Note));
            if (notesToCustomer.Any())
            {
                note += $"Note to Customer:{Environment.NewLine}";

                notesToCustomer.ForEach(n =>
                {
                    note += $"{n.Note}{Environment.NewLine}";
                });
                note += $"{ Environment.NewLine}";
            }

            var privateNotes = notes.Where(n => n.CustomerNote.HasValue && !n.CustomerNote.Value);
            if (privateNotes.Any())
            {
                note += $"Private Notes:{Environment.NewLine}";
                privateNotes.ForEach(n =>
                {
                    note += $"{n.Note}{Environment.NewLine}";
                });
            }

            impl.Note = string.IsNullOrWhiteSpace(note) ? null : note;
            #endregion

            impl.ExternalOrderOriginal = true.ValueField();

            PXResult<PX.Objects.CR.Address, PX.Objects.CR.Contact> billingResult = null;
            PXResult<PX.Objects.CR.Location, PX.Objects.CR.Address, PX.Objects.CR.Contact, BCSyncStatus> shippingResult = null;

            PX.Objects.CR.Address address = null;
            PX.Objects.CR.Contact contact = null;
            PX.Objects.CR.Location location = null;
            PX.Objects.AR.Customer customer = null;
            //Customer ID
            if (bucket.Customer != null)
            {
                var result = PXSelectJoin<PX.Objects.AR.Customer,
                    LeftJoin<PX.Objects.CR.Address, On<PX.Objects.AR.Customer.defBillAddressID, Equal<PX.Objects.CR.Address.addressID>>,
                    LeftJoin<PX.Objects.CR.Contact, On<PX.Objects.AR.Customer.defBillContactID, Equal<PX.Objects.CR.Contact.contactID>>,
                    LeftJoin<BCSyncStatus, On<PX.Objects.AR.Customer.noteID, Equal<BCSyncStatus.localID>>>>>,
                    Where<BCSyncStatus.connectorType, Equal<Current<BCEntity.connectorType>>,
                        And<BCSyncStatus.bindingID, Equal<Current<BCEntity.bindingID>>,
                        And<BCSyncStatus.entityType, Equal<Required<BCEntity.entityType>>,
                        And<BCSyncStatus.externID, Equal<Required<BCSyncStatus.externID>>>>>>>
                        .Select(this, BCEntitiesAttribute.Customer, data.CustomerId)
                        .Cast<PXResult<PX.Objects.AR.Customer, PX.Objects.CR.Address, PX.Objects.CR.Contact, BCSyncStatus>>().FirstOrDefault();
                customer = result?.GetItem<PX.Objects.AR.Customer>();
                address = result?.GetItem<PX.Objects.CR.Address>();
                if (customer == null) throw new PXException(BCMessages.CustomerNotSyncronized, data.CustomerId);
                if (customer.CuryID != impl.CurrencyID.Value && !customer.AllowOverrideCury.Value)
                    throw new PXException(BCMessages.OrderCurrencyNotMathced, impl.CurrencyID.Value, customer.CuryID);
                impl.CustomerID = customer.AcctCD?.Trim().ValueField();
                billingResult = new PXResult<PX.Objects.CR.Address, PX.Objects.CR.Contact>(result?.GetItem<PX.Objects.CR.Address>(), result?.GetItem<PX.Objects.CR.Contact>());
            }
            else
            {
                var result = PXSelectJoin<PX.Objects.AR.Customer,
                    LeftJoin<Contact2, On<PX.Objects.AR.Customer.defContactID, Equal<Contact2.contactID>>,
                    LeftJoin<PX.Objects.CR.Contact, On<PX.Objects.AR.Customer.defBillContactID, Equal<PX.Objects.CR.Contact.contactID>>,
                    LeftJoin<PX.Objects.CR.Address, On<PX.Objects.AR.Customer.defBillAddressID, Equal<PX.Objects.CR.Address.addressID>>>>>,
                    Where<PX.Objects.CR.Contact.eMail, Equal<Required<PX.Objects.CR.Contact.eMail>>>>
                    .Select(this, data.Billing.Email)
                    .Cast<PXResult<PX.Objects.AR.Customer, Contact2, PX.Objects.CR.Contact, PX.Objects.CR.Address>>().FirstOrDefault();
                customer = result?.GetItem<PX.Objects.AR.Customer>();
                address = result?.GetItem<PX.Objects.CR.Address>();

                //In WooCommerce,it is possible to create a customer without an email from admin
                if (string.IsNullOrWhiteSpace(data.Billing.Email) || customer == null)
                {
                    var guestCustomerResult = PXSelectJoin<PX.Objects.AR.Customer,
                       LeftJoin<PX.Objects.CR.Address, On<PX.Objects.AR.Customer.defBillAddressID, Equal<PX.Objects.CR.Address.addressID>>>,
                       Where<PX.Objects.AR.Customer.bAccountID, Equal<Required<PX.Objects.AR.Customer.bAccountID>>>>
                       .Select(this, currentBindingExt.GuestCustomerID)
                       .Cast<PXResult<PX.Objects.AR.Customer, PX.Objects.CR.Address>>().FirstOrDefault();
                    customer = guestCustomerResult?.GetItem<PX.Objects.AR.Customer>();
                    address = guestCustomerResult?.GetItem<PX.Objects.CR.Address>();
                    if (customer == null) throw new PXException(WCMessages.NoGuestCustomer);
                }
                else
                {
                    if (customer.CuryID != impl.CurrencyID.Value && !customer.AllowOverrideCury.Value)
                        throw new PXException(BCMessages.OrderCurrencyNotMathced, impl.CurrencyID.Value, customer.CuryID);
                    billingResult = new PXResult<PX.Objects.CR.Address, PX.Objects.CR.Contact>(result?.GetItem<PX.Objects.CR.Address>(), result?.GetItem<PX.Objects.CR.Contact>());

                }
                impl.CustomerID = customer.AcctCD?.Trim().ValueField();
            }


            //FinancialSettings
            impl.FinancialSettings = new FinancialSettings();
            impl.FinancialSettings.Branch = Branch.PK.Find(this, currentBinding.BranchID)?.BranchCD?.Trim().ValueField();
            #endregion

            #region ShippingSettings
            //Freight
            impl.Totals = new Totals();
            impl.Totals.OverrideFreightAmount = new BooleanValue() { Value = true };
            var shippingRefundItems = data.Refunds.SelectMany(x => x.ShippingLines).ToList();
            decimal shippingRefundAmount = shippingRefundItems.Sum(s => s.TotalInDecimal);
            decimal freight = data.ShippingLines.Sum(s => s.TotalInDecimal);
            impl.Totals.Freight = (freight + shippingRefundAmount).ValueField();
            if (impl.Totals.Freight?.Value < 0)
            {
                exceededRefundAmount += impl.Totals.Freight.Value.Value; //throw new PXException(BCMessages.RefundShippingFeeInvalid, shippingRefundItems, freight); //Shipping and freight has been ignored
                impl.Totals.Freight = 0m.ValueField();
                totalFloatingRefundedAmount += freight.Abs();

            }
            else
            {
                totalFloatingRefundedAmount += Math.Abs(shippingRefundAmount);
            }

            if (data.Refunds.Any())
                impl.ExternalRefundRef = string.Join(";", data.Refunds.Select(x => x.Id)).ValueField();
            State state;
            impl.OrderTotal = data.TotalInDecimal.ValueField();
            //ShippingSettings
            impl.ShippingSettings = new ShippingSettings();
            shippingMappings = PXSelect<BCShippingMappings,
                Where<BCShippingMappings.bindingID, Equal<Required<BCShippingMappings.bindingID>>>>
                .Select(this, Operation.Binding).Select(x => x.GetItem<BCShippingMappings>()).ToList();
            PXCache cache = Caches[typeof(BCShippingMappings)];
            bool hasMappingError = false;
            string zoneName = string.Empty;
            string zoneMethod = string.Empty;

            if (data.Shipping != null)
            {
                foreach (ShippingLineData shippingLine in data.ShippingLines)
                {
                    bool found = false;
                    //Search for mapping value
                    foreach (BCShippingMappings mapping in shippingMappings)
                    {
                        if (mapping.ShippingMethod == null || shippingLine.MethodTitle == null) continue;

                        string shippingMethod = mapping.ShippingMethod.Replace(".", "").Replace("_", "").Replace("-", "");
                        string shippingMethodPart1 = shippingMethod.FieldsSplit(0, string.Empty, BCConstants.Separator).Replace(" ", "").Trim();
                        string shippingMethodPart2 = shippingMethod.FieldsSplit(1, string.Empty, BCConstants.Separator).Replace(" ", "").Trim();

                        string target = shippingLine.MethodTitle.Replace(".", "").Replace("_", "").Replace("-", "").Replace(" ", "");

                        if (target.Contains(shippingMethodPart1, StringComparison.InvariantCultureIgnoreCase)
                            && (string.IsNullOrEmpty(shippingMethodPart2) || target.Contains(shippingMethodPart2, StringComparison.InvariantCultureIgnoreCase)))
                        {
                            found = true;
                            if (mapping.Active == true && mapping.CarrierID == null)
                            {
                                hasMappingError = true;
                                zoneMethod = shippingLine.MethodTitle;
                            }
                            else if (mapping.Active == true && mapping.CarrierID != null)
                            {
                                impl.ShipVia = impl.ShippingSettings.ShipVia = mapping.CarrierID.ValueField();
                                impl.ShippingSettings.ShippingZone = mapping.ZoneID.ValueField();
                                impl.ShippingSettings.ShippingTerms = mapping.ShipTermsID.ValueField();
                            }
                            break;
                        }
                    }
                    if (!found && !shippingMappings.Any(x => string.Equals(x.ShippingMethod, shippingLine.MethodTitle, StringComparison.InvariantCultureIgnoreCase)))
                    {
                        hasMappingError = true;
                        zoneName = string.Empty;
                        zoneMethod = shippingLine.MethodTitle;
                        BCShippingMappings inserted = new BCShippingMappings()
                        {
                            BindingID = Operation.Binding,
                            ShippingZone = shippingLine.MethodTitle,
                            ShippingMethod = shippingLine.MethodTitle,
                            Active = true
                        };
                        cache.Insert(inserted);
                    }

                    #region Ship-To Address && Contact

                    impl.ShipToAddress = new Address();
                    impl.ShipToAddress.AddressLine1 = data.Shipping.Address1.ValueField();
                    impl.ShipToAddress.AddressLine2 = data.Shipping.Address2.ValueField();
                    impl.ShipToAddress.City = data.Shipping.City.ValueField();
                    impl.ShipToAddress.Country = data.Shipping.Country.ValueField();
                    if (!string.IsNullOrEmpty(data.Shipping.State))
                    {
                        state = states.Select(data.Shipping.State, data.Shipping.State);
                        if (state == null)
                            impl.ShipToAddress.State = data.Shipping.State.ValueField();
                        else
                            impl.ShipToAddress.State = state.StateID?.ValueField();
                    }
                    else
                        impl.ShipToAddress.State = string.Empty.ValueField();

                    impl.ShipToAddress.PostalCode = data.Shipping.PostalCode?.ToUpperInvariant()?.ValueField();

                    impl.ShipToContact = new DocContact();
                    var attentionShip = data.Shipping.FirstName.Trim();
                    if (data.Shipping.LastName.Trim().ToLower() != attentionShip.ToLower()) attentionShip += $" {data.Shipping.LastName.Trim()}";
                    impl.ShipToContact.Attention = attentionShip.ValueField();
                    impl.ShipToContact.BusinessName = data.Shipping.Company.ValueField();

                    impl.ShipToAddressOverride = true.ValueField();
                    impl.ShipToContactOverride = true.ValueField();
                    if (customer.BAccountID != currentBindingExt.GuestCustomerID)
                    {
                        address = shippingResult?.GetItem<PX.Objects.CR.Address>();
                        // Always use the address in the order
                        impl.ShipToAddressOverride = true.ValueField();

                        contact = shippingResult?.GetItem<PX.Objects.CR.Contact>();
                        location = shippingResult?.GetItem<PX.Objects.CR.Location>();
                        // Always use the contact info in the order
                        impl.ShipToContactOverride = true.ValueField();
                    }
                    #endregion

                    break;
                }
            }
            else
            {
                impl.ShipToAddress = new Address();
                impl.ShipToAddress.AddressLine1 = string.Empty.ValueField();
                impl.ShipToAddress.AddressLine2 = string.Empty.ValueField();
                impl.ShipToAddress.City = string.Empty.ValueField();
                impl.ShipToAddress.State = string.Empty.ValueField();
                impl.ShipToAddress.PostalCode = string.Empty.ValueField();
                impl.ShipToContact = new DocContact();
                impl.ShipToContact.Phone1 = string.Empty.ValueField();
                impl.ShipToContact.Email = string.Empty.ValueField();
                impl.ShipToContact.Attention = string.Empty.ValueField();
                impl.ShipToContact.BusinessName = string.Empty.ValueField();
                impl.ShipToAddressOverride = true.ValueField();
                impl.ShipToContactOverride = true.ValueField();
                impl.ShipToAddress.Country = (data.Billing?.Country ?? data.Billing.Country ?? address?.CountryID)?.ValueField();
            }
            if (cache.Inserted.Count() > 0)
                cache.Persist(PXDBOperation.Insert);
            if (hasMappingError)
            {
                throw new PXException(BCMessages.OrderShippingMappingIsMissing, zoneName, zoneMethod);
            }

            #endregion

            #region Bill-To Address && Contact

            impl.BillToAddress = new Address();
            impl.BillToAddress.AddressLine1 = data.Billing.Address1.ValueField();
            impl.BillToAddress.AddressLine2 = data.Billing.Address2.ValueField();
            impl.BillToAddress.City = data.Billing.City.ValueField();
            impl.BillToAddress.Country = data.Billing.Country.ValueField();
            if (!string.IsNullOrEmpty(data.Billing.State))
            {
                state = states.Select(data.Billing.State, data.Billing.State);
                if (state == null)
                {
                    impl.BillToAddress.State = GetSubstituteLocalByExtern(BCSubstitute.GetValue(Operation.ConnectorType, BCSubstitute.State), data.Billing.State, data.Billing.State).ValueField();
                }
                else
                    impl.BillToAddress.State = state.StateID?.ValueField();
            }
            else
                impl.BillToAddress.State = string.Empty.ValueField();
            impl.BillToAddress.PostalCode = data.Billing.PostalCode?.ToUpperInvariant()?.ValueField();

            //Contact
            impl.BillToContact = new DocContact();
            impl.BillToContact.Phone1 = data.Billing.Phone.ValueField();
            impl.BillToContact.Email = data.Billing.Email.ValueField();
            impl.BillToContact.BusinessName = data.Billing.Company.ValueField();
            var attentionBill = data.Billing.FirstName.Trim();
            if (data.Billing.LastName.Trim().ToLower() != attentionBill.ToLower()) attentionBill += $" {data.Billing.LastName.Trim()}";
            impl.BillToContact.Attention = attentionBill.ValueField();

            impl.BillToContactOverride = true.ValueField();
            impl.BillToAddressOverride = true.ValueField();
            if (customer.BAccountID != currentBindingExt.GuestCustomerID)
            {
                address = billingResult?.GetItem<PX.Objects.CR.Address>();
                // Always use the address in the order
                impl.BillToAddressOverride = true.ValueField();

                contact = billingResult?.GetItem<PX.Objects.CR.Contact>();
                // Always use the contact info in the order
                impl.BillToContactOverride = true.ValueField();
            }

            #endregion

            #region Products

            //Products

            Dictionary<string, decimal?> totaldiscount = new Dictionary<string, decimal?>();

            impl.Details = new List<SalesOrderDetail>();

            var refundLineItems = data.Refunds.SelectMany(s => s.LineItems);
            foreach (OrderLineItemData productData in data.LineItems)
            {
                if (productData.ProductId <= 0) continue; //product that does not exists in big Commerce
                if (productData.Quantity == 0) continue;

                string inventoryCD = helper.GetInventoryCDByExternID(productData.ProductId.ToString(),
                    productData.VariationId >= 0 ? productData.VariationId.ToString() : null,
                    productData.Sku,
                    BigCommerce.API.REST.OrdersProductsType.Physical, //TODO:product type need to retrive
                    out string uom);

                var refundItem = refundLineItems.Where(r => r.Sku == productData.Sku).ToList();
                SalesOrderDetail detail = new SalesOrderDetail();
                detail.Branch = impl.FinancialSettings.Branch;
                detail.InventoryID = inventoryCD?.TrimEnd().ValueField();
                int refundQty = (int)refundItem?.Sum(x => x.Quantity);
                if (refundQty > productData.Quantity) throw new PXException(BCMessages.RefundQuantityGreater);
                detail.OrderQty = ((decimal?)(productData.Quantity + refundQty)).ValueField();
                detail.UOM = uom.ValueField();
                detail.UnitPrice = productData.UnitPrice.ValueField();
                detail.LineDescription = productData.Name.ValueField();
                detail.ExtendedPrice = (Math.Abs(refundQty) > 0 ? detail.OrderQty.Value * productData.UnitPrice : productData.SubTotalDecimal).ValueField();
                detail.FreeItem = (productData.SubTotalTaxDecimal == 0m && productData.PriceDecimal == 0m).ValueField();
                detail.ManualPrice = true.ValueField();
                detail.ExternalRef = productData.Id.ToString().ValueField();
                totalFloatingRefundedAmount += Math.Round(refundQty.Abs() * productData.DiscountedUnitPrice, 2);
                //if (currentBindingExt.PostDiscounts == BCPostDiscountAttribute.LineDiscount)
                //{
                //    detail.DiscountAmount = productData.Discount.ValueField();
                //    detail.ManualDiscount = true.ValueField();
                //}

                var nonQuantityRefundAmount = refundItem.Where(s => s.Quantity.Abs() == 0 & s.TotalInDecimal.Abs() > 0).Sum(s => s.TotalInDecimal).Abs();
                if (refundQty.Abs() > 0 && nonQuantityRefundAmount > 0)
                {
                    detail.ExtendedPrice = (productData.SubTotalDecimal - nonQuantityRefundAmount).ValueField();
                    totalFloatingRefundedAmount += nonQuantityRefundAmount;
                }

                if (productData.Discount > 0)
                {
                    if (refundItem?.Count() > 0)
                    {

                        var discountPerItem = productData.Discount / productData.Quantity;
                        if (currentBindingExt.PostDiscounts == BCPostDiscountAttribute.LineDiscount)
                            detail.DiscountAmount = (discountPerItem * detail.OrderQty.Value).ValueField();
                        totaldiscount["Manual"] = productData.Discount;
                        refundedDiscount += Math.Round(discountPerItem.Value * refundQty.Abs(), 2);
                    }
                    else if (currentBindingExt.PostDiscounts == BCPostDiscountAttribute.LineDiscount)
                    {
                        detail.DiscountAmount = productData.Discount.ValueField();
                        detail.ManualDiscount = true.ValueField();
                    }
                }
                else if (currentBindingExt.PostDiscounts == BCPostDiscountAttribute.DocumentDiscount)
                    detail.DiscountAmount = 0m.ValueField();

                //Check for existing				
                DetailInfo matchedDetail = existing?.Details?.FirstOrDefault(d => d.EntityType == BCEntitiesAttribute.OrderLine && productData.Id.ToString() == d.ExternID);
                if (matchedDetail != null) detail.Id = matchedDetail.LocalID; //Search by Details
                else if (presented?.Details != null && presented.Details.Count > 0) //Serach by Existing line
                {
                    SalesOrderDetail matchedLine = presented.Details.FirstOrDefault(x =>
                        x.ExternalRef?.Value != null && x.ExternalRef?.Value == productData.Id.ToString()
                        ||
                        x.InventoryID?.Value == detail.InventoryID?.Value && (detail.UOM == null || detail.UOM.Value == x.UOM?.Value));
                    if (matchedLine != null) detail.Id = matchedLine.Id;
                }

                impl.Details.Add(detail);
            }

            //var x = data.Refunds.SelectMany(r=>r.LineItems.SelectMany(s=>s.a)
            #endregion


            #region Taxes
            //Insert Taxes if Importing Them
            impl.TaxDetails = new List<TaxDetail>();
            if (!(data.TaxLines.Count == 1 && data.TaxLines.First().Label.Equals(BCObjectsConstants.AutomaticTax)))
            {
                if (currentBindingExt.TaxSynchronization == true)
                {
                    impl.IsTaxValid = true.ValueField();
                    var taxRefundItems = data.Refunds.SelectMany(s => s.LineItems.SelectMany(x => x.Taxes)).ToList();
                    taxRefundItems.AddRange(data.Refunds.SelectMany(s => s.ShippingLines.SelectMany(x => x.Taxes)).ToList());

                    foreach (TaxLineData tax in data.TaxLines)
                    {
                        //Third parameter set to tax name in order to simplify process (if tax names are equal and user don't want to fill lists)
                        string mappedTaxName = mappedTaxName = GetSubstituteLocalByExtern(currentBindingExt.TaxSubstitutionListID, tax.Label, tax.Label);
                        mappedTaxName = helper.TrimAutomaticTaxNameForAvalara(mappedTaxName);
                        if (string.IsNullOrEmpty(mappedTaxName)) throw new PXException(BCObjectsMessages.TaxNameDoesntExist);


                        var refundedTax = taxRefundItems.Where(y => y.Id == tax.RateCode).Sum(s => s.TotalInDecimal);

                        TaxDetail inserted = impl.TaxDetails.FirstOrDefault(i => i.TaxID.Value?.Equals(mappedTaxName, StringComparison.InvariantCultureIgnoreCase) == true);

                        decimal? taxAmount = 0;

                        if (tax.ShippingTaxTotalInDecimal + tax.TaxTotalInDecimal < refundedTax.Abs())
                        {
                            taxAmount = 0;
                            totalFloatingRefundedAmount += (tax.ShippingTaxTotalInDecimal + tax.TaxTotalInDecimal).Abs();
                        }
                        else
                        {
                            taxAmount = tax.ShippingTaxTotalInDecimal + tax.TaxTotalInDecimal + refundedTax;
                            totalFloatingRefundedAmount += refundedTax.Abs();
                        }

                        var taxableAmount = tax.ShippingTaxTotalInDecimal > 0 ? data.TotalInDecimal - data.TotalTaxInDecimal + data.OrderRefunds.Sum(s => s.TotalDecimal)
                            : (data.TotalInDecimal - data.TotalTaxInDecimal - data.ShippingTotalInDecimal) + data.OrderRefunds.Sum(s => s.TotalDecimal);

                        if (inserted == null)
                        {
                            impl.TaxDetails.Add(new TaxDetail
                            {
                                TaxableAmount = taxableAmount.ValueField(),
                                TaxID = mappedTaxName.ValueField(),
                                TaxAmount = taxAmount.ValueField(),
                                TaxRate = (taxAmount / taxableAmount * 100).ValueField()
                            });
                        }
                        else if (inserted.TaxAmount != null)
                        {
                            inserted.TaxAmount = taxAmount.ValueField();
                            inserted.TaxableAmount = taxableAmount.ValueField();
                        }
                    }
                }
            }
            if (data.TaxLines.Count == 1 && data.TaxLines.First().Label.Equals(BCObjectsConstants.AutomaticTax))
                impl.IsTaxValid = false.ValueField();

            //Check for tax Ids with more than 30 characters
            string[] tooLongTaxIDs = (impl.TaxDetails ?? new List<TaxDetail>()).Select(x => x.TaxID?.Value).Where(x => (x?.Length ?? 0) > PX.Objects.TX.Tax.taxID.Length).ToArray();
            if (tooLongTaxIDs != null && tooLongTaxIDs.Length > 0)
            {
                throw new PXException(BCObjectsMessages.CannotFindSaveTaxIDs, string.Join(",", tooLongTaxIDs), PX.Objects.TX.Tax.taxID.Length);
            }

            //TaxZone if Automatic tax mode is on
            if (currentBindingExt.TaxSynchronization == true && !string.IsNullOrWhiteSpace(currentBindingExt.DefaultTaxZoneID) && currentBindingExt.UseAsPrimaryTaxZone == true)
            {
                impl.FinancialSettings.OverrideTaxZone = true.ValueField();
                impl.FinancialSettings.CustomerTaxZone = currentBindingExt.DefaultTaxZoneID.ValueField();
            }
            #endregion

            #region Add RefundItem Line
            var totalOrderRefundAmout = data.OrderRefunds?.Sum(s => s.TotalDecimal) ?? 0;
            //Add orderAdjustments
            if (totalOrderRefundAmout != 0 && Math.Abs(totalOrderRefundAmout) != totalFloatingRefundedAmount.Value.Abs())
            {
                var detail = InsertRefundAmountItem(totalOrderRefundAmout + totalFloatingRefundedAmount.Value, impl.FinancialSettings.Branch);
                if (presented != null && presented.Details?.Count > 0)
                {
                    presented.Details.FirstOrDefault(x => x.InventoryID.Value == detail.InventoryID.Value).With(e => detail.Id = e.Id);
                }
                impl.Details.Add(detail);
            }
            #endregion


            #region Coupons

            //Coupons 
            impl.DisableAutomaticDiscountUpdate = true.ValueField();
            impl.DiscountDetails = new List<SalesOrdersDiscountDetails>();
            foreach (var couponData in data.CouponLines)
            {
                SalesOrdersDiscountDetails detail = new SalesOrdersDiscountDetails();
                detail.ExternalDiscountCode = couponData.Code.ValueField();

                detail.Description = string.Format(BCMessages.DiscountCouponDesctiption, couponData.Code, couponData.Discount)?.ValueField();
                if (currentBindingExt.PostDiscounts == BCPostDiscountAttribute.DocumentDiscount)
                {
                    detail.DiscountAmount = (couponData.DiscountInDecimal - refundedDiscount).ValueField();
                }
                else
                {
                    detail.DiscountAmount = 0m.ValueField();
                }
                impl.DiscountDetails.Add(detail);
            }
            #endregion

            #region Payment

            if (existing == null
                && GetEntity(BCEntitiesAttribute.Payment)?.IsActive == true
                && !paymentProcessor.ImportMappings.Select().Any()) //skip creation of payments if there are refunds as Applied to order amount will be greater than order total
            {
                impl.Payments = new List<SalesOrderPayment>();
                foreach (MappedPayment payment in bucket.Payments)
                {
                    OrdersTransactionData dataPayment = payment.Extern;
                    SalesOrderPayment implPament = new SalesOrderPayment();
                    if (!payment.IsNew)
                        continue;
                    implPament.ExternalID = payment.ExternID;

                    //Product
                    implPament.DocType = PX.Objects.AR.Messages.Prepayment.ValueField();
                    implPament.Currency = impl.CurrencyID;
                    var appDate = dataPayment.DateCreatedUT.ToString()
                        .ToDate(PXTimeZoneInfo.FindSystemTimeZoneById(currentBindingExt.OrderTimeZone));
                    if (appDate.HasValue)
                        implPament.ApplicationDate = new DateTime(appDate.Value.Date.Ticks).ValueField();
                    implPament.PaymentAmount = dataPayment.Amount.ValueField();
                    implPament.Hold = false.ValueField();
                    if (data.Status == OrderStatuses.Cancelled)
                        implPament.AppliedToOrder = 0m.ValueField();
                    else
                        implPament.AppliedToOrder = dataPayment.Amount.ValueField();

                    BCPaymentMethods methodMapping = helper.GetPaymentMethodMapping(helper.GetPaymentMethodName(data.PaymentMethod), data.PaymentMethod, dataPayment.Currency, out string cashAcount);
                    if (methodMapping?.ReleasePayments ?? false) continue; //don't save payment with the order if the require release.

                    implPament.PaymentMethod = methodMapping?.PaymentMethodID?.ValueField();
                    implPament.CashAccount = cashAcount?.Trim()?.ValueField();
                    implPament.PaymentRef = helper.ParseTransactionNumber(dataPayment, out bool isCreditCardTran).ValueField();
                    implPament.ExternalRef = dataPayment.Id.ToString().ValueField();

                    ARRegister existingPayment = PXSelect<ARRegister,
                        Where<ARRegister.externalRef, Equal<Required<ARRegister.externalRef>>>>.Select(this, implPament.ExternalRef.Value);

                    if (existingPayment != null) continue; //skip if payment with same ref nbr exists already.

                    implPament.Description = PXMessages.LocalizeFormat(WCMessages.PaymentDescription,
                                                                       currentBinding.BindingName,
                                                                       methodMapping.StorePaymentMethod,
                                                                       data.Id,
                                                                       dataPayment.Id).ValueField();

                    //Auth in WooCommerce and then capture from WooCommerce (Auth.NET)
                    if (bucket.Payments.Count > 1 && dataPayment.paymentEvent == OrderPaymentEvent.Capture || bucket.Payments.Count == 1)
                    {
                        //Credit Card:
                        if (dataPayment.GatewayTransactionId != null && methodMapping?.ProcessingCenterID != null)
                        {
                            //implPament.IsNewCard = true.ValueField();
                            implPament.SaveCard = (!String.IsNullOrWhiteSpace(dataPayment.PaymentInstrumentToken)).ValueField();
                            implPament.ProcessingCenterID = methodMapping?.ProcessingCenterID?.ValueField();

                            SalesOrderCreditCardTransactionDetail creditCardDetail = new SalesOrderCreditCardTransactionDetail();
                            creditCardDetail.TranNbr = implPament.PaymentRef;
                            creditCardDetail.TranDate = implPament.ApplicationDate;
                            creditCardDetail.ExtProfileId = dataPayment.PaymentInstrumentToken.ValueField();
                            creditCardDetail.TranType = helper.GetTransactionType(dataPayment.paymentEvent);
                            implPament.CreditCardTransactionInfo = new List<SalesOrderCreditCardTransactionDetail>(new[] { creditCardDetail });
                        }
                        impl.Payments.Add(implPament);
                    }

                }
            }
            if (existing != null && bucket.Payments.Count > 1)
            {
                foreach (var item in bucket.Payments)
                {
                    if (item.Extern.paymentEvent == OrderPaymentEvent.Capture)// && !string.IsNullOrWhiteSpace(item.Extern.PaymentInstrumentToken)
                    {
                        var payment = cbapi.GetByID<Payment>(item.LocalID);
                        if (payment.Status.Value == PX.Objects.AR.Messages.CCHold)
                        {
                            var paymentImpl = cbapi.Invoke(payment, action: new CardOperation()
                            {
                                TranType = CCTranTypeCode.PriorAuthorizedCapture.ValueField(),
                                TranNbr = helper.ParseTransactionNumber(item.Extern, out bool isCreditCardTran).ValueField()
                            });
                        }
                    }
                }
            }

            #endregion

            #region Adjust for Existing
            if (presented != null)
            {
                obj.Local.OrderType = presented.OrderType; //Keep the same order Type

                //remap entities if existing
                presented.DiscountDetails?.ForEach(e => obj.Local.DiscountDetails?.FirstOrDefault(n => n.ExternalDiscountCode.Value == e.ExternalDiscountCode.Value).With(n => n.Id = e.Id));
                presented.Payments?.ForEach(e => obj.Local.Payments?.FirstOrDefault(n => n.PaymentRef.Value == e.PaymentRef.Value).With(n => n.Id = e.Id));

                //delete unnecessary entities
                //obj.Local.Details?.AddRange(presented.Details == null ? Enumerable.Empty<SalesOrderDetail>()
                //    : presented.Details.Where(e => obj.Local.Details == null || !obj.Local.Details.Any(n => e.Id == n.Id)).Select(n => new SalesOrderDetail() { Id = n.Id, Delete = true, InventoryID = n.InventoryID }));
                obj.Local.DiscountDetails?.AddRange(presented.DiscountDetails == null ? Enumerable.Empty<SalesOrdersDiscountDetails>()
                    : presented.DiscountDetails.Where(e => obj.Local.DiscountDetails == null || !obj.Local.DiscountDetails.Any(n => e.Id == n.Id)).Select(n => new SalesOrdersDiscountDetails() { Id = n.Id, Delete = true }));
                obj.Local.Payments?.AddRange(presented.Payments == null ? Enumerable.Empty<SalesOrderPayment>()
                    : presented.Payments.Where(e => obj.Local.Payments == null || !obj.Local.Payments.Any(n => e.Id == n.Id)).Select(n => new SalesOrderPayment() { Id = n.Id, Delete = true }));
            }
            #endregion
        }

        private static RefundStatus GetRefundStatus(OrderData data)
        {
            return !data.Refunds.Any() ? RefundStatus.None : data.Refunds.Sum(s => s.AmountDecimal) == data.TotalInDecimal ? RefundStatus.Full : RefundStatus.Partially;
        }

        protected bool CompareAddress(Address mappedAddress, PX.Objects.CR.Address address)
        {
            return Compare(mappedAddress.City?.Value, address.City)
                                            && Compare(mappedAddress.Country?.Value, address.CountryID)
                                            && Compare(mappedAddress.State?.Value, address.State)
                                            && Compare(mappedAddress.AddressLine1?.Value, address.AddressLine1)
                                            && Compare(mappedAddress.AddressLine2?.Value, address.AddressLine2)
                                            && Compare(mappedAddress.PostalCode?.Value, address.PostalCode);
        }

        protected bool CompareContact(DocContact mappedContact, PX.Objects.CR.Contact contact, PX.Objects.CR.Location location = null)
        {
            return (Compare(mappedContact.BusinessName?.Value, contact.FullName) || Compare(mappedContact.BusinessName?.Value, location?.Descr))
                                        && Compare(mappedContact.Attention?.Value, contact.Attention)
                                        && Compare(mappedContact.Email?.Value, contact.EMail)
                                        && Compare(mappedContact.Phone1?.Value, contact.Phone1);
        }

        protected bool Compare(string value1, string value2)
        {
            return string.Equals(value1?.Trim() ?? string.Empty, value2?.Trim() ?? string.Empty, StringComparison.InvariantCultureIgnoreCase);
        }

        public override void SaveBucketImport(WCSalesOrderBucket bucket, IMappedEntity existing, string operation)
        {
            MappedOrder obj = bucket.Order;
            SalesOrder local = obj.Local;
            BCBindingExt bindingExt = GetBindingExt<BCBindingExt>();
            SalesOrder impl;//Due to the saving issue we should delete all needed order lines first with the separate calls.
            SalesOrder presented = existing?.Local as SalesOrder;
            // If custom mapped orderType, this will prevent attempt to modify existing SO type and following error
            if (existing != null)
                obj.Local.OrderType = ((MappedOrder)existing).Local.OrderType;
            if (obj.Extern?.Status == OrderStatuses.Refunded && presented != null)
            {
                impl = cbapi.Invoke<SalesOrder, CancelSalesOrder>(local, obj.LocalID);
            }
            else
            {

                if (obj.Local.Details != null && obj.Local.Details.Any(x => x.Delete) && obj.Local.Details.Any(x => !x.Delete))
                {
                    List<SalesOrderDetail> updatedLines = obj.Local.Details.Where(x => x.Delete == false).ToList();

                    obj.Local.Details = obj.Local.Details.Where(x => x.Delete).ToList(); // only deleted lines
                    impl = cbapi.Put(obj.Local, obj.LocalID);

                    obj.Local.Details = updatedLines.ToList();
                }

                #region Taxes
                helper.LogTaxDetails(obj.SyncID, obj.Local);
                #endregion

                impl = cbapi.Put(obj.Local, obj.LocalID);

                #region Taxes
                helper.ValidateTaxes(obj.SyncID, impl, obj.Local);

                #endregion

                //If we need to cancel the order in Acumatica
                if (obj.Extern?.Status == OrderStatuses.Cancelled || obj.Extern?.RefundStatus == RefundStatus.Full)
                {
                    SalesOrder orderToCancel = impl == null ? null : new SalesOrder()
                    {
                        Id = impl.Id,
                        Payments = impl.Payments?.Select(x => new SalesOrderPayment() { Id = x.Id, AppliedToOrder = 0m.ValueField() }).ToList(),
                    };
                    impl = cbapi.Invoke<SalesOrder, CancelSalesOrder>(orderToCancel, impl.SyncID);
                }
            }
            obj.AddLocal(impl, impl.SyncID, impl.SyncTime);

            // Save Details
            DetailInfo[] oldDetails = obj.Details.ToArray(); obj.ClearDetails();
            ShippingAddressData shippingAddresses = obj.Extern.Shipping ?? new ShippingAddressData();
            foreach (OrderLineItemData product in obj.Extern.LineItems) //Line ID detail
            {
                if (product.Quantity == 0) continue;

                SalesOrderDetail detail = null;
                detail = impl.Details.FirstOrDefault(x => x.NoteID.Value == oldDetails.FirstOrDefault(o => o.ExternID == product.Id.ToString())?.LocalID);
                if (detail == null) detail = impl.Details.FirstOrDefault(x => x.ExternalRef?.Value != null && x.ExternalRef?.Value == product.Id.ToString());
                if (detail == null)
                {
                    string inventoryCD = helper.GetInventoryCDByExternID(product.ProductId.ToString(), product.VariationId.ToString(), product.Sku, BigCommerce.API.REST.OrdersProductsType.Physical, out string uom);
                    detail = impl.Details.FirstOrDefault(x => !obj.Details.Any(o => x.NoteID.Value == o.LocalID) && x.InventoryID.Value == inventoryCD);
                }
                if (detail != null)
                {
                    obj.AddDetail(BCEntitiesAttribute.OrderLine, detail.NoteID.Value, product.Id.ToString());
                    continue;
                }
                throw new PXException(BCMessages.CannotMapLines);
            }

            UpdateStatus(obj, operation);

            #region Payments
            if (existing == null && local.Payments != null && bucket.Payments != null)
            {
                BCPaymentMethods methodMapping = helper.GetPaymentMethodMapping(helper.GetPaymentMethodName(obj.Extern.PaymentMethod), obj.Extern.PaymentMethod, obj.Extern.Currency, out string cashAcount);

                for (int i = 0; i < local.Payments.Count; i++)
                {
                    SalesOrderPayment sent = local.Payments[i];
                    ARPayment payment = null;

                    String docType = (new ARDocType()).ValueLabelPairs.First(p => p.Label == sent.DocType.Value).Value;
                    string extRef = sent.PaymentRef.Value;
                    payment = PXSelectJoin<ARPayment, InnerJoin<SOAdjust, On<SOAdjust.adjgRefNbr, Equal<ARPayment.refNbr>>>,
                        Where<ARPayment.extRefNbr, Equal<Required<ARPayment.extRefNbr>>,
                        And<ARPayment.docType, Equal<Required<ARPayment.docType>>,
                        And<SOAdjust.adjdOrderNbr, Equal<Required<SOAdjust.adjdOrderNbr>>
                        >>>>.Select(this, extRef, docType, impl.OrderNbr.Value);

                    if (payment == null) continue;

                    MappedPayment objPayment = bucket.Payments?.FirstOrDefault(x => x.ExternID == sent.ExternalID);
                    if (objPayment == null) continue;

                    objPayment.AddLocal(null, payment.NoteID, payment.LastModifiedDateTime);
                    UpdateStatus(objPayment, operation);
                }
            }
            #endregion

        }
        #endregion

        #region Export
        public override void FetchBucketsForExport(DateTime? minDateTime, DateTime? maxDateTime, PXFilterRow[] filters)
        {
            var bindingExt = GetBindingExt<BCBindingExt>();
            SalesOrder[] impls = new SalesOrder[] { };
            List<string> orderTypesArray = new List<string> { bindingExt.OrderType };
            if (PXAccess.FeatureInstalled<FeaturesSet.userDefinedOrderTypes>() && bindingExt.OtherSalesOrderTypes != null && bindingExt.OtherSalesOrderTypes?.Count() > 0)
                orderTypesArray.AddRange(bindingExt.OtherSalesOrderTypes.Split(',').Where(i => i != bindingExt.OrderType).ToList());

            foreach (var orderType in orderTypesArray)
            {
                if (string.IsNullOrEmpty(orderType)) continue;

                var res = cbapi.GetAll(
                        new SalesOrder()
                        {
                            OrderType = orderType.SearchField(),
                            OrderNbr = new StringReturn(),
                            Status = new StringReturn(),
                            CustomerID = new StringReturn(),
                            ExternalRef = new StringReturn(),
                            Details = new List<SalesOrderDetail>() { new SalesOrderDetail() {
                            ReturnBehavior = ReturnBehavior.OnlySpecified,
                            InventoryID = new StringReturn() } }
                        },
                        minDateTime, maxDateTime, filters);
                impls = impls.Append(res.ToArray());
            }

            if (impls != null && impls.Count() > 0)
            {
                int countNum = 0;
                List<IMappedEntity> mappedList = new List<IMappedEntity>();
                foreach (SalesOrder impl in impls)
                {
                    IMappedEntity obj = new MappedOrder(impl, impl.SyncID, impl.SyncTime);

                    mappedList.Add(obj);
                    countNum++;
                    if (countNum % BatchFetchCount == 0 || countNum == impls.Count())
                    {
                        ProcessMappedListForExport(ref mappedList);
                    }
                }
            }
        }

        public override EntityStatus GetBucketForExport(WCSalesOrderBucket bucket, BCSyncStatus syncstatus)
        {
            SalesOrder impl = cbapi.GetByID<SalesOrder>(syncstatus.LocalID, GetCustomFieldsForExport());
            if (impl == null) return EntityStatus.None;

            MappedOrder obj = bucket.Order = bucket.Order.Set(impl, impl.SyncID, impl.SyncTime);
            EntityStatus status = EnsureStatus(bucket.Order, SyncDirection.Export);

            if (status != EntityStatus.Pending && status != EntityStatus.Syncronized)
                return status;

            if (GetEntity(BCEntitiesAttribute.Shipment)?.IsActive == true && impl.Shipments != null)
            {
                foreach (SalesOrderShipment orderShipmentImpl in impl.Shipments)
                {
                    if (orderShipmentImpl.ShippingNoteID?.Value == null) continue;

                    BCShipments shipmentImpl = new BCShipments();
                    shipmentImpl.ShippingNoteID = orderShipmentImpl.ShippingNoteID;
                    shipmentImpl.ShipmentNumber = orderShipmentImpl.ShipmentNbr;
                    shipmentImpl.OrderNoteIds = new List<Guid?>() { syncstatus.LocalID };
                    shipmentImpl.ShipmentType = orderShipmentImpl.ShipmentType;
                    shipmentImpl.Confirmed = (orderShipmentImpl.Status?.Value == BCAPICaptions.Confirmed).ValueField();
                    MappedShipment shipmentObj = new MappedShipment(shipmentImpl, shipmentImpl.ShippingNoteID.Value, orderShipmentImpl.LastModifiedDateTime.Value);
                    EntityStatus shipmentStatus = EnsureStatus(shipmentObj, SyncDirection.Export);

                    if (shipmentStatus == EntityStatus.Pending)
                        bucket.Shipments.Add(shipmentObj);
                }
            }

            BCSyncStatus customerStatus = PXSelectJoin<BCSyncStatus,
                InnerJoin<PX.Objects.AR.Customer, On<PX.Objects.AR.Customer.noteID, Equal<BCSyncStatus.localID>>>,
                Where<BCSyncStatus.connectorType, Equal<Current<BCEntity.connectorType>>,
                    And<BCSyncStatus.bindingID, Equal<Current<BCEntity.bindingID>>,
                    And<BCSyncStatus.entityType, Equal<Required<BCEntity.entityType>>,
                    And<PX.Objects.AR.Customer.acctCD, Equal<Required<PX.Objects.AR.Customer.acctCD>>>>>>>
                .Select(this, BCEntitiesAttribute.Customer, impl.CustomerID?.Value);
            if (customerStatus == null)
            {
                Core.API.Customer implCust = cbapi.Get(new Core.API.Customer() { CustomerID = new StringSearch() { Value = impl.CustomerID.Value } });
                if (implCust == null)
                    throw new PXException(BCMessages.NoCustomerForOrder, obj.Local.OrderNbr.Value);
                MappedCustomer objCust = new MappedCustomer(implCust, implCust.SyncID, implCust.SyncTime);
                EntityStatus custStatus = EnsureStatus(objCust, SyncDirection.Export);

                if (custStatus == EntityStatus.Pending)
                    bucket.Customer = objCust;
            }
            return status;
        }

        public override void MapBucketExport(WCSalesOrderBucket bucket, IMappedEntity existing)
        {
            MappedOrder obj = bucket.Order;
            if (obj.Local.Details == null || obj.Local.Details.Count == 0) throw new PXException(WCMessages.NoOrderDetails, obj.Local.OrderNbr.Value);
            if (!string.IsNullOrEmpty(obj.Local.ExternalRefundRef?.Value)) throw new PXException(WCMessages.CannotExportOrder, obj.Local.OrderNbr.Value);
            SalesOrder impl = obj.Local;
            OrderData orderData = obj.Extern = new OrderData();

            obj.Extern.Id = APIHelper.ReferenceParse(impl.ExternalRef?.Value, GetBinding().BindingName).ToInt();

            BCSyncStatus customerStatus = PXSelectJoin<BCSyncStatus,
                InnerJoin<PX.Objects.AR.Customer, On<PX.Objects.AR.Customer.noteID, Equal<BCSyncStatus.localID>>>,
                Where<BCSyncStatus.connectorType, Equal<Current<BCEntity.connectorType>>,
                    And<BCSyncStatus.bindingID, Equal<Current<BCEntity.bindingID>>,
                    And<BCSyncStatus.entityType, Equal<Required<BCEntity.entityType>>,
                    And<PX.Objects.AR.Customer.acctCD, Equal<Required<PX.Objects.AR.Customer.acctCD>>>>>>>
                .Select(this, BCEntitiesAttribute.Customer, impl.CustomerID?.Value);
            var customer = PX.Objects.AR.Customer.PK.Find(this, GetBindingExt<BCBindingExt>()?.GuestCustomerID);
            if (customer != null && customer?.AcctCD.Trim() == impl.CustomerID?.Value?.Trim())
            {
                orderData.CustomerId = 0;
            }
            else if (customerStatus == null || customerStatus.ExternID == null)
            {
                throw new PXException(BCMessages.CustomerNotSyncronized, impl.CustomerID?.Value);
            }
            else
            {
                orderData.CustomerId = customerStatus.ExternID.ToInt();
            }
            orderData.Status = ConvertStatus(impl.Status?.Value);
            orderData.DiscountTotal = (impl.Totals.DiscountTotal?.Value ?? 0m).ToString();
            if (obj.IsNew && impl.Date.Value != null) orderData.DateCreatedUT = impl.Date.Value.Value;//.TDToString(PXTimeZoneInfo.FindSystemTimeZoneById(GetBindingExt<BCBindingExt>()?.OrderTimeZone));

            string attentionB = impl.BillToContact.Attention?.Value ?? impl.BillToContact.BusinessName?.Value;
            orderData.Billing = new BillingAddressData();
            orderData.Billing.Address1 = impl.BillToAddress.AddressLine1?.Value;
            orderData.Billing.Email = impl.BillToContact.Email?.Value;
            orderData.Billing.Address2 = impl.BillToAddress.AddressLine2?.Value;
            orderData.Billing.City = impl.BillToAddress.City?.Value;
            orderData.Billing.PostalCode = impl.BillToAddress.PostalCode?.Value;
            orderData.Billing.Country = GetSubstituteExternByLocal(BCSubstitute.GetValue(Operation.ConnectorType, BCSubstitute.Country), impl.BillToAddress.Country?.Value, Country.PK.Find(this, impl.BillToAddress.Country?.Value)?.Description);
            orderData.Billing.Company = impl.BillToContact.BusinessName?.Value;
            orderData.Billing.Phone = impl.BillToContact.Phone1?.Value;
            orderData.Billing.FirstName = attentionB.FieldsSplit(0, attentionB);
            orderData.Billing.LastName = attentionB.FieldsSplit(1, attentionB);
            orderData.ShippingTotal = (impl.Totals?.Freight?.Value ?? 0) + (impl.Totals?.PremiumFreight?.Value ?? 0).ToString();
            orderData.TotalTax = impl.TaxTotal?.Value.ToString();
            orderData.Total = (impl.OrderTotal?.Value ?? 0).ToString();

            State state = PXSelect<State, Where<State.stateID, Equal<Required<State.stateID>>>>.Select(this, impl.BillToAddress.State?.Value);
            if (state == null)
                orderData.Billing.State = impl.BillToAddress.State?.Value; //GetSubstituteExternByLocal(BCSubstitute.GetValue(Operation.ConnectorType, BCSubstitute.State), impl.BillToAddress.State?.Value, impl.BillToAddress.State?.Value);
            else
                orderData.Billing.State = state.Name;
            orderData.Billing.State = string.IsNullOrEmpty(orderData.Billing.State) ? " " : orderData.Billing.State;

            string attentionS = impl.ShipToContact.Attention?.Value ?? impl.ShipToContact.BusinessName?.Value;
            orderData.Shipping.Address1 = impl.ShipToAddress.AddressLine1?.Value;
            orderData.Shipping.Address2 = impl.ShipToAddress.AddressLine2?.Value;
            orderData.Shipping.City = impl.ShipToAddress.City?.Value;
            orderData.Shipping.PostalCode = impl.ShipToAddress.PostalCode?.Value;
            orderData.Shipping.Country = GetSubstituteExternByLocal(BCSubstitute.GetValue(Operation.ConnectorType, BCSubstitute.Country), impl.ShipToAddress.Country?.Value, Country.PK.Find(this, impl.ShipToAddress.Country?.Value)?.Description);
            orderData.Shipping.Company = impl.ShipToContact.BusinessName?.Value;
            orderData.Shipping.FirstName = attentionS.FieldsSplit(0, attentionS);
            orderData.Shipping.LastName = attentionS.FieldsSplit(1, attentionS);
            state = PXSelect<State, Where<State.stateID, Equal<Required<State.stateID>>>>.Select(this, impl.ShipToAddress.State?.Value);
            if (state == null)
                orderData.Shipping.State = impl.ShipToAddress.State?.Value;// GetSubstituteExternByLocal(BCSubstitute.GetValue(Operation.ConnectorType, BCSubstitute.State), impl.ShipToAddress.State?.Value, impl.ShipToAddress.State?.Value);
            else
                orderData.Shipping.State = state.Name;

            List<OrderLineItemData> productData = new List<OrderLineItemData>();
            if (existing != null && existing.Extern != null)
            {
                var syncDetails = PXSelectJoin<BCSyncDetail,
                    InnerJoin<BCSyncStatus, On<BCSyncStatus.syncID, Equal<BCSyncDetail.syncID>>>,
                    Where<BCSyncStatus.connectorType, Equal<Current<BCEntity.connectorType>>,
                        And<BCSyncStatus.bindingID, Equal<Current<BCEntity.bindingID>>,
                        And<BCSyncDetail.entityType, Equal<Required<BCSyncDetail.entityType>>,
                        And<BCSyncStatus.externID, Equal<Required<BCSyncStatus.externID>>>>>>>
                    .Select(this, BCEntitiesAttribute.OrderLine, existing.ExternID);
                var deletedList = syncDetails.Where(p => !impl.Details.Any(p2 => p2.NoteID.Value == ((BCSyncDetail)p).LocalID));

                foreach (BCSyncDetail detail in deletedList)
                {

                    OrderLineItemData product = new OrderLineItemData();
                    product.Id = detail.ExternID.ToInt();
                    product.Quantity = 0;
                    product.Total = "0";
                    product.SubTotal = "0";
                    productData.Add(product);
                }
            }

            InventoryItem giftCertificate = GetBindingExt<BCBindingExt>()?.GiftCertificateItemID != null ? InventoryItem.PK.Find(this, GetBindingExt<BCBindingExt>()?.GiftCertificateItemID) : null;
            foreach (SalesOrderDetail detail in impl.Details)
            {
                OrderLineItemData product = new OrderLineItemData();
                if (giftCertificate != null && detail.InventoryID?.Value?.Trim() == giftCertificate.InventoryCD?.Trim()) continue;

                string key = GetProductExternIDByProductCD(detail.InventoryID?.Value, out string sku, out string uom);
                if (key == null) throw new PXException(BCMessages.InvenotryNotSyncronized, detail.InventoryID?.Value);
                if (uom != detail?.UOM?.Value) throw new PXException(BCMessages.NotBaseUOMUsed, detail.InventoryID?.Value);
                if (detail.OrderQty.Value % 1 != 0) throw new PXException(BCMessages.NotDecimalQtyUsed, detail.InventoryID?.Value);

                product.Id = obj.Details.Where(x => x.EntityType == BCEntitiesAttribute.OrderLine && x.LocalID == detail.NoteID.Value).FirstOrDefault()?.ExternID.ToInt();
                product.Quantity = (int)detail.OrderQty.Value;
                product.Total = (decimal)detail.OrderQty.Value == 0 ? detail.Amount.Value.Value.ToString() : (detail.Amount.Value.Value / detail.OrderQty.Value.Value).ToString();
                product.SubTotal = (decimal)detail.OrderQty.Value == 0 ? detail.Amount.Value.Value.ToString() : (detail.Amount.Value.Value / detail.OrderQty.Value.Value).ToString();
                if (!string.IsNullOrEmpty(key.KeySplit(0, string.Empty))) product.ProductId = key.KeySplit(0, string.Empty).ToInt() ?? 0;
                if (!string.IsNullOrEmpty(key.KeySplit(1, string.Empty))) product.VariationId = key.KeySplit(1, string.Empty).ToInt() ?? 0;

                productData.Add(product);
            }
            //We export an order and the order has been updated in both systems with conflict resolved from Acumatica. We need to make sure no new lines has been added in BC, otherwise delete (nullify) them
            if (existing?.Extern != null && ((OrderData)existing?.Extern)?.LineItems?.Count > 0)
                foreach (OrderLineItemData prod in ((OrderData)existing.Extern).LineItems)
                {
                    if (!productData.Any(i => i.Id == prod.Id))
                        productData.Add(new OrderLineItemData()
                        {
                            Id = prod.Id,
                            Quantity = 0,
                            Total = "0",
                            SubTotal = "0"
                        });
                }
            orderData.LineItems = productData;
        }

        public override void SaveBucketExport(WCSalesOrderBucket bucket, IMappedEntity existing, string operation)
        {
            List<PXDataFieldParam> fieldParams = new List<PXDataFieldParam>();
            BCBindingExt bindingExt = GetBindingExt<BCBindingExt>();
            MappedOrder obj = bucket.Order;

            OrderData data = null;
            if (obj.ExternID != null && existing != null && obj.Local.ExternalOrderOriginal?.Value == true) // Update status only if order is unmodified
            {
                data = new OrderData();
                data.Status = obj.Extern.Status;
                data = orderDataProvider.Update(data, obj.ExternID.ToInt().Value);
            }
            else
            {
                if (obj.ExternID == null || existing == null)
                {
                    data = orderDataProvider.Create(obj.Extern);
                }
                else
                {
                    data = orderDataProvider.Update(obj.Extern, obj.ExternID.ToInt().Value);
                }

                InventoryItem giftCertificate = bindingExt.GiftCertificateItemID != null ? InventoryItem.PK.Find(this, bindingExt.GiftCertificateItemID) : null;
                List<OrderLineItemData> products = data.LineItems;// orderProductsRestDataProvider.Get(data.Id?.ToString()) ?? new List<OrdersProductData>();
                DetailInfo[] oldDetails = obj.Details.ToArray(); obj.ClearDetails();
                foreach (SalesOrderDetail detail in obj.Local.Details) //Line ID detail
                {
                    OrderLineItemData product = null;

                    product = products.FirstOrDefault(x => x.ProductId.ToString()
                    == oldDetails.FirstOrDefault(o => o.LocalID == detail.NoteID.Value)?.ExternID);
                    if (product == null)
                    {
                        string externalID = GetProductExternIDByProductCD(detail.InventoryID.Value, out string sku, out string uom);
                        product = products.FirstOrDefault(x => !obj.Details.Any(o => x.Id.ToString() == o.ExternID)
                            && x.ProductId.ToString() == externalID.KeySplit(0)
                            && (string.IsNullOrEmpty(externalID.KeySplit(1, string.Empty))
                                || x.VariationId.ToString() == externalID.KeySplit(1, string.Empty)
                                || !string.IsNullOrEmpty(sku) && x.Sku == sku));
                    }
                    if (product != null)
                    {
                        obj.AddDetail(BCEntitiesAttribute.OrderLine, detail.NoteID.Value, product.Id.ToString());
                        continue;
                    }
                    throw new PXException(BCMessages.CannotMapLines);
                }
                //  Reset ExternalOrderOriginal flag to true 
                fieldParams.Add(new PXDataFieldAssign(typeof(BCSOOrderExt.externalOrderOriginal).Name,
                                                      PXDbType.Bit,
                                                      true));
            }
            obj.AddExtern(data, data.Id?.ToString(), data.DateModifiedGmt.ToDate());
            UpdateStatus(obj, operation);

            #region Update ExternalRef
            string externalRef = APIHelper.ReferenceMake(data.Id?.ToString(), GetBinding().BindingName);
            if (externalRef.Length < 40 && obj.Local.SyncID != null)
            {
                fieldParams.Add(new PXDataFieldAssign(typeof(SOOrder.customerRefNbr).Name,
                                                      PXDbType.NVarChar,
                                                      externalRef));
            }

            if (fieldParams.Count > 0)
            {
                fieldParams.Add(new PXDataFieldRestrict(typeof(SOOrder.noteID).Name,
                                                        PXDbType.UniqueIdentifier,
                                                        obj.Local.SyncID.Value));
                PXDatabase.Update<SOOrder>(fieldParams.ToArray());
            }
            #endregion
        }
        #endregion

        #region Methods
        public static string ConvertStatus(string status)
        {
            switch (status)
            {
                case PX.Objects.SO.Messages.BackOrder:
                    return OrderStatuses.Completed;
                case PX.Objects.SO.Messages.Cancelled:
                    return OrderStatuses.Cancelled;
                case PX.Objects.SO.Messages.Completed:
                    return OrderStatuses.Completed;
                case PX.Objects.SO.Messages.CreditHold:
                    return OrderStatuses.OnHold;
                case PX.Objects.SO.Messages.Hold:
                    return OrderStatuses.OnHold;
                case PX.Objects.SO.Messages.Open:
                    return OrderStatuses.Processing;
                case PX.Objects.EP.Messages.Balanced:
                    return OrderStatuses.Completed;
                case PX.Objects.SO.Messages.Shipping:
                    return OrderStatuses.OnHold;
                case PX.Objects.EP.Messages.Voided:
                    return OrderStatuses.Cancelled;
                case PX.Objects.SO.Messages.Invoiced:
                    return OrderStatuses.Processing;
                default:
                    return OrderStatuses.Pending;
            }
        }

        public virtual string GetProductExternIDByProductCD(string inventoryCD, out string sku, out string uom)
        {
            sku = null;

            InventoryItem item = PXSelect<InventoryItem,
                    Where<InventoryItem.inventoryCD, Equal<Required<InventoryItem.inventoryCD>>>>.Select(this, inventoryCD);
            if (item?.InventoryID == null) throw new PXException(BCMessages.InvenotryNotSyncronized, inventoryCD);
            if (item?.ItemStatus == INItemStatus.Inactive)
                throw new PXException(BCMessages.InvenotryInactive, inventoryCD);
            uom = item?.BaseUnit?.Trim();

            BCSyncStatus itemStatus = PXSelect<BCSyncStatus,
                Where<BCSyncStatus.connectorType, Equal<Current<BCEntity.connectorType>>,
                    And<BCSyncStatus.bindingID, Equal<Current<BCEntity.bindingID>>,
                    And2<Where<BCSyncStatus.entityType, Equal<Required<BCEntity.entityType>>,
                        Or<BCSyncStatus.entityType, Equal<Required<BCEntity.entityType>>>>,
                    And<BCSyncStatus.localID, Equal<Required<BCSyncStatus.localID>>>>>>>
                .Select(this, BCEntitiesAttribute.NonStockItem, BCEntitiesAttribute.StockItem, item.NoteID);

            int? productID = null, variantID = null;
            if (itemStatus?.ExternID == null && item.TemplateItemID != null) // Check for parent item - for variants
            {
                foreach (var status in PXSelectJoin<BCSyncStatus,
                        InnerJoin<InventoryItem, On<InventoryItem.noteID, Equal<BCSyncStatus.localID>>,
                        InnerJoin<BCSyncDetail, On<BCSyncDetail.syncID, Equal<BCSyncStatus.syncID>>>>,
                        Where<BCSyncStatus.connectorType, Equal<Current<BCEntity.connectorType>>,
                            And<BCSyncStatus.bindingID, Equal<Current<BCEntity.bindingID>>,
                            And<BCSyncStatus.entityType, Equal<Required<BCEntity.entityType>>,
                            And<BCSyncDetail.localID, Equal<Required<BCSyncDetail.localID>>>>>>>
                        .Select(this, BCEntitiesAttribute.ProductWithVariant, item.NoteID))
                {
                    BCSyncDetail variantStatus = status.GetItem<BCSyncDetail>();
                    BCSyncStatus parentStatus = status.GetItem<BCSyncStatus>();
                    if (variantStatus?.ExternID != null && parentStatus?.ExternID != null)
                    {
                        variantID = variantStatus.ExternID.ToInt();
                        productID = parentStatus.ExternID.ToInt();
                    }
                }
            }
            else if (itemStatus?.ExternID != null) productID = itemStatus?.ExternID.ToInt();

            if (productID == null)
            {
                ProductData product = productDataProvider.Get(new FilterProducts()
                {
                    Sku = inventoryCD
                })
                    .FirstOrDefault();
                if (product != null)
                {
                    sku = product.Sku;
                    productID = product.Id;
                }
            }

            if (productID == null) throw new PXException(BCMessages.InvenotryNotSyncronized, inventoryCD);

            return variantID == null ? productID?.ToString() : new object[] { productID, variantID }.KeyCombine();
        }
        #endregion
    }
}