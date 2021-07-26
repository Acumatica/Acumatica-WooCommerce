using System.ComponentModel;
using ACSC.Tests.ShopifyRest.Commerce;
using Newtonsoft.Json;

namespace ACSC.Tests.ShopifyRest.Domain.Entities.Products
{
    [Description(ShopifyCaptions.PriceSet)]
    public class PriceSet
    {
        [JsonProperty("shop_money", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.ShopMoney)]
        public PresentmentPrice ShopMoney { get; set; }

        [JsonProperty("presentment_money", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.PresentmentMoney)]
        public PresentmentPrice PresentmentMoney { get; set; }
    }
}