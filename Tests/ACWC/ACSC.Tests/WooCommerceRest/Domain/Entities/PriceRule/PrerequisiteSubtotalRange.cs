using Newtonsoft.Json;

namespace ACSC.Tests.ShopifyRest.Domain.Entities.PriceRule
{
    public class PrerequisiteSubtotalRange
    {
        [JsonProperty("greater_than_or_equal_to")]
        public decimal? GreaterThanOrEqualTo { get; set; }
    }
}
