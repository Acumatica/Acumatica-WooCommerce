using PX.Api.ContractBased.Models;
using PX.Commerce.Core;
using PX.Commerce.Core.API;
using PX.Commerce.Objects;
using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order;
using PX.Commerce.WooCommerce.API.REST.Filters;
using PX.Commerce.WooCommerce.Sync;
using PX.Commerce.WooCommerce.Sync.Processors;
using PX.Commerce.WooCommerce.WC;
using PX.Commerce.WooCommerce.WC.DACExtensions;
using PX.Commerce.WooCommerce.WC.Descriptor;
using PX.Common;
using PX.Data;
using PX.Objects.AR;
using PX.Objects.SO;
using System;
using System.Collections.Generic;
using System.Linq;
using static PX.Commerce.WooCommerce.WC.Descriptor.Constants;

namespace PX.Commerce.WooCommerce
{
    public class WCRefundsBucket : EntityBucketBase, IEntityBucket
    {
        public IMappedEntity Primary { get => Refunds; }
        public IMappedEntity[] Entities => new IMappedEntity[] { Refunds };
        public override IMappedEntity[] PostProcessors { get => new IMappedEntity[] { Order }; }

        public MappedRefunds Refunds;
        public MappedOrder Order;
    }

    public class BCRefundsRestrictor : BCBaseRestrictor, IRestrictor
    {
        public virtual FilterResult RestrictExport(IProcessor processor, IMappedEntity mapped)
        {
            return null;
        }

        public virtual FilterResult RestrictImport(IProcessor processor, IMappedEntity mapped)
        {
            return base.Restrict(mapped, delegate (MappedRefunds obj)
            {
                if (processor.SelectStatus(BCEntitiesAttribute.Order, obj.Extern.Id.ToString()) == null)
                {
                    return new FilterResult(FilterStatus.Ignore,
                        PXMessages.LocalizeNoPrefix(BCMessages.LogRefundSkippedOrderNotSynced));
                }

                return null;
            });
        }
    }

    [BCProcessor(typeof(WCConnector), BCEntitiesAttribute.OrderRefunds, BCCaptions.Refunds,
        IsInternal = false,
        Direction = SyncDirection.Import,
        PrimaryDirection = SyncDirection.Import,
        PrimarySystem = PrimarySystem.Extern,
        PrimaryGraph = typeof(SOOrderEntry),
        ExternTypes = new Type[] { },
        LocalTypes = new Type[] { },
        DetailTypes = new String[] { BCEntitiesAttribute.CustomerRefundOrder, BCCaptions.CustomerRefundOrder },
        AcumaticaPrimaryType = typeof(SOOrder),
        AcumaticaPrimarySelect = typeof(Search2<SOOrder.orderNbr,
            InnerJoin<BCBinding, On<BCBindingExt.orderType, Equal<SOOrder.orderType>>>,
            Where<BCBinding.connectorType, Equal<Current<BCSyncStatusEdit.connectorType>>,
                And<BCBinding.bindingID, Equal<Current<BCSyncStatusEdit.bindingID>>>>>),
        URL = "post.php?post={0}&action=edit",
        Requires = new string[] { BCEntitiesAttribute.Order, BCEntitiesAttribute.Payment }
    )]
    public class WCRefundsProcessor : WCOrderBaseProcessor<WCRefundsProcessor, WCRefundsBucket, MappedRefunds>
    {

        #region Initialization
        public override void Initialise(IConnector iconnector, ConnectorOperation operation)
        {
            base.Initialise(iconnector, operation);
        }

        #endregion

        #region Export

        public override void FetchBucketsForExport(DateTime? minDateTime, DateTime? maxDateTime, PXFilterRow[] filters)
        {
        }

        public override EntityStatus GetBucketForExport(WCRefundsBucket bucket, BCSyncStatus syncstatus)
        {
            SalesOrder impl = cbapi.GetByID<SalesOrder>(syncstatus.LocalID, GetCustomFieldsForExport());
            if (impl == null) return EntityStatus.None;

            bucket.Refunds = bucket.Refunds.Set(impl, impl.SyncID, impl.SyncTime);
            EntityStatus status = EnsureStatus(bucket.Refunds, SyncDirection.Export);

            return status;
        }

        public override void SaveBucketExport(WCRefundsBucket bucket, IMappedEntity existing, string operation)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Import
        public override IEnumerable<MappedRefunds> PullSimilar(IExternEntity entity, out string uniqueField)
        {
            var currentBinding = GetBinding();
            var currentBindingExt = GetBindingExt<BCBindingExt>();
            uniqueField = ((OrderData)entity)?.Id.ToString();
            if (string.IsNullOrEmpty(uniqueField))
                return null;
            uniqueField = APIHelper.ReferenceMake(uniqueField, currentBinding.BindingName);

            List<MappedRefunds> result = new List<MappedRefunds>();
            List<string> orderTypes = new List<string>() { currentBindingExt?.OrderType };
            if (!string.IsNullOrWhiteSpace(currentBindingExt.OtherSalesOrderTypes))
            {
                //Support exported order type searching
                var exportedOrderTypes = currentBindingExt.OtherSalesOrderTypes?.Split(',').Where(i => i != currentBindingExt.OrderType);
                if (exportedOrderTypes.Count() > 0)
                    orderTypes.AddRange(exportedOrderTypes);
            }
            helper.TryGetCustomOrderTypeMappings(ref orderTypes);

            foreach (SOOrder item in helper.OrderByTypesAndCustomerRefNbr.Select(orderTypes.ToArray(), uniqueField))
            {
                SalesOrder data = new SalesOrder() { SyncID = item.NoteID, SyncTime = item.LastModifiedDateTime, ExternalRef = item.CustomerRefNbr?.ValueField() };
                result.Add(new MappedRefunds(data, data.SyncID, data.SyncTime));
            }
            return result;
        }

