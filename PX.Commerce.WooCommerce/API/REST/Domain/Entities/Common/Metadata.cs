using Newtonsoft.Json;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Common
{
    public class Metadata
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public object ObjValue { get; set; }

        public string Value
        {
            get
            {
                return ObjValue.ToString();
            }
        }
    }
}