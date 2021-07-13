using Newtonsoft.Json;
using PX.Commerce.Core;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Sores
{
    public class TaxClass : BCAPIEntity
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
