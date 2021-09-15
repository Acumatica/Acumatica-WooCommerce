using PX.Commerce.Core;
using PX.Commerce.Core.API;
using PX.Commerce.Objects;
using PX.Commerce.WooCommerce.API.REST.Client;
using PX.Commerce.WooCommerce.API.REST.Client.Common;
using PX.Commerce.WooCommerce.API.REST.Client.DataRepository;
using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Product;
using PX.Commerce.WooCommerce.Sync;
using PX.Commerce.WooCommerce.Sync.Processors;
using PX.Commerce.WooCommerce.WC.DAC;
using PX.Data;
using PX.Objects.Common;
using PX.Objects.IN;
using System;
using System.Collections.Generic;
using System.Linq;
using static PX.Commerce.WooCommerce.WC.Descriptor.Constants;

namespace PX.Commerce.WooCommerce
{
    public class WCAvailabilityEntityBucket : EntityBucketBase, IEntityBucket
    {
        public IMappedEntity Primary => Product;
        public IMappedEntity[] Entities => new IMappedEntity[] { Primary };

        public MappedAvailability Product;
    }

    [BCProcessor(typeof(WCConnector), BCEntitiesAttribute.ProductAvailability, BCCaptions.ProductAvailability,
        IsInternal = false,
        Direction = SyncDirection.Export,
        PrimaryDirection = SyncDirection.Export,
        PrimarySystem = PrimarySystem.Local,
        PrimaryGraph = typeof(InventorySummaryEnq),
        ExternTypes = new Type[] { },
        LocalTypes = new Type[] { },
        GIScreenID = BCConstants.GenericInquiryAvailability,
        GIResult = typeof(StorageDetails),
        AcumaticaPrimaryType = typeof(InventoryItem),
        Requires = new string[] { BCEntitiesAttribute.StockItem },
        URL = "post.php?post={0}&action=edit"
        )]
    public class WCAvailabilityProcessor : BCProcessorBulkBase<WCStockItemProcessor, WCAvailabilityEntityBucket, MappedAvailability>, IProcessor
    {
        protected ProductRestDataProvider productDataProvider;
        protected ProductVariantDataProvider productVariantDataProvider;
        protected ProductAvailabilityDataProvider productAvailabilityDataProvider;

        #region Constructor
        public override void Initialise(IConnector iconnector, ConnectorOperation operation)
        {

            base.Initialise(iconnector, operation);
            WooRestClient restClient = WCConnector.GetRestClient(GetBindingExt<BCBindingWooCommerce>());

            productDataProvider = new ProductRestDataProvider(restClient);
            productVariantDataProvider = new ProductVariantDataProvider(restClient);
            productAvailabilityDataProvider = new ProductAvailabilityDataProvider(restClient);
        }
        #endregion

        #region Common
        public override void NavigateLocal(IConnector connector, ISyncStatus status)
        {
            InventorySummaryEnq extGraph = PXGraph.CreateInstance<PX.Objects.IN.InventorySummaryEnq>();
            InventorySummaryEnqFilter filter = extGraph.Filter.Current;
            InventoryItem item = PXSelect<InventoryItem, Where<InventoryItem.noteID, Equal<Required<InventoryItem.noteID>>>>.Select(this, status.LocalID);
            filter.InventoryID = item.InventoryID;

            if (filter.InventoryID != null)
                throw new PXRedirectRequiredException(extGraph, "Navigation") { Mode = PXBaseRedirectException.WindowMode.NewWindow };
        }
        public override MappedAvailability PullEntity(Guid? localID, Dictionary<string, object> fields)
        {
            if (localID == null) return null;
            DateTime? timeStamp = fields.Where(f => f.Key.EndsWith(nameof(BCEntity.LastModifiedDateTime), StringComparison.InvariantCultureIgnoreCase)).Select(f => f.Value).LastOrDefault()?.ToDate();
            int? parentID = fields.Where(f => f.Key.EndsWith(nameof(BCSyncStatus.SyncID), StringComparison.InvariantCultureIgnoreCase)).Select(f => f.Value).LastOrDefault()?.ToInt();
            localID = fields.Where(f => f.Key.EndsWith("TemplateItem_noteID", StringComparison.InvariantCultureIgnoreCase)).Select(f => f.Value).LastOrDefault()?.ToGuid() ?? localID;
            return new MappedAvailability(new StorageDetailsResult(), localID, timeStamp, parentID);
        }
        #endregion

