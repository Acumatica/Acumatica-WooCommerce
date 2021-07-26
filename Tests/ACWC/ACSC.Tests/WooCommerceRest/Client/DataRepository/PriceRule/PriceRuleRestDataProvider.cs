using System;
using System.Collections.Generic;
using ACSC.Tests.ShopifyRest.Client.Common;
using ACSC.Tests.ShopifyRest.Domain.Entities.Common;
using ACSC.Tests.ShopifyRest.Domain.Entities.Customers;
using ACSC.Tests.ShopifyRest.Domain.Entities.PriceRule;
using ACSC.Tests.ShopifyRest.Interfaces;
using Newtonsoft.Json;
using RestSharp.Extensions;

namespace ACSC.Tests.ShopifyRest.Client.DataRepository.PriceRule
{
    public class PriceRuleRestDataProvider : RestDataProviderBase, IParentRestDataProvider<PriceRuleData>
    {
        protected override string GetSingleUrl { get; } = "price_rules/{id}.json";
        private string GetDiscountUrl { get; } = "price_rules/{id}/discount_codes.json";

        protected override string GetListUrl { get; } = "price_rules.json";

        protected override string GetCountUrl => throw new NotImplementedException();

        protected override string GetSearchUrl => throw new NotImplementedException();

        public PriceRuleRestDataProvider(IWooCommerceRestClient restClient) : base()
        {
            ShopifyRestClient = restClient;
        }

        public PriceRuleData Create(PriceRuleData entity)
        {
            return base.Create<PriceRuleData, PriceRuleResponse>(entity);
        }

        public PriceRuleData GetByID(string priceRuleId)
        {
            var segments = MakeUrlSegments(priceRuleId);
            return base.GetByID<PriceRuleData, PriceRuleResponse>(segments);
        }

        public PriceRuleData Update(PriceRuleData entity, string id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<PriceRuleData> GetCurrentList(out string previousList, out string nextList, IFilter filter = null)
        {
            throw new NotImplementedException();
        }

        public List<PriceRuleData> GetAll(IFilter filter = null)
        {
            throw new NotImplementedException();
        }

        public ItemCount Count()
        {
            throw new NotImplementedException();
        }

        public ItemCount Count(IFilter filter)
        {
            throw new NotImplementedException();
        }
    }
}