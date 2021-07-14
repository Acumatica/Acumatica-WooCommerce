using System.Collections.Generic;
using BCApiClient.Rest.Domain.Entities.Common;
using Newtonsoft.Json;

namespace ACSC.Tests.BigCommerceRest.Rest.Domain.Entities.Products
{
    [JsonObject(Description = "Bulk Pricing Rule (total  BigCommerce API v3 response)")]
    public class ProductsBulkPricingRule : IEntityResponse<ProductsBulkPricingRulesData>
    {
        [JsonProperty("data")]
        public ProductsBulkPricingRulesData Data { get; set; }
        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }

    [JsonObject(Description = "Bulk Pricing Rule list (total  BigCommerce API v3 response)")]
    public class ProductsBulkPricingRuleList : IEntitiesResponse<ProductsBulkPricingRulesData>
    {
        private List<ProductsBulkPricingRulesData> _data;

        [JsonProperty("data")]
        public List<ProductsBulkPricingRulesData> Data
        {
            get => _data ??= new List<ProductsBulkPricingRulesData>();
            set => _data = value;
        }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}