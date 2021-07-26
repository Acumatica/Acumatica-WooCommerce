using System.ComponentModel;
using ACSC.Tests.ShopifyRest.Commerce;
using ACSC.Tests.ShopifyRest.Domain.Entities.Enumerations;
using Newtonsoft.Json;

namespace ACSC.Tests.ShopifyRest.Domain.Entities.Order
{
    /// <summary>
    /// A list of discounts applied to the order. Each discount object includes the following properties:
    /// amount: The amount that's deducted from the order total. When you create an order, this value is the percentage or monetary amount to deduct. After the order is created, this property returns the calculated amount.
    /// code: When the associated discount application is of type code, this property returns the discount code that was entered at checkout. Otherwise this property returns the title of the discount that was applied.
    /// type: The type of discount. Default value: fixed_amount.
    /// </summary>
    [JsonObject(Description = "discount_codes")]
    [Description(ShopifyCaptions.Discount)]
    public class OrderDiscountCodes
    {
        /// <summary>
        /// The amount that's deducted from the order total. When you create an order, this value is the percentage or monetary amount to deduct. After the order is created, this property returns the calculated amount.
        /// </summary>
        [JsonProperty("id")]
        [Description(ShopifyCaptions.Id)]
        public long? Id { get; set; }

        [JsonProperty("code")]
        [Description(ShopifyCaptions.Code)]
        public string Code { get; set; }

        [JsonProperty("amount")]
        [Description(ShopifyCaptions.Amount)]
        public decimal? Amount { get; set; }

        [JsonProperty("discount_tax")]
        [Description(ShopifyCaptions.DiscountTax)]
        public string DiscountTax { get; set; }

        /// <summary>
        /// When the associated discount application is of type code, this property returns the discount code that was entered at checkout.
        /// Otherwise this property returns the title of the discount that was applied.
        /// </summary>


        /// <summary>
        /// The type of discount. Default value: fixed_amount.
        /// </summary>
        [JsonProperty("type")]
        [Description(ShopifyCaptions.Type)]
        public DiscountType Type { get; set; }
    }
}