using PX.Api.ContractBased.Models;
using PX.Commerce.Core;
using PX.Commerce.Core.API;
using PX.Commerce.Objects;
using PX.Data;
using PX.Objects.Common;
using Meta = PX.Commerce.WooCommerce.API.REST.Domain.Entities.Common;
using PX.Objects.IN.RelatedItems;
using System;
using System.Collections.Generic;
using System.Linq;
using PX.Common;
using PX.Commerce.WooCommerce.Sync;
using PX.Commerce.WooCommerce.WC.Descriptor;
using PX.Commerce.WooCommerce.Sync.Processors;
using PX.Commerce.WooCommerce.Sync.Buckets;
using PX.Commerce.WooCommerce.API.REST.Client;
using PX.Commerce.WooCommerce.API.REST.Client.DataRepository;
using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Sores;
using PX.Commerce.WooCommerce.WC.DAC;
using PX.Commerce.WooCommerce.API.REST.Filters;
using static PX.Commerce.WooCommerce.WC.Descriptor.Constants;
using PX.Commerce.Objects.Substitutes;
using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Product;
using System.Text.RegularExpressions;

namespace PX.Commerce.WooCommerce
{

    public class WCNonStockItemRestrictor : BCBaseRestrictor, IRestrictor
    {
        public virtual FilterResult RestrictExport(IProcessor processor, IMappedEntity mapped)
        {
            #region NonStockItems
            return base.Restrict<MappedNonStockItem>(mapped, delegate (MappedNonStockItem obj)
            {
                if (obj.Local != null && obj.Local.TemplateItemID?.Value != null)
                {
                    return new FilterResult(FilterStatus.Invalid,
                        PXMessages.LocalizeFormatNoPrefixNLA(BCMessages.LogNonStockSkippedVariant, obj.Local.InventoryID?.Value ?? obj.Local.SyncID.ToString()));
                }

                BCBindingExt bindingExt = processor.GetBindingExt<BCBindingExt>();
                if (obj.Local != null && (obj.Local.Categories == null || obj.Local.Categories.Count <= 0) && bindingExt.NonStockSalesCategoriesIDs == null)
                {
                    return new FilterResult(FilterStatus.Invalid,
                        PXMessages.LocalizeFormatNoPrefixNLA(BCMessages.LogItemSkippedNoCategories, obj.Local.InventoryID?.Value ?? obj.Local.SyncID.ToString()));
                }

                if (obj.Local != null && obj.Local.ExportToExternal?.Value == false)
                {
                    return new FilterResult(FilterStatus.Invalid,
                        PXMessages.LocalizeFormatNoPrefixNLA(BCMessages.LogItemNoExport, obj.Local.InventoryID?.Value ?? obj.Local.SyncID.ToString()));
                }

                if (bindingExt.RefundAmountItemID != null && obj.Local?.InventoryID?.Value != null)
                {
                    PX.Objects.IN.InventoryItem refundItem = bindingExt.RefundAmountItemID != null ? PX.Objects.IN.InventoryItem.PK.Find((PXGraph)processor, bindingExt.RefundAmountItemID) : null;
                    if (refundItem != null && obj.Local?.InventoryID?.Value.Trim() == refundItem?.InventoryCD?.Trim())
                    {
                        return new FilterResult(FilterStatus.Invalid,
                            PXMessages.LocalizeFormatNoPrefixNLA(BCMessages.LogNonStockSkippedRefund, obj.Local.InventoryID?.Value ?? obj.Local.SyncID.ToString()));
                    }
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

    [BCProcessor(typeof(WCConnector), BCEntitiesAttribute.NonStockItem, BCCaptions.NonStockItem,
        IsInternal = false,
        Direction = SyncDirection.Export,
        PrimaryDirection = SyncDirection.Export,
        PrimarySystem = PrimarySystem.Local,
        PrimaryGraph = typeof(PX.Objects.IN.NonStockItemMaint),
        ExternTypes = new Type[] { typeof(ProductData) },
        LocalTypes = new Type[] { typeof(NonStockItem) },
        DetailTypes = new String[] { BCEntitiesAttribute.ProductVideo, BCCaptions.ProductVideo },
        AcumaticaPrimaryType = typeof(PX.Objects.IN.InventoryItem),
        AcumaticaPrimarySelect = typeof(Search<PX.Objects.IN.InventoryItem.inventoryCD, Where<PX.Objects.IN.InventoryItem.stkItem, Equal<False>>>),
        URL = "post.php?post={0}&action=edit",
        Requires = new string[] { BCEntitiesAttribute.SalesCategory }

    )]
    [BCProcessorExternCustomField(BCConstants.CustomFields, WCCaptions.CustomFields, nameof(ProductData.MetaData), typeof(ProductData))]
    public class WCNonStockItemProcessor : BCProcessorSingleBase<WCStockItemProcessor, WCNonStockItemEntityBucket, MappedNonStockItem>, IProcessor
    {
        protected WooRestClient client;
        protected ProductRestDataProvider productDataProvider;
        protected TaxClasesProvider taxDataProvider;

        protected List<TaxClass> taxClasses;
        protected const string InvalidSKUPattern = "[a-zA-Z1-9\\s\\S]*[ ]{2,}[a-zA-Z1-9\\s\\S]*";

        #region Constructor
        public override void Initialise(IConnector connector, ConnectorOperation operation)
        {
            base.Initialise(connector, operation);
            client = WCConnector.GetRestClient(GetBindingExt<BCBindingWooCommerce>());
            productDataProvider = new ProductRestDataProvider(client);
            taxDataProvider = new TaxClasesProvider(client);

            taxClasses = taxDataProvider.GetAll().ToList();
        }
        #endregion

        #region Common
        public override MappedNonStockItem PullEntity(Guid? localID, Dictionary<string, object> externalInfo)
        {
            NonStockItem impl = cbapi.GetByID<NonStockItem>(localID);
            if (impl == null) return null;

            MappedNonStockItem obj = new MappedNonStockItem(impl, impl.SyncID, impl.SyncTime);

            return obj;
        }
        public override MappedNonStockItem PullEntity(String externID, String externalInfo)
        {
            ProductData data = productDataProvider.GetByID(externID);
            if (data == null) return null;

            MappedNonStockItem obj = new MappedNonStockItem(data, data.Id?.ToString(), data.DateModifiedUT.ToDate());

            return obj;
        }
        #endregion

        #region Import
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
                WCNonStockItemEntityBucket bucket = CreateBucket();

                MappedNonStockItem obj = bucket.Product = bucket.Product.Set(data, data.Id?.ToString(), data.DateModifiedUT.ToDate());
                EnsureStatus(obj, SyncDirection.Import);
            }
        }
        public override EntityStatus GetBucketForImport(WCNonStockItemEntityBucket bucket, BCSyncStatus syncstatus)
        {
            FilterProducts filter = new FilterProducts();
            ProductData data = productDataProvider.GetByID(syncstatus.ExternID, filter);
            if (data == null) return EntityStatus.None;

            MappedNonStockItem obj = bucket.Product = bucket.Product.Set(data, data.Id?.ToString(), data.DateModifiedUT.ToDate());
            EntityStatus status = EnsureStatus(obj, SyncDirection.Import);

            return status;
        }

        public override void MapBucketImport(WCNonStockItemEntityBucket bucket, IMappedEntity existing)
        {
            MappedNonStockItem obj = bucket.Product;

            ProductData data = obj.Extern;
            NonStockItem impl = obj.Local = new NonStockItem();
            StringValue tax = obj.Extern?.TaxClass != null ? GetSubstituteLocalByExtern(
                    BCSubstitute.GetValue(Operation.ConnectorType, BCSubstitute.TaxClasses),
                    taxClasses?.Find(i => i.Name == obj.Extern?.TaxClass)?.Name, "").ValueField() :
                    obj.Local.TaxCategory;

            impl.Custom = GetCustomFieldsForImport();

            //Product
            impl.InventoryID = GetEntityKey(PX.Objects.IN.InventoryAttribute.DimensionName, data.Name).ValueField();
            impl.Description = data.Name.ValueField();
            impl.ItemClass = obj.LocalID == null || existing?.Local == null ? PX.Objects.IN.INItemClass.PK.Find(this, GetBindingExt<BCBindingExt>().NonStockItemClassID)?.ItemClassCD.ValueField() : null;
            impl.DefaultPrice = data.PriceInDecimal.ValueField();
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
                    And<BCSyncStatus.externID, Equal<Required<BCSyncStatus.externID>>>>>>>.Select(this, BCEntitiesAttribute.SalesCategory, cat);

                if (incategory == null || incategory.CategoryID == null) throw new PXException(BCMessages.CategoryNotSyncronizedForItem, data.Name);

                impl.Categories.Add(new CategoryStockItem() { CategoryID = incategory.CategoryID.ValueField() });
            }
        }
        public override void SaveBucketImport(WCNonStockItemEntityBucket bucket, IMappedEntity existing, String operation)
        {
            MappedNonStockItem obj = bucket.Product;

            if (existing?.Local != null) obj.Local.InventoryID = ((NonStockItem)existing.Local).InventoryID.Value.SearchField();

            NonStockItem impl = cbapi.Put<NonStockItem>(obj.Local, obj.LocalID);

            bucket.Product.AddLocal(impl, impl.SyncID, impl.SyncTime);
            UpdateStatus(obj, operation);
        }
        #endregion

        #region Export
        public override IEnumerable<MappedNonStockItem> PullSimilar(ILocalEntity entity, out string uniqueField)
        {
            List<ProductData> datas = PullSimilar(((NonStockItem)entity)?.Description?.Value, ((NonStockItem)entity)?.InventoryID?.Value, out uniqueField);
            return datas == null ? null : datas.Select(data => new MappedNonStockItem(data, data.Id.ToString(), data.DateModifiedUT.ToDate()));
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
                    if ((Operation.EntityType == BCEntitiesAttribute.ProductWithVariant && statuses.Any(x => x.GetItem<BCSyncStatus>().EntityType == BCEntitiesAttribute.StockItem || x.GetItem<BCSyncStatus>().EntityType == BCEntitiesAttribute.NonStockItem)) ||
                        (Operation.EntityType == BCEntitiesAttribute.StockItem && statuses.Any(x => x.GetItem<BCSyncStatus>().EntityType == BCEntitiesAttribute.ProductWithVariant || x.GetItem<BCSyncStatus>().EntityType == BCEntitiesAttribute.NonStockItem)) ||
                        (Operation.EntityType == BCEntitiesAttribute.NonStockItem && statuses.Any(x => x.GetItem<BCSyncStatus>().EntityType == BCEntitiesAttribute.StockItem || x.GetItem<BCSyncStatus>().EntityType == BCEntitiesAttribute.ProductWithVariant)))
                    {
                        throw new PXException(WCMessages.MappedToOtherEntity, uniqueField);
                    }

                }
            }

            return datas;
        }


