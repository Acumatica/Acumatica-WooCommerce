using System.Collections.Generic;
using System.Linq;
using ACSC.Tests.BigCommerceRest.Rest.Domain.Entities.Customers;
using BCApiClient.Rest.Client.Common;
using BCApiClient.Rest.Domain.Entities.Common;
using BCApiClient.Rest.Domain.Entities.Customers;
using BCApiClient.Rest.Filters;
using BCApiClient.Rest.Interfaces;

namespace BCApiClient.Rest.Client.DataRepository.Customers
{
    public class CustomerFormFieldValuesDataProvider : RestDataProviderV3, IParentRestDataProvider<CustomerFormFieldValuesData>
    {
        protected override string GetListUrl { get; } = "v3/customers/form-field-values";
        protected override string GetSingleUrl { get; } = "v3/customers/form-field-values";
        protected override string GetCountUrl { get; }

        public CustomerFormFieldValuesDataProvider(IBigCommerceRestClient restClient)
        {
            _restClient = restClient;
        }

        public CustomerFormFieldValuesData Create(CustomerFormFieldValuesData entity)
        {
            throw new System.NotImplementedException();
        }

        public CustomerFormFieldValueList Update(List<CustomerFormFieldValuesData> entity)
        {
            var segments = new UrlSegments();
            var newCustomer = Update<List<CustomerFormFieldValuesData>, CustomerFormFieldValueList>(entity, segments);
            return newCustomer;
        }

        public CustomerFormFieldValuesData Update(CustomerFormFieldValuesData entity, int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<CustomerFormFieldValuesData> Get(IFilter filter = null)
        {
            throw new System.NotImplementedException();
        }

        public List<CustomerFormFieldValuesData> GetAll(IFilter filter = null)
        {
            throw new System.NotImplementedException();
        }

        public CustomerFormFieldValuesData GetByID(int id)
        {
            throw new System.NotImplementedException();
        }

        public CustomerFormFieldValuesData GetByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public ItemCount Count()
        {
            throw new System.NotImplementedException();
        }

        public ItemCount Count(IFilter filter)
        {
            throw new System.NotImplementedException();
        }
    }
}
