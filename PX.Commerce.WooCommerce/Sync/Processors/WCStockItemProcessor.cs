using PX.Api.ContractBased.Models;
using PX.Commerce.Core;
using PX.Commerce.Core.API;
using PX.Commerce.Objects;
using PX.Commerce.WooCommerce.API.REST.Client;
using PX.Commerce.WooCommerce.API.REST.Client.DataRepository;
using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Product;
using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Sores;
using PX.Commerce.WooCommerce.API.REST.Filters;
using PX.Commerce.WooCommerce.Sync.Buckets;
using PX.Commerce.WooCommerce.WC.DAC;
using PX.Commerce.WooCommerce.WC.Descriptor;
using PX.Common;
using PX.Data;
using PX.Objects.IN.RelatedItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using static PX.Commerce.WooCommerce.WC.Descriptor.Constants;

namespace PX.Commerce.WooCommerce.Sync.Processors
{
    public class WCStockItemRestrictor : BCBaseRestrictor, IRestrictor
    {
        public virtual FilterResult RestrictExport(IProcessor processor, IMappedEntity mapped)
        {
            #region StockItems
            return base.Restrict<MappedStockItem>(mapped, delegate (MappedStockItem obj)
            {
                if (obj.Local != null && obj.Local.TemplateItemID?.Value != null)
                {
                    return new FilterResult(FilterStatus.Invalid,
                        PXMessages.LocalizeFormatNoPrefixNLA(BCMessages.LogStockSkippedVariant, obj.Local.InventoryID?.Value ?? obj.Local.SyncID.ToString()));
                }

                if (obj.Local != null && (obj.Local.Categories == null || obj.Local.Categories.Count <= 0) && processor.GetBindingExt<BCBindingExt>().StockSalesCategoriesIDs == null)
                {
                    return new FilterResult(FilterStatus.Invalid,
                        PXMessages.LocalizeFormatNoPrefixNLA(BCMessages.LogItemSkippedNoCategories, obj.Local.InventoryID?.Value ?? obj.Local.SyncID.ToString()));
                }

                if (obj.Local != null && obj.Local.ExportToExternal?.Value == false)
                {
                    return new FilterResult(FilterStatus.Invalid,
                        PXMessages.LocalizeFormatNoPrefixNLA(BCMessages.LogItemNoExport, obj.Local.InventoryID?.Value ?? obj.Local.SyncID.ToString()));
                }

                return null;
            });
            #endregion
        }

        public virtual FilterResult RestrictImport(IProcessor processor, IMappedEntity mapped)
        {
            return null;
        }
    }


    [BCProcessor(typeof(WCConnector), BCEntitiesAttribute.StockItem, BCCaptions.StockItem,
        IsInternal = false,
        Direction = SyncDirection.Export,
        PrimaryDirection = SyncDirection.Export,
        PrimarySystem = PrimarySystem.Local,
        PrimaryGraph = typeof(PX.Objects.IN.InventoryItemMaint),
        ExternTypes = new Type[] { typeof(ProductData) },
        LocalTypes = new Type[] { typeof(StockItem) },
        DetailTypes = new string[] { BCEntitiesAttribute.ProductVideo, BCCaptions.ProductVideo },
        AcumaticaPrimaryType = typeof(PX.Objects.IN.InventoryItem),
        AcumaticaPrimarySelect = typeof(Search<PX.Objects.IN.InventoryItem.inventoryCD, Where<PX.Objects.IN.InventoryItem.stkItem, Equal<True>>>),
        URL = "post.php?post={0}&action=edit",
        Requires = new string[] { BCEntitiesAttribute.SalesCategory }
    )]
    public class WCStockItemProcessor : BCProcessorSingleBase<WCStockItemProcessor, WCStockItemEntityBucket, MappedStockItem>, IProcessor
    {
        protected WooRestClient client;
        protected ProductRestDataProvider productDataProvider;
        protected TaxClasesProvider taxDataProvider;
        protected const string InvalidSKUPattern = "[a-zA-Z1-9\\s\\S]*[ ]{2,}[a-zA-Z1-9\\s\\S]*";

        protected List<TaxClass> taxClasses;

        public override void Initialise(IConnector connector, ConnectorOperation operation)
        {
            base.Initialise(connector, operation);
            client = WCConnector.GetRestClient(GetBindingExt<BCBindingWooCommerce>());
            productDataProvider = new ProductRestDataProvider(client);
            taxDataProvider = new TaxClasesProvider(client);

            taxClasses = taxDataProvider.GetAll().ToList();
        }

        #region Import

