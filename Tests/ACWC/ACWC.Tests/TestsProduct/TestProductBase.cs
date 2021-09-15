using ACSC.Tests.BigCommerceRest;
using ACSC.Tests.Cleanup;
using ACSC.Tests.Custom;
using ACSC.Tests.Entity.Attribute;
using ACSC.Tests.Entity.Items;
using ACSC.Tests.Entity.Items.NonStockItems;
using ACSC.Tests.Entity.Items.StockItems;
using ACSC.Tests.Entity.Items.TemplateItem;
using ACSC.Tests.Entity.SyncStatus;
using ACSC.Tests.EntityValidators;
using ACSC.Tests.Extensions.CustomerPriceClasses;
using ACSC.Tests.Extensions.NonStockItem;
using ACSC.Tests.Extensions.SalesPrices;
using ACSC.Tests.Extensions.StockItem;
using ACSC.Tests.Extensions.TemplateItems;
using ACSC.Tests.PageVisitors;
using ACSC.Tests.PageVisitors.StockItem;
using ACSC.Tests.ShopifyRest;
using ACSC.Tests.ShopifyRest.Client.DataRepository.Products;
using ACSC.Tests.ShopifyRest.Domain.Entities.Products;
using ACSC.Tests.TestsBase;
using BCApiClient.Rest.Client.DataRepository.Products;
using Core.Core.Browser;
using Core.Log;
using PX.QA.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using ACSC.Tests.BigCommerceRest.Rest.Client.DataRepository.Products;
using ACSC.Tests.Entity.ConnectorEntity;
using ACSC.Tests.Entity.SalesPrices;
using ACSC.Tests.Extensions.ItemWarehouseDetails;
using ACSC.Tests.Extensions.SalesOrder;
using ACSC.Tests.PageVisitors.SalesPrices;
using ProductRestDataProvider = ACSC.Tests.BigCommerceRest.Rest.Client.DataRepository.Products.ProductRestDataProvider;
using ProductVariantRestDataProvider = ACSC.Tests.BigCommerceRest.Rest.Client.DataRepository.Products.ProductVariantRestDataProvider;
using ACSC.Tests.BigCommerceRest.Rest.Client.DataRepository.PriceList;

namespace ACSC.Tests.TestsProduct
{
    public abstract class TestProductBase : TestBase
    {
        protected static ItemWarehouseDetails ItemWarehouseDetails => new ItemWarehouseDetails();
        protected static ACCustomerPriceClassesPage CustomerPriceClassesPage => new ACCustomerPriceClassesPage();
        protected static ACSalesPricePage SalesPricePage => new ACSalesPricePage();
        protected static StockItemsGi StockItemGI => new StockItemsGi();
        protected static StockItem StockItemPage => new StockItem();
        protected static ACTemplateItemGI TemplateItemGI => new ACTemplateItemGI();
        protected static TemplateItem TemplateItemPage => new TemplateItem();
        protected static NonStockItemsGI NonStockItemGI => new NonStockItemsGI();
        protected static NonStockItem NonStockItemPage => new NonStockItem();
        protected static ReceiptIn ReceiptPage => new ReceiptIn();
        
        protected ShopifyRest.Client.DataRepository.Products.ProductRestDataProvider productRestDataProvider;
        protected ProductImageRestDataProvider productImageRestDataProvider;

        protected ProductImagesDataProvider bcProductImageRestDataProvider;
        protected ProductRestDataProvider bcPoductRestDataProvider;
        protected ProductVariantRestDataProvider ProductVariantsRestDataProvider;
        protected ProductBulkPricingRulesDataProvider ProductBulkPricingRulesDataProvider;
        protected PriceListDataProvider PriceListDataProvider;
        protected BigCommerceApiService bcService = BigCommerceApiService.Instance;
        protected SyncStatus syncStatus;

        protected List<AttributeEntity> attributes;
        protected List<StockItemGIRow> stockItemGIExtList;
        protected List<TemplateItemGIRow> templateItemGIExtList;
        protected List<TemplateItemEntityMatrixItemsResult> variantsExt;
        protected TemplateItemGIRow templateItemGI;
        protected Dictionary<string, string> externalIds;
        protected StockItemEntity stockItem;
        protected SalesPriceEntity salesPrices;
        protected SalesPriceEntity salesPrice;
        protected ConnectorEntity connectorEntity;
        protected IStockItemVisitor visitor;
        protected ISalesPriceVisitor spVisitor;

