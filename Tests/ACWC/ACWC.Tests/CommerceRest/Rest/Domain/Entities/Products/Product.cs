using System.Collections.Generic;
using BCApiClient.Rest.Domain.Entities.Common;
using Newtonsoft.Json;

namespace ACSC.Tests.BigCommerceRest.Rest.Domain.Entities.Products
{
    [JsonObject(Description = "Product (total  BigCommerce API v3 response)")]
    public class Product : IEntityResponse<ProductData>
    {
        [JsonProperty("data")]
        public ProductData Data { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }

    [JsonObject(Description = "Product list (total  BigCommerce API v3 response)")]
    public class ProductList : IEntitiesResponse<ProductData>
    {
        private List<ProductData> _data;

        [JsonProperty("data")]
        public List<ProductData> Data
        {
            get => _data ?? (_data = new List<ProductData>());
            set => _data = value;
        }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}




