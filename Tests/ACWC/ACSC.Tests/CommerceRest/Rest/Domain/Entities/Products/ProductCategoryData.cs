using BCApiClient.Rest.Domain.Entities.Common;
using Newtonsoft.Json;

namespace BCApiClient.Rest.Domain.Entities.Products
{
    [JsonObject(Description = Messages.ProductCategory)]
    public class ProductCategoryData : IBCEntityData
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("parent_id")]
        public int? ParentId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("views")]
        public int? Views { get; set; }

        [JsonProperty("sort_order")]
        public int? SortOrder { get; set; }

        [JsonProperty("page_title")]
        public string PageTitle { get; set; }

        [JsonProperty("meta_keywords")]
        public string[] MetaKeywords { get; set; }

        [JsonProperty("meta_description")]
        public string MetaDescription { get; set; }

        [JsonProperty("layout_file")]
        public string LayoutFile { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("is_visible")]
        public bool? IsVisible { get; set; }

        [JsonProperty("search_keywords")]
        public string SearchKeywords { get; set; }

        [JsonProperty("default_product_sort")]
        public string DefaultProductSort { get; set; }

        [JsonProperty("custom_url")]
        public ProductCustomUrl CustomUrl { get; set; }

        [JsonIgnore]
        public ProductCategoryData[] ChildItems { get; set; }

        public override string ToString()
        {
            return $"{Name}, ID: {Id}, ParentID: {ParentId} ";
        }
    }
}
