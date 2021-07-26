using BCApiClient.Rest.Domain.Entities.Common;
using Newtonsoft.Json;

namespace BCApiClient.Rest.Domain.Entities.Orders
{
    [JsonObject(Description = "Order -> Product")]
    public class OrderProductData : IBCEntityData
    {
        /// <summary>
        /// The ID of the product.
        /// </summary>
        ///
        [JsonProperty("product_id")]
        public virtual int? Id { get; set; }

        /// <summary>
        /// The SKU of the product.
        /// 
        /// [string(250)]
        /// </summary>
        [JsonProperty("sku")]
        public virtual string Sku { get; set; }

        /// <summary>
        /// The name of the product.
        /// 
        /// [string(250)]
        /// </summary>
        [JsonProperty("name")]
        public virtual string ProductName { get; set; }

        /// <summary>
        /// The price of the product excluding tax.
        /// 
        /// [decimal(20,4)]
        /// </summary>
        [JsonProperty("price_ex_tax")]
        public virtual decimal PriceExcludingTax { get; set; }

        /// <summary>
        /// The price of the product include tax.
        /// 
        /// [decimal(20,4)]
        /// </summary>
        [JsonProperty("price_inc_tax")]
        public virtual decimal PriceIncludingTax { get; set; }

        /// <summary>
        /// The quantity of the product that was purchased.
        /// </summary>
        [JsonProperty("quantity")]
        public virtual int Quantity { get; set; }
    }
}
