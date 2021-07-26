using Newtonsoft.Json;
using PX.Commerce.Core;
using System;
using System.Collections.Generic;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order
{
    public class RefundLineItemData: BCAPIEntity, IWooEntity
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("product_id")]
        public int? ProductId { get; set; }

        [JsonProperty("variation_id")]
        public int? VariationId { get; set; }

        [JsonProperty("quantity")]
        public int? Quantity { get; set; }

        [JsonProperty("tax_class")]
        public string TaxClass { get; set; }

        [JsonProperty("subtotal")]
        public string Subtotal { get; set; }

        [JsonProperty("subtotal_tax")]
        public string SubtotalTax { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("total_tax")]
        public string TotalTax { get; set; }

        [JsonProperty("taxes")]
        public List<object> Taxes { get; set; }

        [JsonProperty("meta_data")]
        public List<object> MetaData { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("price")]
        public int? Price { get; set; }

        [JsonProperty("parent_name")]
        public object ParentName { get; set; }
        public DateTime? DateCreatedUT { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