        public override void FetchBucketsForExport(DateTime? minDateTime, DateTime? maxDateTime, PXFilterRow[] filters)
        {
            NonStockItem item = new NonStockItem()
            {
                InventoryID = new StringReturn(),
                TemplateItemID = new StringReturn(),
                Categories = new List<CategoryStockItem>() { new CategoryStockItem() { CategoryID = new IntReturn() } },
                ExportToExternal = new BooleanReturn()
            };
            IEnumerable<NonStockItem> impls = cbapi.GetAll<NonStockItem>(item, minDateTime, maxDateTime, filters);

            if (impls != null && impls.Count() > 0)
            {
                int countNum = 0;
                List<IMappedEntity> mappedList = new List<IMappedEntity>();
                String[] allowedRels = GetBindingExt<BCBindingExt>().RelatedItems?.Split(',');
                Dictionary<string, int> stats = new Dictionary<string, int>();
                foreach (string impl in impls.Select(i => i.InventoryID.Value))
                    stats.Add(impl, 0);
                if (allowedRels != null && allowedRels.Count() > 0 && !String.IsNullOrWhiteSpace(allowedRels[0]))
                {
                    PXResultset<PX.Objects.IN.InventoryItem, INRelatedInventory> relationsFetched = PXSelectJoin<PX.Objects.IN.InventoryItem,
                        InnerJoin<INRelatedInventory, On<INRelatedInventory.inventoryID, Equal<PX.Objects.IN.InventoryItem.inventoryID>>>>
                            .Select<PXResultset<PX.Objects.IN.InventoryItem, INRelatedInventory>>(this);
                    foreach (PXResult<PX.Objects.IN.InventoryItem, INRelatedInventory> relation in relationsFetched)
                        if (stats.ContainsKey(relation.GetItem<PX.Objects.IN.InventoryItem>().InventoryCD.TrimEnd()) && allowedRels.Contains(relation.GetItem<INRelatedInventory>().Relation) &&
                            (relation.GetItem<INRelatedInventory>().ExpirationDate == null || relation.GetItem<INRelatedInventory>().ExpirationDate > DateTime.Now))
                            stats[relation.GetItem<PX.Objects.IN.InventoryItem>().InventoryCD.TrimEnd()] += 1;
                }
                foreach (string key in stats.OrderBy(i => i.Value).Select(i => i.Key))
                {
                    NonStockItem impl = impls.First(i => i.InventoryID.Value.Equals(key));
                    IMappedEntity obj = new MappedNonStockItem(impl, impl.SyncID, impl.SyncTime);

                    mappedList.Add(obj);
                    countNum++;
                    if (countNum % BatchFetchCount == 0 || countNum == impls.Count())
                    {
                        ProcessMappedListForExport(ref mappedList);
                    }
                }
            }
        }
        public override EntityStatus GetBucketForExport(WCNonStockItemEntityBucket bucket, BCSyncStatus syncstatus)
        {
            NonStockItem impl = cbapi.GetByID<NonStockItem>(syncstatus.LocalID, GetCustomFieldsForExport());
            if (impl == null) return EntityStatus.None;

            MappedNonStockItem obj = bucket.Product = bucket.Product.Set(impl, impl.SyncID, impl.SyncTime);
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

                    BCItemSalesCategory implCat = cbapi.Get<BCItemSalesCategory>(new BCItemSalesCategory() { CategoryID = new IntSearch() { Value = item.CategoryID.Value } });
                    if (implCat == null) continue;

                    MappedCategory mappedCategory = new MappedCategory(implCat, implCat.SyncID, implCat.SyncTime);
                    EntityStatus mappedCategoryStatus = EnsureStatus(mappedCategory, SyncDirection.Export);
                    if (mappedCategoryStatus == EntityStatus.Deleted)
                        throw new PXException(BCMessages.CategoryIsDeletedForItem, item.CategoryID.Value, impl.Description.Value);
                    if (mappedCategory.IsNew)
                    {
                        LogWarning(Operation.LogScope(obj), BCMessages.LogItemCategoryNotSynchronized,
                            implCat.Description?.Value, impl.InventoryID?.Value, mappedCategoryStatus.ToString());
                        continue;
                    }

                    bucket.Categories.Add(mappedCategory);
                }
            }
            return status;
        }

        public override void MapBucketExport(WCNonStockItemEntityBucket bucket, IMappedEntity existing)
        {
            MappedNonStockItem obj = bucket.Product;

            NonStockItem impl = obj.Local;

            //Existing item and store Availability Policies
            BCBindingExt currentBindingExt = GetBindingExt<BCBindingExt>();
            string storeAvailability = BCItemAvailabilities.Convert(currentBindingExt.Availability);
            var regEx = new Regex(InvalidSKUPattern);
            if (regEx.IsMatch(impl.InventoryID.Value))
            {
                throw new PXException(WCMessages.InvalidSKU, regEx.Match(impl.InventoryID.Value), impl.InventoryID.Value);
            }

            ProductData data = obj.Extern = new ProductData();

            //Inventory Item
            data.Name = impl.Description?.Value;
            data.Description = ClearHTMLContent(impl.Content?.Value);
            data.Type = ProductTypes.Simple;
            data.Virtual = true;
            //data.Downloadable = true;
            data.Price = impl.DefaultPrice.Value.ToString();
            data.ShortDescription = impl.MetaDescription?.Value;
            data.RegularPrice = impl.DefaultPrice?.Value.ToString(); //TODO:Need to check localisation
            data.Weight = impl.DimensionWeight?.Value.ToString();
            data.Sku = impl.InventoryID?.Value;
            data.Tags = impl.MetaKeywords?.Value?.Split(',').Select(s => new TagData { Name = s }).ToList();
            data.TaxClass = taxClasses?.Find(i => i.Name.Equals(base.GetSubstituteLocalByExtern(currentBindingExt.TaxCategorySubstitutionListID, impl.TaxCategory?.Value, string.Empty)))?.Name;

            if (impl.CustomURL?.Value != null) data.ExternalUrl = impl.CustomURL?.Value;

            data.RelatedIds = MapRelatedItems(obj.Local.InventoryID?.Value.TrimEnd());

            if (impl.Attributes?.Count() > 0)
            {
                data.Attributes = new List<AttributeData>();
                foreach (var attribute in impl.Attributes)
                {
                    GenerateAttributeData(data, attribute);
                }
            }

            data.Featured = false;
            data.Type = ProductTypes.Simple;
            data.Status = impl.ItemStatus.Value == PX.Objects.IN.Messages.Active ? ProductStatuses.Published : ProductStatuses.Draft;//TODO:M2

            string visibility = impl?.Visibility?.Value;
            if (visibility == null || visibility == BCCaptions.StoreDefault) visibility = BCItemVisibility.Convert(currentBindingExt.Visibility);
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

            Boolean isItemActive = !(impl.ItemStatus?.Value == PX.Objects.IN.Messages.Inactive || impl.ItemStatus?.Value == PX.Objects.IN.Messages.ToDelete || impl.ItemStatus?.Value == PX.Objects.IN.Messages.NoSales);
            string availability = impl?.Availability?.Value;
            if (availability == null || availability == BCCaptions.StoreDefault) availability = storeAvailability;
            if (availability != BCCaptions.DoNotUpdate)
            {
                data.ManageStock = false;
                data.StockStatus = StockStatuses.InStock;
                switch (availability)
                {
                    case BCCaptions.AvailableTrack:
                        data.StockStatus = StockStatuses.InStock;
                        break;
                    case BCCaptions.AvailableSkip: data.StockStatus = StockStatuses.InStock; break;
                    case BCCaptions.PreOrder: data.StockStatus = StockStatuses.OnBackOrder; break;
                    case BCCaptions.Disabled: data.StockStatus = StockStatuses.OutOfStock; break;

                }
            }

            if (data.Categories == null)
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
                String categories = currentBindingExt.NonStockSalesCategoriesIDs;
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

        public virtual List<int> MapRelatedItems(string inventoryID)
        {
            BCBinding binding = GetBinding();
            string[] categoriesAllowed = GetBindingExt<BCBindingExt>().RelatedItems?.Split(',');

            Boolean anyRelation = false;
            List<int> ids = new List<int>();
            if (categoriesAllowed != null && categoriesAllowed.Count() > 0 && !String.IsNullOrWhiteSpace(categoriesAllowed[0]))
            {
                PXResultset<PX.Objects.IN.InventoryItem, INRelatedInventory, BCChildrenInventoryItem, BCSyncStatus> relates = PXSelectJoin<PX.Objects.IN.InventoryItem,
                    InnerJoin<INRelatedInventory, On<PX.Objects.IN.InventoryItem.inventoryID, Equal<INRelatedInventory.inventoryID>>,
                    InnerJoin<BCChildrenInventoryItem, On<INRelatedInventory.relatedInventoryID, Equal<BCChildrenInventoryItem.inventoryID>>,
                    InnerJoin<BCSyncStatus, On<BCSyncStatus.localID, Equal<BCChildrenInventoryItem.noteID>,
                        And<BCSyncStatus.connectorType, Equal<Required<BCSyncStatus.connectorType>>,
                        And<BCSyncStatus.bindingID, Equal<Required<BCSyncStatus.bindingID>>,
                        And2<Where<BCSyncStatus.entityType, Equal<BCEntitiesAttribute.stockItem>, Or<BCSyncStatus.entityType, Equal<BCEntitiesAttribute.nonStockItem>>>,
                        And<BCSyncStatus.syncID, IsNotNull,
                        And<BCSyncStatus.externID, IsNotNull>>>>>>>>>,
                    Where<PX.Objects.IN.InventoryItem.inventoryCD, Equal<Required<PX.Objects.IN.InventoryItem.inventoryCD>>>>
                        .Select<PXResultset<PX.Objects.IN.InventoryItem, INRelatedInventory, BCChildrenInventoryItem, BCSyncStatus>>(this,
                        binding.ConnectorType,
                        binding.BindingID,
                        inventoryID);

                foreach (var rel in relates)
                {
                    anyRelation = true;

                    INRelatedInventory row = rel.GetItem<INRelatedInventory>();
                    if (row.IsActive == true
                        && categoriesAllowed.Contains(row.Relation)
                        && (row.ExpirationDate == null || row.ExpirationDate > DateTime.Now))
                    {
                        ids.Add((int)rel.GetItem<BCSyncStatus>().ExternID.ToInt());
                    }
                }
            }
            return anyRelation ? ids : null;
        }

        public override object GetAttribute(WCNonStockItemEntityBucket bucket, string attributeID)
        {
            MappedNonStockItem obj = bucket.Product;
            NonStockItem impl = obj.Local;
            return impl.Attributes?.Where(x => string.Equals(x?.AttributeDescription?.Value, attributeID, StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault();

        }

        public override void AddAttributeValue(WCNonStockItemEntityBucket bucket, string attributeID, object attributeValue)
        {
            MappedNonStockItem obj = bucket.Product;
            NonStockItem impl = obj.Local;
            impl.Attributes = impl.Attributes ?? new List<AttributeValue>();
            AttributeValue attribute = new AttributeValue();
            attribute.AttributeID = new StringValue() { Value = attributeID };
            attribute.ValueDescription = new StringValue() { Value = attributeValue?.ToString() };
            impl.Attributes.Add(attribute);
        }

        public override void SaveBucketExport(WCNonStockItemEntityBucket bucket, IMappedEntity existing, String operation)
        {
            MappedNonStockItem obj = bucket.Product;

            ProductData data;
            if (obj.ExternID == null)
                data = productDataProvider.Create(obj.Extern);
            else
                data = productDataProvider.Update(obj.Extern, obj.ExternID.ToInt().Value);

            //ExportCustomFields(obj, obj.Extern.MetaData, data);
            obj.AddExtern(data, data.Id?.ToString(), data.DateModifiedUT.ToDate());

            UpdateStatus(obj, operation);
        }

        #endregion
    }
}
