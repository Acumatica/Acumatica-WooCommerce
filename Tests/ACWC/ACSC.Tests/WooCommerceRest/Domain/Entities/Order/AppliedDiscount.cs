using System.ComponentModel;
using ACSC.Tests.ShopifyRest.Commerce;
using Newtonsoft.Json;

namespace ACSC.Tests.ShopifyRest.Domain.Entities.Order
{
    [JsonObject(Description = "Order Discount Allocation")]
    [Description(ShopifyCaptions.AppliedDiscount)]
    public class AppliedDiscount
    {
        [JsonProperty("amount")]
        [Description(ShopifyCaptions.Amount)]
        public decimal? DiscountAmount { get; set; }

        [JsonProperty("value")]
        [Description(ShopifyCaptions.Value)]
        public decimal? DiscountValue { get; set; }

        [JsonProperty("value_type")]
        [Description(ShopifyCaptions.ValueType)]
        public string ValueType { get; set; }

        [JsonProperty("description")]
        [Description(ShopifyCaptions.DiscountDescription)]
        public string Description { get; set; }

        [JsonProperty("title")]
        [Description(ShopifyCaptions.Title)]
        public string Title { get; set; }
    }
}