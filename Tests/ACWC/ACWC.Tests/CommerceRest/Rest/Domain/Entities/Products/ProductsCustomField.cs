using Newtonsoft.Json;

namespace BCApiClient.Rest.Domain.Entities.Products
{
    [JsonObject(Description = "Product -> ProductsCustomField")]
    public class ProductsCustomField
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
