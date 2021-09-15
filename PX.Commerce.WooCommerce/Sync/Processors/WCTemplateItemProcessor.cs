using PX.Api.ContractBased.Models;
using PX.Commerce.Core;
using PX.Commerce.Core.API;
using PX.Commerce.Objects;
using PX.Commerce.WooCommerce.API.REST.Client;
using PX.Commerce.WooCommerce.API.REST.Client.Common;
using PX.Commerce.WooCommerce.API.REST.Client.DataRepository;
using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Product;
using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Sores;
using PX.Commerce.WooCommerce.API.REST.Filters;
using PX.Commerce.WooCommerce.Sync;
using PX.Commerce.WooCommerce.Sync.Buckets;
using PX.Commerce.WooCommerce.WC.DAC;
using PX.Commerce.WooCommerce.WC.Descriptor;
using PX.Data;
using PX.Data.BQL.Fluent;
using PX.Objects.CS;
using PX.Objects.IN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using static PX.Commerce.WooCommerce.WC.Descriptor.Constants;

namespace PX.Commerce.WooCommerce
{

    public class WCTemplateItem : BCBaseRestrictor, IRestrictor
    {
        public virtual FilterResult RestrictExport(IProcessor processor, IMappedEntity mapped)
        {
            return base.Restrict(mapped, delegate (MappedTemplateItem obj)
            {
                if (obj.Local != null && (obj.Local.Matrix == null || obj.Local.Matrix?.Count == 0))
                {
                    return new FilterResult(FilterStatus.Invalid,
                        PXMessages.LocalizeFormatNoPrefixNLA(BCMessages.LogTemplateSkippedNoMatrix, obj.Local.InventoryID?.Value ?? obj.Local.SyncID.ToString()));
                }

                if (obj.Local != null && obj.Local.ExportToExternal?.Value == false)
                {
                    return new FilterResult(FilterStatus.Invalid,
                        PXMessages.LocalizeFormatNoPrefixNLA(BCMessages.LogItemNoExport, obj.Local.InventoryID?.Value ?? obj.Local.SyncID.ToString()));
                }

                if (obj.Local != null && (obj.Local.Categories == null || obj.Local.Categories.Count <= 0))
                {
                    var defaultCategories = obj.Local.IsStockItem?.Value == false ? processor.GetBindingExt<BCBindingExt>().NonStockSalesCategoriesIDs : processor.GetBindingExt<BCBindingExt>().StockSalesCategoriesIDs;
                    if (defaultCategories == null)
                    {
                        return new FilterResult(FilterStatus.Invalid,
                            PXMessages.LocalizeFormatNoPrefixNLA(BCMessages.LogItemSkippedNoCategories, obj.Local.InventoryID?.Value ?? obj.Local.SyncID.ToString()));
                    }
                }

                return null;
            });
        }

        public virtual FilterResult RestrictImport(IProcessor processor, IMappedEntity mapped)
        {
            return null;
        }
    }


    [BCProcessor(typeof(WCConnector), BCEntitiesAttribute.ProductWithVariant, BCCaptions.TemplateItem,
        IsInternal = false,
        Direction = SyncDirection.Export,
        PrimaryDirection = SyncDirection.Export,
        PrimarySystem = PrimarySystem.Local,
        PrimaryGraph = typeof(InventoryItemMaint),
        ExternTypes = new Type[] { typeof(ProductData) },
        LocalTypes = new Type[] { typeof(TemplateItems) },
        DetailTypes = new String[] { BCEntitiesAttribute.ProductOption, BCCaptions.ProductOption,
            BCEntitiesAttribute.ProductOptionValue, BCCaptions.ProductOptionValue,
            BCEntitiesAttribute.Variant, BCCaptions.Variant,
            BCEntitiesAttribute.ProductVideo, BCCaptions.ProductVideo },
        AcumaticaPrimaryType = typeof(InventoryItem),
        AcumaticaPrimarySelect = typeof(Search<InventoryItem.inventoryCD, Where<InventoryItem.isTemplate, Equal<True>>>),
        AcumaticaFeaturesSet = typeof(FeaturesSet.matrixItem),
        URL = "post.php?post={0}&action=edit",
        Requires = new string[] { BCEntitiesAttribute.SalesCategory }
    )]
    [BCProcessorExternCustomField(BCConstants.CustomFields, WCCaptions.CustomFields, nameof(ProductData.MetaData), typeof(ProductData))]
    public class WCTemplateItemProcessor : BCProcessorSingleBase<WCTemplateItemProcessor, WCProductWithVariantEntityBucket, MappedTemplateItem>, IProcessor
    {
        protected const string InvalidSKUPattern = "[a-zA-Z1-9\\s\\S]*[ ]{2,}[a-zA-Z1-9\\s\\S]*";
        protected WooRestClient client;
        protected ProductRestDataProvider productDataProvider;
        protected TaxClasesProvider taxDataProvider;
        protected ProductVariantDataProvider productVariantDataProvider;

