using System.Collections.Generic;
using BCApiClient.Rest.Domain.Entities.Common;
using Newtonsoft.Json;

namespace ACSC.Tests.BigCommerceRest.Rest.Domain.Entities.PriceList
{
    [JsonObject(Description = "Price List (total  BigCommerce API v3 response)")]
    public class PriceListRule : IEntityResponse<PriceListData>
    {
        [JsonProperty("data")]
        public PriceListData Data { get; set; }
        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }

    [JsonObject(Description = "Price List (total  BigCommerce API v3 response)")]
    public class PriceListRuleList : IEntitiesResponse<PriceListData>
    {
        private List<PriceListData> _data;

        [JsonProperty("data")]
        public List<PriceListData> Data
        {
            get => _data ??= new List<PriceListData>();
            set => _data = value;
        }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}