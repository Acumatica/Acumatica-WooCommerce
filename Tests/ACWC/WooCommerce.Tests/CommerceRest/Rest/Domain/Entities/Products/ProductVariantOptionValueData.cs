using BCApiClient.Rest;
using Newtonsoft.Json;

namespace BigCommerce.REST.Domain.Entities.Products
{
    [JsonObject(Description = Messages.ProductProductVariantProductVariantOptionValue)]
    public class ProductVariantOptionValueData
    {
    
        [JsonProperty("option_display_name")]
        public string OptionDisplayName { get; set; }

  
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("option_id")]
        public int? OptionId { get; set; }
    }
}
