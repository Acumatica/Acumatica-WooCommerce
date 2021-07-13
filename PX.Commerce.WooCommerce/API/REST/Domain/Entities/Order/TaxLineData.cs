using Newtonsoft.Json;
using System.Collections.Generic;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order
{
    public class TaxLineData
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("rate_code")]
        public string RateCode { get; set; }

        [JsonProperty("rate_id")]
        public int RateId { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("compound")]
        public bool Compound { get; set; }

        [JsonProperty("tax_total")]
        public string TaxTotal { get; set; }

        public decimal TaxTotalInDecimal
        {
            get
            {
                decimal val;
                return decimal.TryParse(TaxTotal, out val) ? val : 0;
            }
        }

        [JsonProperty("shipping_tax_total")]
        public string ShippingTaxTotal { get; set; }

        public decimal ShippingTaxTotalInDecimal
        {
            get
            {
                decimal val;
                return decimal.TryParse(ShippingTaxTotal, out val) ? val : 0;
            }
        }

        [JsonProperty("rate_percent")]
        public decimal RatePercent { get; set; }

        [JsonProperty("meta_data")]
        public List<object> MetaData { get; set; }
    }
}
