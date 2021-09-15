using Newtonsoft.Json;
using PX.Commerce.Core;
using PX.Commerce.WooCommerce.WC.Descriptor;
using System;
using System.Collections.Generic;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order
{
    [JsonObject(Description = "Sales Order -> Refunds")]
    [CommerceDescription(WCCaptions.RefundData)]
    public class RefundLineItemData: BCAPIEntity, IWooEntity
    {
        [JsonProperty("id")]
        [CommerceDescription(WCCaptions.ID, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
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

        public decimal SubTotalInDecimal { get { return decimal.TryParse(Subtotal, out decimal value) ? value : 0m; } }

        [JsonProperty("subtotal_tax")]
        public string SubtotalTax { get; set; }

        public decimal SubTotalTaxInDecimal { get { return decimal.TryParse(SubtotalTax, out decimal value) ? value : 0m; } }

        [JsonProperty("total")]
        public string Total { get; set; }

        public decimal TotalInDecimal { get { return decimal.TryParse(Total, out decimal value) ? value : 0m; } }

        [JsonProperty("total_tax")]
        public string TotalTax { get; set; }

        public decimal TotalTaxInDecimal { get { return decimal.TryParse(TotalTax, out decimal value) ? value : 0m; } }

        [JsonProperty("taxes")]
        public List<TaxData> Taxes { get; set; }

        [JsonProperty("meta_data")]
        public List<object> MetaData { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("price")]
        public decimal? Price { get; set; }

        [JsonProperty("parent_name")]
        public object ParentName { get; set; }
        public DateTime? DateCreatedUT { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
