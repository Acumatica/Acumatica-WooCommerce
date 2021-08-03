using System;
using System.Collections.Generic;
using ACSC.Tests.Custom;
using ACSC.Tests.ShopifyRest.Client.Common;
using ACSC.Tests.ShopifyRest.Domain.Entities.Common;
using ACSC.Tests.ShopifyRest.Domain.Entities.Customers;
using ACSC.Tests.ShopifyRest.Domain.Entities.Order;
using ACSC.Tests.ShopifyRest.Interfaces;

namespace ACSC.Tests.ShopifyRest.Client.DataRepository.Order
{
    public class OrderRestDataProvider : RestDataProviderBase //,IParentRestDataProvider<OrderData>
    {
        protected override string GetListUrl { get; } = "orders";
        protected override string GetSingleUrl { get; } = "orders/{id}";
        protected override string GetCountUrl { get; } = "orders/count";
        protected override string GetSearchUrl => throw new NotImplementedException();
        private string GetMetafieldsUrl { get; } = "orders/{id}/metafields";
        private string GetCloseOrderUrl { get; } = "orders/{id}/close";
        private string GetCancelOrderUrl { get; } = "orders/{id}/cancel";
        private string GetReOpenOrderUrl { get; } = "orders/{id}/open";
        private string GetTransactionsUrl { get; } = "orders/{id}/transactions";
        private string GetSingleTransactionUrl { get; } = "orders/{parent_id}/transactions/{id}";
        private string GetCustomerUrl { get; } = "customers/{id}";
        private string GetOrderRiskUrl { get; } = "orders/{id}/risks";

        private DraftOrderRestDataProvider draftOrderRestDataProvider;

        public OrderRestDataProvider(IWooCommerceRestClient restClient) : base()
        {
            ShopifyRestClient = restClient;
            draftOrderRestDataProvider = new DraftOrderRestDataProvider(restClient);
        }

        //public OrderData Create(OrderData entity)
        //{
        //    DraftOrderData draftOrder = CreateDraftOrder(entity);
        //    if (draftOrder != null) return GetByID(draftOrder.OrderID.ToString());
        //    else throw new Exception(Messages.OrderWasntCreatedException);
        //}

        public OrderData Update(OrderData entity) => Update(entity, entity.Id.ToString());

        public OrderData Update(OrderData entity, string id)
        {
            var segments = MakeUrlSegments(id);
            return base.Update<OrderData, OrderResponse>(entity, segments);
        }

        public bool Delete(OrderData entity, string id) => Delete(id);

        public bool Delete(string id)
        {
            var segments = MakeUrlSegments(id);
            return Delete(segments);
        }

        public List<OrderData> GetCurrentList(out string previousList, out string nextList, IFilter filter = null)
        {
            return GetCurrentList<OrderData, OrdersResponse>(out previousList, out nextList, filter);
        }

        public List<OrderData> GetAll(IFilter filter = null)
        {
            return GetAll<OrderData, OrdersResponse>(filter);
        }

        public OrderData GetByID(string id)
        {
            return GetByID(id, false, false, false, false);
        }

        public OrderData GetByID(string id, bool includedMetafields = false, bool includedTransactions = false, bool includedCustomer = true, bool includedOrderRisk = false)
        {
            var segments = MakeUrlSegments(id);
            var entity = base.GetByID<OrderData, OrderResponse>(segments);
            //if (includedTransactions == true)
            //    entity.Transactions = GetOrderTransactions(id);
            if (includedCustomer == true && entity.Customer != null && entity.Customer.Id > 0)
            {
                entity.Customer = GetOrderCustomer(entity.Customer.Id.ToString());
            }
            //if (includedMetafields == true)
            //    entity.Metafields = GetMetafieldsById(id);
            if (includedOrderRisk == true)
                entity.OrderRisks = GetOrderRisks(id);
            return entity;
        }

        public ItemCount Count()
        {
            return base.GetCount();
        }

        public ItemCount Count(IFilter filter)
        {
            return base.GetCount(filter);
        }