        public override void FetchBucketsForImport(DateTime? minDateTime, DateTime? maxDateTime, PXFilterRow[] filters)
        {
            var currentBindingExt = GetBindingExt<BCBindingExt>();
            var extentionOfExt = currentBindingExt.GetExtension<BCBindingExtExt>();
            FilterOrders filter = new FilterOrders();
            if (minDateTime != null) filter.CreatedAfter = minDateTime;

            IEnumerable<OrderData> datas = orderDataProvider.GetAllToDate(filter, extentionOfExt.MaxRefundDays ?? 0);

            foreach (OrderData data in datas)
            {
                if (data.OrderRefunds.Count == 0) continue;

                FilterOrders refundFilter = new FilterOrders();
                refundFilter.CreatedAfter = data.DateModified;
                var newRefunds = orderRefundsRestDataProvider.Get(filter, data.Id);
                if (newRefunds.Max(a => a.DateCreatedUT) > data.DateModified)
                    data.DateModifiedGmt = newRefunds.Max(a => a.DateCreatedUT).ToDate(true);

                WCRefundsBucket bucket = CreateBucket();
                var orderStatus = SelectStatus(BCEntitiesAttribute.Order, data.Id.ToString(), false);

                if (orderStatus == null) continue;

                MappedRefunds obj = bucket.Refunds = bucket.Refunds.Set(data, data.Id.ToString(), data.DateModifiedGmt).With(_ => { _.ParentID = orderStatus.SyncID; return _; });
                EntityStatus status = EnsureStatus(obj, SyncDirection.Import, true);
            }
        }

        public override EntityStatus GetBucketForImport(WCRefundsBucket bucket, BCSyncStatus syncstatus)
        {
            OrderData orderData = orderDataProvider.GetByID(syncstatus.ExternID.KeySplit(0).ToString());

            if (orderData == null) return EntityStatus.None;

            EntityStatus status = EntityStatus.None;
            orderData.Refunds = orderRefundsRestDataProvider.GetByParentId(orderData.Id.ToString()) ?? new List<RefundData>();
            var orderStatus = (BCSyncStatus)SelectStatus(BCEntitiesAttribute.Order, orderData.Id.ToString(), false);
            if (orderStatus == null) return status;

            if (orderStatus.LastOperation == BCSyncOperationAttribute.Skipped)
                throw new PXException(BCMessages.OrderStatusSkipped, orderData.Id);

            bucket.Order = bucket.Order.Set(orderData, orderData.Id?.ToString(), orderData.DateModifiedGmt.ToDate());
            var date = orderData.Refunds.Max(x => x.DateCreatedUT.ToDate());
            MappedRefunds obj = bucket.Refunds = bucket.Refunds.Set(orderData, orderData.Id.ToString(), date);
            status = EnsureStatus(obj, SyncDirection.Import);

            return status;
        }

        public override void MapBucketImport(WCRefundsBucket bucket, IMappedEntity existing)
        {
            MappedRefunds obj = bucket.Refunds;
            OrderData orderData = obj.Extern;
            MappedRefunds mappedRefunds = existing as MappedRefunds;
            if (mappedRefunds?.Local == null) throw new PXException(BCMessages.OrderNotSyncronized, orderData.Id);
            if (mappedRefunds.Local.Status?.Value == PX.Objects.SO.Messages.Open || mappedRefunds.Local.Status?.Value == PX.Objects.SO.Messages.Hold)
            {
                bucket.Refunds.Local = new SalesOrder();
                bucket.Refunds.Local.EditSO = true;
                CreateRefundPayment(bucket, mappedRefunds);
            }
            else if (mappedRefunds.Local.Status?.Value == PX.Objects.SO.Messages.Cancelled && (orderData.Status == OrderStatuses.Refunded || orderData.Status == OrderStatuses.Cancelled))
            {
                bucket.Refunds.Local = new SalesOrder();
                CreateRefundPayment(bucket, mappedRefunds);
            }
            else if (mappedRefunds?.Local?.Status?.Value == PX.Objects.SO.Messages.Completed)
            {
                bucket.Refunds.Local = new SalesOrder();
                CreateRefundOrders(bucket, mappedRefunds);
                CreateRefundPayment(bucket, mappedRefunds);
            }
            else
                throw new PXException(BCMessages.OrderStatusNotValid, orderData.Id);

        }

        #region Create CustomerRefund 

