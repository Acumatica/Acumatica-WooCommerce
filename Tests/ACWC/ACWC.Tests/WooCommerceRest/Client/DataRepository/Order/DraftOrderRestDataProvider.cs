using ACSC.Tests.ShopifyRest.Domain.Entities.Order;
using System;
using System.Collections.Generic;
using ACSC.Tests.ShopifyRest.Client.Common;
using ACSC.Tests.ShopifyRest.Domain.Entities.Common;
using ACSC.Tests.ShopifyRest.Interfaces;

namespace ACSC.Tests.ShopifyRest.Client.DataRepository.Order
{
    public class DraftOrderRestDataProvider : RestDataProviderBase, IParentRestDataProvider<DraftOrderData>
    {
        protected override string GetListUrl { get; } = "draft_orders";
        protected override string GetSingleUrl { get; } = "draft_orders/{id}";
        protected override string GetCountUrl { get; } = "draft_orders/count";
        protected override string GetSearchUrl => throw new NotImplementedException();
        private string CompleteUrl { get; } = "draft_orders/{id}/complete";

        public DraftOrderRestDataProvider(IWooCommerceRestClient restClient) : base()
        {
            ShopifyRestClient = restClient;
        }

        public DraftOrderData Create(DraftOrderData entity)
        {
            return base.Create<DraftOrderData, DraftOrderResponse>(entity);
        }

        public DraftOrderData Update(DraftOrderData entity, string id)
        {
            var segments = MakeUrlSegments(id);
            return base.Update<DraftOrderData, DraftOrderResponse>(entity, segments);
        }

        public bool Delete(string id)
        {
            var segments = MakeUrlSegments(id);
            return Delete(segments);
        }

        public List<DraftOrderData> GetCurrentList(out string previousList, out string nextList, IFilter filter = null)
        {
            return GetCurrentList<DraftOrderData, DraftOrdersResponse>(out previousList, out nextList, filter);
        }

        public List<DraftOrderData> GetAll(IFilter filter = null)
        {
            return GetAll<DraftOrderData, DraftOrdersResponse>(filter);
        }

        public DraftOrderData GetByID(string id)
        {
            throw new NotImplementedException();
        }

        public ItemCount Count()
        {
            return base.GetCount();
        }

        public ItemCount Count(IFilter filter)
        {
            return base.GetCount(filter);
        }

        public DraftOrderData Complete(long id)
        {
            var request = BuildRequest(CompleteUrl, nameof(Complete), MakeUrlSegments(id), null);
            request.AddParameter("payment_pending", true);
            return ShopifyRestClient.Put<DraftOrderData, DraftOrderResponse>(request, null, false);
        }
    }
}
