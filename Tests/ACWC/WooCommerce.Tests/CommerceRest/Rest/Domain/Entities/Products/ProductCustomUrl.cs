using Newtonsoft.Json;

namespace BCApiClient.Rest.Domain.Entities.Products
{
    [JsonObject(Description = "Product->ProductsCustomUrl")]
    public class ProductCustomUrl
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("is_customized")]
        public bool IsCustomized { get; set; }
    }

}