        public virtual void CreateRefundPayment(WCRefundsBucket bucket, MappedRefunds existing)
        {
            var currentBinding = GetBinding();
            var currentBindingExt = GetBindingExt<BCBindingExt>();
            SalesOrder impl = bucket.Refunds.Local;
            OrderData orderData = bucket.Refunds.Extern;
            List<RefundData> refunds = orderData.Refunds;
            impl.Payment = new List<Payment>();
            StringValue branch = null;

            List<PXResult<ARPayment, BCSyncStatus>> result = PXSelectJoin<ARPayment,
                                               InnerJoin<BCSyncStatus, On<ARPayment.noteID, Equal<BCSyncStatus.localID>>>,
                                               Where<BCSyncStatus.connectorType, Equal<Current<BCEntity.connectorType>>,
                                                    And<BCSyncStatus.bindingID, Equal<Current<BCEntity.bindingID>>,
                                                   And<BCSyncStatus.entityType, Equal<Required<BCEntity.entityType>>,
                                                   And<BCSyncStatus.externID, Like<Required<BCSyncStatus.externID>>,
                                                   And<ARPayment.docType, Equal<ARDocType.prepayment>>
                                            >>>>>.Select(this, BCEntitiesAttribute.Payment, '%' + bucket.Primary.ExternID + '%').Cast<PXResult<ARPayment, BCSyncStatus>>().ToList();
            branch = PX.Objects.GL.Branch.PK.Find(this, currentBinding.BranchID)?.BranchCD?.ValueField();

            int refundsCount = refunds.Count();
            List<string> usedTransactions = null;

            orderData.Transactions = new List<OrdersTransactionData>();
            var trans1 = helper.CreateOrderTransactionData(orderData);
            trans1.paymentEvent = helper.GetLastEvent(trans1);
            orderData.Transactions.Add(trans1);

            foreach (var refund in refunds)
            {
                ARPayment aRPayment = null;
                BCPaymentMethods currentPayment = null;
                string cashAccount = null;
                Payment refundPayment = new Payment();
                refundPayment.DocumentsToApply = new List<PaymentDetail>();
                refundPayment.TransactionID = new object[] { refund.Id, trans1.Id.ToString() }.KeyCombine();
                var parent = orderData.Transactions.FirstOrDefault();
                if (existing.Local?.Status?.Value != PX.Objects.SO.Messages.Completed
                    && (orderData.Status == OrderStatuses.Refunded || orderData.Status == OrderStatuses.Cancelled)
                    && refund.RefundedPayment.HasValue
                    && refund.RefundedPayment.Value
                    && refund.AmountDecimal.Abs() == orderData.TotalInDecimal.Abs()
                    && orderData.Metadata.Any(s => s.Key == PaymentCaptureKey.AuthNet))
                {
                    /*call voidCardPayment Action 
                     * if Ac order open and fully refunded with CC type payment method and captured(settled)
                    */
                    #region VoidCardFlow
                    refundPayment.Type = PX.Objects.AR.Messages.Prepayment.ValueField();
                    if (!ValidateRefundTransaction(trans1, bucket.Refunds.SyncID, orderData, refund.Id ?? 0, out cashAccount, out currentPayment)) continue;
                    var payment = result?.FirstOrDefault(x => x?.GetItem<BCSyncStatus>()?.ExternID != null
                                                              && x.GetItem<BCSyncStatus>().ExternID.HasParent()
                                                              ? x?.GetItem<BCSyncStatus>()?.ExternID.KeySplit(1) == orderData.Id.ToString()
                                                              : x?.GetItem<BCSyncStatus>()?.ExternID == orderData.Id.ToString());
                    aRPayment = payment?.GetItem<ARPayment>();
                    if (aRPayment == null) throw new PXException(BCMessages.OriginalPaymentNotImported, orderData.Id.ToString(), orderData.Id.ToString());
                    if (aRPayment?.Released != true) throw new PXException(BCMessages.OriginalPaymentNotReleased, orderData.Id.ToString(), orderData.Id.ToString());
                    if (existing != null)
                    {
                        PopulateNoteID(existing, refundPayment, ARDocType.VoidPayment, aRPayment.RefNbr);
                        if (refundPayment.NoteID != null)
                        {
                            impl.Payment.Add(refundPayment);
                            continue;
                        }
                    }

                    refundPayment.ReferenceNbr = aRPayment.RefNbr.ValueField();
                    String paymentTran = helper.ParseTransactionNumber(orderData.Transactions.FirstOrDefault(), out bool isCreditCardTran);
                    refundPayment.VoidCardParameters = new VoidCardPayment()
                    {
                        TranType = CCTranTypeCode.Unknown.ValueField(),
                        TranNbr = paymentTran.ValueField(),
                    };

                    impl.Payment.Add(refundPayment);
                    #endregion
                }
                else
                {
                    bool isCreditCardTran = false;

                    if (orderData.Transactions.First().IsAuthNetTrans() && refund.RefundedPayment == false) continue; //Manual refund to an order with auth.net payment

                    refundPayment.ExternalRef = refund.Id.ToString().ValueField();
                    if (existing != null)
                    {
                        PopulateNoteID(existing, refundPayment, ARDocType.Refund, refundPayment.ExternalRef.Value);
                        if (refundPayment.NoteID != null)
                        {
                            impl.Payment.Add(refundPayment);
                            continue;
                        }
                    }
                    OrdersTransactionData ccrefundTransaction = null;

                    if (orderData.Transactions?.Count() > 0)
                    {
                        var ccrefundTransactionList = orderData.Transactions.Where(s => s.Metadata.Any(m => m.Key == PaymentCaptureKey.AuthNet));
                        //need this logic to get refund transaction. as there is no link between refund payment and refund transaction
                        if (ccrefundTransactionList?.Count() > 1 && usedTransactions == null)
                        {
                            var ccTransactions = PXSelectJoin<BCSyncDetail, InnerJoin<ARPayment, On<BCSyncDetail.localID, Equal<ARPayment.noteID>>>,
                               Where<BCSyncDetail.syncID, Equal<Required<BCSyncDetail.syncID>>,
                               And<BCSyncDetail.entityType, Equal<Required<BCSyncDetail.entityType>>,
                               And<ARPayment.docType, Equal<ARDocType.refund>,
                               And<ARPayment.isCCPayment, Equal<True>>>>>>.Select(this, bucket.Refunds.SyncID, BCEntitiesAttribute.Payment)?.Cast<PXResult<BCSyncDetail, ARPayment>>().ToList();

                            usedTransactions = usedTransactions ?? new List<string>();
                            usedTransactions.AddRange(ccTransactions.Select(x => x.GetItem<ARPayment>().ExtRefNbr));
                            ccrefundTransaction = ccrefundTransactionList.FirstOrDefault(x => usedTransactions != null && !usedTransactions.Contains(helper.ParseTransactionNumber(x, out bool iscc)));
                        }
                        else
                            ccrefundTransaction = ccrefundTransactionList.FirstOrDefault();
                    }

                    var reference = helper.ParseTransactionNumber(ccrefundTransaction, out isCreditCardTran);
                    if (reference != null)
                    {
                        usedTransactions = usedTransactions ?? new List<string>();
                        usedTransactions.Add(reference);
                    }
                    refundPayment.PaymentRef = (reference ?? orderData.TransactionId).ValueField();

                    if (!ValidateRefundTransaction(orderData.Transactions.FirstOrDefault(), bucket.Refunds.SyncID, orderData, refund.Id ?? 0, out cashAccount, out currentPayment)) continue;
                    if (ccrefundTransaction == null && currentPayment?.ProcessingCenterID != null) continue;// if there is processing center and no external refund transaction then skip
                    var payment = result.FirstOrDefault(x => x.GetItem<BCSyncStatus>().ExternID == orderData.Id.ToString());
                    aRPayment = payment.GetItem<ARPayment>();
                    if (currentPayment?.ProcessingCenterID != null && isCreditCardTran)
                    {
                        helper.AddCreditCardProcessingInfo(currentPayment, refundPayment, ccrefundTransaction.paymentEvent, ccrefundTransaction.PaymentInstrumentToken);
                        if (aRPayment?.IsCCPayment == true)
                        {
                            refundPayment.OrigTransaction = ExternalTransaction.PK.Find(this, aRPayment?.CCActualExternalTransactionID)?.TranNumber.ValueField();
                        }
                    }
                    if (existing.Local?.Status?.Value == PX.Objects.SO.Messages.Completed) // do not apply payment just create in on hold status
                    {
                        refundPayment.Hold = true.ValueField();
                        refundPayment.PaymentAmount = refund.AmountDecimal.Abs().ValueField();
                    }
                    else
                    {

                        if (aRPayment == null) throw new PXException(BCMessages.OriginalPaymentNotImported, orderData.Id.ToString(), orderData.Id.ToString());
                        if (aRPayment?.Released != true) throw new PXException(BCMessages.OriginalPaymentNotReleased, orderData.Id.ToString(), orderData.Id.ToString());

                        ValidateCRPayment(aRPayment?.RefNbr);
                        var paymentDetail = CreatePaymentDetail(refundPayment, aRPayment, refund.AmountDecimal.Abs());
                        refundPayment.PaymentAmount = paymentDetail.AmountPaid;

                    }

                    //map Sumary section
                    refundPayment.Type = PX.Objects.AR.Messages.Refund.ValueField();
                    refundPayment.CustomerID = existing.Local.CustomerID;
                    refundPayment.CustomerLocationID = existing.Local.LocationID;
                    var date = refund.DateCreatedUT.ToString().ToDate(PXTimeZoneInfo.FindSystemTimeZoneById(currentBindingExt.OrderTimeZone));
                    if (date.HasValue)
                        refundPayment.ApplicationDate = (new DateTime(date.Value.Date.Ticks)).ValueField();
                    refundPayment.BranchID = branch;
                    refundPayment.TransactionID = new object[] { refund.Id, orderData.Id.ToString() }.KeyCombine();
                    refundPayment.PaymentMethod = currentPayment?.PaymentMethodID?.ValueField();
                    refundPayment.CashAccount = cashAccount?.Trim()?.ValueField();

                    var desc = PXMessages.LocalizeFormat(WCMessages.PaymentRefundDescription, currentBinding.BindingName, orderData.Id, refund.Id, orderData.PaymentMethodTitle);
                    refundPayment.Description = desc.ValueField();
                    impl.Payment.Add(refundPayment);
                }
            }
        }

