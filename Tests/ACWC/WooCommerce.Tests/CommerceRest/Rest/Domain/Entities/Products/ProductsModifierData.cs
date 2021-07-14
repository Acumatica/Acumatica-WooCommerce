
using Newtonsoft.Json;
using System.Collections.Generic;
using BigCommerce.Process.REST.Domain.Options;

namespace BigCommerce.Process.REST.Domain.Entities.Products
{
    [JsonObject(Description = "Product -> Product Modifier")]
    public class ProductsModifierData
    {
        public ProductsModifierData()
        {
            OptionValues = new List<ProductModifierValueData>();
            NewOptionValues = new List<ProductModifierValueData>();
        }

        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("product_id")]
        public int ProductId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
      
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("sort_order")]
        public int SortOrder { get; set; }

        [JsonProperty("config")]
        public object Config { get; set; }

        [JsonProperty("option_values")]
        public List<ProductModifierValueData> OptionValues { get; set; }

        [JsonIgnore]
        public List<ProductModifierValueData> NewOptionValues { get; set; }
    }
}
