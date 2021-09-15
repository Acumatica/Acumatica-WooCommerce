using Newtonsoft.Json;
using PX.Commerce.Core;
using PX.Commerce.WooCommerce.WC.Descriptor;
using System;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Product
{
    [JsonObject(Description = "Product->Images")]
    public class ProductImage
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("src")]
        [CommerceDescription(WCCaptions.Src, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string Src { get; set; }

        [JsonProperty("name")]
        [CommerceDescription(WCCaptions.Name, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string Name { get; set; }

        [JsonProperty("alt")]
        [CommerceDescription(WCCaptions.Alt, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string Alt { get; set; }

        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; set; }

        [JsonProperty("date_created_gmt")]
        public DateTime? DateCreatedGmt { get; set; }

        [JsonProperty("date_modified")]
        public DateTime? DateModified { get; set; }

        [JsonProperty("date_modified_gmt")]
        public DateTime? DateModifiedGmt { get; set; }
    }
}
