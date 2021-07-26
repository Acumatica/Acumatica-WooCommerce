using Newtonsoft.Json;
using PX.Commerce.Core;
using PX.Commerce.WooCommerce.WC.Descriptor;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Product
{
    [JsonObject(Description = "Product->Tags")]
    public class TagData : BCAPIEntity
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        [CommerceDescription(WCCaptions.Name, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string Name { get; set; }

        [JsonProperty("slug")]
        [CommerceDescription(WCCaptions.Slug, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string Slug { get; set; }

        [JsonProperty("description")]
        [CommerceDescription(WCCaptions.Description, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string Description { get; set; }

        [JsonProperty("count")]
        public int? Count { get; set; }
    }
}