        public virtual void PopulateNoteID(MappedRefunds existing, Payment refundPayment, string docType, string reference, string paymentRef = null)
        {
            if (existing?.Details?.Count() > 0)
            {
                existing?.Details.FirstOrDefault(d => d.EntityType == BCEntitiesAttribute.Payment && d.ExternID == refundPayment.TransactionID).With(p => refundPayment.NoteID = p.LocalID.ValueField());
            }

            if (refundPayment.NoteID?.Value == null)
            {
                helper.GetExistingRefundPayment(refundPayment, docType, reference);
            }
        }

        public virtual PaymentDetail CreatePaymentDetail(Payment cr, ARPayment aRPayment, decimal? amount)
        {
            PaymentDetail paymentDetail = new PaymentDetail();
            paymentDetail.DocType = ARDocType.Prepayment.ValueField();
            paymentDetail.AmountPaid = (amount ?? 0).ValueField();
            paymentDetail.ReferenceNbr = aRPayment?.RefNbr.ValueField();

            cr.DocumentsToApply.Add(paymentDetail);
            return paymentDetail;
        }

        //validates if existingCR payment is released or not
        public virtual void ValidateCRPayment(string adjgRefNbr)
        {
            var existinCRPayment = PXSelectJoin<ARPayment, InnerJoin<ARAdjust, On<ARPayment.refNbr,
                Equal<ARAdjust.adjgRefNbr>, And<ARAdjust.adjdRefNbr, Equal<Required<ARAdjust.adjdRefNbr>>>>>,
                            Where<ARPayment.docType, Equal<Required<ARPayment.docType>>>>.Select(this, adjgRefNbr, ARDocType.Refund);
            if (existinCRPayment != null && existinCRPayment.Count > 0)
            {
                if (existinCRPayment.Any(x => x.GetItem<ARPayment>().Released == false))
                    throw new PXException(BCMessages.UnreleasedCRPayment, adjgRefNbr,
                        existinCRPayment.FirstOrDefault(x => x.GetItem<ARPayment>().Released == false).GetItem<ARPayment>().RefNbr);
            }
        }

