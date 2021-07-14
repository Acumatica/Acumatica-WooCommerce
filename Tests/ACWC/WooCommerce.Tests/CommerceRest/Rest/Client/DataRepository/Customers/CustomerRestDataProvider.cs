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
    public class CustomerRestDataProvider : RestDataProviderV2, IParentRestDataProvider<CustomerData>
    {
        private readonly CustomerAddressRestDataProvider _customerAddressRestClient;
        protected override string GetListUrl { get; } = "customers";
        protected override string GetSingleUrl { get; } = "customers/{id}";

        protected override string GetCountUrl => throw new System.NotImplementedException();

        // protected override string GetCountUrl { get; } = "customers/count";

        public CustomerRestDataProvider(IBigCommerceRestClient restClient, CustomerAddressRestDataProvider customerAddressRestClient)
        {
            _restClient = restClient;
            _customerAddressRestClient = customerAddressRestClient;
        }

        #region IParentDataRestClient

        public ItemCount Count()
        {
            return GetCount();
        }

        public ItemCount Count(IFilter filter)
        {
            return GetCount(filter);
        }

        public CustomerData Create(CustomerData customer)
        {
            var newCustomer = base.Create(customer);
            return newCustomer;
        }

        public CustomerData Update(CustomerData customer, int id)
        {
            var segments = MakeUrlSegments(id.ToString());
            var newCustomer = Update(customer, segments);
            return newCustomer;
        }
    
        public bool Delete(CustomerData order, int id)
        {
            return Delete(id);
        }
      
        public bool Delete(int id)
        {
            var segments = MakeUrlSegments(id.ToString());
            return Delete(segments);
        }

        public List<CustomerData> Get(IFilter filter = null)
        {
            var customers = Get<CustomerData>(filter);

            if (customers != null)
            {
                foreach (var customer in customers)
                {
                    var addresses = _customerAddressRestClient.Get(customer.Id);
                    customer.AddAddresses(addresses);

                }

            }
            return customers;
        }

        public List<CustomerData> GetAll(IFilter filter = null)
        {
            var allCustomers = base.GetAll<CustomerData>(filter);
            foreach (var customer in allCustomers)
            {
                var addresses = _customerAddressRestClient.Get(customer.Id);
                customer.AddAddresses(addresses);
            }
            return allCustomers;
        }

        public CustomerData GetByID(int customerId)
        {
            var segments = MakeUrlSegments(customerId.ToString());
            var customer = GetByID<CustomerData>(segments);
            if (customer != null)
            {
                var addresses = _customerAddressRestClient.Get(customer.Id);
                customer.AddAddresses(addresses);
            }
            return customer;
        }


        /// <summary>
        /// Get customer by customer e-mail address
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public CustomerData GetByName(string email)
        {
            FilterCustomers filter = new FilterCustomers { Email = email };
            CustomerData customer = Get(filter)?.FirstOrDefault();
            return customer;
        }

        #endregion

    }
}