        protected List<TaxClass> taxClasses;

        #region Constructor
        public override void Initialise(IConnector connector, ConnectorOperation operation)
        {
            base.Initialise(connector, operation);
            client = WCConnector.GetRestClient(GetBindingExt<BCBindingWooCommerce>());
            productDataProvider = new ProductRestDataProvider(client);
            taxDataProvider = new TaxClasesProvider(client);
            productVariantDataProvider = new ProductVariantDataProvider(client);
            taxClasses = taxDataProvider.GetAll().ToList();
        }
        #endregion

        #region Common
        public override MappedTemplateItem PullEntity(Guid? localID, Dictionary<string, object> fields)
        {
            TemplateItems impl = cbapi.GetByID<TemplateItems>(localID);
            if (impl == null) return null;

            MappedTemplateItem obj = new MappedTemplateItem(impl, impl.SyncID, impl.SyncTime);

            return obj;
        }

        public override MappedTemplateItem PullEntity(String externID, String jsonObject)
        {
            ProductData data = productDataProvider.GetByID(externID);
            if (data == null) return null;

            MappedTemplateItem obj = new MappedTemplateItem(data, data.Id?.ToString(), data.DateModifiedUT.ToDate());

            return obj;
        }
        #endregion

        #region Import
        public override void FetchBucketsForImport(DateTime? minDateTime, DateTime? maxDateTime, PXFilterRow[] filters)
        {
            FilterProducts filter = new FilterProducts
            {
                After = minDateTime == null ? null : minDateTime,
                Before = maxDateTime == null ? null : maxDateTime
            };

            IEnumerable<ProductData> datas = productDataProvider.GetAll(filter);

            foreach (ProductData data in datas)
            {
                WCProductWithVariantEntityBucket bucket = CreateBucket();

                MappedTemplateItem obj = bucket.Product = bucket.Product.Set(data, data.Id?.ToString(), data.DateModifiedUT.ToDate());
                EntityStatus status = EnsureStatus(obj, SyncDirection.Import);
            }
        }
        public override EntityStatus GetBucketForImport(WCProductWithVariantEntityBucket bucket, BCSyncStatus syncstatus)
        {
            FilterProducts filter = new FilterProducts { };
            ProductData data = productDataProvider.GetByID(syncstatus.ExternID, filter);
            if (data == null) return EntityStatus.None;

            MappedTemplateItem obj = bucket.Product = bucket.Product.Set(data, data.Id?.ToString(), data.DateModifiedUT.ToDate());
            EntityStatus status = EnsureStatus(obj, SyncDirection.Import);

            return status;
        }
        public override void MapBucketImport(WCProductWithVariantEntityBucket bucket, IMappedEntity existing)
        {
            MappedTemplateItem obj = bucket.Product;

            ProductData data = obj.Extern;
            // Following lines added because a stock items and non-stock item processors also have this tax category resolution, 
            // but currently there are not importing processes being used to test this code. We might still need this in future.

            TemplateItems impl = obj.Local = new TemplateItems();
            impl.Custom = GetCustomFieldsForImport();

            //Product
            impl.InventoryID = GetEntityKey(PX.Objects.IN.InventoryAttribute.DimensionName, data.Name).ValueField();
            impl.Description = data.Name.ValueField();
            impl.ItemClass = obj.LocalID == null || existing?.Local == null ? PX.Objects.IN.INItemClass.PK.Find(this, GetBindingExt<BCBindingExt>().StockItemClassID)?.ItemClassCD.ValueField() : null;
            impl.DefaultPrice = data.PriceInDecimal.ValueField();
            //impl.TaxCategory = tax;

            foreach (var cat in data.Categories)
            {
                INCategory incategory = PXSelectJoin<INCategory,
                LeftJoin<BCSyncStatus, On<INCategory.noteID, Equal<BCSyncStatus.localID>>>,
                Where<BCSyncStatus.connectorType, Equal<Current<BCEntity.connectorType>>,
                    And<BCSyncStatus.bindingID, Equal<Current<BCEntity.bindingID>>,
                    And<BCSyncStatus.entityType, Equal<Current<BCEntity.entityType>>,
                    And<BCSyncStatus.externID, Equal<Required<BCSyncStatus.externID>>>>>>>.Select(this, cat);

                if (incategory == null || incategory.CategoryID == null) throw new PXException(BCMessages.CategoryNotSyncronizedForItem, data.Name);

                impl.Categories.Add(new CategoryStockItem() { CategoryID = incategory.CategoryID.ValueField() });
            }
        }
        public override void SaveBucketImport(WCProductWithVariantEntityBucket bucket, IMappedEntity existing, string operation)
        {
            MappedTemplateItem obj = bucket.Product;

            if (existing?.Local != null) obj.Local.InventoryID = ((TemplateItems)existing.Local).InventoryID.Value.SearchField();

            TemplateItems impl = cbapi.Put(obj.Local, obj.LocalID);

            bucket.Product.AddLocal(impl, impl.SyncID, impl.SyncTime);
            UpdateStatus(obj, operation);
        }

