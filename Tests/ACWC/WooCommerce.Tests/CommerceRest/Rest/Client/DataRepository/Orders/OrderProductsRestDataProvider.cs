using System.Collections.Generic;
using BCApiClient.Rest.Client.Common;
using BCApiClient.Rest.Domain.Entities.Orders;
using BCApiClient.Rest.Interfaces;

namespace BCApiClient.Rest.Client.DataRepository.Orders
{
    public class OrderProductsRestDataProvider : RestDataProviderV2, IChildRestDataProvider<OrderProductData>
    {
        protected override string GetListUrl { get; }   = "v2/orders/{parent_id}/products";
        protected override string GetSingleUrl { get; } = "v2/orders/{parent_id}/products/{id}";
        protected override string GetCountUrl { get; }  = "v2/orders/{parent_id}/products/count";

        public OrderProductsRestDataProvider(IBigCommerceRestClient restClient)
        {
            _restClient = restClient;
        }
        public int Count(int parentId)
        {
            var segments = MakeUrlSegments(parentId.ToString());
            return GetCount(segments).Count;
        }

        public List<OrderProductData> Get(int parentId)
        {
            var segments = MakeParentUrlSegments(parentId.ToString());
            return Get<OrderProductData>(null, segments);
        }

        public List<OrderProductData> GetAll(int parentId)
        {
            var segments = MakeUrlSegments(parentId.ToString());
            return GetAll<OrderProductData>(null, segments);
        }
        
        public OrderProductData GetByID(int id, int parentId)
        {
            var segments = MakeUrlSegments(id.ToString(), parentId.ToString());
            return GetByID<OrderProductData>(segments);
        }

        public OrderProductData Create(OrderProductData entity, int parentId)
        {
            var segments = MakeParentUrlSegments(parentId.ToString());
            return Create(entity, segments);
        }

        public OrderProductData Update(OrderProductData entity, int id, int parentId)
        {
            var segments = MakeUrlSegments(id.ToString(), parentId.ToString());
            return Update(entity, segments);
        }

        public bool Delete(int id, int parentId)
        {
            var segments = MakeUrlSegments(id.ToString(), parentId.ToString());
            return base.Delete(segments);
        }

        public bool Delete(int parentId)
        {
            throw new System.NotImplementedException();
        }
    }
}
