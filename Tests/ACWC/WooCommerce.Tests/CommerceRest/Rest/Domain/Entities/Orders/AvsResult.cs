using Newtonsoft.Json;

namespace BCApiClient.Rest.Domain.Entities.Orders
{
    public class AvsResult
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("postal_match")]
        public string PostalMatch { get; set; }

        [JsonProperty("street_match")]
        public string StreetMatch { get; set; }

    }
}