        public override EntityStatus GetBucketForImport(WCStockItemEntityBucket bucket, BCSyncStatus syncstatus)
        {
            ProductData data = productDataProvider.GetByID(syncstatus.ExternID);
            if (data == null) return EntityStatus.None;

            MappedStockItem obj = bucket.Product = bucket.Product.Set(data, data.Id?.ToString(), data.DateModifiedUT.ToDate());
            EntityStatus status = EnsureStatus(obj, SyncDirection.Import);

            return status;
        }

        public override void FetchBucketsForImport(DateTime? minDateTime, DateTime? maxDateTime, PXFilterRow[] filters)
        {
            //No DateTime filtering for Category
            FilterProducts filter = new FilterProducts
            {
                After = minDateTime == null ? null : minDateTime,
                Before = maxDateTime == null ? null : maxDateTime
            };

            IEnumerable<ProductData> datas = productDataProvider.GetAll(filter);

            foreach (ProductData data in datas)
            {
                WCStockItemEntityBucket bucket = CreateBucket();

                MappedStockItem obj = bucket.Product = bucket.Product.Set(data, data.Id?.ToString(), data.DateModifiedUT.ToDate());
                EntityStatus status = EnsureStatus(obj, SyncDirection.Import);
            }
        }

        public override void MapBucketImport(WCStockItemEntityBucket bucket, IMappedEntity existing)
        {
            MappedStockItem obj = bucket.Product;

            ProductData data = obj.Extern;
            StringValue tax = obj.Extern?.TaxClass != null ? GetSubstituteLocalByExtern(
                    BCSubstitute.TaxClasses,
                    taxClasses?.Find(i => i.Name == obj.Extern?.TaxClass)?.Name, "").ValueField() :
                    obj.Local.TaxCategory;
            StockItem impl = obj.Local = new StockItem();
            impl.Custom = GetCustomFieldsForImport();

            //Product
            impl.InventoryID = GetEntityKey(PX.Objects.IN.BaseInventoryAttribute.DimensionName, data.Name).ValueField();
            impl.Description = data.Name.ValueField();
            impl.ItemClass = obj.LocalID == null || existing?.Local == null
                ? PX.Objects.IN.INItemClass.PK.Find(this, GetBindingExt<BCBindingExt>().StockItemClassID)?.ItemClassCD.ValueField()
                : null;
            decimal defaultPrice;
            decimal.TryParse(data.RegularPrice, out defaultPrice);
            impl.DefaultPrice = defaultPrice.ValueField();
            impl.TaxCategory = tax;
            if (data.Categories != null)
                impl.Categories = new List<CategoryStockItem>();
            foreach (var cat in data.Categories)
            {
                PX.Objects.IN.INCategory incategory = PXSelectJoin<PX.Objects.IN.INCategory,
                LeftJoin<BCSyncStatus, On<PX.Objects.IN.INCategory.noteID, Equal<BCSyncStatus.localID>>>,
                Where<BCSyncStatus.connectorType, Equal<Current<BCEntity.connectorType>>,
                    And<BCSyncStatus.bindingID, Equal<Current<BCEntity.bindingID>>,
                    And<BCSyncStatus.entityType, Equal<Required<BCEntity.entityType>>,
                    And<BCSyncStatus.externID, Equal<Required<BCSyncStatus.externID>>>>>>>
                    .Select(this, BCEntitiesAttribute.SalesCategory, cat);

                if (incategory == null || incategory.CategoryID == null)
                    throw new PXException(BCMessages.CategoryNotSyncronizedForItem, data.Name);

                impl.Categories.Add(new CategoryStockItem() { CategoryID = incategory.CategoryID.ValueField() });
            }
        }

        protected void GenerateAttributeData(ProductData data, AttributeValue attribute)
        {
            AttributeData item = new AttributeData
            {
                Name = attribute.AttributeDescription?.Value,
                OrderBy = "name",
            };
            if (attribute.Value != null)
                item.Options = new List<string> { attribute.Value?.Value ?? string.Empty };

            data.Attributes.Add(item);
        }


        public override MappedStockItem PullEntity(Guid? localID, Dictionary<string, object> externalInfo)
        {
            StockItem impl = cbapi.GetByID<StockItem>(localID);
            if (impl == null) return null;

            MappedStockItem obj = new MappedStockItem(impl, impl.SyncID, impl.SyncTime);

            return obj;
        }

        public override MappedStockItem PullEntity(string externID, string externalInfo)
        {
            ProductData data = productDataProvider.GetByID(externID);
            if (data == null) return null;

            MappedStockItem obj = new MappedStockItem(data, data.Id?.ToString(), data.DateModifiedUT.ToDate());

            return obj;
        }

