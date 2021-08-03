﻿using System.Collections.Generic;
using BCApiClient.Rest.Domain.Entities.Common;
using Newtonsoft.Json;

namespace BCApiClient.Rest.Domain.Entities.Products
{
    [JsonObject(Description = "Product Category list (total  BigCommerce API v3 response)")]
    public class ProductCategory : IEntityResponse<ProductCategoryData>
    {

        [JsonProperty("data")]
        public ProductCategoryData Data { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
    
    [JsonObject(Description = "Product Category list (total  BigCommerce API v3 response)")]
    public class ProductCategoryList: IEntitiesResponse<ProductCategoryData>
    {
        private List<ProductCategoryData> _data;

        [JsonProperty("data")]
        public List<ProductCategoryData> Data   
        {
            get => _data ?? (_data = new List<ProductCategoryData>());
            set => _data = value;
        }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}
