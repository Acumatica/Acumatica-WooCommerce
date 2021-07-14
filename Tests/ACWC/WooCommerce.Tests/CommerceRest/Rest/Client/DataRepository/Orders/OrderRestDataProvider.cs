using System.Collections.Generic;
using ACSC.Tests.BigCommerceRest.Rest.Domain.Entities.Orders;
using BCApiClient.Rest.Client.Common;
using BCApiClient.Rest.Domain.Entities.Common;
using BCApiClient.Rest.Domain.Entities.Orders;
using BCApiClient.Rest.Domain.Entities.Products;
using BCApiClient.Rest.Filters;
using BCApiClient.Rest.Interfaces;

namespace ACSC.Tests.BigCommerceRest.Rest.Client.DataRepository.Orders
{
    public class OrderRestDataProvider : RestDataProviderV2, IParentRestDataProvider<OrderData>
    {
        protected override string GetListUrl { get; } = "v2/orders";
        protected override string GetSingleUrl { get; } = "v2/orders/{id}";
        protected override string GetCountUrl { get; } = "v2/orders/count";

        public OrderRestDataProvider(IBigCommerceRestClient restClient)
        {
            _restClient = restClient;
        }

        public ItemCount Count()
        {
            return GetCount();
        }

        public ItemCount Count(IFilter filter)
        {
            return GetCount(filter);
        }

        public OrderDataResponse CreateOrder(OrderData order)
        {
            var newOrder = Create<OrderData, OrderDataResponse>(order);
            return newOrder;
        }

        public OrderDataResponse Update(OrderData order, int id)
        {
            var segments = MakeUrlSegments(id.ToString());
            return Update<OrderData, OrderDataResponse>(order, segments);
        }
        public OrderDataResponse Update(OrderDataResponse order, int id)
        {
            var segments = MakeUrlSegments(id.ToString());
            return Update<OrderDataResponse>(order, segments);
        }

        public bool Delete(int id)
        {
            var segments = MakeUrlSegments(id.ToString());
            return base.Delete(segments);
        }

        public OrderDataResponse GetByID(int id)
        {
            var segments = MakeUrlSegments(id.ToString());
            var orderData = GetByID<OrderDataResponse>(segments);

            return orderData;
        }

        public OrderDataResponse GetOrderByID(int id)
        {
            var segments = MakeUrlSegments(id.ToString());
            var orderData = GetByID<OrderDataResponse>(segments);

            return orderData;
        }

        public OrderData GetByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public OrderData Create(OrderData entity)
        {
            var newOrder = Create<OrderData>(entity);
            return newOrder;
        }

        public List<OrderData> Get(IFilter filter = null)
        {
            throw new System.NotImplementedException();
        }
       
        public List<OrderData> GetAll(IFilter filter = null)
        {
            throw new System.NotImplementedException();
        }

        OrderData IParentRestDataProvider<OrderData>.GetByID(int id)
        {
            throw new System.NotImplementedException();
        }

        OrderData IParentRestDataProvider<OrderData>.Update(OrderData entity, int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
