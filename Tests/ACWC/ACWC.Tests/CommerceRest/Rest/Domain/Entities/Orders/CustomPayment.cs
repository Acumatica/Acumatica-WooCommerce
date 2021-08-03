using Newtonsoft.Json;

namespace BCApiClient.Rest.Domain.Entities.Orders
{
    public class CustomPayment
    {
        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }
    }
}
