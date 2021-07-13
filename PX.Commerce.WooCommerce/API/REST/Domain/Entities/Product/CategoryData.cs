using Newtonsoft.Json;
using PX.Commerce.Core;
using PX.Commerce.WooCommerce.API.REST.Domain.Entities;
using System;

namespace PX.Commerce.WooCommerce
{
    public class CategoryData : BCAPIEntity, IWooEntity
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("parent")]
        public int? Parent { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }

        [JsonProperty("image")]
        public object Image { get; set; }

        [JsonProperty("menu_order")]
        public int MenuOrder { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("date_created")]
        public DateTime DateCreatedUT { get; set; }

        public DateTime? DateModified { get; set; }
    }
}