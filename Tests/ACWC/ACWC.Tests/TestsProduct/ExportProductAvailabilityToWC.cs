using ACSC.Tests.Custom;
using ACSC.Tests.Entity.Items.NonStockItems;
using ACSC.Tests.Entity.Items.StockItems;
using ACSC.Tests.EntityData;
using ACSC.Tests.EntityDataService;
using ACSC.Tests.EntityValidators;
using ACSC.Tests.Extensions;
using ACSC.Tests.PageVisitors;
using ACSC.Tests.PageVisitors.NonStockItem;
using ACSC.Tests.PageVisitors.StockItem;
using ACSC.Tests.ShopifyRest;
using Core.Log;
using Core.TestExecution;
using PX.QA.Tools;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ACSC.Tests.TestsProduct
{
    public class ExportProductAvailabilityToWC : TestProductBase
    {
        int randNum;

        public override void Execute()
        {
            List<StockItemEntity> stockItemsExtList;
            ACWooCommerceStore storesPage = new ACWooCommerceStore();

            using (TestExecution.CreateTestCaseGroup("Export the Product Availability to WC"))
            {
                using (TestExecution.CreateTestStepGroup("Step 0 - Preconditions and clearing"))
                {
                    Clearing(this.GetType());

                    Random rand = new Random();
                    randNum = rand.Next(000, 999);

                    nonStockItemExtList = DataService.GetNonStockItems(DataFilePath.ExportProductAvailabilityToSPNonStockItems);
                    PrepareDataNonStockItem(nonStockItemExtList);

                    store = Stores.WooCommerce;
                    ConnectorEntity.OpenScreen();
                    ConnectorEntity.SetConnectorSettings(Entities.StockItem, store: store);
                    ConnectorEntity.ClearSync();
                    ConnectorEntity.DeleteConfirmationPanel.EntityName.Type(Entities.StockItem);
                    ConnectorEntity.DeleteConfirmationPanel.Continue();

                    storesPage.OpenScreen();
                    storesPage.StoreSettings.Availability.Select(Statuses.DefaultAvailability);
                    storesPage.StoreSettings.NotAvailMode.Select(Statuses.WhenQtyUnavailable);
                    storesPage.StoreSettings.AvailabilityCalcRule.Select("Available");
                    storesPage.StoreSettings.WarehouseMode.Select(Statuses.All);
                   // storesPage.StoreSettings.RefundAmountItemID.Type("ADVERT");
                   // storesPage.StoreSettings.ReasonCode.Select("INISSUE");
                    storesPage.Save();
                }

                using (TestExecution.CreateTestStepGroup("Step 1 - Identify Stock Items in Acumatica"))
                {
                    StockItemGI.OpenScreen();
                    stockItemGIExtList = DataService.GetStockItemsGI(DataFilePath.ExportProductAvailabilityToSPEntity);
                    var itemsToCreate = new List<string>();
                    foreach (var stockItemExt in stockItemGIExtList)
                    {
                        stockItemExt.InventoryCD = string.Join(string.Empty, randNum, stockItemExt.InventoryCD);
                        stockItemExt.Description = string.Join(string.Empty, randNum, stockItemExt.Description);

                        StockItemGI.ResultsGridHeader.InventoryItem_inventoryCD.Equals(stockItemExt.InventoryCD);
                        if (StockItemGI.Details.RowsCount() == 0)
                        {
                            itemsToCreate.Add(stockItemExt.InventoryCD);
                        }
                    }

                    PrepareData(itemsToCreate);
                }

                using (TestExecution.CreateTestStepGroup("Step 2 - Export Stock Items to SP"))
                {
                    FetchDataPage.FetchData(Stores.WooCommerce, FetchMode.Incremental, Entities.StockItem);
                    SetManualSyncListByLocalId(Entities.StockItem, stockItemGIExtList.Select(x => x.Description).ToList());
                    FetchDataPage.FetchData(Stores.WooCommerce, FetchMode.Incremental, Entities.ProductAvailability);
                    SetManualSyncListByLocalId(Entities.ProductAvailability, stockItemGIExtList.Select(x => x.Description).ToList());
                }

                using (TestExecution.CreateTestStepGroup("Step 3 - Verify Export Process Success in Acumatica."))
                {
                    stockItemsExtList = GetQty();
                    VerifySyncSuccessInAcumatica(stockItemsExtList);
                }

                using (TestExecution.CreateTestStepGroup("Step 4 - Set zero Inventory quantity in Shopify"))
                {
                    var productDataProvider = WooCommerceApiService.Instance.ProductRestDataProvider;

                    var productsSP = productDataProvider.GetAll();

                    var productsExt = DataService.GetStockItems(DataFilePath.ExportProductAvailabilityToSP);

                    foreach (var productExt in productsExt)
                    {
                        productExt.ProductName = string.Join(string.Empty, randNum, productExt.ProductName);
                        productExt.Variants[0].Sku = string.Join(string.Empty, randNum, productExt.Variants[0].Sku);

                        var productSP = productsSP.Find(x =>
                            x.ProductName == productExt.ProductName && x.Variants[0].Sku == productExt.Variants[0].Sku);

                        if (productSP != null && productSP.Variants[0].InventoryQuantity != 0)
                        {
                            productSP.Variants[0].InventoryQuantity = 0;
                            productDataProvider.Update(productSP);
                        }

                        productSP = null;
                    }
                }

                using (TestExecution.CreateTestStepGroup("Step 5 - Verify Product List in Shopify"))
                {
                    var stockItemExts = DataService.GetStockItems(DataFilePath.ExportProductAvailabilityToSP);

                    foreach (var item in stockItemExts)
                    {
                        item.ProductName = string.Join(string.Empty, randNum, item.ProductName);
                        item.Variants[0].Sku = string.Join(string.Empty, randNum, item.Variants[0].Sku);
                    }

                    foreach (var item in externalIds)
                    {
                        var stockItemExt = stockItemExts.FirstOrDefault(c => c.ProductName == item.Value);
                        var stockItem = productRestDataProvider.GetByID(item.Key);
                        EntityComparer.Instance.Validate(stockItemExt, stockItem)
                            .Trace(Messages.ValidateSyncStatusFor(Entities.StockItem, item.Value));
                    }
                }

                using (TestExecution.CreateTestStepGroup("Step 6 - Change PA Sync settings"))
                {
                    storesPage.OpenScreen();
                    storesPage.StoreSettings.Availability.Select(Statuses.DefaultAvailability);
                    storesPage.StoreSettings.NotAvailMode.Select("Do Nothing");
                    storesPage.StoreSettings.AvailabilityCalcRule.Select("Available");
                    storesPage.StoreSettings.WarehouseMode.Select(Statuses.All);
                    storesPage.Save();
                }

                using (TestExecution.CreateTestStepGroup("Step 7 - Create and release receipt for MAIN Warehouse"))
                {
                    var itemsEx = DataService.GetStockItemsEntity(DataFilePath.ExportProductAvailabilityToSPEntity);

                    foreach (var item in itemsEx)
                    {
                        item.InventoryCD = string.Join(string.Empty, randNum, item.InventoryCD);
                        item.Description = string.Join(string.Empty, randNum, item.Description);

                        ReceiptPage.CreateReceipt(item.InventoryCD, "MAIN", 10);
                    }
                }

                using (TestExecution.CreateTestStepGroup("Step 8 - Export Product Availability to SP"))
                {
                    FetchDataPage.FetchData(Stores.WooCommerce, FetchMode.Full, Entities.StockItem,
                        Entities.ProductAvailability);
                    SetManualSyncListByLocalId(Entities.StockItem,
                        stockItemsExtList.Select(x => x.Description).ToList());
                    SetManualSyncListByLocalId(Entities.ProductAvailability,
                        stockItemsExtList.Select(x => x.Description).ToList());
                }

                using (TestExecution.CreateTestStepGroup("Step 9 - Verify Export Process Success in Acumatica"))
                {
                    VerifySyncSuccessInAcumatica(stockItemsExtList, Entities.ProductAvailability);
                }

                //using (TestExecution.CreateTestStepGroup("Step 10 - Verify Product List in WooCommerce"))
                //{
                //    foreach (var item in externalIds)
                //    {
                //        //if (stockItemsExtList.Find(x => x.Description == item.Value) == null) continue;
                //        var stockItemExt = stockItemsExtList.Find(x => x.Description == item.Value);
                //        var stockItem = productRestDataProvider.GetByID(item.Key);
                //        var tempQty = stockItem.Variants[0].InventoryQuantity.GetValueOrDefault();

                //        bool result = stockItem.Variants[0].InventoryQuantity.GetValueOrDefault() -
                //                      stockItemExt.QtyOnHand.GetValueOrDefault() == 10;

                //        decimal resultQty = stockItemExt.QtyOnHand.GetValueOrDefault() + 10.0m;
                //        stockItem.Variants[0].InventoryQuantity.ToString().VerifyEquals(resultQty);
                //        result.VerifyEquals(true);

                //        if (result)
                //        {
                //            Log.Information("Quantity increased by 10");
                //        }
                //        else
                //        {
                //            Log.Information("Quantity changed incorrectly");
                //        }
                //    }
                //}

                using (TestExecution.CreateTestStepGroup("Step 11 - Create and release receipt for RETAIL Warehouse"))
                {
                    stockItemsExtList = GetQtyRetail();

                    var itemsEx = DataService.GetStockItemsEntity(DataFilePath.ExportProductAvailabilityToSPEntity);

                    foreach (var item in itemsEx)
                    {
                        item.InventoryCD = string.Join(string.Empty, randNum, item.InventoryCD);
                        item.Description = string.Join(string.Empty, randNum, item.Description);

                        ReceiptPage.CreateReceipt(item.InventoryCD, "RETAIL", 20);
                    }
                }

                using (TestExecution.CreateTestStepGroup("Step 12 - Change PA Sync settings"))
                {
                    storesPage.OpenScreen();
                    storesPage.StoreSettings.Availability.Select(Statuses.DefaultAvailability);
                    storesPage.StoreSettings.NotAvailMode.Select(Statuses.WhenQtyUnavailable);
                    storesPage.StoreSettings.AvailabilityCalcRule.Select("Available");
                    storesPage.StoreSettings.WarehouseMode.Select(Statuses.All);
                    //storesPage.WarehousesLocations.ClickAndAddNewRow();
                    //storesPage.WarehousesLocations.Row.SiteID.Select("RETAIL");
                    storesPage.Save();
                }

                using (TestExecution.CreateTestStepGroup("Step 13 - Export Product Availability to SP"))
                {
                    FetchDataPage.FetchData(Stores.WooCommerce, FetchMode.Full, Entities.ProductAvailability);

                    SetManualSyncListByLocalId(Entities.ProductAvailability,
                        stockItemsExtList.Select(x => x.Description).ToList());
                }

                using (TestExecution.CreateTestStepGroup("Step 14 - Verify Export Process Success in Acumatica"))
                {
                    VerifySyncSuccessInAcumatica(stockItemsExtList, Entities.ProductAvailability);
                }

                //using (TestExecution.CreateTestStepGroup("Step 15 - Verify Product List in Shopify"))
                //{
                //    //var stockItemExts = DataService.GetStockItems(DataFilePath.ExportProductAvailabilityToSP);

                //    foreach (var item in externalIds)
                //    {
                //        if (stockItemsExtList.Find(x => x.Description == item.Value) == null) continue;
                //        var stockItemExt = stockItemsExtList.Find(x => x.Description == item.Value);
                //        var stockItem = productRestDataProvider.GetByID(item.Key);

                //        bool result = stockItem.Variants[0].InventoryQuantity.GetValueOrDefault() -
                //                      stockItemExt.QtyOnHand.GetValueOrDefault() == 20;

                //        decimal resultQty = stockItemExt.QtyOnHand.GetValueOrDefault() + 20.0m;
                //        stockItem.Variants[0].InventoryQuantity.ToString().VerifyEquals(resultQty);
                //        result.VerifyEquals(true);

                //        if (result)
                //        {
                //            Log.Information("Quantity increased by 20");
                //        }
                //        else
                //        {
                //            Log.Information("Quantity changed incorrectly");
                //        }
                //    }
                //}

                using (TestExecution.CreateTestStepGroup("Step 16 - Change availaility settings on item level"))
                {
                    StockItemPage.OpenScreen();

                    foreach (var stkItm in stockItemsExtList)
                    {
                        StockItemPage.Summary.InventoryCD.Select(stkItm.InventoryCD);
                        StockItemPage.Tabs.Availability.Select(Statuses.AvailabilityDontTrack);
                        StockItemPage.Save();
                    }
                }

                using (TestExecution.CreateTestStepGroup("Step 17 - Change PA Sync settings"))
                {
                    storesPage.OpenScreen();
                    storesPage.StoreSettings.Availability.Select(Statuses.AvailabilityDontTrack);
                    storesPage.StoreSettings.AvailabilityCalcRule.Select("Available");
                    storesPage.StoreSettings.WarehouseMode.Select(Statuses.All);
                    storesPage.Save();
                }

                using (TestExecution.CreateTestStepGroup("Step 18 - Export PA and SI to WC"))
                {
                    FetchDataPage.FetchData(Stores.WooCommerce, FetchMode.Incremental, Entities.StockItem,
                        Entities.ProductAvailability);
                    SetManualSyncListByLocalId(Entities.StockItem,
                        stockItemsExtList.Select(x => x.Description).ToList());
                    SetManualSyncListByLocalId(Entities.ProductAvailability,
                        stockItemsExtList.Select(x => x.Description).ToList());

                    using (TestExecution.CreateTestStepGroup("Step 19 - Verify Export Process Success in Acumatica"))
                    {
                        VerifySyncSuccessInAcumatica(stockItemsExtList, Entities.ProductAvailability);
                    }

                    //using (TestExecution.CreateTestStepGroup("Step 20 - Verify Product List in WC"))
                    //{
                    //    var stockItemExts = DataService.GetStockItems(DataFilePath.ExportProductAvailabilityToSP);

                    //    foreach (var item in externalIds)
                    //    {
                    //        if (stockItemsExtList.Find(x => x.Description == item.Value) == null) continue;
                    //        var product = productRestDataProvider.GetByID(item.Key);
                    //        var inventoryProvider = WooCommerceApiService.Instance.InventoryItemRestDataProvider;
                    //        var stockItem = inventoryProvider.GetByID(product.Variants[0].InventoryItemId.ToString());
                    //        stockItem.Tracked.VerifyEquals(false);
                    //    }
                    //}

                    using (TestExecution.CreateTestStepGroup("Step 21 - Save ID and restore settings"))
                    {
                        StockItemPage.OpenScreen();

                        foreach (var stkItm in stockItemsExtList)
                        {
                            StockItemPage.Summary.InventoryCD.Select(stkItm.InventoryCD);
                            StockItemPage.Tabs.Availability.Select("Store Default");
                            StockItemPage.Save();
                        }

                        storesPage.OpenScreen();
                        storesPage.StoreSettings.Availability.Select(Statuses.DefaultAvailability);
                        storesPage.StoreSettings.NotAvailMode.Select(Statuses.WhenQtyUnavailable);
                        storesPage.StoreSettings.AvailabilityCalcRule.Select("Available");
                        storesPage.StoreSettings.WarehouseMode.Select(Statuses.All);
                        storesPage.Save();

                        SaveID(this.GetType());
                    }
                }
            }
        }

        private void PrepareDataNonStockItem(List<NonStockItemEntity> itemsToCreate)
        {
            store = Stores.Shopify;
            if (itemsToCreate.Count != 0)
            {
                ConfigureInventoryAutoNumbering();

                itemClass = DataService.GetItemClassEntity(DataFilePath.ExportNonStockItemsToSPItemClass1);
                CreateItemClass(itemClass);

                var visitor = VisitorsManager.GetSingle<INonStockItemVisitor>(typeof(NonStockItemVisitor));
                NonStockItemPage.OpenScreen();
                foreach (var item in itemsToCreate)
                {
                    visitor.SetData(item);
                    NonStockItemPage.Insert();
                    NonStockItemPage.Full(visitor);
                    NonStockItemPage.Save();
                }
            }
        }

        private void PrepareData(List<string> itemsToCreate)
        {
            if (itemsToCreate.Count != 0)
            {
                ConfigureInventoryAutoNumbering();
                warehouse = DataService.GetWarehouseEntity(DataFilePath.WarehouseCreateItem);
                calcRule = DataService.GetAvailCalcRule(DataFilePath.AvailCalcRuleCreateItem);
                itemClass = DataService.GetItemClassEntity(DataFilePath.ExportStockItemToWCCreateItemClass);
                CreateAvailCalcRule(calcRule);
                CreateWarehouse(warehouse);
                CreateItemClass(itemClass);

                var itemsEx = DataService.GetStockItemsEntity(DataFilePath.ExportProductAvailabilityToSPEntity);

                foreach (var item in itemsEx)
                {
                    item.InventoryCD = string.Join(string.Empty, randNum, item.InventoryCD);
                    item.Description = string.Join(string.Empty, randNum, item.Description);
                }

                visitor = VisitorsManager.GetSingle<IStockItemVisitor>(typeof(StockItemVisitor));
                stockItems = itemsEx.Where(x => itemsToCreate.Contains(x.InventoryCD)).ToList();
                StockItemPage.OpenScreen();
                foreach (var item in stockItems)
                {
                    visitor.SetData(item);
                    StockItemPage.Insert();
                    StockItemPage.Full(visitor);
                    StockItemPage.Save();
                }
            }
        }

        private List<StockItemEntity> GetQty()
        {
            var stockItemsExtList = DataService.GetStockItemsEntity(DataFilePath.ExportProductAvailabilityToSPResult);

            StockItemPage.OpenScreen();
            foreach (var item in stockItemsExtList)
            {
                item.InventoryCD = string.Join(string.Empty, randNum, item.InventoryCD);
                item.Description = string.Join(string.Empty, randNum, item.Description);

                StockItemPage.Summary.InventoryCD.Type(item.InventoryCD);

                var rowsCount = StockItemPage.WarehouseDetails.RowsCount();

                item.QtyOnHand = 0;

                for (int i = 1; i <= rowsCount; i++)
                {
                    StockItemPage.WarehouseDetails.SelectRow(i);

                    item.QtyOnHand += decimal.Parse(StockItemPage.WarehouseDetails.Row.INSiteStatusSummary__QtyOnHand.GetValue());
                }
            }
            return stockItemsExtList;
        }

        private List<StockItemEntity> GetQtyRetail()
        {
            var stockItemsExtList = DataService.GetStockItemsEntity(DataFilePath.ExportProductAvailabilityToSPResult);

            StockItemPage.OpenScreen();
            foreach (var item in stockItemsExtList)
            {
                item.InventoryCD = string.Join(string.Empty, randNum, item.InventoryCD);
                item.Description = string.Join(string.Empty, randNum, item.Description);

                StockItemPage.Summary.InventoryCD.Type(item.InventoryCD);

                var rowsCount = StockItemPage.WarehouseDetails.RowsCount();

                for (int i = 1; i <= rowsCount; i++)
                {
                    StockItemPage.WarehouseDetails.SelectRow(i);

                    if (StockItemPage.WarehouseDetails.Row.SiteID.GetValue() == "RETAIL")
                    {
                        item.QtyOnHand = decimal.Parse(StockItemPage.WarehouseDetails.Row.INSiteStatusSummary__QtyOnHand.GetValue());
                        break;
                    }
                }
            }

            return stockItemsExtList;
        }
    }
}
