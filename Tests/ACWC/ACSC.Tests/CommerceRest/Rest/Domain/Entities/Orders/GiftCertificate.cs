using BCApiClient.Rest.Domain.Enumerations;
using Newtonsoft.Json;

namespace BCApiClient.Rest.Domain.Entities.Orders
{
    public class GiftCertificate
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("original_balance")]
        public float OriginalBalance { get; set; }

        [JsonProperty("starting_balance")]
        public float StartingBalance { get; set; }

        [JsonProperty("remaining_balance")]
        public float RemainingBalance { get; set; }

        [JsonProperty("status")]
        public GiftCertificateStatus Status { get; set; }
    }
}
