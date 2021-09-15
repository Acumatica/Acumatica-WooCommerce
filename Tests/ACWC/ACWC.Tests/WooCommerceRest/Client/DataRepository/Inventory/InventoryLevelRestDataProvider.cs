using System;
using System.Collections.Generic;
using ACSC.Tests.ShopifyRest.Client.Common;
using ACSC.Tests.ShopifyRest.Domain.Entities.Common;
using ACSC.Tests.ShopifyRest.Domain.Entities.Inventory;
using ACSC.Tests.ShopifyRest.Interfaces;

namespace ACSC.Tests.ShopifyRest.Client.DataRepository.Inventory
{
    public class InventoryLevelRestDataProvider : RestDataProviderBase, IParentRestDataProvider<InventoryLevelData>
    {
        protected override string GetListUrl { get; } = "inventory_levels.json";
        protected override string GetSingleUrl => throw new NotImplementedException();
        protected override string GetCountUrl => throw new NotImplementedException();
        protected override string GetSearchUrl => throw new NotImplementedException();
        private string GetDeleteUrl { get; } = "inventory_levels.json?inventory_item_id={0}&location_id={1}";
        private string GetPostSetUrl { get; } = "inventory_levels/set.json";
        private string GetPostAdjustUrl { get; } = "inventory_levels/adjust.json";
        private string GetPostConnectUrl { get; } = "inventory_levels/connect.json";

        public InventoryLevelRestDataProvider(IWooCommerceRestClient restClient) : base()
        {
            WooCommerceRestClient = restClient;
        }

        public InventoryLevelData Create(InventoryLevelData entity) => throw new NotImplementedException();

        public InventoryLevelData Update(InventoryLevelData entity) => throw new NotImplementedException();

        public InventoryLevelData Update(InventoryLevelData entity, string id) => throw new NotImplementedException();

        public bool Delete(InventoryLevelData entity, string id) => throw new NotImplementedException();

        public bool Delete(string id) => throw new NotImplementedException();

        public bool Delete(string inventoryItemId, string inventoryLocationId)
        {
            var request = BuildRequest(string.Format(GetDeleteUrl, inventoryItemId, inventoryLocationId), nameof(Delete), null, null);
            return WooCommerceRestClient.Delete(request);
        }

        public List<InventoryLevelData> GetCurrentList(out string previousList, out string nextList, IFilter filter = null)
        {
            if (filter == null) throw new Exception("You must include inventory_item_ids, location_ids, or both as filter parameters");
            return GetCurrentList<InventoryLevelData, InventoryLevelsResponse>(out previousList, out nextList, filter);
        }

        public List<InventoryLevelData> GetAll(IFilter filter = null)
        {
            if (filter == null) throw new Exception("You must include inventory_item_ids, location_ids, or both as filter parameters");
            return GetAll<InventoryLevelData, InventoryLevelsResponse>(filter);
        }

        public InventoryLevelData GetByID(string id) => throw new NotImplementedException();

        public ItemCount Count() => throw new NotImplementedException();

        public ItemCount Count(IFilter filter) => throw new NotImplementedException();

        public InventoryLevelData AdjustInventory(InventoryLevelData entity)
        {
            WooCommerceRestClient.Logger?.Debug($"AdjustInventory: adjusting {entity.GetType()} entry");
            var request = BuildRequest(GetPostAdjustUrl, nameof(AdjustInventory), null, null);
            return WooCommerceRestClient.Post<InventoryLevelData, InventoryLevelResponse>(request, entity, false);
        }

        public InventoryLevelData SetInventory(InventoryLevelData entity)
        {
            WooCommerceRestClient.Logger?.Debug($"SetInventory: setting {entity.GetType()} entry");
            var request = BuildRequest(GetPostSetUrl, nameof(SetInventory), null, null);
            return WooCommerceRestClient.Post<InventoryLevelData, InventoryLevelResponse>(request, entity, false);
        }

        public InventoryLevelData ConnectInventory(InventoryLevelData entity)
        {
            WooCommerceRestClient.Logger?.Debug($"ConnectInventory: connecting {entity.GetType()} entry");
            var request = BuildRequest(GetPostConnectUrl, nameof(ConnectInventory), null, null);
            return WooCommerceRestClient.Post<InventoryLevelData, InventoryLevelResponse>(request, entity, false);
        }
    }
}