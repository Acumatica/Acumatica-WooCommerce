using Newtonsoft.Json;
using PX.Commerce.Core;
using System;
using System.Collections.Generic;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Product
{
    public class AttributeData : BCAPIEntity, IWooEntity
    {
        [JsonProperty("id")]
        public int Id { get; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("type")]
        public string Type { get; }

        [JsonProperty("order_by")]
        public string OrderBy { get; set; } = "name";

        [JsonProperty("has_archives")]
        public bool HasArchives { get; }

        [JsonProperty("options")]
        public List<string> Options { get; set; }

        [JsonProperty("visible")]
        public bool Visible { get; set; } = true;

        [JsonProperty("variation")]
        public bool Variation { get; set; } = false;

        [JsonProperty("date_created")]
        public DateTime DateCreatedUT { get; set; }
        public DateTime? DateModified { get; set; }
    }
}