using Newtonsoft.Json;
using PX.Commerce.Core;
using PX.Commerce.WooCommerce.WC.Descriptor;
using System.Collections.Generic;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order
{
    [JsonObject(Description = "Sales Order -> TaxLines")]
    [CommerceDescription(WCCaptions.TaxData)]
    public class TaxLineData
    {
        [JsonProperty("id")]
        [CommerceDescription(WCCaptions.ID, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public string Id { get; set; }

        [JsonProperty("rate_code")]
        [CommerceDescription(WCCaptions.RateCode, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public string RateCode { get; set; }

        [JsonProperty("rate_id")]
        [CommerceDescription(WCCaptions.RateId, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public int? RateId { get; set; }

        [JsonProperty("label")]
        [CommerceDescription(WCCaptions.Label, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public string Label { get; set; }

        [JsonProperty("compound")]
        [CommerceDescription(WCCaptions.Compound, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public bool? Compound { get; set; }

        [JsonProperty("tax_total")]
        [CommerceDescription(WCCaptions.TaxTotal, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public string TaxTotal { get; set; }

        public decimal? TaxTotalInDecimal
        {
            get
            {
                decimal val;
                return decimal.TryParse(TaxTotal, out val) ? val : 0;
            }
        }

        [JsonProperty("shipping_tax_total")]
        [CommerceDescription(WCCaptions.ShippingTaxTotal, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public string ShippingTaxTotal { get; set; }

        public decimal? ShippingTaxTotalInDecimal
        {
            get
            {
                decimal val;
                return decimal.TryParse(ShippingTaxTotal, out val) ? val : 0;
            }
        }

        [JsonProperty("rate_percent")]
        public decimal? RatePercent { get; set; }

        [JsonProperty("meta_data")]
        public List<object> MetaData { get; set; }
    }
}