        #region Import
        public override List<WCAvailabilityEntityBucket> FetchBucketsImport(List<BCSyncStatus> ids)
        {
            return null;
        }
        public override void MapBucketImport(WCAvailabilityEntityBucket bucket, IMappedEntity existing)
        {
            throw new NotImplementedException();
        }
        public override void SaveBucketsImport(List<WCAvailabilityEntityBucket> buckets)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Export
        public override List<WCAvailabilityEntityBucket> FetchBucketsExport(List<BCSyncStatus> syncIDs)
        {
            BCEntityStats entityStats = GetEntityStats();
            BCBinding binding = GetBinding();
            BCBindingExt bindingExt = GetBindingExt<BCBindingExt>();

            var warehouses = new Dictionary<string, INSite>();
            var locations = new Dictionary<string, string>();

            foreach (PXResult<BCLocations, INSite, INLocation> result in PXSelectJoin<BCLocations,
                InnerJoin<INSite, On<INSite.siteID, Equal<BCLocations.siteID>>,
                InnerJoin<INLocation, On<INLocation.siteID, Equal<BCLocations.siteID>, And<BCLocations.locationID, IsNull, Or<BCLocations.locationID, Equal<INLocation.locationID>>>>>>,
                Where<BCLocations.bindingID, Equal<Required<BCLocations.bindingID>>>>.Select(this, binding.BindingID))
            {
                var bl = (BCLocations)result;
                var site = (INSite)result;
                var location = (INLocation)result;
                warehouses[site.SiteCD.Trim()] = site;
                if (location != null && bl.LocationID != null)
                {
                    locations[site.SiteCD.Trim()] = locations.ContainsKey(site.SiteCD.Trim()) ? (locations[site.SiteCD.Trim()] + "," + location.LocationCD) : location.LocationCD;
                }
                //If customer specifies the warehouse but not specifis the location, should include all locations and all items that not assigned to any location.
                if (bl.LocationID == null)
                {
                    locations[site.SiteCD.Trim()] = string.Empty;
                }
            }
            Boolean anyLocation = warehouses.Any() && locations.Any(x => x.Value != string.Empty);

            List<StorageDetailsResult> response = FetchStorageDetails(syncIDs, warehouses.Keys.ToArray(), anyLocation);

            //Remove all items that should not be updated, based on combination of Item + Store settings
            string storeAvailability = BCItemAvailabilities.Convert(GetBindingExt<BCBindingExt>().Availability);
            response.RemoveAll(c => c.Availability.Value == BCCaptions.StoreDefault && storeAvailability == BCCaptions.DoNotUpdate);

            //Filter results if specific entity provided or if we don't need to fetch new changes
            List<WCAvailabilityEntityBucket> buckets = new List<WCAvailabilityEntityBucket>();
            if (syncIDs != null && syncIDs.Count > 0 && (Operation.PrepareMode == PrepareMode.None))
            {
                var localIds = syncIDs.Select(x => x.LocalID);
                response = response?.Where(s => localIds.Any(id => s.IdentifyNoteID.Value.IndexOf(id.Value.ToString(), StringComparison.OrdinalIgnoreCase) >= 0))?.ToList();
            }

            List<StorageDetailsResult> results = new List<StorageDetailsResult>();
            if (response != null && response.Count > 0)
                foreach (var detailsGroup in response.GroupBy(r => new { InventoryID = r.InventoryCD?.Value, /*SiteID = r.SiteID?.Value*/ }))
                {
                    StorageDetailsResult result = detailsGroup.First();
                    result.SiteLastModifiedDate = detailsGroup.Where(d => d.SiteLastModifiedDate != null).Select(d => d.SiteLastModifiedDate.Value).Max().ValueField();
                    result.LocationLastModifiedDate = detailsGroup.Where(d => d.LocationLastModifiedDate != null).Select(d => d.LocationLastModifiedDate.Value).Max().ValueField();
                    result.SiteOnHand = detailsGroup.Sum(k => k.SiteOnHand?.Value ?? 0m).ValueField();
                    result.SiteAvailable = detailsGroup.Sum(k => k.SiteAvailable?.Value ?? 0m).ValueField();
                    result.SiteAvailableforIssue = detailsGroup.Sum(k => k.SiteAvailableforIssue?.Value ?? 0m).ValueField();
                    result.SiteAvailableforShipping = detailsGroup.Sum(k => k.SiteAvailableforShipping?.Value ?? 0m).ValueField();
                    if (bindingExt.WarehouseMode == BCWarehouseModeAttribute.SpecificWarehouse && !warehouses.Any())//if warehouse is specific but nothing is configured in table
                    {
                        result.LocationOnHand = result.LocationAvailable = result.LocationAvailableforIssue = result.LocationAvailableforShipping = 0m.ValueField();
                    }
                    else
                    {
                        if (detailsGroup.Any(i => i.SiteID?.Value != null))
                        {
                            result.LocationOnHand = anyLocation ? detailsGroup.Where
                                (k => warehouses.Count <= 0
                                || (locations.ContainsKey(k.SiteID?.Value?.Trim())
                                    && (locations[k.SiteID?.Value?.Trim()] == string.Empty
                                    || (k.LocationID?.Value != null
                                        && locations[k.SiteID?.Value?.Trim()].Contains(k.LocationID?.Value?.Trim())))))
                                .Sum(k => k.LocationOnHand?.Value ?? 0m).ValueField() : null;
                            result.LocationAvailable = anyLocation ? detailsGroup.Where(
                                k => warehouses.Count <= 0
                                || (locations.ContainsKey(k.SiteID?.Value?.Trim())
                                    && (locations[k.SiteID?.Value?.Trim()] == string.Empty
                                    || (k.LocationID?.Value != null
                                        && locations[k.SiteID?.Value?.Trim()].Contains(k.LocationID?.Value?.Trim())))))
                                .Sum(k => k.LocationAvailable?.Value ?? 0m).ValueField() : null;
                            result.LocationAvailableforIssue = anyLocation ? detailsGroup.Where(
                                k => warehouses.Count <= 0
                                || (locations.ContainsKey(k.SiteID?.Value?.Trim())
                                    && (locations[k.SiteID?.Value?.Trim()] == string.Empty
                                    || (k.LocationID?.Value != null
                                    && locations[k.SiteID?.Value?.Trim()].Contains(k.LocationID?.Value?.Trim())))))
                                .Sum(k => k.LocationAvailableforIssue?.Value ?? 0m).ValueField() : null;
                            result.LocationAvailableforShipping = anyLocation ? detailsGroup.Where(
                                k => warehouses.Count <= 0
                                || (locations.ContainsKey(k.SiteID?.Value?.Trim())
                                    && (locations[k.SiteID?.Value?.Trim()] == string.Empty
                                    || (k.LocationID?.Value != null
                                    && locations[k.SiteID?.Value?.Trim()].Contains(k.LocationID?.Value?.Trim())))))
                                .Sum(k => k.LocationAvailableforShipping?.Value ?? 0m).ValueField() : null;
                        }
                        else
                            result.LocationOnHand = result.LocationAvailable = result.LocationAvailableforIssue = result.LocationAvailableforShipping = null;
                    }
                    results.Add(result);
                }

            var allVariants = results.Where(x => x.TemplateItemID?.Value != null);

            if (results != null)
            {
                var stockItems = results.Where(x => x.TemplateItemID?.Value == null);
                if (stockItems != null)
                {
                    foreach (StorageDetailsResult line in stockItems)
                    {
                        Guid? noteID = line.InventoryNoteID?.Value;
                        DateTime? lastModified;
                        if (line.IsTemplate?.Value == true)
                        {
                            line.VariantDetails = new List<StorageDetailsResult>();
                            line.VariantDetails.AddRange(allVariants.Where(x => string.Equals(x.TemplateItemID?.Value.Trim(), line.InventoryCD.Value.Trim())));
                            if (line.VariantDetails.Count() == 0) continue;
                            lastModified = line.VariantDetails.Select(x => new DateTime?[] { x.LocationLastModifiedDate?.Value, x.SiteLastModifiedDate?.Value, x.InventoryLastModifiedDate.Value }.Where(d => d != null).Select(d => d.Value).Max()).Max();
                        }
                        else
                        {
                            lastModified = new DateTime?[] { line.LocationLastModifiedDate?.Value, line.SiteLastModifiedDate?.Value, line.InventoryLastModifiedDate.Value }.Where(d => d != null).Select(d => d.Value).Max();
                        }
                        BCSyncStatus current = syncIDs.FirstOrDefault(s => s.LocalID == noteID);

                        if (Operation.PrepareMode == PrepareMode.Incremental && current != null && current.PendingSync != true
                            && entityStats?.LastIncrementalExportDateTime != null && lastModified < entityStats.LastIncrementalExportDateTime)
                            continue; //TODO Check if we need it at all.

                        WCAvailabilityEntityBucket bucket = new WCAvailabilityEntityBucket();
                        MappedAvailability obj = bucket.Product = new MappedAvailability(line, noteID, lastModified, line.ParentSyncId.Value);
                        EntityStatus status = EnsureStatus(obj, SyncDirection.Export);
                        if (status == EntityStatus.Deleted) status = EnsureStatus(obj, SyncDirection.Export, resync: true);

                        obj.ParentID = line.ParentSyncId.Value;
                        if (Operation.PrepareMode != PrepareMode.Reconciliation && Operation.PrepareMode != PrepareMode.Full && status != EntityStatus.Pending && Operation.SyncMethod != SyncMode.Force)
                        {
                            SynchronizeStatus(bucket.Product, BCSyncOperationAttribute.Reconfiguration);
                            Statuses.Cache.Persist(PXDBOperation.Update);
                            Statuses.Cache.Persisted(false);
                            continue;
                        }

                        buckets.Add(bucket);
                    }
                }
            }

            return buckets;
        }
        public virtual List<StorageDetailsResult> FetchStorageDetails(List<BCSyncStatus> statuses, String[] warehouses, bool anyLocation)
        {
            StorageDetails request = new StorageDetails();
            request.Warehouse = string.Join(",", warehouses).ValueField();
            request.SplitByLocation = anyLocation.ValueField();
            request.BindingID = GetBinding().BindingID.ValueField();
            List<StorageDetailsResult> results = new List<StorageDetailsResult>();
            if (Operation.PrepareMode == PrepareMode.None && statuses?.Count < (BCConstants.GenericInquiryPageSize / 2))
            {
                List<PXFilterRow> filters = new List<PXFilterRow>();
                foreach (BCSyncStatus status in statuses)
                {
                    if (status?.LocalID == null) continue;

                    filters.Add(new PXFilterRow() { DataField = nameof(StorageDetailsResult.IdentifyNoteID), Condition = PXCondition.LIKE, Value = status.LocalID.Value.ToString(), OrOperator = true });
                    if (filters.Count % BCConstants.GerericInquiryFetchByBatch == 0)
                    {
                        filters.Last().OrOperator = false;
                        var response = cbapi.GetGIResult<StorageDetailsResult>(request, BCConstants.GenericInquiryAvailability, filters.ToArray());
                        if (response != null)
                            results.AddRange(response);

                        filters.Clear();
                    }
                }
                if (filters.Count != 0)
                {
                    filters.Last().OrOperator = false;
                    var response = cbapi.GetGIResult<StorageDetailsResult>(request, BCConstants.GenericInquiryAvailability, filters.ToArray());
                    if (response != null)
                        results.AddRange(response);
                    filters.Clear();
                }
            }
            if (Operation.PrepareMode != PrepareMode.None)
            {
                var response = cbapi.GetGIResult<StorageDetailsResult>(request, BCConstants.GenericInquiryAvailability);
                if (response != null)
                    results.AddRange(response);
            }

            return results;
        }

