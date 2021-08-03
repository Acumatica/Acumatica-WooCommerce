using System.Collections.Generic;
using BCApiClient.Rest.Client.Common;
using BCApiClient.Rest.Domain.Entities.Orders;
using BCApiClient.Rest.Interfaces;

namespace BCApiClient.Rest.Client.DataRepository.Orders
{
    public class OrderShipmentsRestDataProvider : RestDataProviderV2, IChildRestDataProvider<OrderShipmentData>
    {
        protected override string GetListUrl { get; }   = "v2/orders/{parent_id}/shipments";
        protected override string GetSingleUrl { get; } = "v2/orders/{parent_id}/shipments/{id}";
        protected override string GetCountUrl { get; }  = "v2/orders/{parent_id}/shipments/count";

        public OrderShipmentsRestDataProvider(IBigCommerceRestClient restClient)
        {
            _restClient = restClient;
        }
        public int Count(int parentId)
        {
            var segments = MakeUrlSegments(parentId.ToString());
            return GetCount(segments).Count;
        }

        public List<OrderShipmentData> Get(int parentId)
        {
            var segments = MakeParentUrlSegments(parentId.ToString());
            return Get<OrderShipmentData>(null, segments);
        }

        public List<OrderShipmentData> GetAll(int parentId)
        {
            var segments = MakeUrlSegments(parentId.ToString());
            return GetAll<OrderShipmentData>(null, segments);
        }

        public OrderShipmentData GetByID(int id, int parentId)
        {
            var segments = MakeUrlSegments(id.ToString(), parentId.ToString());
            return GetByID<OrderShipmentData>(segments);
        }

        public OrderShipmentData Create(OrderShipmentData entity, int parentId)
        {
            var segments = MakeParentUrlSegments(parentId.ToString());
            return base.Create(entity, segments);
        }

        public OrderShipmentData Update(OrderShipmentData entity, int id, int parentId)
        {
            var segments = MakeUrlSegments(id.ToString(), parentId.ToString());
            return Update(entity, segments);
        }

        public bool Delete(int id, int parentId)
        {
            var segments = MakeUrlSegments(id.ToString(), parentId.ToString());
            return Delete(segments);
        }

        public bool Delete(int parentId)
        {
            throw new System.NotImplementedException();
        }
    }
}