        protected TestProductBase()
        {
            ProductVariantsRestDataProvider = bcService.ProductVariantsRestDataProvider;
            ProductBulkPricingRulesDataProvider = bcService.ProductBulkPricingRulesRestDataProvider;
            PriceListDataProvider = bcService.PriceListRestDataProvider;
            spVisitor = VisitorsManager.GetSingle<ISalesPriceVisitor>(typeof(SalesPriceVisitor));
            visitor = VisitorsManager.GetSingle<IStockItemVisitor>(typeof(StockItemVisitor));
            variantsExt = new List<TemplateItemEntityMatrixItemsResult>();
            salesPrice = new SalesPriceEntity();
            attributes = new List<AttributeEntity>();
            syncStatus = new SyncStatus();
            stockItemGIExtList = new List<StockItemGIRow>(0);
            templateItemGIExtList = new List<TemplateItemGIRow>(0);
            externalIds = new Dictionary<string, string>(0);
            productRestDataProvider = WooCommerceApiService.Instance.ProductRestDataProvider;
            productImageRestDataProvider = WooCommerceApiService.Instance.ProductImageRestDataProvider;
          //  bcPoductRestDataProvider = BigCommerceApiService.Instance.ProductRestDataProvider;
          //  bcProductImageRestDataProvider = BigCommerceApiService.Instance.ProductImageRestDataProvider;
        }
        public override void AfterExecute()
        {
            StockItemGI.LogOut();
            Browser.Stop();
            base.AfterExecute();
        }
        

        protected bool IsExistedSalesPrice(SalesPriceEntityDetails existedItem, SalesPriceEntityDetails etalonItem)
        {
            var isExisted = !(etalonItem.Currency != null && existedItem.Currency != etalonItem.Currency);

            if (etalonItem.Warehouse != null && existedItem.Warehouse != etalonItem.Warehouse)
            {
                isExisted = false;
            }
           
            if (etalonItem.UOM != null && existedItem.UOM != etalonItem.UOM)
            {
                isExisted = false;
            }
            if (etalonItem.PriceType != null && existedItem.PriceType != etalonItem.PriceType)
            {
                isExisted = false;
            }

            if (etalonItem.ExpirationDate != null && existedItem.ExpirationDate!=DateTime.MinValue && existedItem.ExpirationDate!= etalonItem.ExpirationDate)
            {
                isExisted = false;
            }

            if (isExisted)
            {
                isExisted = existedItem.BreakQty == etalonItem.BreakQty && existedItem.Price == etalonItem.Price;
            }

            return isExisted;
        }
        protected virtual void BCClearing(Type type)
        {
            var clenupHelper = CleanupHelper.Instance;
            try
            {
                var data = clenupHelper.Get(type);
                if (data.Any())
                {
                    foreach (var id in data.SelectMany(c => c.IDs))
                    {
                        bcPoductRestDataProvider.Delete(int.Parse(id));
                    }
                    clenupHelper.Clean(type);
                }
            }
            catch (Exception e)
            {
                Log.Error($"Clearing error: {e}");
            }
        }

        protected virtual void Clearing(Type type)
        {
            var clenupHelper = CleanupHelper.Instance;
            try
            {
                var data = clenupHelper.Get(type);
                if (data.Any())
                {
                    foreach (var id in data.SelectMany(c => c.IDs))
                    {
                        productRestDataProvider.Delete(id);
                    }
                    clenupHelper.Clean(type);
                }
            }
            catch (Exception e)
            {
                Log.Error($"Clearing error: {e}");
            }
        }

        protected virtual SyncStatus GetSyncStatus(string localID)
        {
            var syncStatus = new SyncStatus();
            syncStatus.DetailsView.Add(new SyncStatusDetails { LocalID = localID, Status = Statuses.Synchronized });
            return syncStatus;
        }

        protected virtual void SaveID(Type type)
        {
            var cleanupHelper = CleanupHelper.Instance;
            var list = externalIds.Keys.ToList();
            cleanupHelper.Save(type, new ClenupEntity(typeof(ProductData), list));
        }

        #region Sync Status Validation
        protected virtual void VerifySyncSuccessInAcumatica(List<StockItemEntity> items, List<StockItemEntity> notSynced, string entity = Entities.StockItem)
        {
            VerifySyncSuccessInAcumatica(items.Select(x => x as IItem).ToList(), entity, notSynced.Select(y => y as IItem).ToList());
        }

