using System;
using System.Collections.Generic;
using ACSC.Tests.ShopifyRest.Client.Common;
using ACSC.Tests.ShopifyRest.Domain.Entities.Common;
using ACSC.Tests.ShopifyRest.Interfaces;

namespace ACSC.Tests.ShopifyRest.Client.DataRepository
{
    public class MetafieldRestDataProvider : RestDataProviderBase, IParentRestDataProvider<MetafieldData>
    {
        protected override string GetListUrl { get; } = "metafields.json";
        protected override string GetSingleUrl { get; } = "metafields/{id}.json";
        protected override string GetCountUrl { get; } = "metafields/count.json";
        protected override string GetSearchUrl => throw new NotImplementedException();

        public MetafieldRestDataProvider(IWooCommerceRestClient restClient) : base()
        {
            WooCommerceRestClient = restClient;
        }

        #region IParentDataRestClient

        public ItemCount Count()
        {
            return base.GetCount();
        }

        public ItemCount Count(IFilter filter)
        {
            return base.GetCount(filter);
        }

        public MetafieldData Create(MetafieldData entity)
        {
            var result = base.Create<MetafieldData, MetafieldResponse>(entity);
            return result;
        }

        public MetafieldData Update(MetafieldData entity, string id)
        {
            var segments = MakeUrlSegments(id);
            return base.Update<MetafieldData, MetafieldResponse>(entity, segments);
        }

        public bool Delete(string id)
        {
            var segments = MakeUrlSegments(id);
            return base.Delete(segments);
        }

        public List<MetafieldData> GetAll(IFilter filter = null)
        {
            var result = base.GetAll<MetafieldData, MetafieldsResponse>(filter);
            return result;
        }

        public MetafieldData GetByID(string id)
        {
            var segments = MakeUrlSegments(id);
            var result = GetByID<MetafieldData, MetafieldResponse>(segments);
            return result;
        }

        public List<MetafieldData> GetCurrentList(out string previousList, out string nextList, IFilter filter = null)
        {
            var result = GetCurrentList<MetafieldData, MetafieldsResponse>(out previousList, out nextList, filter);
            return result;
        }

        public MetafieldData GetMetafieldBySpecifiedUrl(string url, string id)
        {
            var request = BuildRequest(url, nameof(GetMetafieldBySpecifiedUrl), MakeUrlSegments(id), null);
            return WooCommerceRestClient.Get<MetafieldData, MetafieldResponse>(request).Data;
        }

        public List<MetafieldData> GetMetafieldsBySpecifiedUrl(string url, string id)
        {
            var request = BuildRequest(url, nameof(GetMetafieldBySpecifiedUrl), MakeUrlSegments(id), null);
            return WooCommerceRestClient.GetAll<MetafieldData, MetafieldsResponse>(request);
        }

        #endregion IParentDataRestClient
    }
}