        public override void MapBucketExport(WCAvailabilityEntityBucket bucket, IMappedEntity existing)
        {
            BCBinding binding = GetBinding();
            BCBindingExt bindingExt = GetBindingExt<BCBindingExt>();

            MappedAvailability obj = bucket.Product;

            StorageDetailsResult impl = obj.Local;
            AvailabilityData data = obj.Extern = new AvailabilityData();

            BCSyncStatus parentStatus = BCSyncStatus.PK.Find(this, obj.ParentID);
            data.Id = parentStatus.ExternID.ToInt();

            string availability = impl.Availability?.Value;
            if (availability == null || availability == BCItemAvailabilities.StoreDefault) availability = bindingExt.Availability;
            string notAvailMode = impl.NotAvailMode?.Value;
            if (notAvailMode == null || notAvailMode == BCItemNotAvailModes.StoreDefault) notAvailMode = bindingExt.NotAvailMode;
            if (availability == BCItemAvailabilities.AvailableTrack)
            {
                data.Availability = StockStatuses.InStock;
                data.ManageStock = true;

                if (impl.IsTemplate?.Value == true)
                {
                    data.Type = ProductTypes.Variable;
                    data.Variants = new List<ProductsVariantData>();
                    foreach (var variant in impl.VariantDetails)
                    {
                        ProductsVariantData variantData = new ProductsVariantData();
                        BCSyncDetail variantStatus = PXSelectJoin<BCSyncDetail,
                        InnerJoin<InventoryItem, On<InventoryItem.noteID, Equal<BCSyncDetail.localID>>,
                        InnerJoin<BCSyncStatus, On<BCSyncStatus.syncID, Equal<BCSyncDetail.syncID>>>>,
                        Where<BCSyncStatus.connectorType, Equal<Current<BCEntity.connectorType>>,
                        And<BCSyncStatus.bindingID, Equal<Current<BCEntity.bindingID>>,
                        And<BCSyncStatus.entityType, Equal<Required<BCEntity.entityType>>,
                        And<BCSyncDetail.localID, Equal<Required<BCSyncDetail.localID>>>>>>>
                        .Select(this, BCEntitiesAttribute.ProductWithVariant, variant.InventoryNoteID.Value);

                        if (variantStatus?.ExternID != null)
                        {
                            variantData.Id = variantStatus?.ExternID.ToInt();
                            variantData.ProductId = data.Id;
                            variantData.OptionValues = null;
                            variantData.ManageStock = true;
                            //Inventory Level
                            variantData.StockQuantity = GetInventoryLevel(bindingExt, variant);
                            if (variantData.StockQuantity < 0)
                                variantData.StockQuantity = 0;
                            data.Variants.Add(variantData);

                        }
                    }
                    if (data.Variants.All(x => x.InventoryLevel <= 0))
                    {
                        switch (notAvailMode)
                        {
                            case BCItemNotAvailModes.DisableItem:
                            case BCItemNotAvailModes.PreOrderItem:
                                data.Availability = StockStatuses.OutOfStock;
                                break;
                        }
                    }
                }
                else
                {
                    data.Type = ProductTypes.Simple;
                    //Inventory Level
                    data.InventoryLevel = GetInventoryLevel(bindingExt, impl);
                    //Not In Stock mode
                    if (data.InventoryLevel <= 0)
                    {
                        data.InventoryLevel = 0;

                        switch (notAvailMode)
                        {
                            case BCItemNotAvailModes.DisableItem:
                            case BCItemNotAvailModes.PreOrderItem:
                                data.Availability = StockStatuses.OutOfStock;
                                break;
                        }
                    }
                }

            }
            else
            {
                data.ManageStock = false;

                switch (availability)
                {
                    case BCItemAvailabilities.AvailableSkip: data.Availability = StockStatuses.InStock; break;
                    case BCItemAvailabilities.PreOrder: data.Availability = StockStatuses.OutOfStock; break;
                    case BCItemAvailabilities.Disabled: data.Availability = StockStatuses.OutOfStock; break;
                    default: data.Availability = StockStatuses.InStock; break;
                }
            }

            Boolean isItemActive = !(impl.ItemStatus?.Value == InventoryItemStatus.Inactive || impl.ItemStatus?.Value == InventoryItemStatus.MarkedForDeletion || impl.ItemStatus?.Value == InventoryItemStatus.NoSales);
            if (!isItemActive)
            {
                data.Availability = StockStatuses.OutOfStock;
            }
        }