        //validates if processrefund checkbox is checked and credit card refund transaction is not offline
        public virtual bool ValidateRefundTransaction(OrdersTransactionData parent,
            int? syncID,
            OrderData orderData,
            int refundId,
            out string cashAccount,
            out BCPaymentMethods methodMapping)
        {
            string transMethod = helper.GetPaymentMethodName(orderData.PaymentMethod);
            methodMapping = helper.GetPaymentMethodMapping(transMethod, orderData.PaymentMethod, orderData.Currency, out cashAccount, false);
            if (methodMapping?.ProcessRefunds != true)
            {
                LogInfo(Operation.LogScope(syncID), BCMessages.LogRefundPaymentSkipped, orderData.Id, refundId, orderData.Id, methodMapping?.PaymentMethodID ?? transMethod);
                return false; // process refund if only ProcessRefunds is checked
            }
            return true;
        }
        #endregion

        #region CreateRefundOrders

        public virtual void CreateRefundOrders(WCRefundsBucket bucket, MappedRefunds existing)
        {
            var currentBinding = GetBinding();
            var currentBindingExt = GetBindingExt<BCBindingExt>();

            SalesOrder origOrder = bucket.Refunds.Local;
            OrderData orderData = bucket.Refunds.Extern;
            List<RefundData> refunds = orderData.Refunds;
            origOrder.RefundOrders = new List<SalesOrder>();
            var branch = PX.Objects.GL.Branch.PK.Find(this, currentBinding.BranchID)?.BranchCD?.ValueField();
            decimal totalRefundAmount = 0;
            decimal totalTaxRefundAmount = 0;
            decimal totalShipRefundAmount = 0;


            Dictionary<string, decimal> refundedTaxes = new Dictionary<string, decimal>();
            foreach (RefundData data in refunds)
            {
                decimal refundItemAmount = 0;

                //if (data.RefundPayments.All(x => x.IsDeclined == true)) continue;
                SalesOrder impl = new SalesOrder();
                impl.ExternalRef = APIHelper.ReferenceMake(data.Id, currentBinding.BindingName).ValueField();
                //Check if refund is already imported as RC Order
                var existingRC = cbapi.GetAll(new SalesOrder()
                {
                    OrderType = currentBindingExt.ReturnOrderType.SearchField(),
                    ExternalRef = impl.ExternalRef.Value.SearchField(),
                    Details = new List<SalesOrderDetail>() { new SalesOrderDetail() { InventoryID = new StringReturn() } },
                    DiscountDetails = new List<SalesOrdersDiscountDetails>() { new SalesOrdersDiscountDetails() { ExternalDiscountCode = new StringReturn() } }
                },
                filters: GetFilter(Operation.EntityType).LocalFiltersRows.Cast<PXFilterRow>());
                if (existingRC.Count() > 1)
                {
                    throw new PXException(BCMessages.MultipleEntitiesWithUniqueField, BCCaptions.SyncDirectionImport,
                          Connector.GetEntities().First(e => e.EntityType == Operation.EntityType).EntityName, data.Id.ToString());
                }
                var presentCROrder = existingRC?.FirstOrDefault();
                // skip refunds that were adjusted  before order completion
                if (existing != null)
                {
                    if (existing?.Details?.Count() > 0)
                    {
                        if (existing.Details.Any(d => d.EntityType == BCEntitiesAttribute.Payment && d.ExternID.KeySplit(0) == data.Id.ToString()) && presentCROrder == null) continue;
                    }
                    if (existing.Local.ExternalRefundRef?.Value != null)
                    {
                        if (existing.Local.ExternalRefundRef.Value.Split(new char[] { ';' }).Contains(data.Id.ToString())) continue;
                    }
                }

                impl.Id = presentCROrder?.Id;

                origOrder.RefundOrders.Add(impl);

                impl.RefundID = data.Id.ToString();
                impl.OrderType = currentBindingExt.ReturnOrderType.ValueField();
                impl.FinancialSettings = new FinancialSettings();
                impl.FinancialSettings.Branch = branch;
                var date = data.DateCreatedUT.ToString().ToDate(PXTimeZoneInfo.FindSystemTimeZoneById(currentBindingExt.OrderTimeZone));
                if (date.HasValue)
                    impl.Date = new DateTime(date.Value.Date.Ticks).ValueField();
                impl.RequestedOn = impl.Date;
                impl.CustomerOrder = orderData.Id.ToString().ValueField();
                impl.CustomerID = existing.Local.CustomerID;
                impl.LocationID = existing.Local.LocationID;
                impl.ExternalRef = APIHelper.ReferenceMake(data.Id, currentBinding.BindingName).ValueField();
                var description = PXMessages.LocalizeFormat(WCMessages.OrderDescription, currentBinding.BindingName, orderData.Id.ToString(), orderData.Status.ToString());
                impl.Description = description.ValueField();
                impl.Details = new List<SalesOrderDetail>();
                impl.Totals = new Totals();
                impl.Totals.OverrideFreightAmount = existing.Local.Totals?.OverrideFreightAmount;
                List<RefundLineItemData> refundItems = data.LineItems;
                decimal shippingRefundAmt = data.ShippingLines.Sum(x => x.TotalInDecimal).Abs();

                impl.ShipVia = existing.Local.ShipVia;
                if ((existing.Local.Totals?.Freight?.Value == null || existing.Local.Totals?.Freight?.Value == 0) && existing.Local.Totals?.PremiumFreight?.Value > 0)
                {
                    totalShipRefundAmount += shippingRefundAmt;
                    if (shippingRefundAmt > existing.Local.Totals?.PremiumFreight?.Value)
                    {
                        refundItemAmount += shippingRefundAmt - existing.Local.Totals.PremiumFreight.Value.Value;
                        shippingRefundAmt = existing.Local.Totals.PremiumFreight.Value.Value;
                    }
                    impl.Totals.PremiumFreight = shippingRefundAmt.ValueField();
                }
                else
                {
                    if (shippingRefundAmt > existing.Local.Totals?.Freight?.Value)
                    {
                        refundItemAmount += shippingRefundAmt - existing.Local.Totals.Freight.Value.Value;
                        shippingRefundAmt = existing.Local.Totals.Freight.Value.Value;
                    }
                    impl.Totals.Freight = shippingRefundAmt.ValueField();
                }

                var totalRefundedProductLineItems = data.LineItems.Sum(s => s.Price * s.Quantity ?? 0m).Abs();
                var totalRefundedShippingLineItems = data.ShippingLines.Sum(s => s.TotalInDecimal).Abs();
                var totalRefundedItemTaxes = data.LineItems.Sum(s => s.Taxes.Sum(x => x.TotalInDecimal)).Abs();
                totalRefundedItemTaxes += data.ShippingLines.Sum(s => s.Taxes.Sum(x => x.TotalInDecimal)).Abs(); ;

                var refundTaxLines = data.LineItems?.SelectMany(s => s.Taxes).ToList();
                refundTaxLines.AddRange(data.ShippingLines?.SelectMany(s => s.Taxes).ToList());

                //#region Taxes	
                decimal? taxable = data.AmountDecimal - totalRefundedItemTaxes;
                var taxAmount = Math.Round(totalRefundedItemTaxes, 2);

                impl.TaxDetails = new List<TaxDetail>();

                totalRefundAmount += data.AmountDecimal.Abs();

                if (existing.Local.TaxDetails?.Count > 0 && totalRefundedItemTaxes > 0 && orderData.TotalInDecimal > 0)// if acumatica original SO has tax and Refunds has tax then process tax
                {
                    impl.IsTaxValid = true.ValueField();
                    foreach (TaxData tax in refundTaxLines.GroupBy(g => g.Id).Select(k => new TaxData { Id = k.Key, Total = k.Sum(s => s.TotalInDecimal).ToString() }))
                    {
                        if (!refundedTaxes.ContainsKey(tax.Id))
                            refundedTaxes.Add(tax.Id, 0);

                        var orderTax = orderData.TaxLines.Single(s => s.RateCode == tax.Id);
                        string mappedTaxName = mappedTaxName = GetSubstituteLocalByExtern(GetBindingExt<BCBindingExt>().TaxSubstitutionListID, tax.Id, tax.Id);
                        mappedTaxName = helper.TrimAutomaticTaxNameForAvalara(mappedTaxName);
                        if (string.IsNullOrEmpty(mappedTaxName)) throw new PXException(BCObjectsMessages.TaxNameDoesntExist);
                        TaxDetail inserted = impl.TaxDetails.FirstOrDefault(i => i.TaxID.Value?.Equals(mappedTaxName, StringComparison.InvariantCultureIgnoreCase) == true);
                        if (refundedTaxes[tax.Id] <= orderTax.TaxTotalInDecimal)
                        {
                            if (inserted == null)
                            {
                                var currentTax = tax.TotalInDecimal.Abs();
                                if (currentTax > orderTax.TaxTotalInDecimal)
                                {
                                    refundItemAmount += currentTax - orderTax.TaxTotalInDecimal ?? 0;
                                    refundedTaxes[tax.Id] = currentTax = orderTax.TaxTotalInDecimal ?? 0;
                                }
                                impl.TaxDetails.Add(new TaxDetail()
                                {
                                    TaxID = mappedTaxName.ValueField(),
                                    TaxAmount = currentTax.ValueField(),
                                    TaxRate = (taxable == 0 ? 0 : tax.TotalInDecimal / taxable).Abs().ValueField(),
                                    TaxableAmount = taxable.ValueField()
                                });
                            }
                            else if (inserted.TaxAmount != null)
                            {
                                var currentTax = tax.TotalInDecimal.Abs();
                                if (inserted.TaxAmount.Value > orderTax.TaxTotalInDecimal)
                                {
                                    refundItemAmount += currentTax;
                                    currentTax = 0;
                                }
                                else if (inserted.TaxAmount.Value + currentTax > orderTax.TaxTotalInDecimal)
                                {
                                    refundItemAmount += inserted.TaxAmount.Value + currentTax - orderTax.TaxTotalInDecimal ?? 0;
                                    currentTax = orderTax.TaxTotalInDecimal ?? 0;
                                }
                                inserted.TaxAmount.Value += currentTax;
                                refundedTaxes[tax.Id] = inserted.TaxAmount.Value ?? 0;
                            }
                        }
                    }
                }

                totalTaxRefundAmount += totalRefundedItemTaxes;

                if (impl.TaxDetails?.Count > 0)
                {
                    impl.FinancialSettings.OverrideTaxZone = existing.Local.FinancialSettings.OverrideTaxZone;
                    impl.FinancialSettings.CustomerTaxZone = existing.Local.FinancialSettings.CustomerTaxZone;
                }

                refundItemAmount += data.LineItems.Where(l => l.Quantity == 0 && l.SubTotalInDecimal.Abs() > 0).Sum(s => s.SubTotalInDecimal.Abs());


                String[] tooLongTaxIDs = ((impl.TaxDetails ?? new List<TaxDetail>()).Select(x => x.TaxID?.Value).Where(x => (x?.Length ?? 0) > PX.Objects.TX.Tax.taxID.Length).ToArray());
                if (tooLongTaxIDs != null && tooLongTaxIDs.Length > 0)
                {
                    throw new PXException(BCObjectsMessages.CannotFindSaveTaxIDs, String.Join(",", tooLongTaxIDs), PX.Objects.TX.Tax.taxID.Length);
                }



                //#endregion


                #region Discounts
                Dictionary<string, decimal?> totalDiscount = null;
                if (data.LineItems.Sum(c => c.Quantity.Abs()) > 0)
                {
                    totalDiscount = AddSOLine(bucket, impl, data, existing, branch, presentCROrder, ref refundItemAmount);
                }

                //Refund item insert
                if (refundItemAmount != 0)
                {
                    var detail = InsertRefundAmountItem(refundItemAmount, branch);
                    if (presentCROrder?.Details != null)
                        presentCROrder?.Details.FirstOrDefault(x => x.InventoryID.Value == detail.InventoryID.Value).With(e => detail.Id = e.Id);
                    impl.Details.Add(detail);

                }


                if (currentBindingExt.PostDiscounts == BCPostDiscountAttribute.DocumentDiscount && totalDiscount != null && totalDiscount?.Count > 0)
                {
                    #region Coupons
                    impl.DisableAutomaticDiscountUpdate = true.ValueField();
                    impl.DiscountDetails = new List<SalesOrdersDiscountDetails>();
                    foreach (CouponLineData couponData in orderData.CouponLines)
                    {
                        SalesOrdersDiscountDetails disDetail = new SalesOrdersDiscountDetails();
                        disDetail.ExternalDiscountCode = couponData.Code.ValueField();
                        disDetail.Description = string.Format(BCMessages.DiscountCouponDesctiption, couponData.Code, couponData.Discount)?.ValueField();

                        if (currentBindingExt.PostDiscounts == BCPostDiscountAttribute.DocumentDiscount)
                            disDetail.DiscountAmount = totalDiscount.GetValueOrDefault_<decimal>(couponData.Code, 0).ValueField();
                        else disDetail.DiscountAmount = 0m.ValueField();

                        impl.DiscountDetails.Add(disDetail);
                    }
                    #endregion


                    SalesOrdersDiscountDetails detail = new SalesOrdersDiscountDetails();
                    detail.Type = PX.Objects.Common.Discount.DiscountType.ExternalDocument.ValueField();
                    detail.ExternalDiscountCode = "Manual".ValueField();
                    detail.DiscountAmount = (totalDiscount.GetValueOrDefault_<decimal>("Manual", 0)).ValueField();
                    impl.DiscountDetails.Add(detail);
                }

                #endregion

                #region Adjust for Existing
                if (presentCROrder != null)
                {
                    //Keep the same order Type
                    impl.OrderType = presentCROrder.OrderType;

                    //if Order already exists assign ID's 
                    presentCROrder.DiscountDetails?.ForEach(e => impl.DiscountDetails?.FirstOrDefault(n => n.ExternalDiscountCode.Value == e.ExternalDiscountCode.Value).With(n => n.Id = e.Id));

                    impl.DiscountDetails?.AddRange(presentCROrder.DiscountDetails == null ? Enumerable.Empty<SalesOrdersDiscountDetails>()
                    : presentCROrder.DiscountDetails.Where(e => impl.DiscountDetails == null || !impl.DiscountDetails.Any(n => e.Id == n.Id)).Select(n => new SalesOrdersDiscountDetails() { Id = n.Id, Delete = true }));
                }
                #endregion
            }

        }
        public virtual Dictionary<string, decimal?> AddSOLine(WCRefundsBucket bucket, SalesOrder impl, RefundData data, MappedRefunds existing,
            StringValue branch, SalesOrder presentCROrder, ref decimal refundItemAmount)
        {
            var currentBinding = GetBinding();
            OrderData salesOrder = bucket.Refunds.Extern;
            var currentBindingExt = GetBindingExt<BCBindingExt>();
            Dictionary<string, decimal?> totaldiscount = new Dictionary<string, decimal?>();
            foreach (var item in data.LineItems?.Where(l => l.Quantity.Abs() > 0))
            {
                SalesOrderDetail detail = new SalesOrderDetail();
                var productData = salesOrder.LineItems.FirstOrDefault(x => x.Sku == item.Sku);
                if (productData == null) throw new PXException(BCMessages.RefundInventoryNotFound, item.Sku);

                var otherRefundsWithCurrentProduct = salesOrder.Refunds.Where(r => r.Id != data.Id)
                    .SelectMany(s => s.LineItems.Where(l => l.Sku == item.Sku));

                string inventoryCD = helper.GetInventoryCDByExternID(
                    productData.ProductId.ToString(), productData.Sku,
                    out string uom);
                decimal? discountPerItem = 0;
                if (productData.Discount != 0)
                {
                    discountPerItem = productData.Discount / productData.Quantity;
                    detail.DiscountAmount = (discountPerItem * item.Quantity.Abs()).ValueField();
                    foreach (var discount in salesOrder.CouponLines)
                    {
                        string key = discount.Code;
                        var discountAmount = (discount.DiscountInDecimal / productData.Quantity * item.Quantity).Abs();
                        if (totaldiscount.ContainsKey(key))
                        {
                            totaldiscount[key] = totaldiscount[key].Value + discountAmount;
                        }
                        else
                        {
                            totaldiscount.Add(key, discountAmount);
                        }
                    }
                }
                if (currentBindingExt.PostDiscounts != BCPostDiscountAttribute.LineDiscount)
                    detail.DiscountAmount = 0m.ValueField();

                detail.InventoryID = inventoryCD?.TrimEnd().ValueField();

                if (item.Quantity.Abs() > productData.Quantity.Abs())
                    throw new PXException(BCMessages.RefundQuantityGreater);
                if (string.IsNullOrWhiteSpace(currentBindingExt.ReasonCode))
                    throw new PXException(WCMessages.ReasonCodeRequired);

                decimal extgendedPrice = 0;

                //Refunded total has to be be equal to quantity * unit price, if only quantity refund
                bool isQuantityOnlyRefund = (item.TotalInDecimal * item.Quantity).Abs() == productData.PriceDecimal * item.Quantity.Abs();

                if (otherRefundsWithCurrentProduct.Any())
                {
                    if (!isQuantityOnlyRefund)
                    {
                        if (item.TotalInDecimal.Abs() > productData.TotalInDecimal)
                        {
                            refundItemAmount += item.TotalInDecimal.Abs() - (item.Quantity.Value.Abs() * productData.PriceDecimal);
                            extgendedPrice = productData.PriceDecimal;
                        }
                        else
                        {
                            extgendedPrice = item.TotalInDecimal.Abs();
                        }
                    }
                    else
                    {
                        extgendedPrice = item.TotalInDecimal.Abs();
                    }
                }
                else
                {
                    decimal maxRefund = 0;
                    maxRefund = productData.TotalInDecimal.Abs() - (item.Quantity.Value.Abs() * productData.PriceDecimal);

                    if (maxRefund <= 0)
                    {
                        refundItemAmount += item.TotalInDecimal.Abs();
                    }
                    else
                    {
                        if (currentBindingExt.PostDiscounts == BCPostDiscountAttribute.DocumentDiscount)
                            extgendedPrice = (productData.SubTotalDecimal / productData.Quantity * item.Quantity.Value.Abs()).Value;
                        else
                            extgendedPrice = maxRefund;
                    }
                }

                detail.OrderQty = ((decimal)item.Quantity.Abs()).ValueField();
                detail.UOM = uom.ValueField();
                detail.UnitPrice = productData.UnitPrice.ValueField();
                detail.ManualPrice = true.ValueField();
                detail.ReasonCode = currentBindingExt.ReasonCode?.ValueField();
                detail.ExternalRef = item.ProductId.ToString().ValueField();
                detail.ExtendedPrice = extgendedPrice.ValueField();
                impl.Details.Add(detail);

                DetailInfo matchedDetail = existing?.Details?.FirstOrDefault(d => d.EntityType == BCEntitiesAttribute.OrderLine && item.ProductId.ToString() == d.ExternID.KeySplit(1) && data.Id.ToString() == d.ExternID.KeySplit(0));
                if (matchedDetail != null) detail.Id = matchedDetail.LocalID; //Search by Details
                else if (presentCROrder?.Details != null && presentCROrder.Details.Count > 0) //Serach by Existing line
                {
                    SalesOrderDetail matchedLine = presentCROrder.Details.FirstOrDefault(x =>
                        (x.ExternalRef?.Value != null && x.ExternalRef?.Value == item.ProductId.ToString())
                        ||
                        (x.InventoryID?.Value == detail.InventoryID?.Value && (detail.UOM == null || detail.UOM.Value == x.UOM?.Value)));
                    if (matchedLine != null) detail.Id = matchedLine.Id;
                }

            }

            return totaldiscount;
        }
        #endregion