        public override void SaveBucketImport(WCStockItemEntityBucket bucket, IMappedEntity existing, string operation)
        {
            MappedStockItem obj = bucket.Product;

            if (existing?.Local != null) obj.Local.InventoryID = ((StockItem)existing.Local).InventoryID.Value.SearchField();

            StockItem impl = cbapi.Put(obj.Local, obj.LocalID);

            bucket.Product.AddLocal(impl, impl.SyncID, impl.SyncTime);
            UpdateStatus(obj, operation);
        }
        #endregion

        #region Export

        public override void FetchBucketsForExport(DateTime? minDateTime, DateTime? maxDateTime, PXFilterRow[] filters)
        {
            BCEntity entity = GetEntity(Operation.EntityType);

            StockItem item = new StockItem()
            {
                InventoryID = new StringReturn(),
                TemplateItemID = new StringReturn(),
                Categories = new List<CategoryStockItem>() { new CategoryStockItem() { CategoryID = new IntReturn() } },
                ExportToExternal = new BooleanReturn()
            };
            IEnumerable<StockItem> impls = cbapi.GetAll<StockItem>(item, minDateTime, maxDateTime, filters);

            if (impls != null)
            {
                int countNum = 0;
                List<IMappedEntity> mappedList = new List<IMappedEntity>();

                foreach (StockItem impl in impls)
                {
                    IMappedEntity obj = new MappedStockItem(impl, impl.SyncID, impl.SyncTime);
                    mappedList.Add(obj);
                    countNum++;
                    if (countNum % BatchFetchCount == 0)
                    {
                        ProcessMappedListForExport(ref mappedList);
                    }
                }
                if (mappedList.Any())
                {
                    ProcessMappedListForExport(ref mappedList);
                }
            }
        }