        public List<MetafieldData> GetMetafieldsById(string id)
        {
            var request = BuildRequest(GetMetafieldsUrl, nameof(GetMetafieldsById), MakeUrlSegments(id), null);
            return ShopifyRestClient.GetAll<MetafieldData, MetafieldsResponse>(request);
        }

        public OrderData CloseOrder(string orderId)
        {
            var request = BuildRequest(GetCloseOrderUrl, nameof(CloseOrder), MakeUrlSegments(orderId), null);
            return ShopifyRestClient.Post<OrderData, OrderResponse>(request, null, false);
        }

        public OrderData ReopenOrder(string orderId)
        {
            var request = BuildRequest(GetReOpenOrderUrl, nameof(ReopenOrder), MakeUrlSegments(orderId), null);
            return ShopifyRestClient.Post<OrderData, OrderResponse>(request, null, false);
        }

        public OrderData CancelOrder(string orderId)
        {
            var request = BuildRequest(GetCancelOrderUrl, nameof(CancelOrder), MakeUrlSegments(orderId), null);
            return ShopifyRestClient.Post<OrderData, OrderResponse>(request, null, false);
        }

        //public List<OrderTransaction> GetOrderTransactions(string orderId)
        //{
        //    var request = BuildRequest(GetTransactionsUrl, nameof(GetOrderTransactions), MakeUrlSegments(orderId), null);
        //    return ShopifyRestClient.GetAll<OrderTransaction, OrderTransactionsResponse>(request);
        //}

        //public OrderTransaction GetOrderSingleTransaction(string orderId, string transactionId)
        //{
        //    var request = BuildRequest(GetSingleTransactionUrl, nameof(GetOrderSingleTransaction), MakeUrlSegments(transactionId, orderId), null);
        //    return ShopifyRestClient.Get<OrderTransaction, OrderTransactionResponse>(request).Data;
        //}

        public CustomerData GetOrderCustomer(string orderId)
        {
            var request = BuildRequest(GetCustomerUrl, nameof(GetOrderCustomer), MakeUrlSegments(orderId), null);
            return ShopifyRestClient.Get<CustomerData, CustomerResponse>(request).Data;
        }

        public List<OrderRisk> GetOrderRisks(string orderId)
        {
            var request = BuildRequest(GetMetafieldsUrl, nameof(GetOrderRisks), MakeUrlSegments(orderId), null);
            return ShopifyRestClient.GetAll<OrderRisk, OrderRisksResponse>(request);
        }

        public OrderTransaction PostPaymentToCapture(OrderTransaction entity, string orderId)
        {
            var request = BuildRequest(GetTransactionsUrl, nameof(PostPaymentToCapture), MakeUrlSegments(orderId), null);
            return ShopifyRestClient.Post<OrderTransaction, OrderTransactionResponse>(request, entity);
        }

        //private DraftOrderData CreateDraftOrder(OrderData entity)
        //{
        //    DraftOrderData draftOrder = draftOrderRestDataProvider.Create(MapDraftOrder(entity));
        //   return draftOrderRestDataProvider.Complete(draftOrder.Id.GetValueOrDefault());
        //}

        private DraftOrderData MapDraftOrder(OrderData entity)
        {
            return new DraftOrderData()
            {
                LineItems = entity.LineItems,
                Customer = entity.Customer,
                UseCustomerDefaultAddress = true,
                BillingAddress = entity.BillingAddress,
                Currency = entity.Currency,
                Email = entity.Email,
                Name = entity.Name,
                Note = entity.Note,
                NoteAttributes = entity.NoteAttributes,
                ShippingAddress = entity.ShippingAddress,
                CouponLines = entity.CouponLines.Count == 0 ? null : entity.CouponLines[0],
                Tags = entity.Tags,
                TaxesIncluded = entity.TaxesIncluded,
                TotalTax = entity.TotalTax,
                TaxLines = entity.TaxLines,
                ShippingLine = entity.ShippingLines.Count == 0 ? null : entity.ShippingLines[0],
                //CouponLines = entity.CouponLines.Count == 0 ? null : new DraftOrderDiscount
                //{
                //    Code = entity.DiscountApplications[0].Code
                //}
            };
        }
    }
}