using ACSC.Tests.EntityData;
using ACSC.Tests.EntityDataService;
using ACSC.Tests.EntityValidators;
using ACSC.Tests.PageVisitors;
using ACSC.Tests.PageVisitors.StockItem;
using ACSC.Tests.ShopifyRest;
using Core.TestExecution;
using PX.QA.Tools;
using System.Collections.Generic;
using System.Linq;
using ACSC.Tests.Custom;

namespace ACSC.Tests.TestsProduct
{
    public class ExportStockItemsToWC : TestProductBase
    {
        public override void Execute()
        {
            using (TestExecution.CreateTestCaseGroup("Export Stock Items from AC to WC"))
            {
                using (TestExecution.CreateTestStepGroup("Step 0 - Clearing"))
                {
                    Clearing(this.GetType());
                }

                using (TestExecution.CreateTestStepGroup("Step 1 - Identify Stock Items in Acumatica"))
                {
                    StockItemGI.OpenScreen();
                    stockItemGIExtList = DataService.GetStockItemsGI(DataFilePath.ExportStockItemToSPGI);
                    var itemsToCreate = new List<string>();

                    foreach (var stockItemExt in stockItemGIExtList)
                    {
                        StockItemGI.ResultsGridHeader.InventoryItem_inventoryCD.Equals(stockItemExt);

                        if (StockItemGI.Details.RowsCount() == 0 || StockItemGI.ResultsGridRow.ItemClass.GetValue() != "STOCKITEM")
                        {
                            itemsToCreate.Add(stockItemExt.InventoryCD);
                        }
                    }

                    PrepareData(itemsToCreate);
                    StockItemGI.OpenScreen();
                    foreach (var stockItemExt in stockItemGIExtList)
                    {
                        StockItemGI.ResultsGridHeader.InventoryItem_inventoryCD.Equals(stockItemExt.InventoryCD);
                        var stockItem = StockItemGI.Get().ResultRows.FirstOrDefault();

                        EntityComparer.Instance.Validate(stockItemExt, stockItem)
                            .Trace("Validate Stock Item")
                            .IsValid
                            .VerifyEquals(true);
                    }
                }

                using (TestExecution.CreateTestStepGroup("Step 2 - Export Stock Items to WC"))
                {
                    FetchDataPage.FetchData(Stores.WooCommerce, FetchMode.Incremental, Entities.StockItem);
                    SetManualSyncListByLocalId(Entities.StockItem, stockItemGIExtList.Select(x => x.Description).ToList());
                }

                using (TestExecution.CreateTestStepGroup("Step 3 - Verify Export Process Success in Acumatica."))
                {
                    VerifySyncSuccessInAcumatica(stockItemGIExtList);
                }

                using (TestExecution.CreateTestStepGroup("Step 4 - Update Stock Item in Acumatica."))
                {
                    stockItem = DataService.GetStockItemsEntity(DataFilePath.ExportStockItemToSPUpdateItem).FirstOrDefault();
                    StockItemPage.OpenScreen();
                    visitor.SetData(stockItem);
                    StockItemPage.Insert();
                    StockItemPage.Full(visitor);
                    StockItemPage.Save();
                }

                using (TestExecution.CreateTestStepGroup("Step 5 - Export Stock Items to WooCommerce"))
                {
                    FetchDataPage.FetchData(store, FetchMode.Incremental, Entities.StockItem);
                    ManualSyncByLocalId(Entities.StockItem, stockItem?.Description);
                }

                using (TestExecution.CreateTestStepGroup("Step 6 - Verify Export Process Success in Acumatica."))
                {
                    VerifySyncSuccessInAcumatica(stockItemGIExtList?.LastOrDefault());
                }

                using (TestExecution.CreateTestStepGroup("Step 7 - Verify Product List in WooCommerce"))
                {
                    var productDataProvider = WooCommerceApiService.Instance.ProductRestDataProvider;
                    var stockItemExts = DataService.GetStockItems(DataFilePath.ExportStockItemToSPProductData);
                    foreach (var item in externalIds)
                    {
                        var stockItemExt = stockItemExts.FirstOrDefault(c => c.ProductName == item.Value);
                        var stockItem = productDataProvider.GetByID(item.Key);
                        EntityComparer.Instance.Validate(stockItemExt, stockItem)
                            .Trace(Messages.ValidateSyncStatusFor(Entities.StockItem, item.Value))
                            .IsValid
                            .VerifyEquals(true);

                        //EntityComparer.Instance.Validate(stockItemExt, stockItem)
                        //    .Trace(Messages.ValidateSyncStatusFor(Entities.StockItem, item.Value))
                        //    .IsValid
                        //    .VerifyEquals(true);
                    }
                }

                using (TestExecution.CreateTestStepGroup("Step 8 - Save ID"))
                {
                    SaveID(this.GetType());
                }
            }
        }

        private void PrepareData(List<string> itemsToCreate)
        {
            store = Stores.Shopify;
            ConnectorEntity.RemoveImportExportMappingFiltering(store, Entities.StockItem);
            if (itemsToCreate.Count != 0)
            {
                itemClass = DataService.GetItemClassEntity(DataFilePath.ExportStockItemToSPCreateItemClass);
                warehouse = DataService.GetWarehouseEntity(DataFilePath.WarehouseCreateItem);
                calcRule = DataService.GetAvailCalcRule(DataFilePath.AvailCalcRuleCreateItem);
                ConfigureInventoryAutoNumbering();
                CreateAvailCalcRule(calcRule);
                CreateWarehouse(warehouse);
                CreateItemClass(itemClass);

                var itemsEx = DataService.GetStockItemsEntity(DataFilePath.ExportStockItemToSPCreateItems);
                visitor = VisitorsManager.GetSingle<IStockItemVisitor>(typeof(StockItemVisitor));
                var stockItems = itemsEx.Where(x => itemsToCreate.Contains(x.InventoryCD)).ToList();
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
    }
}