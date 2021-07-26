using Newtonsoft.Json;

namespace ACSC.Tests.BigCommerceRest.Rest.Domain.Entities.Customers
{
    [JsonObject(Description = "Customer -> FormFieldValues")]
    public class CustomerFormFieldValuesData
    {
        [JsonProperty("customer_id")]
        public int? CustomerId { get; set; }

        [JsonProperty("name")]
        public string FieldName { get; set; }

        [JsonProperty("value")]
        public object Value { get; set; }
    }
}