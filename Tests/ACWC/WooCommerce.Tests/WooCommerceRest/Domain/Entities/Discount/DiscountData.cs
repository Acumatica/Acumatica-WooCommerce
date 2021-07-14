using ACSC.Tests.ShopifyRest.Domain.Entities.Common;
using Newtonsoft.Json;

namespace ACSC.Tests.ShopifyRest.Domain.Entities.Discount
{
    public class DiscountResponse : IEntityResponse<DiscountData>
    {
        [JsonProperty("discount_code")]
        public DiscountData Data { get; set; }
    }

    [JsonObject(Description = "discount_code")]
    public class DiscountData
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }
}