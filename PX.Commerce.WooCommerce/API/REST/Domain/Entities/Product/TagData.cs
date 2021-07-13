using Newtonsoft.Json;
using PX.Commerce.Core;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Product
{
    public class TagData : BCAPIEntity
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
