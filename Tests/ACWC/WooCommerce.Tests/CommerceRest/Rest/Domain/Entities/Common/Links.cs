using Newtonsoft.Json;

namespace BCApiClient.Rest.Domain.Entities.Common
{
    public class Links
    {
        [JsonProperty("current")]
        public string Current { get; set; }
    }
}
