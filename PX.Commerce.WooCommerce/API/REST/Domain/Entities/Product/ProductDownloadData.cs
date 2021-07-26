using Newtonsoft.Json;
using PX.Commerce.Core;
using PX.Commerce.WooCommerce.WC.Descriptor;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Product
{
    [JsonObject(Description = "Product->Downloads")]
    public class ProductDownloadData
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [CommerceDescription(WCCaptions.Name, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        [JsonProperty("name")]
        public string Name { get; set; }

        [CommerceDescription(WCCaptions.File, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        [JsonProperty("file")]
        public string File { get; set; }
    }
}
