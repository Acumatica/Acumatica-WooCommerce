using System.Collections.Generic;
using BCApiClient.Rest.Client.Common;
using BCApiClient.Rest.Domain.Entities.Orders;
using BCApiClient.Rest.Interfaces;

namespace BCApiClient.Rest.Client.DataRepository.Orders
{
    public class OrderShippingAddressesRestDataProvider : RestDataProviderV2, IChildRestDataProvider<OrderShippingAddressData>
    {
        protected override string GetListUrl { get; }   = "v2/orders/{parent_id}/shipping_addresses";
        protected override string GetSingleUrl { get; } = "v2/orders/{parent_id}/shipping_addresses/{id}";
        protected override string GetCountUrl { get; }  = "v2/orders/{parent_id}/shipping_addresses/count";

        public OrderShippingAddressesRestDataProvider(IBigCommerceRestClient restClient)
        {
            _restClient = restClient;
        }
        public int Count(int parentId)
        {
            var segments = MakeUrlSegments(parentId.ToString());
            return GetCount(segments).Count;
        }

        public List<OrderShippingAddressData> Get(int parentId)
        {
            var segments = MakeParentUrlSegments(parentId.ToString());
            return Get<OrderShippingAddressData>(null, segments);
        }

        public List<OrderShippingAddressData> GetAll(int parentId)
        {
            var segments = MakeUrlSegments(parentId.ToString());
            return GetAll<OrderShippingAddressData>(null, segments);
        }
        
        public OrderShippingAddressData GetByID(int parentId, int id)
        {
            var segments = MakeUrlSegments(id.ToString(), parentId.ToString());
            return GetByID<OrderShippingAddressData>(segments);
        }

        public OrderShippingAddressData Create(OrderShippingAddressData entity, int parentId)
        {
            var segments = MakeParentUrlSegments(parentId.ToString());
            return Create(entity, segments);
        }

        public OrderShippingAddressData Update(OrderShippingAddressData entity, int id, int parentId)
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
