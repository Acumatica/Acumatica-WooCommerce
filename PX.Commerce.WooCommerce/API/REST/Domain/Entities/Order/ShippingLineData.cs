using Newtonsoft.Json;
using PX.Commerce.Core;
using PX.Commerce.WooCommerce.WC.Descriptor;
using System.Collections.Generic;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order
{
    public class ShippingLineData
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("method_title")]
        [CommerceDescription(WCCaptions.MethodTitle, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public string MethodTitle { get; set; }

        [JsonProperty("method_id")]
        [CommerceDescription(WCCaptions.MethodId, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public string MethodId { get; set; }

        [JsonProperty("instance_id")]
        public string InstanceId { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }

        public decimal? TotalInDecimal
        {
            get
            {
                decimal val;
                return decimal.TryParse(Total, out val) ? val : 0;
            }
        }

        [JsonProperty("total_tax")]
        public string TotalTax { get; set; }

        public decimal? TotalTaxinDecimal
        {
            get
            {
                decimal val;
                return decimal.TryParse(TotalTax, out val) ? val : 0;
            }
        }

        [JsonProperty("taxes")]
        [CommerceDescription(WCCaptions.Taxes, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public List<TaxData> Taxes { get; set; }
    }
}
