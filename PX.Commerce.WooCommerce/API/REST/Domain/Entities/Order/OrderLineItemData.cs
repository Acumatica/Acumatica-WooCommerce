using Newtonsoft.Json;
using PX.Commerce.Core;
using System;
using System.Collections.Generic;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order
{
    public class OrderLineItemData : BCAPIEntity, IWooEntity
    {
        private decimal? subtotalDecimal;
        private decimal? totalDecimal;
        private decimal? totalTaxDecimal;
        private decimal? priceDecimal;
        private decimal? subTotaTaxlDecimal;

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
        public string SubTotal { get; set; }

        public decimal? SubTotalDecimal
        {
            get
            {
                decimal val;
                subtotalDecimal = decimal.TryParse(SubTotal, out val) ? val : 0;
                return subtotalDecimal;
            }
        }

        [JsonProperty("subtotal_tax")]
        public string SubtotalTax { get; set; }

        public decimal? SubTotalTaxDecimal
        {
            get
            {
                decimal val;
                subTotaTaxlDecimal = decimal.TryParse(SubtotalTax, out val) ? val : 0;
                return subTotaTaxlDecimal;
            }
        }

        [JsonProperty("total")]
        public string Total { get; set; }

        public decimal? TotalDecimal
        {
            get
            {
                decimal val;
                totalDecimal = decimal.TryParse(Total, out val) ? val : 0;
                return totalDecimal;
            }
        }

        [JsonProperty("total_tax")]
        public string TotalTax { get; set; }

        public decimal? TotalTaxDecimal
        {
            get
            {
                decimal val;
                totalTaxDecimal = decimal.TryParse(TotalTax, out val) ? val : 0;
                return totalTaxDecimal;
            }
        }

        [JsonProperty("taxes")]
        public List<TaxData> Taxes { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        public decimal? PriceDecimal
        {
            get
            {
                decimal val;
                priceDecimal = decimal.TryParse(Price, out val) ? val : 0;
                return priceDecimal;
            }
        }

        public decimal? UnitPrice
        {
            get
            {
                return SubTotalDecimal / Quantity;
            }
        }

        [JsonProperty("parent_name")]
        public object ParentName { get; set; }

        public DateTime? DateCreatedUT { get; set; }

        public decimal? Discount
        {
            get
            {
                return SubTotalDecimal - TotalDecimal;
            }
        }

        public DateTime? DateModified { get; set; }
    }
}
