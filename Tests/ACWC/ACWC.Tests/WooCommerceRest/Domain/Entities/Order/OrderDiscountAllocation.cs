using System.ComponentModel;
using ACSC.Tests.ShopifyRest.Commerce;
using ACSC.Tests.ShopifyRest.Domain.Entities.Products;
using Newtonsoft.Json;

namespace ACSC.Tests.ShopifyRest.Domain.Entities.Order
{
    [JsonObject(Description = "Order Discount Allocation")]
    [Description(ShopifyCaptions.DiscountAllocation)]
    public class OrderDiscountAllocation
    {
        /// <summary>
        /// The discount amount allocated to the line in the shop currency.
        /// </summary>
        /// 

        [JsonProperty("code")]
        [Description(ShopifyCaptions.Code)]
        public string Code { get; set; }

        //[JsonProperty("amount")]
        //[Description(ShopifyCaptions.Amount)]
        //public decimal? DiscountAmount { get; set; } 
    }
}