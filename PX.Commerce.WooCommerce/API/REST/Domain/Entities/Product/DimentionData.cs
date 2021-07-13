using Newtonsoft.Json;
using PX.Commerce.Core;
using PX.Commerce.WooCommerce.WC.Descriptor;
using System.ComponentModel;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Product
{
    public class DimentionData : BCAPIEntity
    {
        [JsonProperty("length")]
        [Description(WCCaptions.Length)]
        public string Length { get; set; }

        [JsonProperty("width")]
        [Description(WCCaptions.Width)]
        public string Width { get; set; }

        [JsonProperty("height")]
        [Description(WCCaptions.Height)]
        public string Height { get; set; }
    }
}
