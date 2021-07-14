using System.Collections.Generic;
using BCApiClient.Rest.Domain.Entities.Common;
using BigCommerce.REST.Domain.Entities.Products;
using Newtonsoft.Json;

namespace BigCommerce.Process.REST.Domain.Entities.Products
{
    [JsonObject(Description = "Product Variant list)")]
    public class ProductsVariant : IEntityResponse<ProductsVariantData>
    {
        [JsonProperty("data")]
        public ProductsVariantData Data { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }

    [JsonObject(Description = "Product Variant list (total  BigCommerce API v3 response)")]
    public class ProductVariantList: IEntitiesResponse<ProductsVariantData>
    {
        private List<ProductsVariantData> _data;

        [JsonProperty("data")]
        public List<ProductsVariantData> Data   
        {
            get => _data ??= new List<ProductsVariantData>();
            set => _data = value;
        }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}
