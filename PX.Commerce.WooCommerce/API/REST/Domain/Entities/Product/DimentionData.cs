using Newtonsoft.Json;
using PX.Commerce.Core;
using PX.Commerce.WooCommerce.WC.Descriptor;
using System.ComponentModel;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Product
{
    [JsonObject(Description = "Product->Dimensions")]
    public class DimentionData : BCAPIEntity
    {
        [JsonProperty("length")]
        [CommerceDescription(WCCaptions.Length, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string Length { get; set; }

        [JsonProperty("width")]
        [CommerceDescription(WCCaptions.Width, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string Width { get; set; }

        [JsonProperty("height")]
        [CommerceDescription(WCCaptions.Height, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string Height { get; set; }
    }
}
