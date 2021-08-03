using ACSC.Tests.BigCommerceRest.Rest.Domain.Entities.PriceList;
using BCApiClient.Rest.Client.Common;
using BCApiClient.Rest.Domain.Entities.Common;
using BCApiClient.Rest.Filters;
using BCApiClient.Rest.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;

namespace ACSC.Tests.BigCommerceRest.Rest.Client.DataRepository.PriceList
{
    public class PriceListDataProvider : RestDataProviderV3, IParentRestDataProvider<PriceListData>
    {
        protected override string GetListUrl { get; } = "v3/pricelists/{id}/records";
        protected override string GetSingleUrl { get; }
        protected override string GetCountUrl { get; }

        public PriceListDataProvider(IBigCommerceRestClient restClient)
        {
            _restClient = restClient;
        }
        public PriceListData Create(PriceListData entity)
        {
            throw new System.NotImplementedException();
        }

        public PriceListData Update(PriceListData entity, int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<PriceListData> Get(IFilter filter = null)
        {
            throw new System.NotImplementedException();
        }

        public List<PriceListData> GetAll(IFilter filter = null)
        {
            throw new System.NotImplementedException();
        }

        public List<PriceListData> Get(string id, string product_id)
        {
            PriceListFilter filter = new PriceListFilter()
            {
                ProductId = product_id,
                Page = 1,
                Limit = 50
            };
            var segments = MakeUrlSegments(id);
            var orderData = GetAll<PriceListData, PriceListRuleList>(filter, segments).Data;
            return orderData;
        }

        public PriceListData GetByID(int id)
        {
            throw new System.NotImplementedException();
        }

        public PriceListData GetByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public ItemCount Count()
        {
            throw new System.NotImplementedException();
        }

        public ItemCount Count(IFilter filter)
        {
            throw new System.NotImplementedException();
        }
    }

    public class PriceListFilter : Filter
    {
        [Description("product_id:in")]
        public string ProductId { get; set; }

        [Description("include")]
        public string bulk_pricing_tiers { get; set; } = "bulk_pricing_tiers";
    }
}