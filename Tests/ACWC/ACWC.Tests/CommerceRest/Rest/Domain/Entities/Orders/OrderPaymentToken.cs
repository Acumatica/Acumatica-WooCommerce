using Newtonsoft.Json;

namespace BCApiClient.Rest.Domain.Entities.Orders
{
    public class OrderPaymentToken
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class OrderPaymentTokenData
    {
        [JsonProperty("data")]
        public OrderPaymentToken Data { get; set; }

        [JsonProperty("meta")]
        public object Meta { get; set; }
    }

    public class PaymentTokenOrderData
    {
        [JsonProperty("order")]
        public PaymentTokenOrder Order { get; set; }
    }

    public class PaymentTokenOrder
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
