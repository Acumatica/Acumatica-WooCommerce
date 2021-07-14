using System;
using System.Collections.Generic;
using ACSC.Tests.ShopifyRest.Client.Common;
using ACSC.Tests.ShopifyRest.Domain.Entities.Customers;
using ACSC.Tests.ShopifyRest.Interfaces;

namespace ACSC.Tests.ShopifyRest.Client.DataRepository.Customers
{
    public class CustomerAddressRestDataProvider : RestDataProviderBase, IChildRestDataProvider<CustomerAddressData>
    {
        protected override string GetListUrl { get; } = "customers/{parent_id}/addresses.json";
        protected override string GetSingleUrl { get; } = "customers/{parent_id}/addresses/{id}.json";
        protected override string GetCountUrl => throw new NotImplementedException();
        protected override string GetSearchUrl => throw new NotImplementedException();

        public CustomerAddressRestDataProvider(IWooCommerceRestClient restClient) : base()
        {
            ShopifyRestClient = restClient;
        }

        public CustomerAddressData Create(CustomerAddressData entity, string customerId)
        {
            var segments = MakeParentUrlSegments(customerId);
            return base.Create<CustomerAddressData, CustomerAddressResponse>(entity, segments);
        }

        public CustomerAddressData Update(CustomerAddressData entity, string customerId, string addressId)
        {
            var segments = MakeUrlSegments(addressId, customerId);
            return Update<CustomerAddressData, CustomerAddressResponse>(entity, segments);
        }

        public bool Delete(string customerId, string addressId)
        {
            var segments = MakeUrlSegments(addressId, customerId);
            return Delete(segments);
        }

        public int Count(string customerId)
        {
            throw new PlatformNotSupportedException();
        }

        public List<CustomerAddressData> GetCurrentList(string customerId, out string previousList, out string nextList, IFilter filter = null)
        {
            var segments = MakeParentUrlSegments(customerId);
            return GetCurrentList<CustomerAddressData, CustomerAddressesResponse>(out previousList, out nextList, filter, segments);
        }

        public List<CustomerAddressData> GetAll(string customerId, IFilter filter = null)
        {
            var segments = MakeParentUrlSegments(customerId);
            return GetAll<CustomerAddressData, CustomerAddressesResponse>(filter, segments);
        }

        public CustomerAddressData GetByID(string customerId, string addressId)
        {
            var segments = MakeUrlSegments(addressId, customerId);
            return GetByID<CustomerAddressData, CustomerAddressResponse>(segments);
        }

        public List<CustomerAddressData> GetAllWithoutParent(IFilter filter = null)
        {
            throw new NotImplementedException();
        }
    }
}