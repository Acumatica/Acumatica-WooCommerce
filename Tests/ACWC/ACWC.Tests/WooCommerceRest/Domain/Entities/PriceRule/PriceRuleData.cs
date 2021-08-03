using ACSC.Tests.ShopifyRest.Commerce;
using ACSC.Tests.ShopifyRest.Domain.Entities.Common;
using ACSC.Tests.ShopifyRest.Domain.Entities.Enumerations;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ACSC.Tests.ShopifyRest.Domain.Entities.PriceRule
{
    public class PriceRuleResponse : IEntityResponse<PriceRuleData>
    {
        [JsonProperty("price_rule")]
        public PriceRuleData Data { get; set; }
    }
    
    [JsonObject(Description = "price_rule")]
    public class PriceRuleData
    {
        public PriceRuleData()
        {
            EntitledProductIds = new List<long?>();
        }

        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("value_type")]
        public PriceRuleValueType ValueType { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("customer_selection")]
        public string CustomerSelection { get; set; }

        [JsonProperty("target_type")]
        public string TargetType { get; set; }

        [JsonProperty("target_selection")]
        public string TargetSelection { get; set; }

        [JsonProperty("allocation_method")]
        public string AllocationMethod { get; set; }

        [JsonProperty("allocation_limit")]
        public string AllocationLimit { get; set; }

        [JsonProperty("once_per_customer")]
        public bool? OncePerCustomer { get; set; }

        [JsonProperty("usage_limit")]
        public string UsageLimit { get; set; }

        [JsonProperty("starts_at")]
        [ShouldNotSerialize]
        public string StartsAt { get; set; }

        [JsonProperty("ends_at")]
        [ShouldNotSerialize]
        public DateTime? EndsAt { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("entitled_product_ids")]
        public List<long?> EntitledProductIds { get; set; }

        [JsonProperty("prerequisite_subtotal_range")]
        public PrerequisiteSubtotalRange SubtotalRange { get; set; }

        [JsonProperty("title")]
        public String Title { get; set; }
    }
}