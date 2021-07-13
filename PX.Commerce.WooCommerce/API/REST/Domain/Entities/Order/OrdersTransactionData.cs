using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PX.Commerce.Core;
using PX.Commerce.WooCommerce.API.REST.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using Meta = PX.Commerce.WooCommerce.API.REST.Domain.Entities.Common;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order
{
    public class OrdersTransactionData : BCAPIEntity, IWooEntity
    {
        [JsonProperty("date_created")]
        public DateTime DateCreatedUT { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        public string OrderId
        {
            get
            {
                return Id.ToString();
            }
        }

        public string Gateway
        {
            get
            {
                return PaymentMethod;
            }
        }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        public decimal Amount
        {
            get
            {
                decimal val;
                return decimal.TryParse(Total, out val) ? val : 0;
            }
        }

        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("transaction_id")]
        public string GatewayTransactionId { get; set; }

        public DateTime? DateModified { get; set; }

        [JsonProperty("meta_data")]
        public List<Meta.Metadata> Metadata { get; set; }

        public OrderPaymentEvent paymentEvent { get; set; }

        public string PaymentInstrumentToken { get {
                var token = Metadata.SingleOrDefault(s => s.Key == "_wc_authorize_net_cim_credit_card_payment_token");
                return token == null ? string.Empty : token.Value;
            } }

    }
}