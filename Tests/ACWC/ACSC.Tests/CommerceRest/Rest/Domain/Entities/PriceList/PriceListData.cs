using ACSC.Tests.BigCommerceRest.Rest.Domain.Entities.Products;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ACSC.Tests.BigCommerceRest.Rest.Domain.Entities.PriceList
{
    [JsonObject(Description = "Price List")]
    public class PriceListData
    {
        public PriceListData()
        {
            BulkPricing = new List<ProductsBulkPricingRulesData>();
        }

        /// <summary>
        /// The ID of the Variant whose prices were requested.
        /// </summary>
        [JsonProperty("variant_id")]
        public int? VariantId { get; set; }

        /// <summary>
        /// A comma-separated list of ids of Products whose prices were requested. 
        /// </summary>
        [JsonProperty("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// Filter items by currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// Filter items by map_price.
        /// </summary>
        [JsonProperty("map_price")]
        public decimal? MapPrice { get; set; }

        /// Filter items by price.
        /// </summary>
        [JsonProperty("price")]
        public decimal? Price { get; set; }

        /// The ID of the Price List requested.
        /// </summary>
        [JsonProperty("price_list_id")]
        public int? PriceListId { get; set; }

        /// Filter items by retail_price.
        /// </summary>
        [JsonProperty("retail_price")]
        public decimal? RetailPrice { get; set; }

        /// Filter items by sale_price.
        /// </summary>
        [JsonProperty("sale_price")]
        public decimal? SalePrice { get; set; }

        /// Filter items by calculated_price.
        /// </summary>
        [JsonProperty("calculated_price")]
        public decimal? CalculatedPrice { get; set; }

        [JsonProperty("bulk_pricing_tiers")]
        public List<ProductsBulkPricingRulesData> BulkPricing { get; set; }
    }
}


