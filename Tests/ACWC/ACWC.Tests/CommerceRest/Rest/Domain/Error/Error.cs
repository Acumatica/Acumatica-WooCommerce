using Newtonsoft.Json;

namespace BCApiClient.Rest.Domain.Error
{
    public class RestError
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("errors")]
        public Errors Errors { get; set; }
    }

    public class Errors
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}