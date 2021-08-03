using ACSC.Tests.ShopifyRest.Client.Common;
using ACSC.Tests.ShopifyRest.Domain.Entities.Discount;
using ACSC.Tests.ShopifyRest.Interfaces;
using System;
using System.Collections.Generic;

namespace ACSC.Tests.ShopifyRest.Client.DataRepository.Discount
{
    public class DiscountRestDataProvider : RestDataProviderBase, IChildRestDataProvider<DiscountData>
    {
        protected override string GetSingleUrl { get; } = "price_rules/{parent_id}/discount_codes/{id}.json";
        protected override string GetListUrl { get; } = "price_rules/{parent_id}/discount_codes.json";

        protected override string GetCountUrl => throw new NotImplementedException();

        protected override string GetSearchUrl => throw new NotImplementedException();

        public DiscountRestDataProvider(IWooCommerceRestClient restClient) : base()
        {
            ShopifyRestClient = restClient;
        }

        public DiscountData Create(DiscountData entity, string price_rule_id)
        {
            var segments = MakeParentUrlSegments(price_rule_id);
            return base.Create<DiscountData, DiscountResponse>(entity, segments);
        }

        public new DiscountData Update(DiscountData entity, string parentId, string id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string parentId, string id)
        {
            throw new NotImplementedException();
        }

        public int Count(string parentId)
        {
            throw new NotImplementedException();
        }

        public new List<DiscountData> GetCurrentList(string parentId, out string previousList, out string nextList, IFilter filter = null)
        {
            throw new NotImplementedException();
        }

        public new List<DiscountData> GetAll(string parentId, IFilter filter = null)
        {
            throw new NotImplementedException();
        }

        public List<DiscountData> GetAllWithoutParent(IFilter filter = null)
        {
            throw new NotImplementedException();
        }

        public new DiscountData GetByID(string parentId, string id)
        {
            throw new NotImplementedException();
        }
    }
}