        public int GetInventoryLevel(BCBindingExt store, StorageDetailsResult detailsResult)
        {
            switch (store.AvailabilityCalcRule)
            {
                case BCAvailabilityLevelsAttribute.Available:
                    return (int)(detailsResult.LocationAvailable?.Value ?? detailsResult.SiteAvailable.Value);
                case BCAvailabilityLevelsAttribute.AvailableForShipping:
                    return (int)(detailsResult.LocationAvailableforShipping?.Value ?? detailsResult.SiteAvailableforShipping.Value);
                case BCAvailabilityLevelsAttribute.OnHand:
                    return (int)(detailsResult.LocationOnHand?.Value ?? detailsResult.SiteOnHand.Value);
                default:
                    return 0;
            }
        }

        public override void SaveBucketsExport(List<WCAvailabilityEntityBucket> buckets)
        {
            var list = buckets.Select(b => b.Product.Extern).ToList();

            var batchData = new BatchData<AvailabilityData> { Update = list };

            BatchData<AvailabilityData> result = productAvailabilityDataProvider.UpdateAll(batchData);

            var templateProducts = list.Where(v => v.Variants != null && v.Variants.Any());
            if (templateProducts.Any())
            {
                foreach (var item in templateProducts)
                {
                    var templateBatch = new BatchData<ProductsVariantData> { Update = item.Variants };
                    productVariantDataProvider.UpdateAll(templateBatch, item.Id.Value);
                }
            }
            for (int i = 0; i < buckets.Count; i++)
            {
                var data = list[i];
                WCAvailabilityEntityBucket bucket = buckets[i];
                bucket.Product.AddExtern(data, data.Id?.ToString(), data.DateModified);
                UpdateStatus(bucket.Product, BCSyncOperationAttribute.ExternUpdate);
                Operation.Callback?.Invoke(new SyncInfo(bucket?.Primary?.SyncID ?? 0, SyncDirection.Export, SyncResult.Processed));
            }
        }
        #endregion
    }
}