        public override void SaveBucketImport(WCRefundsBucket bucket, IMappedEntity existing, string operation)
        {
            MappedRefunds obj = bucket.Refunds;
            SalesOrder order = obj.Local;
            try
            {
                obj.ClearDetails();

                if (order.Payment != null)
                {
                    List<Tuple<string, string>> addedRefNbr = new List<Tuple<string, string>>();
                    foreach (var payment in order.Payment)
                    {
                        Payment paymentResp = null;
                        Guid? localId = payment.NoteID?.Value;
                        if (payment.VoidCardParameters != null)
                        {
                            paymentResp = cbapi.Invoke(payment, action: payment.VoidCardParameters);
                            localId = paymentResp.Id;
                        }
                        else
                        {
                            if (payment.NoteID?.Value == null)
                            {
                                paymentResp = cbapi.Put(payment);
                                localId = paymentResp?.NoteID?.Value;
                                foreach (var detail in payment.DocumentsToApply)
                                {
                                    addedRefNbr.Add(new Tuple<string, string>(detail.ReferenceNbr.Value, paymentResp.ReferenceNbr.Value));
                                }
                            }
                        }
                        if (!obj.Details.Any(x => x.LocalID == localId))
                        {
                            obj.AddDetail(BCEntitiesAttribute.Payment, localId, obj.Extern.TransactionId);

                        }

                    }
                }

                if (order.RefundOrders != null)
                {
                    foreach (var refundOrder in order.RefundOrders)
                    {
                        var details = refundOrder.Details;
                        var localID = refundOrder.Id;
                        if (refundOrder.Id == null)
                        {
                            #region Taxes
                            //Logging for taxes
                            helper.LogTaxDetails(obj.SyncID, refundOrder);
                            #endregion

                            SalesOrder impl = cbapi.Put(refundOrder, localID);
                            localID = impl.Id;
                            details = impl.Details;
                            if (impl.OrderTotal?.Value > obj.Extern.Refunds.FirstOrDefault(x => x.Id.ToString() == refundOrder.RefundID).AmountDecimal.Abs())
                                throw new PXException(BCMessages.RCOrderTotalGreater);
                            #region Taxes
                            helper.ValidateTaxes(obj.SyncID, impl, refundOrder);
                            #endregion
                        }

                        if (!obj.Details.Any(x => x.LocalID == localID))
                        {
                            obj.AddDetail(BCEntitiesAttribute.CustomerRefundOrder, localID, refundOrder.RefundID);
                        }
                    }

                }
                UpdateStatus(obj, operation);
                if (order.EditSO)
                {
                    bucket.Order.ExternTimeStamp = DateTime.MaxValue;
                    EnsureStatus(bucket.Order, SyncDirection.Import);
                }
                else
                    bucket.Order = null;

            }
            catch (SetSyncStatusException)
            {
                throw;
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Pull
        public override MappedRefunds PullEntity(string externID, string externalInfo)
        {
            return null;
        }

        public override MappedRefunds PullEntity(Guid? localID, Dictionary<string, object> externalInfo)
        {
            return null;
        }

        #endregion
    }
}
