using System.Collections.Generic;
using BCApiClient.Rest.Client.Common;
using BCApiClient.Rest.Domain.Entities.Customers;
using BCApiClient.Rest.Interfaces;

namespace BCApiClient.Rest.Client.DataRepository.Customers
{
    public class CustomerAddressRestDataProvider : RestDataProviderV2,  IChildRestDataProvider<CustomerAddressData>
    {
        protected override string GetListUrl   { get; } = "v2/customers/{parent_id}/addresses";
        protected override string GetSingleUrl { get; } = "v2/customers/{parent_id}/addresses/{id}";
        protected override string GetCountUrl  { get; } = "v2/customers/{parent_id}/addresses/count";

        public CustomerAddressRestDataProvider(IBigCommerceRestClient restClient)
        {
            _restClient = restClient;
        }

        public CustomerAddressData Create(CustomerAddressData entity, int parentId)
        {
            var segments = MakeParentUrlSegments(parentId.ToString());
            return base.Create(entity, segments);
        }

        public CustomerAddressData Update(CustomerAddressData entity, int id, int parentId)
        {
            var segments = MakeUrlSegments(id.ToString(), parentId.ToString());
            return Update(entity, segments);
        }

        public bool Delete(int id, int parentId)
        {
            var segments = MakeUrlSegments(id.ToString(), parentId.ToString());
            return Delete(segments);
        }

        public int Count(int parentId)
        {
            var segments = MakeUrlSegments(parentId.ToString());
            return GetCount(segments).Count;
        }

        public List<CustomerAddressData> GetAll(int parentId)
        {
            var segments = MakeParentUrlSegments(parentId.ToString());
            return Get<CustomerAddressData>(null, segments);
        }

        public List<CustomerAddressData> Get(int parentId)
        {
            var segments = MakeParentUrlSegments(parentId.ToString());
            return Get<CustomerAddressData>(null, segments);
        }

        public CustomerAddressData GetByID(int id, int parentId)
        {
            var segments = MakeUrlSegments(id.ToString(), parentId.ToString());
            return GetByID<CustomerAddressData>(segments);
        }

        public bool Delete(int parentId)
        {
            var segments = MakeParentUrlSegments(parentId.ToString());
            return Delete(segments);
        }

        public int Count(string parentId)
        {
            throw new System.NotImplementedException();
        }
    }
}
