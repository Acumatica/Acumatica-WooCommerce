using Newtonsoft.Json;
using PX.Commerce.Core;
using PX.Commerce.WooCommerce.WC.Descriptor;
using System;
using System.Collections.Generic;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order
{
    [JsonObject(Description = "Sales Order -> Line Item")]
    [CommerceDescription(WCCaptions.LineItemData)]
    public class OrderLineItemData : BCAPIEntity, IWooEntity
    {
        [JsonProperty("id")]
        [CommerceDescription(WCCaptions.ID, FieldFilterStatus.Skipped, FieldMappingStatus.ImportAndExport)]
        public int? Id { get; set; }

        [JsonProperty("name")]
        [CommerceDescription(WCCaptions.Name, FieldFilterStatus.Skipped, FieldMappingStatus.ImportAndExport)]
        public string Name { get; set; }

        [JsonProperty("product_id")]
        [CommerceDescription(WCCaptions.Productid, FieldFilterStatus.Skipped, FieldMappingStatus.ImportAndExport)]
        public int? ProductId { get; set; }

        [JsonProperty("variation_id")]
        [CommerceDescription(WCCaptions.VariationId, FieldFilterStatus.Skipped, FieldMappingStatus.ImportAndExport)]
        public int? VariationId { get; set; }

        [JsonProperty("quantity")]
        [CommerceDescription(WCCaptions.Quantity, FieldFilterStatus.Skipped, FieldMappingStatus.ImportAndExport)]
        public int? Quantity { get; set; }

        [JsonProperty("tax_class")]
        [CommerceDescription(WCCaptions.TaxClass, FieldFilterStatus.Skipped, FieldMappingStatus.ImportAndExport)]
        public string TaxClass { get; set; }

        [JsonProperty("subtotal")]
        [CommerceDescription(WCCaptions.Subtotal, FieldFilterStatus.Skipped, FieldMappingStatus.ImportAndExport)]
        public string SubTotal { get; set; }

        public decimal SubTotalDecimal
        {
            get
            {
                return decimal.TryParse(SubTotal, out decimal val) ? val : 0m;
            }
        }

        [JsonProperty("subtotal_tax")]
        [CommerceDescription(WCCaptions.SubtotalTax, FieldFilterStatus.Skipped, FieldMappingStatus.ImportAndExport)]
        public string SubtotalTax { get; set; }

        public decimal SubTotalTaxDecimal
        {
            get
            {
                return decimal.TryParse(SubtotalTax, out decimal val) ? val : 0m;
            }
        }

        [JsonProperty("total")]
        [CommerceDescription(WCCaptions.Total, FieldFilterStatus.Skipped, FieldMappingStatus.ImportAndExport)]
        public string Total { get; set; }

        public decimal TotalInDecimal
        {
            get
            {
                return decimal.TryParse(Total, out decimal val) ? val : 0m;
            }
        }

        [JsonProperty("total_tax")]
        [CommerceDescription(WCCaptions.TotalTax, FieldFilterStatus.Skipped, FieldMappingStatus.ImportAndExport)]
        public string TotalTax { get; set; }

        public decimal TotalTaxDecimal
        {
            get
            {
                return decimal.TryParse(TotalTax, out decimal val) ? val : 0m;
            }
        }

        [JsonProperty("taxes")]
        public List<TaxData> Taxes { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        public decimal PriceDecimal
        {
            get
            {
                return decimal.TryParse(Price, out decimal val) ? val : 0m;
            }
        }

        public decimal UnitPrice
        {
            get
            {
                return Quantity.HasValue ? SubTotalDecimal / Quantity.Value : 0m;
            }
        }

        public decimal DiscountedUnitPrice
        {
            get
            {
                return Quantity.HasValue ? TotalInDecimal / Quantity.Value : 0m;
            }
        }

        [JsonProperty("parent_name")]
        public object ParentName { get; set; }

        public DateTime? DateCreatedUT { get; set; }

        public decimal Discount
        {
            get
            {
                return SubTotalDecimal - TotalInDecimal;
            }
        }

        public DateTime? DateModified { get; set; }
    }
}
