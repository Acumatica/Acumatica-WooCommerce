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
using Core.TestExecution;
using PX.QA.Tools;

namespace ACSC.Tests.BigCommerceTests.TestsProduct
{
    public class NegativeBasePriceTest : TestProductBase
    {
        public override void Execute()
        {
            using (TestExecution.CreateTestCaseGroup("Negative Base Price Test"))
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

                    //Update template item
                    TemplateItemPage.OpenScreen();
                    TemplateItemPage.Summary.InventoryCD.Select(templateItem.InventoryCD);
                    TemplateItemPage.Matrix.Row.Preliminary.SetTrue();
                    TemplateItemPage.CreateMatrixItems();
                    TemplateItemPage.MatrixItemsForCreation.Buttons.Confirmation.Click();
                    //Create Stock Items
                    var itemsToCreate = new List<StockItemEntity>();
                    foreach (var item in stockItems)
                    {
                        StockItemGI.OpenScreen();
                        StockItemGI.ResultsGridHeader.InventoryItem_inventoryCD.Equals(item.InventoryCD);

                        if (StockItemGI.Details.RowsCount() == 0 || StockItemGI.Details.Row.InventoryItem_baseUnit.GetValue() != item.ItemDetails.BaseUnit)
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
                    SalesPricePage.Details.ResetColumnFilters();
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
                    FetchDataPage.FetchData(store, FetchMode.Reconciliation, Entities.StockItem, Entities.SalesCategory);
                    ProcessDataPage.OpenScreen();
                    ProcessDataPage.SetProcessFilter(Stores.BigCommerce, new[] { Statuses.Pending }, Entities.SalesCategory);
                    ProcessDataPage.ProcessAll();
                    SetManualSyncListByLocalId(Entities.StockItem, stockItems.Select(x => x.Description).ToList());
                   
                    FetchDataPage.FetchData(store, FetchMode.Reconciliation, Entities.BaseSalesPrice);
                    SetManualSyncListByLocalId(Entities.BaseSalesPrice, salesPrice.Details.Select(x => x.Description).Distinct().ToList());
                }

                using (TestExecution.CreateTestStepGroup("Step 4 - Verify Export Process in Acumatica."))
                {
                    VerifySyncSuccessInAcumatica(stockItems);
                    VerifySyncSuccessInAcumatica(templateItem);
                    //verify sales prices
                    SyncStatus.OpenScreen();
                    SyncStatus.SetVerifyFilter(Entities.BaseSalesPrice, Statuses.Failed, store);

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

                using (TestExecution.CreateTestStepGroup("Step 8 - Save ID"))
                {
                    SaveID(this.GetType());
                }
            }
        }

        private void PrepareData()
        {
            store = Stores.BigCommerce;
            BigCommerceStore.ActivateEntity(new []{Entities.TemplateItem, Entities.CustomerPriceClass});
            ConfigureInventoryAutoNumbering();
            attributes = DataService.GetAttributes(BcDataFilePath.AttributesBasePriceTestNegative);
            stockItems = DataService.GetStockItemsEntity(BcDataFilePath.BasePriceTestNegativeCreateStockItems);
            templateItem = DataService.GetTemplateItem(BcDataFilePath.BasePriceTestCreateTemplateItems);
            itemClass = DataService.GetItemClassEntity(BcDataFilePath.ItemClassBasePriceTest);
            salesPrice = DataService.GetSalesPriceEntity(BcDataFilePath.NegativeSalesPriceBasePriceTest);
            CreateAttributes(attributes);
            UpdateAttributes(attributes);
            CreateItemClass(itemClass);
        }
    }
}