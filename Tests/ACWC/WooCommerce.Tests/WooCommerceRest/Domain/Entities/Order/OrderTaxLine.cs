using System;
using System.ComponentModel;
using ACSC.Tests.ShopifyRest.Commerce;
using ACSC.Tests.ShopifyRest.Domain.Entities.Products;
using Newtonsoft.Json;

namespace ACSC.Tests.ShopifyRest.Domain.Entities.Order
{
//    [JsonObject(Description = "Order Tax Line")]
//    [Description(ShopifyCaptions.TaxLine)]
    public class OrderTaxLine
    {
        /// <summary>
        /// The name of the tax.
        /// </summary>
        /// 
        [JsonProperty("rate_code")]
        [Description(ShopifyCaptions.TaxLine)]
        public String TaxName { get; set; }

        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.ProductId)]
        public String ProductId { get; set; }

        //[JsonProperty("title")]
        //[Description(ShopifyCaptions.TaxName)]
        //public String TaxName { get; set; }

        ///// <summary>
        ///// The amount added to the order for this tax in the shop currency.
        ///// </summary>
        //[JsonProperty("price")]
        //[Description(ShopifyCaptions.TaxLineAmount)]
        //public decimal? TaxAmount { get; set; }

        ///// <summary>
        ///// The tax rate applied to the order to calculate the tax price.
        ///// </summary>
        //[JsonProperty("rate")]
        //[Description(ShopifyCaptions.TaxRate)]
        //public decimal? TaxRate { get; set; }

        ///// <summary>
        ///// The amount added to the order for this tax in shop and presentment currencies.
        ///// </summary>
        //[JsonProperty("price_set")]
        //[Description(ShopifyCaptions.PriceSet)]
        //public PriceSet TaxPriceSet { get; set; }
    }
}