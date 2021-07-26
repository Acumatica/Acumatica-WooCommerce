using Newtonsoft.Json;

namespace BCApiClient.Rest.Domain.Entities.Orders
{
    public class OrderPayment
    {
        [JsonProperty("instrument")]
        public OrderPaymentInstrument Instrument { get; set; }

        [JsonProperty("payment_method_id")]
        public string PaymentMethodID { get; set; }

        [JsonProperty("save_instrument")]
        public bool? SaveInstrument { get; set; }
    }

    public class OrderPaymentInstrument
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("cardholder_name")]
        public string CardholderName { get; set; }

        [JsonProperty("expiry_month")]
        public int? ExpiryMonth { get; set; }

        [JsonProperty("expiry_year")]
        public int? ExpiryYear { get; set; }

        [JsonProperty("verification_value")]
        public string VerificationValue { get; set; }
    }

    public class OrderPaymentData
    {
        [JsonProperty("payment")]
        public OrderPayment Payment { get; set; }
    }


    public class ProcesssPaymentResult
    {
        [JsonProperty("data")]
        public ProcessPaymentData Data { get; set; }
    }

    public class ProcessPaymentData
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("transaction_type")]
        public string TransactionType { get; set; }
    }
}
