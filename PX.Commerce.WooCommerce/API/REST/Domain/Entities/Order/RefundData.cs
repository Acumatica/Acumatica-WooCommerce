using Newtonsoft.Json;
using PX.Commerce.Core;
using PX.Commerce.WooCommerce.WC.Descriptor;
using System;
using System.Collections.Generic;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order
{

    [JsonObject(Description = "Refund")]
    [CommerceDescription(WCCaptions.RefundData)]
    public class RefundData : BCAPIEntity, IWooEntity
    {
        private decimal amountDecimal;

        [JsonProperty("id")]
        [CommerceDescription(WCCaptions.ID, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public int? Id { get; set; }

        [JsonProperty("date_created")]
        public DateTime? DateCreatedUT { get; set; }

        [JsonProperty("date_created_gmt")]
        public DateTime? DateCreatedGmt { get; set; }

        [JsonProperty("amount")]
        [CommerceDescription(WCCaptions.Amount, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public string Amount { get; set; }

        public decimal AmountDecimal
        {
            get
            {
                decimal val;
                amountDecimal = decimal.TryParse(Amount, out val) ? val : 0;
                return amountDecimal;
            }
        }

        [JsonProperty("reason")]
        [CommerceDescription(WCCaptions.Reason, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public string Reason { get; set; }

        [JsonProperty("refunded_by")]
        public int? RefundedBy { get; set; }

        [JsonProperty("refunded_payment")]
        public bool? RefundedPayment { get; set; }

        [JsonProperty("meta_data")]
        public List<object> MetaData { get; set; }

        [JsonProperty("line_items")]
        public List<RefundLineItemData> LineItems { get; set; }

        [JsonProperty("shipping_lines")]
        public List<ShippingLineData> ShippingLines { get; set; }

        [JsonProperty("tax_lines")]
        public List<object> TaxLines { get; set; }

        [JsonProperty("fee_lines")]
        public List<object> FeeLines { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
