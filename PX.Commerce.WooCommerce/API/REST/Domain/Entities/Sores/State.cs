using Newtonsoft.Json;
using PX.Commerce.Core;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Sores
{
    public class State : BCAPIEntity
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
