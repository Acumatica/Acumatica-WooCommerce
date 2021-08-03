using BCApiClient.Rest.Domain.Entities.Common;
using Newtonsoft.Json;

namespace BCApiClient.Rest.Domain.Entities.Products
{
    [JsonObject(Description = "Product-> ProductImage")]
    public class ProductsImageData : IBCEntityData
    {
        [JsonProperty("is_thumbnail")]
        public bool IsThumbnail { get; set; }

        [JsonProperty("sort_order")]
        public int SortOrder { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("image_file")]
        public string ImageFile { get; set; }

        [JsonProperty("url_zoom")]
        public string UrlZoom { get; set; }

        [JsonProperty("url_standard")]
        public string UrlStandard { get; set; }

        [JsonProperty("url_thumbnail")]
        public string UrlThumbnail { get; set; }

        [JsonProperty("url_tiny")]
        public string UrlTiny { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

    }
}