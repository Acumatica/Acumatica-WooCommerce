using System.Collections.Generic;
using BCApiClient.Rest.Domain.Entities.Common;
using Newtonsoft.Json;

namespace ACSC.Tests.BigCommerceRest.Rest.Domain.Entities.Customers
{
    [JsonObject(Description = "Form Field Values (total  BigCommerce API v3 response)")]
    public class CustomerFormFieldValue : IEntityResponse<CustomerFormFieldValuesData>
    {
        [JsonProperty("data")]
        public CustomerFormFieldValuesData Data { get; set; }
        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }

    [JsonObject(Description = "Form Field Value list (total  BigCommerce API v3 response)")]
    public class CustomerFormFieldValueList : IEntitiesResponse<CustomerFormFieldValuesData>
    {
        private List<CustomerFormFieldValuesData> _data;

        [JsonProperty("data")]
        public List<CustomerFormFieldValuesData> Data
        {
            get => _data ??= new List<CustomerFormFieldValuesData>();
            set => _data = value;
        }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}