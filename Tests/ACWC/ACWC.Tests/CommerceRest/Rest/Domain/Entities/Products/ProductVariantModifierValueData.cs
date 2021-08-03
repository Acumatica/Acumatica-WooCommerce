﻿using Newtonsoft.Json;

namespace BigCommerce.Process.REST.Domain.Entities.Products
{
    [JsonObject(Description = "Product -> Product Variant -> Product Variant Modifier Value")]
    public class ProductVariantModifierValueData
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
