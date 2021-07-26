using Newtonsoft.Json;
using PX.Commerce.Core;
using PX.Commerce.WooCommerce.API.REST.Domain.Entities;
using PX.Commerce.WooCommerce.WC.Descriptor;
using System;

namespace PX.Commerce.WooCommerce
{
    [JsonObject(Description = "Product->Categories")]
    [CommerceDescription(WCCaptions.SalesCategory)]
    public class CategoryData : BCAPIEntity, IWooEntity
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        [CommerceDescription(WCCaptions.Name, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string Name { get; set; }

        [JsonProperty("slug")]
        [CommerceDescription(WCCaptions.Slug, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string Slug { get; set; }

        [JsonProperty("parent")]
        [CommerceDescription(WCCaptions.Parent, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public int? Parent { get; set; }

        [JsonProperty("description")]
        [CommerceDescription(WCCaptions.Description, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string Description { get; set; }

        [JsonProperty("display")]
        [CommerceDescription(WCCaptions.Display, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public string Display { get; set; }

        [JsonProperty("image")]
        [CommerceDescription(WCCaptions.Image, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public object Image { get; set; }

        [JsonProperty("menu_order")]
        [CommerceDescription(WCCaptions.MenuOrder, FieldFilterStatus.Skipped, FieldMappingStatus.Export)]
        public int? MenuOrder { get; set; }

        [JsonProperty("count")]
        public int? Count { get; set; }

        [JsonProperty("date_created")]
        public DateTime? DateCreatedUT { get; set; }

        public DateTime? DateModified { get; set; }
    }
}