﻿using System;
using System.Collections.Generic;
using ACSC.Tests.ShopifyRest.Client.Common;
using ACSC.Tests.ShopifyRest.Domain.Entities.Common;
using ACSC.Tests.ShopifyRest.Domain.Entities.WebHooks;
using ACSC.Tests.ShopifyRest.Interfaces;

namespace ACSC.Tests.ShopifyRest.Client.DataRepository
{
    public class WebHookRestDataProvider : RestDataProviderBase, IParentRestDataProvider<WebHookData>
    {
        protected override string GetListUrl { get; } = "/webhooks.json";
        protected override string GetSingleUrl { get; } = "/webhooks/{id}.json";
        protected override string GetCountUrl { get; } = "/webhooks/count.json";
        protected override string GetSearchUrl => throw new NotImplementedException();

        public WebHookRestDataProvider(IWooCommerceRestClient restClient) : base()
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

        public WebHookData Create(WebHookData entity)
        {
            var newwebhook = base.Create<WebHookData, WebHookResponse>(entity);
            return newwebhook;
        }

        public WebHookData Update(WebHookData entity, string id)
        {
            var segments = MakeUrlSegments(id);
            return base.Update<WebHookData, WebHookResponse>(entity, segments);
        }

        public bool Delete(string id)
        {
            var segments = MakeUrlSegments(id);
            return base.Delete(segments);
        }

        public List<WebHookData> GetAll(IFilter filter = null)
        {
            var allWebHooks = base.GetAll<WebHookData, WebHooksResponse>(filter);
            return allWebHooks;
        }

        public WebHookData GetByID(string id)
        {
            var segments = MakeUrlSegments(id);
            var webhook = GetByID<WebHookData, WebHookResponse>(segments);
            return webhook;
        }

        public List<WebHookData> GetCurrentList(out string previousList, out string nextList, IFilter filter = null)
        {
            var webhook = GetCurrentList<WebHookData, WebHooksResponse>(out previousList, out nextList, filter);
            return webhook;
        }

        #endregion IParentDataRestClient
    }
}