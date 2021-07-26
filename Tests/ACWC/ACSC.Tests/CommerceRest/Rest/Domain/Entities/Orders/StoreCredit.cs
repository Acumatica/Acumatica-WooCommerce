using Newtonsoft.Json;

namespace BCApiClient.Rest.Domain.Entities.Orders
{
    public class StoreCredit
    {
        [JsonProperty("remaining_balance")]
        public string RemainingBalance { get; set; }
    }
}