        protected virtual void VerifySyncSuccessInAcumatica(List<IItem> items, string entity, List<IItem> notSynced)
        {
            bool saveID = !(string.Equals(entity, Entities.ProductImage) ||
                            string.Equals(entity, Entities.ProductAvailability));

            SyncStatus.OpenScreen();
            SyncStatus.SetVerifyFilter(entity, Statuses.Synchronized, store);

            foreach (IItem item in items)
            {
                var localID = $"{item.Description}";
                SyncStatus.DetailsFilter.LocalID.Contains(localID);
                syncStatus = SyncStatus.Get();

                EntityComparer.Instance.Validate(GetSyncStatus(localID), syncStatus)
                    .Trace(Messages.ValidateSyncStatusFor(entity, item.InventoryCD))
                    .IsValid
                    .VerifyEquals(true);

                if (saveID)
                {
                    string key = syncStatus?.ExternalIds?.FirstOrDefault();
                    externalIds[key] = item.Description;
                }
            }

            foreach (var localID in notSynced.Select(item => $"{item.Description}"))
            {
                SyncStatus.DetailsFilter.LocalID.Contains(localID);
                syncStatus = SyncStatus.Get();
                if (syncStatus.DetailsView.Any())
                {
                    Log.Error($"Item {localID} should not be synchronized");
                }
            }
        }

        protected virtual void VerifySyncSuccessInAcumatica(List<StockItemEntity> items, string entity = Entities.StockItem)
        {
            VerifySyncSuccessInAcumatica(items.Select(x => x as IItem).ToList(), entity);
        }
        protected virtual void VerifySyncSuccessInAcumatica(List<NonStockItemEntity> items, string entity = Entities.NonStockItem)
        {
            VerifySyncSuccessInAcumatica(items.Select(x => x as IItem).ToList(), entity);
        }
        protected virtual void VerifySyncSuccessInAcumatica(List<TemplateItemEntity> items, string entity = Entities.TemplateItem)
        {
            VerifySyncSuccessInAcumatica(items.Select(x => x as IItem).ToList(), entity);
        }
        protected virtual void VerifySyncSuccessInAcumatica(List<StockItemGIRow> items, string entity = Entities.StockItem)
        {
            VerifySyncSuccessInAcumatica(items.Select(x => x as IItem).ToList(), entity);
        }
        protected virtual void VerifySyncSuccessInAcumatica(List<NonStockItemGIRow> items, string entity = Entities.NonStockItem)
        {
            VerifySyncSuccessInAcumatica(items.Select(x => x as IItem).ToList(), entity);
        }
        protected virtual void VerifySyncSuccessInAcumatica(List<TemplateItemGIRow> items, string entity = Entities.TemplateItem)
        {
            VerifySyncSuccessInAcumatica(items.Select(x => x as IItem).ToList(), entity);
        }
        protected virtual void VerifySyncSuccessInAcumatica(IItem item, string entity = Entities.StockItem)
        {
            VerifySyncSuccessInAcumatica(new List<IItem>() { item }, entity);
        }
        protected virtual void VerifySyncSuccessInAcumatica(TemplateItemEntity item, string entity = Entities.TemplateItem)
        {
            VerifySyncSuccessInAcumatica(new List<IItem>() { item }, entity);
        }
        private void VerifySyncSuccessInAcumatica(List<IItem> items, string entity)
        {
            bool saveID = !(String.Equals(entity, Entities.ProductImage) ||
                            String.Equals(entity, Entities.ProductAvailability));

            SyncStatus.OpenScreen();
            SyncStatus.SetVerifyFilter(entity, Statuses.Synchronized, store);

            foreach (IItem item in items)
            {
                    var localID = $"{item.Description}";
                    SyncStatus.DetailsFilter.LocalID.Contains(localID);
                    syncStatus = SyncStatus.Get();

                    EntityComparer.Instance.Validate(GetSyncStatus(localID), syncStatus)
                                    .Trace(Messages.ValidateSyncStatusFor(localID, item.Description))
                                    .IsValid
                                    .VerifyEquals(true);

                    if (saveID)
                    {
                        string key = syncStatus?.ExternalIds?.FirstOrDefault();
                        externalIds[key] = item.Description;
                    }
            }
        }
        #endregion
    }
}