        public override void MapBucketExport(WCStockItemEntityBucket bucket, IMappedEntity existing)
        {
            var currentBindingExt = GetBindingExt<BCBindingExt>();

            MappedStockItem obj = bucket.Product;
            StockItem impl = obj.Local;
            ProductData data = obj.Extern = new ProductData();
            //Existing item and store Availability Policies
            string storeAvailability = BCItemAvailabilities.Convert(GetBindingExt<BCBindingExt>().Availability);
            var regEx = new Regex(InvalidSKUPattern);
            if (regEx.IsMatch(impl.InventoryID.Value))
            {
                throw new PXException(WCMessages.InvalidSKU, regEx.Match(impl.InventoryID.Value), impl.InventoryID.Value);
            }

            data.Name = impl.Description?.Value;
            data.Description = ClearHTMLContent(impl.Content?.Value);
            data.ShortDescription = impl.MetaDescription?.Value;
            data.RegularPrice = impl.DefaultPrice?.Value.ToString();
            data.Weight = impl.DimensionWeight?.Value.ToString();
            data.Sku = impl.InventoryID?.Value;
            data.Tags = impl.MetaKeywords?.Value?.Split(',').Select(s => new TagData { Name = s }).ToList();

            data.TaxClass = taxClasses?.Find(i => i.Name.Equals(GetSubstituteLocalByExtern(
                GetBindingExt<BCBindingExt>().TaxCategorySubstitutionListID, impl.TaxCategory?.Value, string.Empty)))?.Name;
            if (impl.Attributes?.Count() > 0)
            {
                data.Attributes = new List<AttributeData>();
                foreach (var attribute in impl.Attributes)
                {
                    GenerateAttributeData(data, attribute);
                }
            }

            string visibility = impl?.Visibility?.Value;
            if (visibility == null || visibility == BCCaptions.StoreDefault) 
                visibility = BCItemVisibility.Convert(GetBindingExt<BCBindingExt>().Visibility);
            data.Featured = false;

            switch (visibility)
            {
                case BCCaptions.Visible:
                    data.CatalogVisibility = CatelogVisibilities.Visible;
                    break;
                case BCCaptions.Featured:
                    data.CatalogVisibility = CatelogVisibilities.Visible;
                    data.Featured = true;
                    break;
                case BCCaptions.Invisible:
                    data.CatalogVisibility = CatelogVisibilities.Hidden;
                    break;
                default:
                    data.CatalogVisibility = CatelogVisibilities.Visible;
                    break;
            }

            //hardcoded properties
            data.Type = ProductTypes.Simple;
            data.Status = impl.ItemStatus.Value == PX.Objects.IN.Messages.Active ? ProductStatuses.Published : ProductStatuses.Draft;//TODO:M2

            data.Virtual = false;

            Boolean isItemActive = !(impl.ItemStatus?.Value == PX.Objects.IN.Messages.Inactive || impl.ItemStatus?.Value == PX.Objects.IN.Messages.ToDelete
                || impl.ItemStatus?.Value == PX.Objects.IN.Messages.NoSales);

            string availability = impl?.Availability?.Value;
            if (availability == null || availability == BCCaptions.StoreDefault) availability = storeAvailability;
            if (availability != BCCaptions.DoNotUpdate)
            {
                data.ManageStock = false;
                data.StockStatus = StockStatuses.OutOfStock;
                switch (availability)
                {
                    case BCCaptions.AvailableTrack:
                        data.StockStatus = StockStatuses.InStock;
                        data.ManageStock = true;
                        break;
                    case BCCaptions.AvailableSkip: data.StockStatus = StockStatuses.InStock; break;
                    case BCCaptions.PreOrder: data.StockStatus = StockStatuses.OnBackOrder; break;
                    case BCCaptions.Disabled: data.StockStatus = StockStatuses.OutOfStock; break;

                }
            }

            data.Categories = new List<CategoryData>();
            foreach (PXResult<PX.Objects.IN.INCategory, PX.Objects.IN.INItemCategory, PX.Objects.IN.InventoryItem, BCSyncStatus> result in PXSelectJoin<PX.Objects.IN.INCategory,
                InnerJoin<PX.Objects.IN.INItemCategory, On<PX.Objects.IN.INItemCategory.categoryID, Equal<PX.Objects.IN.INCategory.categoryID>>,
                InnerJoin<PX.Objects.IN.InventoryItem, On<PX.Objects.IN.InventoryItem.inventoryID, Equal<PX.Objects.IN.INItemCategory.inventoryID>>,
                LeftJoin<BCSyncStatus, On<PX.Objects.IN.INCategory.noteID, Equal<BCSyncStatus.localID>>>>>,
                Where<BCSyncStatus.connectorType, Equal<Current<BCEntity.connectorType>>,
                And<BCSyncStatus.bindingID, Equal<Current<BCEntity.bindingID>>,
                And<BCSyncStatus.entityType, Equal<Required<BCEntity.entityType>>,
                And<PX.Objects.IN.InventoryItem.noteID, Equal<Required<PX.Objects.IN.InventoryItem.noteID>>>>>>>
                .Select(this, BCEntitiesAttribute.SalesCategory, obj.LocalID))
            {
                BCSyncStatus status = result.GetItem<BCSyncStatus>();
                if (status == null || status.ExternID == null) throw new PXException(BCMessages.CategoryNotSyncronizedForItem, impl.Description.Value);

                data.Categories.Add(new CategoryData { Id = status.ExternID.ToInt().Value });
            }
            if (data.Categories.Count <= 0)
            {
                String categories = GetBindingExt<BCBindingExt>().StockSalesCategoriesIDs;
                if (!String.IsNullOrEmpty(categories))
                {
                    Int32?[] categoriesArray = categories.Split(',').Select(c => { return Int32.TryParse(c, out Int32 i) ? (int?)i : null; }).Where(i => i != null).ToArray();

                    foreach (BCSyncStatus status in PXSelectJoin<BCSyncStatus,
                        LeftJoin<PX.Objects.IN.INCategory, On<PX.Objects.IN.INCategory.noteID, Equal<BCSyncStatus.localID>>>,
                        Where<BCSyncStatus.connectorType, Equal<Current<BCEntity.connectorType>>,
                            And<BCSyncStatus.bindingID, Equal<Current<BCEntity.bindingID>>,
                            And<BCSyncStatus.entityType, Equal<Required<BCEntity.entityType>>,
                            And<PX.Objects.IN.INCategory.categoryID, In<Required<PX.Objects.IN.INCategory.categoryID>>>>>>>
                            .Select(this, BCEntitiesAttribute.SalesCategory, categoriesArray))
                    {
                        if (status == null || status.ExternID == null) throw new PXException(BCMessages.CategoryNotSyncronizedForItem, impl.Description.Value);

                        if (status != null) data.Categories.Add(new CategoryData { Id = status.ExternID.ToInt().Value });
                    }
                }
            }

            data.DateCreatedUT = DateTime.Now.ToString().ToDate(PXTimeZoneInfo.FindSystemTimeZoneById(currentBindingExt.OrderTimeZone)).Value;
            data.DateModifiedUT = DateTime.Now.ToString().ToDate(PXTimeZoneInfo.FindSystemTimeZoneById(currentBindingExt.OrderTimeZone)).Value;
        }


