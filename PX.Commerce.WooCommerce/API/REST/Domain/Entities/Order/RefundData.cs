using Newtonsoft.Json;
using PX.Commerce.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order
{

    public class RefundData : BCAPIEntity, IWooEntity
    {
        private decimal amountDecimal;

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("date_created")]
        public DateTime DateCreatedUT { get; set; }

        [JsonProperty("date_created_gmt")]
        public DateTime DateCreatedGmt { get; set; }

        [JsonProperty("amount")]
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
        public string Reason { get; set; }

        [JsonProperty("refunded_by")]
        public int RefundedBy { get; set; }

        [JsonProperty("refunded_payment")]
        public bool RefundedPayment { get; set; }

        [JsonProperty("meta_data")]
        public List<object> MetaData { get; set; }

        [JsonProperty("line_items")]
        public List<RefundLineItemData> LineItems { get; set; }

        [JsonProperty("shipping_lines")]
        public List<object> ShippingLines { get; set; }

        [JsonProperty("tax_lines")]
        public List<object> TaxLines { get; set; }

        [JsonProperty("fee_lines")]
        public List<object> FeeLines { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
