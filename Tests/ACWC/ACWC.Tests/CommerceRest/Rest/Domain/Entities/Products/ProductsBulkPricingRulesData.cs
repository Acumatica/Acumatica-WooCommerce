using Newtonsoft.Json;

namespace ACSC.Tests.BigCommerceRest.Rest.Domain.Entities.Products
{
    [JsonObject(Description = "Product -> ProductsBulkPricingRules")]
    public class ProductsBulkPricingRulesData
    {
        /// <summary>
        /// The minimum inclusive quantity of a product to satisfy this rule.Must be greater than or equal to zero.
        /// (optional) integer 
        /// </summary>
        [JsonProperty("quantity_min")]
        public int? QuantityMin { get; set; }

        /// <summary>
        /// The maximum inclusive quantity of a product to satisfy this rule..
        /// Must be greater than the quantity_min value – unless this field has a value of 0 (zero), 
        /// in which case there will be no maximum bound for this rule.
        /// (optional) integer 
        /// </summary>
        [JsonProperty("quantity_max")]
        public int? QuantityMax { get; set; }

        /// <summary>
        /// The type of adjustment that is made. Values: 
        /// price – the adjustment amount per product; 
        /// percent – the adjustment as a percentage of the original price; 
        /// fixed – the adjusted absolute price of the product.
        /// (optional) string 
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The value of the adjustment by the bulk pricing rule.   double float (number)  (optional)  
        /// </summary>
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        /// <summary>
        /// The ID of the bulk pricing rule. (optional) integer 
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }
    }
}


