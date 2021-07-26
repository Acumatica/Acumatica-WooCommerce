using Newtonsoft.Json;

namespace BCApiClient.Rest.Domain.Entities.Orders
{
    public class CreditCard
    {
        [JsonProperty("card_expiry_month")]
        public int CardExpiryMonth { get; set; }

        [JsonProperty("card_expiry_year")]
        public int CardExpiryYear { get; set; }

        [JsonProperty("card_iin")]
        public string CardIin { get; set; }

        [JsonProperty("card_last4")]
        public string CardLast4 { get; set; }

        [JsonProperty("card_type")]
        public string CardType { get; set; }
    }
}