        public override EntityStatus GetBucketForExport(WCStockItemEntityBucket bucket, BCSyncStatus syncstatus)
        {
            StockItem impl = cbapi.GetByID<StockItem>(syncstatus.LocalID, GetCustomFieldsForExport());
            if (impl == null) return EntityStatus.None;

            MappedStockItem obj = bucket.Product = bucket.Product.Set(impl, impl.SyncID, impl.SyncTime);
            EntityStatus status = EnsureStatus(obj, SyncDirection.Export);

            if (obj.Local.Categories != null)
            {
                foreach (CategoryStockItem item in obj.Local.Categories)
                {
                    BCSyncStatus result = PXSelectJoin<BCSyncStatus,
                        InnerJoin<PX.Objects.IN.INCategory, On<PX.Objects.IN.INCategory.noteID, Equal<BCSyncStatus.localID>>>,
                        Where<BCSyncStatus.connectorType, Equal<Current<BCEntity.connectorType>>,
                            And<BCSyncStatus.bindingID, Equal<Current<BCEntity.bindingID>>,
                            And<BCSyncStatus.entityType, Equal<Required<BCEntity.entityType>>,
                            And<PX.Objects.IN.INCategory.categoryID, Equal<Required<PX.Objects.IN.INCategory.categoryID>>>>>>>
                        .Select(this, BCEntitiesAttribute.SalesCategory, item.CategoryID.Value);
                    if (result != null && result.ExternID != null && result.LocalID != null) continue;

                    BCItemSalesCategory implCat = cbapi.Get(new BCItemSalesCategory() { CategoryID = new IntSearch() { Value = item.CategoryID.Value } });
                    if (implCat == null) continue;
                }
            }
            return status;
        }

        public override void SaveBucketExport(WCStockItemEntityBucket bucket, IMappedEntity existing, string operation)
        {
            MappedStockItem obj = bucket.Product;
            ProductData data;
            if (obj.ExternID == null)
                data = productDataProvider.Create(obj.Extern);
            else
                data = productDataProvider.Update(obj.Extern, obj.ExternID.ToInt().Value);
            obj.AddExtern(data, data.Id?.ToString(), data.CalculateHash());

            UpdateStatus(obj, operation);
        }

        public override IEnumerable<MappedStockItem> PullSimilar(ILocalEntity entity, out string uniqueField)
        {
            List<ProductData> datas = PullSimilar(((StockItem)entity)?.Description?.Value, ((StockItem)entity)?.InventoryID?.Value, out uniqueField);
            return datas == null ? null : datas.Select(data => new MappedStockItem(data, data.Id.ToString(), data.DateModifiedUT.ToDate()));
        }

        public List<ProductData> PullSimilar(string description, string inventoryId, out string uniqueField)
        {
            uniqueField = inventoryId;

            List<ProductData> datas = null;
            if (!string.IsNullOrEmpty(inventoryId))
            {

                datas = productDataProvider.GetAll(new FilterProducts() { Sku = inventoryId })?.ToList();
            }

            if (datas == null) return null;
            var id = datas.FirstOrDefault(x => x.Id != null)?.Id;
            if (id != null)
            {
                var statuses = PXSelect<BCSyncStatus,
                    Where<BCSyncStatus.connectorType, Equal<Required<BCSyncStatus.connectorType>>,
                        And<BCSyncStatus.bindingID, Equal<Required<BCSyncStatus.bindingID>>,
                        And<BCSyncStatus.externID, Equal<Required<BCSyncStatus.externID>>>>>>.Select(this, Operation.ConnectorType, Operation.Binding, id);
                if (statuses != null)
                {
                    if ((Operation.EntityType == BCEntitiesAttribute.ProductWithVariant && statuses.Any(x => x.GetItem<BCSyncStatus>().EntityType == BCEntitiesAttribute.StockItem
                        || x.GetItem<BCSyncStatus>().EntityType == BCEntitiesAttribute.NonStockItem))
                        || (Operation.EntityType == BCEntitiesAttribute.StockItem && statuses.Any(x => x.GetItem<BCSyncStatus>().EntityType == BCEntitiesAttribute.ProductWithVariant
                        || x.GetItem<BCSyncStatus>().EntityType == BCEntitiesAttribute.NonStockItem))
                        || (Operation.EntityType == BCEntitiesAttribute.NonStockItem && statuses.Any(x => x.GetItem<BCSyncStatus>().EntityType == BCEntitiesAttribute.StockItem
                        || x.GetItem<BCSyncStatus>().EntityType == BCEntitiesAttribute.ProductWithVariant)))
                    {
                        throw new PXException(WCMessages.MappedToOtherEntity, uniqueField);
                    }
                }
            }

            return datas;
        }
        #endregion


    }
}
