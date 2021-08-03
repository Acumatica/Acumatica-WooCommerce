using System;
using System.Collections.Generic;
using System.Linq;
using ACSC.Tests.BigCommerceRest.Rest.Domain.Entities.Products;
using ACSC.Tests.BigCommerceTests.EntityData;
using ACSC.Tests.Custom;
using ACSC.Tests.Entity.Items.StockItems;
using ACSC.Tests.Entity.SalesPrices;
using ACSC.Tests.EntityDataService;
using ACSC.Tests.EntityValidators;
using ACSC.Tests.Extensions.SalesPrices;
using ACSC.Tests.PageVisitors;
using ACSC.Tests.PageVisitors.SalesPrices;
using ACSC.Tests.PageVisitors.TemplateItem;
using ACSC.Tests.TestsProduct;
using ACSC.Tests.Utils;
using BCApiClient.Rest.Domain.Entities.Products;
using BigCommerce.REST.Domain.Entities.Products;
using Core.Log;
using Core.TestExecution;
using PX.QA.Tools;

namespace ACSC.Tests.BigCommerceTests.TestsProduct
{
    public class PositiveBasePriceTest : TestProductBase
    {
        public override void Execute()
        {
            using (TestExecution.CreateTestCaseGroup("Base Price Test"))
            {
                using (TestExecution.CreateTestStepGroup("Step 0 - Preconditions and clearing"))
                {
                    BCClearing(this.GetType());
                    PrepareData();
                }

                using (TestExecution.CreateTestCaseGroup("Step 1 - Create Stock and Matrix Items"))
                {
                    //Create Matrix Items
                    var matrixVisitor = VisitorsManager.GetSingle<ITemplateItemVisitor>(typeof(TemplateItemVisitor));
                    TemplateItemPage.OpenScreen();
                    matrixVisitor.SetData(templateItem);
                    TemplateItemPage.Full(matrixVisitor);

                    //Create Stock Items
                    var itemsToCreate = new List<StockItemEntity>();
                    foreach (var item in stockItems)
                    {
                        StockItemGI.OpenScreen();
                        StockItemGI.ResultsGridHeader.InventoryItem_inventoryCD.Equals(item.InventoryCD);

                        if (StockItemGI.Details.RowsCount() == 0)
                        {
                            itemsToCreate.Add(item);
                        }
                    }

                    if (itemsToCreate.Any())
                    {
                        StockItemPage.OpenScreen();
                        foreach (var item in itemsToCreate)
                        {
                            StockItemPage.OpenScreen();
                            visitor.SetData(item);
                            StockItemPage.Insert();
                            StockItemPage.Full(visitor);
                            StockItemPage.Save();
                            StockItemPage.WarehouseDetails.AddWarehouseDetail();
                            ItemWarehouseDetails.Summary.SiteID.Select("WHOLESALE");
                            ItemWarehouseDetails.Summary.ProductManagerOverride.SetTrue();
                            ItemWarehouseDetails.Save();
                        }
                    }
                }

                using (TestExecution.CreateTestCaseGroup("Step 2 - Create Sales Price"))
                {
                    SalesPricePage.OpenScreen();
                    SalesPricePage.Summary.PriceType.Select(salesPrice.Summary.PriceType);
                    var itemsToCreate = new List<SalesPriceEntityDetails>();
                    foreach (var priceDetail in salesPrice.Details)
                    {
                        SalesPricePage.Details.Columns.InventoryID.Equals(priceDetail.InventoryID);
                        if (SalesPricePage.Details.RowsCount() == 0)
                        {
                            itemsToCreate.Add(priceDetail);
                        }
                        else
                        {
                            var existedItems = SalesPricePage.Get().Details;
                            if (!existedItems.Any(x => IsExistedSalesPrice(x, priceDetail)))
                            {
                                itemsToCreate.Add(priceDetail);
                            }
                        }
                    }

                    if (itemsToCreate.Any())
                    {
                        salesPrice.Details = itemsToCreate;
                        spVisitor.SetData(salesPrice);
                        SalesPricePage.Full(spVisitor);
                        SalesPricePage.Save();
                    }
                }

                using (TestExecution.CreateTestStepGroup("Step 3 - Export Data to BC"))
                {
                    FetchDataPage.FetchData(store, FetchMode.Reconciliation, Entities.StockItem, Entities.TemplateItem, Entities.SalesCategory);

                    ProcessDataPage.OpenScreen();
                    ProcessDataPage.SetProcessFilter(Stores.BigCommerce, new[] { Statuses.Pending }, Entities.SalesCategory);
                    ProcessDataPage.ProcessAll();
                    SetManualSyncListByLocalId(Entities.StockItem, stockItems.Select(x => x.Description).ToList());
                    ManualSyncByLocalId(Entities.TemplateItem, templateItem.Description);
                    FetchDataPage.FetchData(store, FetchMode.Reconciliation, Entities.BaseSalesPrice);
                    SetManualSyncListByLocalId(Entities.BaseSalesPrice, salesPrice.Details.Select(x => x.Description).Distinct().ToList());
                }

                using (TestExecution.CreateTestStepGroup("Step 4 - Verify Export Process Success in Acumatica."))
                {
                    VerifySyncSuccessInAcumatica(stockItems);
                    VerifySyncSuccessInAcumatica(templateItem);
                    //verify sales prices
                    SyncStatus.OpenScreen();
                    SyncStatus.SetVerifyFilter(Entities.BaseSalesPrice, Statuses.Synchronized, store);
                    foreach (var item in salesPrice.Details.GroupBy(s => s.Description).Select(x => x.FirstOrDefault()).ToList())
                    {
                        var localID = $"{item.Description}";
                        SyncStatus.DetailsFilter.LocalID.Contains(localID);
                        syncStatus = SyncStatus.Get();

                        EntityComparer.Instance.Validate(GetSyncStatus(localID), syncStatus)
                            .Trace(Messages.ValidateSyncStatusFor(Entities.BaseSalesPrice, item.InventoryID))
                            .IsValid
                            .VerifyEquals(true);
                        string key = syncStatus?.ExternalIds?.FirstOrDefault();
                        if (key != null)
                        {
                            externalIds[key] = item.Description;
                        }
                    }
                }

                using (TestExecution.CreateTestStepGroup("Step 7 - Verify Product List in BigCommerce"))
                {
                    var productDataExList = GetProductDataObj();
                    foreach (var item in externalIds.Where(x => x.Value != templateItem.Description))
                    {
                        var product = bcPoductRestDataProvider.GetByID(int.Parse(item.Key));
                        var bulkProducts = ProductBulkPricingRulesDataProvider.Get(product.Id);
                        product.BulkPricingRules = bulkProducts;
                        EntityComparer.Instance.Validate(productDataExList.FirstOrDefault(x => x.Sku == product.Sku), product)
                            .Trace(Messages.ValidateSyncStatusFor(Entities.StockItem, item.Value))
                            .IsValid
                            .VerifyEquals(true);
                    }
                    //verify variants
                    try
                    {
                        var templateId = externalIds.FirstOrDefault(x => x.Value == templateItem.Description).Key;
                        ProductsVariantData productVariant = ProductVariantsRestDataProvider.Get(templateId).FirstOrDefault(x => x.Sku == "SHIRT    -Red  -S");
                        productVariant.HasValue().VerifyEquals(true, "Matrix Item exported").Assert();
                        var variantBulkPrice = ProductBulkPricingRulesDataProvider.Get(productVariant?.Id ?? default);
                    }
                    catch (Exception e)
                    {
                        Log.Error(e.Message);
                       
                    }
                   
                    
                }

                using (TestExecution.CreateTestStepGroup("Step 8 - Save ID"))
                {
                    SaveID(this.GetType());
                }
            }
        }

