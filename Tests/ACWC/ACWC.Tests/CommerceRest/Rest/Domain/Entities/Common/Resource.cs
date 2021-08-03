using Newtonsoft.Json;

namespace BCApiClient.Rest.Domain.Entities.Common
{
    public class Resource
    {
        [JsonProperty("url")]
        public virtual string Url { get; set; }

        [JsonProperty("resource")]
        public virtual string ResourceEndPoint { get; set; }
        
    }
}
