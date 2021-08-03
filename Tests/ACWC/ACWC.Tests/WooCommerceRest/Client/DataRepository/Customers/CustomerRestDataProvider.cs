using System;
using System.Collections.Generic;
using ACSC.Tests.ShopifyRest.Client.Common;
using ACSC.Tests.ShopifyRest.Domain.Entities.Common;
using ACSC.Tests.ShopifyRest.Domain.Entities.Customers;
using ACSC.Tests.ShopifyRest.Domain.Entities.Order;
using ACSC.Tests.ShopifyRest.Interfaces;
using Newtonsoft.Json;
using RestSharp.Extensions;

namespace ACSC.Tests.ShopifyRest.Client.DataRepository.Customers
{
    public class CustomerRestDataProvider : RestDataProviderBase, IParentRestDataProvider<CustomerData>
    {
        protected override string GetListUrl { get; } = "customers";
        protected override string GetSingleUrl { get; } = "customers/{id}";

        protected override string GetCountUrl => throw new NotImplementedException();

        protected override string GetSearchUrl => throw new NotImplementedException();

        //protected override string GetCountUrl { get; } = "customers/count.json";
        //protected override string GetSearchUrl { get; } = "customers/search.json";
        //private string GetAccountActivationUrl { get; } = "customers/{id}/account_activation_url.json";
        //private string GetSendInviteUrl { get; } = "customers/{id}/send_invite.json";
        //protected string GetCustomerOrders { get; } = "customers/{id}/orders.json";

        public CustomerRestDataProvider(IWooCommerceRestClient restClient) : base()
        {
            ShopifyRestClient = restClient;
        }

        public CustomerData Create(CustomerData entity)
        {
            return base.Create<CustomerData>(entity);
            //return base.Create(entity);
        }

        public CustomerData Update(CustomerData entity) => Update(entity, entity.Id.ToString());

        public CustomerData Update(CustomerData entity, string customerId)
        {
            var segments = MakeUrlSegments(customerId);
            return base.Update<CustomerData, CustomerResponse>(entity, segments);
        }

        public bool Delete(CustomerData entity, string customerId) => Delete(customerId);

        public bool Delete(string customerId)
        {
            var segments = MakeUrlSegments(customerId);
            return Delete(segments);
        }

        //public List<CustomerData> GetCurrentList(out string previousList, out string nextList, IFilter filter = null)
        //{
        //    return GetCurrentList<CustomerData, CustomersResponse>(out previousList, out nextList, filter);
        //}

        //public List<CustomerData> GetAll(IFilter filter = null)
        //{
        //    return GetAll<CustomerData, CustomersResponse>(filter);
        //}

        public CustomerData GetByID(string customerId)
        {
            var segments = MakeUrlSegments(customerId);
            return base.GetByID<CustomerData, CustomerResponse>(segments);
        }

        public ItemCount Count()
        {
            return base.GetCount();
        }

        public ItemCount Count(IFilter filter)
        {
            return base.GetCount(filter);
        }

        //public List<CustomerData> GetByQuery(string fieldName, string value)
        //{
        //    var url = GetSearchUrl;
        //    var property = typeof(CustomerData).GetProperty(fieldName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.IgnoreCase);
        //    if (property != null)
        //    {
        //        var attr = property.GetAttribute<JsonPropertyAttribute>();
        //        if (attr == null) throw new KeyNotFoundException();
        //        String key = attr.PropertyName;
        //        url += $"?query={attr.PropertyName}:{value}";
        //    }
        //    else
        //        throw new KeyNotFoundException();
        //    var request = BuildRequest(url, nameof(this.GetByQuery), null, null);
        //    return ShopifyRestClient.GetAll<CustomerData, CustomersResponse>(request);
        //}

        //public bool ActivateAccount(string customerId)
        //{
        //    var request = BuildRequest(GetAccountActivationUrl, nameof(this.ActivateAccount), MakeUrlSegments(customerId), null);
        //    return ShopifyRestClient.Post(request);
        //}

        //public List<OrderData> GetCustomerAll(string customerId)
        //{
        //    var request = BuildRequest(GetCustomerOrders, nameof(GetCustomerAll), MakeUrlSegments(customerId), null);
        //    return ShopifyRestClient.GetAll<OrderData, OrdersResponse>(request);
        //}
    }
}