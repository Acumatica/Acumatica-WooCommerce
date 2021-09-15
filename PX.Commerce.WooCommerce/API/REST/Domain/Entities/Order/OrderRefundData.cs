using Newtonsoft.Json;
using PX.Commerce.Core;
using PX.Commerce.WooCommerce.WC.Descriptor;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order
{
    [JsonObject(Description = "Sales Order -> Refunds")]
    [CommerceDescription(WCCaptions.RefundData)]
    public class OrderRefundData
    {
        private decimal? totalDecimal;

        [JsonProperty("id")]
        [CommerceDescription(WCCaptions.ID, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public int? Id { get; set; }

        [JsonProperty("reason")]
        [CommerceDescription(WCCaptions.Reason, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public string Reason { get; set; }

        [JsonProperty("total")]
        [CommerceDescription(WCCaptions.Total, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
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
    }
}
