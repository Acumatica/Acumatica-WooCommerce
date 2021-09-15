using System;
using System.Collections.Generic;
using ACSC.Tests.Custom;
using ACSC.Tests.ShopifyRest.Client.Common;
using ACSC.Tests.ShopifyRest.Domain.Entities.Common;
using ACSC.Tests.ShopifyRest.Domain.Entities.Customers;
using ACSC.Tests.ShopifyRest.Domain.Entities.Order;
using ACSC.Tests.ShopifyRest.Interfaces;

namespace ACSC.Tests.ShopifyRest.Client.DataRepository.Refund
{
    public class RefundRestDataProvider : RestDataProviderBase //,IParentRestDataProvider<OrderData>
    {

        protected override string GetSingleUrl { get; } = "orders/{id}/refunds";

        protected override string GetListUrl => throw new NotImplementedException();

        protected override string GetCountUrl => throw new NotImplementedException();

        protected override string GetSearchUrl => throw new NotImplementedException();

        public RefundRestDataProvider(IWooCommerceRestClient restClient) : base()
        {
            WooCommerceRestClient = restClient;
        }

        //public OrderRefund CreateRefund(OrderRefund entity)
        //{
        //   return base.CreateRefund<OrderRefund, OrderRefundResponse>(entity);
        //    //return base.CreateRefund<OrderRefund>(entity);
        //}

        public OrderRefund GetByID(string id)
        {
            return GetByID(id, false, false, false, false);
        }

        public OrderRefund GetByID(string id, bool includedMetafields = false, bool includedTransactions = false, bool includedCustomer = false, bool includedOrderRisk = false)
        {
            var segments = MakeUrlSegments(id);
            var entity = base.GetByID<OrderRefund, OrderRefundResponse>(segments);
            //if (includedTransactions == true)
            //    entity.Transactions = GetOrderTransactions(id);
            //if (includedCustomer == true && entity.Customer != null && entity.Customer.Id > 0)
            //{
            //    entity.Customer = GetOrderCustomer(entity.Customer.Id.ToString());
            //}
            //if (includedMetafields == true)
            //    entity.Metafields = GetMetafieldsById(id);
            //if (includedOrderRisk == true)
            //    entity.OrderRisks = GetOrderRisks(id);
            return entity;
        }

        //public OrderData Create(OrderData entity)
        //{
        //    DraftOrderData draftOrder = CreateDraftOrder(entity);
        //    if (draftOrder != null) return GetByID(draftOrder.OrderID.ToString());
        //    else throw new Exception(Messages.OrderWasntCreatedException);
        //}

        //public OrderRefund Create(OrderRefund entity)
        //{

        //}
    }
}