        private void PrepareData()
        {
            BigCommerceStore.ActivateEntity(new []{Entities.TemplateItem, Entities.CustomerPriceClass});
            store = Stores.BigCommerce;
            ConfigureInventoryAutoNumbering();
            attributes = DataService.GetAttributes(BcDataFilePath.AttributesBasePriceTest);
            stockItems = DataService.GetStockItemsEntity(BcDataFilePath.BasePriceTestCreateStockItems);
            templateItem = DataService.GetTemplateItem(BcDataFilePath.BasePriceTestCreateTemplateItems);
            itemClass = DataService.GetItemClassEntity(BcDataFilePath.ItemClassBasePriceTest);
            salesPrice = DataService.GetSalesPriceEntity(BcDataFilePath.PositiveSalesPriceBasePriceTest);
            var row = salesPrice.Details.FirstOrDefault(x => x.ExpirationDate.HasValue());
            if (row != null) row.ExpirationDate = DateTime.Today;
            CreateAttributes(attributes);
            CreateItemClass(itemClass);
        }

        private List<ProductData> GetProductDataObj()
        {

            return new List<ProductData>
            {
                new ProductData
                {
                    Name = "Test Item 1",
                    Sku = "TEST-ITEM1",
                    SalePrice = 500m
                },
                new ProductData
                {
                    Name = "Test Item 2",
                    Sku = "TEST-ITEM2",
                    SalePrice = 400m
                },
                new ProductData
                {
                    Name = "Test Item 3",
                    Sku = "TEST-ITEM3",
                    SalePrice = 400m,

                    BulkPricingRules = new List<ProductsBulkPricingRulesData>
                    {
                        new ProductsBulkPricingRulesData
                        {
                            QuantityMin = 2,
                            Amount = 300,
                            Type = "fixed"
                        },
                        new ProductsBulkPricingRulesData
                        {
                            QuantityMin = 3,
                            Amount = 200,
                            Type = "fixed"
                        }
                    }
                },
                new ProductData
                {
                    Name = "Test Item 4",
                    Sku = "TEST-ITEM4",
                    Price = 500m
                },
                new ProductData
                {
                    Name = "Test Item 5",
                    Sku = "TEST-ITEM5",
                    Price = 500m
                }
            };
        }
    }
}