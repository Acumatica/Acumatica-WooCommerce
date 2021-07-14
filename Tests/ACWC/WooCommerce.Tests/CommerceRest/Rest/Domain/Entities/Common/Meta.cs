using Newtonsoft.Json;

namespace BCApiClient.Rest.Domain.Entities.Common
{
    public class Meta
    {
        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }

}
