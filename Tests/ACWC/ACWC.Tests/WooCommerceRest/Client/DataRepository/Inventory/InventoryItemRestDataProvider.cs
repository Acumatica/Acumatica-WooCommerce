using System;
using System.Collections.Generic;
using ACSC.Tests.ShopifyRest.Client.Common;
using ACSC.Tests.ShopifyRest.Domain.Entities.Common;
using ACSC.Tests.ShopifyRest.Domain.Entities.Inventory;
using ACSC.Tests.ShopifyRest.Interfaces;

namespace ACSC.Tests.ShopifyRest.Client.DataRepository.Inventory
{
    public class InventoryItemRestDataProvider : RestDataProviderBase, IParentRestDataProvider<InventoryItemData>
    {
        protected override string GetListUrl { get; } = "inventory_items.json";
        protected override string GetSingleUrl { get; } = "inventory_items/{id}.json";
        protected override string GetCountUrl => throw new NotImplementedException();
        protected override string GetSearchUrl => throw new NotImplementedException();

        public InventoryItemRestDataProvider(IWooCommerceRestClient restClient) : base()
        {
            WooCommerceRestClient = restClient;
        }

        public InventoryItemData Create(InventoryItemData entity) => throw new NotImplementedException();

        public InventoryItemData Update(InventoryItemData entity) => Update(entity, entity.Id.ToString());

        public InventoryItemData Update(InventoryItemData entity, string id)
        {
            var segments = MakeUrlSegments(id);
            return base.Update<InventoryItemData, InventoryItemResponse>(entity, segments);
        }

        public bool Delete(InventoryItemData entity, string id) => Delete(id);

        public bool Delete(string id)
        {
            var segments = MakeUrlSegments(id);
            return Delete(segments);
        }

        public List<InventoryItemData> GetCurrentList(out string previousList, out string nextList, IFilter filter = null)
        {
            return GetCurrentList<InventoryItemData, InventoryItemsResponse>(out previousList, out nextList, filter);
        }

        public List<InventoryItemData> GetAll(IFilter filter = null)
        {
            return GetAll<InventoryItemData, InventoryItemsResponse>(filter);
        }

        public InventoryItemData GetByID(string id)
        {
            var segments = MakeUrlSegments(id);
            var entity = base.GetByID<InventoryItemData, InventoryItemResponse>(segments);
            return entity;
        }

        public ItemCount Count() => throw new NotImplementedException();

        public ItemCount Count(IFilter filter) => throw new NotImplementedException();
    }
}