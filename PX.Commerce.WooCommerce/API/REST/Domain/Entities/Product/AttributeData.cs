using Newtonsoft.Json;
using PX.Commerce.Core;
using PX.Commerce.WooCommerce.WC.Descriptor;
using System;
using System.Collections.Generic;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Product
{
    [JsonObject(Description = "Product->Attributes")]
    public class AttributeData : BCAPIEntity, IWooEntity
    {
        [JsonProperty("id")]
        public int? Id { get; }

        [JsonProperty("name")]
        [CommerceDescription(WCCaptions.Name, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string Name { get; set; }

        [JsonProperty("slug")]
        [CommerceDescription(WCCaptions.Slug, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string Slug { get; set; }

        [JsonProperty("type")]
        [CommerceDescription(WCCaptions.Type, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string Type { get; }

        [JsonProperty("order_by")]
        public string OrderBy { get; set; } = "name";

        [JsonProperty("has_archives")]
        public bool? HasArchives { get; }

        [JsonProperty("options")]
        [CommerceDescription(WCCaptions.Options, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public List<string> Options { get; set; }

        [JsonProperty("option")]
        public string Option { get; set; }

        [JsonProperty("visible")]
        public bool? Visible { get; set; } = true;

        [JsonProperty("variation")]
        [CommerceDescription(WCCaptions.Variation, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public bool? Variation { get; set; } = false;

        [JsonProperty("date_created")]
        public DateTime? DateCreatedUT { get; set; }
        public DateTime? DateModified { get; set; }
    }
}