        #endregion

        #region Export
        public override IEnumerable<MappedTemplateItem> PullSimilar(ILocalEntity entity, out string uniqueField)
        {
            List<ProductData> datas = PullSimilar(((TemplateItems)entity)?.Description?.Value, ((TemplateItems)entity)?.InventoryID?.Value, out uniqueField);
            return datas == null ? null : datas.Select(data => new MappedTemplateItem(data, data.Id.ToString(), data.DateModifiedUT.ToDate()));
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

        public override void FetchBucketsForExport(DateTime? minDateTime, DateTime? maxDateTime, PXFilterRow[] filters)
        {
            TemplateItems item = new TemplateItems()
            {
                InventoryID = new StringReturn(),
                IsStockItem = new BooleanReturn(),
                Matrix = new List<MatrixItems>() { new MatrixItems() { InventoryID = new StringReturn() } },
                Categories = new List<CategoryStockItem>() { new CategoryStockItem() { CategoryID = new IntReturn() } },
                ExportToExternal = new BooleanReturn()
            };
            IEnumerable<TemplateItems> impls = cbapi.GetAll(item, minDateTime, maxDateTime, filters);

            if (impls != null && impls.Count() > 0)
            {
                int countNum = 0;
                List<IMappedEntity> mappedList = new List<IMappedEntity>();
                foreach (TemplateItems impl in impls)
                {
                    IMappedEntity obj = new MappedTemplateItem(impl, impl.SyncID, impl.SyncTime);

                    mappedList.Add(obj);
                    countNum++;
                    if (countNum % BatchFetchCount == 0 || countNum == impls.Count())
                    {
                        ProcessMappedListForExport(ref mappedList);
                    }
                }
            }
        }

        public override EntityStatus GetBucketForExport(WCProductWithVariantEntityBucket bucket, BCSyncStatus syncstatus)
        {
            TemplateItems impl = cbapi.GetByID<TemplateItems>(syncstatus.LocalID, GetCustomFieldsForExport());
            if (impl == null) return EntityStatus.None;

            impl.AttributesDef = new List<AttributeDefinition>();
            impl.AttributesValues = new List<AttributeValue>();
            int? inventoryID = null;
            foreach (PXResult<CSAttribute, CSAttributeGroup, INItemClass, InventoryItem> attributeDef in PXSelectJoin<CSAttribute,
               InnerJoin<CSAttributeGroup, On<CSAttributeGroup.attributeID, Equal<CSAttribute.attributeID>>,
               InnerJoin<INItemClass, On<INItemClass.itemClassID, Equal<CSAttributeGroup.entityClassID>>,
               InnerJoin<InventoryItem, On<InventoryItem.itemClassID, Equal<INItemClass.itemClassID>>>>>,
              Where<InventoryItem.isTemplate, Equal<True>,
              And<InventoryItem.noteID, Equal<Required<InventoryItem.noteID>>,
              And<CSAttribute.controlType, Equal<Required<CSAttribute.controlType>>,
              And<CSAttributeGroup.isActive, Equal<True>,
              And<CSAttributeGroup.attributeCategory, Equal<CSAttributeGroup.attributeCategory.variant>
              >>>>>>.Select(this, impl.Id, 2))
            {
                AttributeDefinition def = new AttributeDefinition();
                var inventory = (InventoryItem)attributeDef;
                inventoryID = inventory.InventoryID;
                var attribute = (CSAttribute)attributeDef;
                def.AttributeID = attribute.AttributeID.ValueField();
                def.Description = attribute.Description.ValueField();
                def.NoteID = attribute.NoteID.ValueField();
                def.Values = new List<AttributeDefinitionValue>();
                var attributedetails = PXSelect<CSAttributeDetail, Where<CSAttributeDetail.attributeID, Equal<Required<CSAttributeDetail.attributeID>>>>.Select(this, def.AttributeID.Value);
                foreach (CSAttributeDetail value in attributedetails)
                {
                    AttributeDefinitionValue defValue = new AttributeDefinitionValue();
                    defValue.NoteID = value.NoteID.ValueField();
                    defValue.ValueID = value.ValueID.ValueField();
                    defValue.Description = value.Description.ValueField();
                    defValue.SortOrder = value.SortOrder.ToInt().ValueField();
                    def.Values.Add(defValue);
                }

                if (def != null)
                    impl.AttributesDef.Add(def);
            }


            foreach (PXResult<InventoryItem, CSAnswers> attributeDef in PXSelectJoin<InventoryItem,
               InnerJoin<CSAnswers, On<InventoryItem.noteID, Equal<CSAnswers.refNoteID>>>,
              Where<InventoryItem.templateItemID, Equal<Required<InventoryItem.templateItemID>>
              >>.Select(this, inventoryID))
            {
                var inventory = (InventoryItem)attributeDef;
                var attribute = (CSAnswers)attributeDef;
                AttributeValue def = new AttributeValue();
                def.AttributeID = attribute.AttributeID.ValueField();
                def.NoteID = inventory.NoteID.ValueField();
                def.InventoryID = inventory.InventoryCD.ValueField();
                def.Value = attribute.Value.ValueField();
                impl.AttributesValues.Add(def);
            }
            impl.InventoryItemID = inventoryID;

            MappedTemplateItem obj = bucket.Product = bucket.Product.Set(impl, impl.SyncID, impl.SyncTime);
            EntityStatus status = EnsureStatus(obj, SyncDirection.Export);

            if (obj.Local.Categories != null)
            {
                foreach (CategoryStockItem item in obj.Local.Categories)
                {
                    BCSyncStatus result = PXSelectJoin<BCSyncStatus,
                        InnerJoin<INCategory, On<INCategory.noteID, Equal<BCSyncStatus.localID>>>,
                        Where<BCSyncStatus.connectorType, Equal<Current<BCEntity.connectorType>>,
                            And<BCSyncStatus.bindingID, Equal<Current<BCEntity.bindingID>>,
                            And<BCSyncStatus.entityType, Equal<Required<BCEntity.entityType>>,
                            And<INCategory.categoryID, Equal<Required<INCategory.categoryID>>>>>>>
                        .Select(this, BCEntitiesAttribute.SalesCategory, item.CategoryID.Value);
                    if (result != null && result.ExternID != null && result.LocalID != null) continue;

                    BCItemSalesCategory implCat = cbapi.Get(new BCItemSalesCategory() { CategoryID = new IntSearch() { Value = item.CategoryID.Value } });
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

        public override void MapBucketExport(WCProductWithVariantEntityBucket bucket, IMappedEntity existing)
        {
            MappedTemplateItem obj = bucket.Product;

            TemplateItems impl = obj.Local;

            //Existing item and store Availability Policies
            BCBindingExt bCBindingExt = GetBindingExt<BCBindingExt>();
            string storeAvailability = BCItemAvailabilities.Convert(bCBindingExt.Availability);
            string currentAvail = obj.Extern?.StockStatus;

            ProductData data = obj.Extern = new ProductData();

            if (impl.Matrix == null || impl.Matrix?.Count == 0)
            {
                throw new PXException(BCMessages.NoMatrixCreated);
            }
            var regEx = new Regex(InvalidSKUPattern);
            if (regEx.IsMatch(impl.InventoryID.Value))
            {
                throw new PXException(WCMessages.InvalidSKU, regEx.Match(impl.InventoryID.Value), impl.InventoryID.Value);
            }

            data.Name = impl.Description?.Value;
            data.Description = ClearHTMLContent(impl.Content?.Value);
            data.Type = ProductTypes.Variable;
            data.Virtual = impl.IsStockItem?.Value == false;
            data.Price = data.RegularPrice = impl.DefaultPrice.Value.ToString();
            data.ShortDescription = impl.MetaDescription?.Value;
            data.Weight = impl.DimensionWeight.Value.ToString();
            data.Sku = impl.InventoryID?.Value;
            data.Tags = impl.MetaKeywords?.Value?.Split(',').Select(s => new TagData { Name = s }).ToList();
            data.TaxClass = taxClasses?.Find(i => i.Name.Equals(base.GetSubstituteLocalByExtern(bCBindingExt.TaxCategorySubstitutionListID,
                                                                                                impl.TaxCategory?.Value,
                                                                                                string.Empty)))?.Name;

            if (impl.CustomURL?.Value != null)
                data.ExternalUrl = impl.CustomURL?.Value;

            if (impl.Attributes?.Count() > 0)
            {
                data.Attributes = new List<AttributeData>();
                foreach (var attribute in impl.Attributes)
                {
                    GenerateAttributeData(data, attribute);
                }
            }


            string visibility = impl?.Visibility?.Value;
            if (visibility == null || visibility == BCCaptions.StoreDefault) visibility = BCItemVisibility.Convert(bCBindingExt.Visibility);
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
            Boolean isItemActive = !(impl.ItemStatus?.Value == PX.Objects.IN.Messages.Inactive
                || impl.ItemStatus?.Value == PX.Objects.IN.Messages.ToDelete
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
            else data.StockStatus = currentAvail;

            if (impl.AttributesDef?.Count > 0)
            {
                foreach (var item in obj.Local.Matrix)
                {
                    var def = obj.Local.AttributesValues.Where(x => x.NoteID.Value == item.Id).ToList();

                    foreach (var attrvalue in def)
                    {
                        var attribute = obj.Local.AttributesDef.FirstOrDefault(x => x.AttributeID.Value == attrvalue.AttributeID.Value);
                        if (attribute == null) continue;
                        var value = attribute.Values.FirstOrDefault(y => y.ValueID.Value == attrvalue.Value.Value);
                        if (value == null) continue;
                        AttributeData productsOptionData = data.Attributes.FirstOrDefault(x => x.Name.Equals(attribute.Description?.Value, StringComparison.InvariantCultureIgnoreCase));
                        if (productsOptionData == null)
                        {
                            productsOptionData = new AttributeData();
                            productsOptionData.Name = attribute.AttributeID?.Value;
                            data.Attributes.Add(productsOptionData);
                        }

                        if (!productsOptionData.Options.Any(x => x.Equals(value.Description?.Value ?? value.ValueID?.Value)))
                        {
                            productsOptionData.Options.Add(value.Description?.Value ?? value.ValueID?.Value);
                        }
                        productsOptionData.Variation = true;
                    }
                }
            }

            foreach (PXResult<INCategory, INItemCategory, InventoryItem, BCSyncStatus> result in PXSelectJoin<INCategory,
                    InnerJoin<INItemCategory, On<INItemCategory.categoryID, Equal<INCategory.categoryID>>,
                    InnerJoin<InventoryItem, On<InventoryItem.inventoryID, Equal<INItemCategory.inventoryID>>,
                    LeftJoin<BCSyncStatus, On<INCategory.noteID, Equal<BCSyncStatus.localID>>>>>,
                    Where<BCSyncStatus.connectorType, Equal<Current<BCEntity.connectorType>>,
                        And<BCSyncStatus.bindingID, Equal<Current<BCEntity.bindingID>>,
                        And<BCSyncStatus.entityType, Equal<Required<BCEntity.entityType>>,
                        And<InventoryItem.noteID, Equal<Required<InventoryItem.noteID>>>>>>>
                            .Select(this, BCEntitiesAttribute.SalesCategory, obj.LocalID))
            {
                BCSyncStatus status = result.GetItem<BCSyncStatus>();
                if (status == null || status.ExternID == null)
                    throw new PXException(BCMessages.CategoryNotSyncronizedForItem, impl.Description.Value);

                data.Categories.Add(new CategoryData { Id = status.ExternID.ToInt().Value });
            }
            if (data.Categories.Count <= 0)
            {
                String categories = null;
                if (impl.IsStockItem?.Value == false)
                    categories = bCBindingExt.NonStockSalesCategoriesIDs;
                else
                    categories = bCBindingExt.StockSalesCategoriesIDs;

                if (!String.IsNullOrEmpty(categories))
                {
                    Int32?[] categoriesArray = categories.Split(',').Select(c => { return Int32.TryParse(c, out Int32 i) ? (int?)i : null; }).Where(i => i != null).ToArray();

                    foreach (BCSyncStatus status in PXSelectJoin<BCSyncStatus,
                        LeftJoin<INCategory, On<INCategory.noteID, Equal<BCSyncStatus.localID>>>,
                        Where<BCSyncStatus.connectorType, Equal<Current<BCEntity.connectorType>>,
                            And<BCSyncStatus.bindingID, Equal<Current<BCEntity.bindingID>>,
                            And<BCSyncStatus.entityType, Equal<Required<BCEntity.entityType>>,
                            And<INCategory.categoryID, In<Required<INCategory.categoryID>>>>>>>
                            .Select(this, BCEntitiesAttribute.SalesCategory, categoriesArray))
                    {
                        if (status == null || status.ExternID == null) throw new PXException(BCMessages.CategoryNotSyncronizedForItem, impl.Description.Value);

                        if (status != null) data.Categories.Add(new CategoryData { Id = status.ExternID.ToInt().Value });
                    }
                }
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
            {
                if (!string.IsNullOrWhiteSpace(attribute.Value?.Value))
                    item.Options = new List<string> { attribute.Value?.Value ?? string.Empty };
                else
                    item.Options = new List<string>();
            }

            data.Attributes.Add(item);
        }

        public override object GetAttribute(WCProductWithVariantEntityBucket bucket, string attributeID)
        {
            MappedTemplateItem obj = bucket.Product;
            TemplateItems impl = obj.Local;
            return impl.Attributes?.Where(x => string.Equals(x?.AttributeDescription?.Value, attributeID, StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault();

        }

        public override void SaveBucketExport(WCProductWithVariantEntityBucket bucket, IMappedEntity existing, string operation)
        {
            MappedTemplateItem obj = bucket.Product;

            ProductData data = null;
            List<ProductsVariantData> existingList = null;
            try
            {
                ValidateLinks(existing, obj);
                if (obj.ExternID == null)
                    data = productDataProvider.Create(obj.Extern);
                else
                {
                    data = productDataProvider.Update(obj.Extern, obj.ExternID.ToInt().Value);
                    existingList = productVariantDataProvider.GetByParentId(obj.ExternID);
                }
                obj.ClearDetails();
                UpdateProductVariant(obj, data, existingList, existing);

            }
            catch
            {
                throw;
            }

            obj.AddExtern(data, data.Id?.ToString(), data.DateModifiedUT.ToDate());

            UpdateStatus(obj, operation);
        }

        public virtual void ValidateLinks(IMappedEntity existing, MappedTemplateItem obj)
        {
            if (existing != null && (obj.Details == null || obj.Details?.Count() == 0))//only while linking to existing 
            {
                var existingProduct = existing.Extern as ProductData;
                if (existingProduct.Attributes.Count() != obj.Extern.Attributes.Count() || existingProduct.Attributes.Any(x => obj.Extern.Attributes.All(y => !string.Equals(y.Name.Trim(), x.Name?.Trim(), StringComparison.InvariantCultureIgnoreCase))))
                {
                    throw new PXException(WCMessages.OptionsNotMatched, obj.ExternID);

                }
                foreach (var option in obj.Extern.Attributes)
                {
                    var existingoption = existingProduct?.Attributes?.FirstOrDefault(x => string.Equals(x.Name.Trim(), option.Name?.Trim(), StringComparison.InvariantCultureIgnoreCase));
                    if (existingoption.Options.Count() != option.Options.Count() || existingoption.Options.Any(a => option.Options.All(b => !string.Equals(b.Trim(), a.Trim(), StringComparison.InvariantCultureIgnoreCase))))
                    {
                        throw new PXException(WCMessages.OptionValuesNotMatched, obj.ExternID);
                    }
                }
            }
        }


        public virtual void UpdateProductVariant(MappedTemplateItem obj, ProductData data, List<ProductsVariantData> existingList, IMappedEntity existing)
        {
            var existingIds = existingList == null ? new List<int>() : existingList.Select(s => s.Id.Value).ToList();
            List<ProductsVariantData> listToCreate = new List<ProductsVariantData>();
            List<ProductsVariantData> listToUpdate = new List<ProductsVariantData>();
            List<int> listToDelete = new List<int>();
            string storeAvailability = BCItemAvailabilities.Convert(GetBindingExt<BCBindingExt>().Availability);
            string storeVisibility = BCItemVisibility.Convert(GetBindingExt<BCBindingExt>().Visibility);

            List<ProductsVariantData> variantData = new List<ProductsVariantData>();
            var results = PXSelectJoin<InventoryItem,
            LeftJoin<INItemXRef, On<InventoryItem.inventoryID, Equal<INItemXRef.inventoryID>,
                And<Where2<Where<INItemXRef.alternateType, Equal<INAlternateType.vPN>,
                                And<INItemXRef.bAccountID, Equal<InventoryItem.preferredVendorID>>>,
                     Or<INItemXRef.alternateType, Equal<INAlternateType.barcode>>>>>>, Where<InventoryItem.templateItemID, Equal<Required<InventoryItem.templateItemID>>>>.
                     Select(this, obj.Local.InventoryItemID).Cast<PXResult<InventoryItem, INItemXRef>>()?.ToList();

            List<string> errors = new List<string>();

            foreach (var item in obj.Local.Matrix.Where(x => IsVariantActive(x)))
            {
                var regEx = new Regex(InvalidSKUPattern);
                if (regEx.IsMatch(item.InventoryID.Value))
                {
                    errors.Add(string.Format(WCMessages.InvalidSKU, item.InventoryID.Value));
                    continue;
                }

                var existingItem = existingList?.FirstOrDefault(x => x.Sku == item.InventoryID.Value);

                var matchedInventoryItems = results?.Where(x => x.GetItem<InventoryItem>().InventoryCD.Trim() == item.InventoryID?.Value?.Trim()).ToList();
                InventoryItem matchedItem = matchedInventoryItems.FirstOrDefault()?.GetItem<InventoryItem>();

                ProductsVariantData variant = new ProductsVariantData();
                variant.LocalID = item.Id;
                if (existingItem != null) variant.Id = existingItem.Id;
                variant.Purchasable = IsVariantPurchasable(item, matchedItem);
                variant.Sku = item.InventoryID.Value;
                variant.Price = item.DefaultPrice.Value.ToString();
                variant.RegularPrice = item.DefaultPrice.Value.ToString();
                variant.Description = item.Description.Value;

                if (obj.Local.IsStockItem?.Value == true)
                {
                    StockItem impl = cbapi.GetByID<StockItem>(matchedItem.NoteID, GetCustomFieldsForExport());
                    //variant.StockQuantity = impl?.WarehouseDetails == null ? 0 : impl.WarehouseDetails.Sum(s => s.QtyOnHand.Value);

                    string availability = impl?.Availability?.Value;
                    if (availability == null || availability == BCCaptions.StoreDefault) availability = storeAvailability;
                    if (availability != BCCaptions.DoNotUpdate)
                    {
                        variant.ManageStock = false;
                        variant.StockStatus = StockStatuses.OutOfStock;
                        switch (availability)
                        {
                            case BCCaptions.AvailableTrack:
                                variant.StockStatus = StockStatuses.InStock;
                                variant.ManageStock = true;
                                break;
                            case BCCaptions.AvailableSkip: variant.StockStatus = StockStatuses.InStock; break;
                            case BCCaptions.PreOrder: variant.StockStatus = StockStatuses.OnBackOrder; break;
                            case BCCaptions.Disabled: variant.StockStatus = StockStatuses.OutOfStock; break;

                        }
                    }

                }
                else
                {
                    NonStockItem impl = cbapi.GetByID<NonStockItem>(matchedItem.NoteID, GetCustomFieldsForExport());
                    string availability = impl?.Availability?.Value;
                    if (availability == null || availability == BCCaptions.StoreDefault) availability = storeAvailability;
                    if (availability != BCCaptions.DoNotUpdate)
                    {
                        variant.StockStatus = StockStatuses.InStock;
                        switch (availability)
                        {
                            case BCCaptions.AvailableTrack:
                                variant.StockStatus = StockStatuses.InStock;
                                break;
                            case BCCaptions.AvailableSkip: variant.StockStatus = StockStatuses.InStock; break;
                            case BCCaptions.PreOrder: variant.StockStatus = StockStatuses.OnBackOrder; break;
                            case BCCaptions.Disabled: variant.StockStatus = StockStatuses.OutOfStock; break;

                        }
                    }
                    variant.ManageStock = false;

                }

                variant.Weight = (matchedItem.BaseItemWeight ?? 0) != 0
                    ? matchedItem.BaseItemWeight.ToString()
                    : obj.Local.DimensionWeight?.Value.ToString();

                variant.Attributes = new List<AttributeData>();
                var def = obj.Local.AttributesValues.Where(x => x.NoteID.Value == item.Id).ToList();

                foreach (var value in def)
                {
                    var optionObj = obj.Local.AttributesDef.FirstOrDefault(x => x.AttributeID.Value == value.AttributeID.Value);
                    if (optionObj == null) continue;
                    var optionValueObj = optionObj.Values.FirstOrDefault(y => y.ValueID.Value == value.Value.Value);

                    AttributeData optionValueData = new AttributeData
                    {
                        Name = optionObj.Description?.Value,
                        OrderBy = "name",
                        Option = optionValueObj.Description?.Value ?? optionValueObj.ValueID?.Value ?? string.Empty
                    };
                    variant.Attributes.Add(optionValueData);
                }
                if (existingItem == null)
                {
                    listToCreate.Add(variant);
                    continue;
                }
                else
                {
                    listToUpdate.Add(variant);
                    existingIds.Remove(existingItem.Id.Value);
                    continue;
                }
                
            }
            if (errors.Any())
            {
                throw new PXException(string.Join(Environment.NewLine, errors));
            }

            var varients = new BatchData<ProductsVariantData>
            {
                Create = listToCreate,
                Update = listToUpdate,
                Delete = existingIds
            };
            var result = productVariantDataProvider.UpdateAll(varients, data.Id ?? 0);
            result.Create?.ForEach(f =>
            {
                var current = varients.Create.Single(s =>
                {
                    if (f == null)
                        throw new Exception();
                    if (f.Sku == null)
                        throw new Exception();

                    return string.Equals(s.Sku, f.Sku, StringComparison.InvariantCultureIgnoreCase);
                }
                );
                obj.AddDetail(BCEntitiesAttribute.Variant, current.LocalID, f.Id.ToString());
            });
            result.Update?.ForEach(f =>
            {
                var current = varients.Update.Single(s => string.Equals(s.Sku, f.Sku, StringComparison.InvariantCultureIgnoreCase));
                obj.AddDetail(BCEntitiesAttribute.Variant, current.LocalID, f.Id.ToString());
            });
        }
        #endregion

        public virtual bool IsVariantActive(MatrixItems item)
        {
            return !(item.ItemStatus?.Value == PX.Objects.IN.Messages.Inactive
                     || item.ItemStatus?.Value == PX.Objects.IN.Messages.ToDelete
                     || item.ItemStatus?.Value == PX.Objects.IN.Messages.NoSales);
        }
        public virtual bool IsVariantPurchasable(MatrixItems item, InventoryItem matchedItem)
        {
            return BCItemAvailabilities.Resolve(BCItemAvailabilities.Convert(matchedItem.Availability),
                                                GetBindingExt<BCBindingExt>().Availability) != BCCaptions.Disabled;
        }
    }
}
