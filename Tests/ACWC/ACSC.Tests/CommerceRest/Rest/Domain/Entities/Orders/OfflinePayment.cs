using Newtonsoft.Json;

namespace BCApiClient.Rest.Domain.Entities.Orders
{
    public class OfflinePayment
    {
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
    }
}
