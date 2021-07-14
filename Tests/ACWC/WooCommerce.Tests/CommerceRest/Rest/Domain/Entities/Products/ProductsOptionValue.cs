using System.Collections.Generic;
using BCApiClient.Rest.Domain.Entities.Common;
using BigCommerce.Process.REST.Domain.Options;
using Newtonsoft.Json;

namespace ACSC.Tests.BigCommerceRest.Rest.Domain.Entities.Products
{
       
    public class ProductsOptionValue : IEntityResponse<ProductOptionValueData>
    {
        [JsonProperty("data")]
        public ProductOptionValueData Data { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }

    public class ProductsOptionValueList :IEntitiesResponse<ProductOptionValueData>
    {
        private List<ProductOptionValueData> _data;

        [JsonProperty("data")]
        public List<ProductOptionValueData> Data
        {
            get => _data ?? (_data = new List<ProductOptionValueData>());
            set => _data = value;
        }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}
