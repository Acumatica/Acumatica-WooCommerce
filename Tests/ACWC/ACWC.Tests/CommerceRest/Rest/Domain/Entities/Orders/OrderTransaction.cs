using System;
using System.Collections.Generic;
using BCApiClient.Rest.Domain.Entities.Common;
using BCApiClient.Rest.Domain.Enumerations;
using Newtonsoft.Json;

namespace BCApiClient.Rest.Domain.Entities.Orders
{
    [JsonObject(Description = "Order Transaction Option (BigCommerce API v3 response)")]
    public class OrderTransactionData : IEntitiesResponse<OrderTransaction>
    {
        [JsonProperty("data")]
        public List<OrderTransaction> Data { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }

    public class OrderTransaction : IBCEntityData
    {
        [JsonProperty("amount")]
        public float Amount { get; set; }

        [JsonProperty("avs_result")]
        public AvsResult AvsResult { get; set; }

        [JsonProperty("credit_card")]
        public CreditCard CreditCard { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("custom")]
        public CustomPayment CustomPayment { get; set; }

        [JsonProperty("cvv_result")]
        public CvvResult CvvResult { get; set; }

        [JsonProperty("date_created")]
        public DateTime CreatedDate { get; set; }

        [JsonProperty("event")]
        public OrderPaymentEvent Event { get; set; }

        [JsonProperty("fraud_review")]
        public bool FraudReview { get; set; }

        [JsonProperty("gateway")]
        public string Gateway { get; set; }

        [JsonProperty("gateway_transaction_id")]
        public string GatewayTransactionId { get; set; }

        [JsonProperty("gift_certificate")]
        public GiftCertificate GiftCertificate { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("method")]
        public string PaymentMethod { get; set; }

        [JsonProperty("offline")]
        public OfflinePayment OfflinePayment { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("payment_instrument_token")]
        public string PaymentInstrumentToken { get; set; }

        [JsonProperty("reference_transaction_id")]
        public int ReferenceTransactionId { get; set; }

        [JsonProperty("status")]
        public OrderPaymentStatus Status { get; set; }

        [JsonProperty("store_credit")]
        public StoreCredit StoreCredit { get; set; }

        [JsonProperty("test")]
        public bool Test { get; set; }
    }
}
