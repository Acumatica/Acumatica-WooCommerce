using ACSC.Tests.BigCommerceTests.EntityData;
using ACSC.Tests.Custom;
using ACSC.Tests.EntityData;
using ACSC.Tests.EntityDataService;
using ACSC.Tests.EntityValidators;
using ACSC.Tests.PageVisitors;
using ACSC.Tests.PageVisitors.StockItem;
using ACSC.Tests.TestsProduct;
using Core.Core.Browser;
using Core.Exceptions;
using Core.TestExecution;
using PX.QA.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using Core.Wait;

namespace ACSC.Tests.BigCommerceTests.TestsProduct
{
    public class ConcurrentSyncSingleItem : TestProductBase
    {
        int randNum;

        public override void Execute()
        {
            using (TestExecution.CreateTestCaseGroup("Stock Item: Export Mapping tab"))
            {
                using (TestExecution.CreateTestStepGroup("Step 0 - Preconditions and clearing"))
                {
                   BCClearing(this.GetType());
                }

                using (TestExecution.CreateTestStepGroup("Step 1 - Create Stock Items"))
                {
                    store = Stores.BigCommerce;
                    var itemsToCreate = new List<string>();
                    Random rand = new Random();
                    randNum = rand.Next(000, 999);

                    StockItemGI.OpenScreen();
                    stockItemGIExtList = DataService.GetStockItemsGI(BcDataFilePath.StockItemConcurrentSyncSingleItemGI);

                    var stockItemExt = stockItemGIExtList.FirstOrDefault();
                    stockItemExt.InventoryCD = string.Join(string.Empty, randNum, stockItemExt.InventoryCD);
                    stockItemExt.Description = string.Join(string.Empty, randNum, stockItemExt.Description);

                    StockItemGI.ResultsGridHeader.InventoryItem_inventoryCD.Equals(stockItemExt.InventoryCD);

                    if (StockItemGI.Details.RowsCount() == 0 || StockItemGI.ResultsGridRow.ItemClass.GetValue() != "STOCKITEM")
                    {
                        itemsToCreate.Add(stockItemExt.InventoryCD);
                    }

                    PrepareData(itemsToCreate);
                    StockItemGI.OpenScreen();

                    StockItemGI.ResultsGridHeader.InventoryItem_inventoryCD.Equals(stockItemExt.InventoryCD);
                    var stockItem = StockItemGI.Get().ResultRows.FirstOrDefault();

                    EntityComparer.Instance.Validate(stockItemExt, stockItem)
                        .Trace("Validate Stock Item")
                        .IsValid
                        .VerifyEquals(true);
                }

                using (TestExecution.CreateTestStepGroup("Step 2 - Export Stock Items to BC"))
                {
                    FetchDataPage.FetchData(store, FetchMode.Reconciliation, Entities.SalesCategory);
                    ProcessDataPage.OpenScreen();
                    ProcessDataPage.SetProcessFilter(Stores.BigCommerce, new[] { Statuses.Pending }, Entities.SalesCategory);
                    ProcessDataPage.ProcessAll();

                    FetchDataPage.FetchData(store, FetchMode.Incremental, Entities.StockItem);
                    ProcessDataPage.SetLastOperationProcessFilter(Stores.BigCommerce, new[] { Statuses.Pending },  1, new []{"Modified Locally"},Entities.StockItem);

                    Browser.Instance.Open("BC501500", true);
                    ProcessDataPage.SetLastOperationProcessFilter(Stores.BigCommerce, new[] { Statuses.Pending },  1, new []{"Modified Locally"},Entities.StockItem);

                    WaitBase.LongTimeOut = 1;
                    try
                    {
                        ProcessDataPage.Process();
                    }
                    catch (WaitTimeoutException)
                    {
                    }

                    Browser.Instance.SelectWindow(1);
                    WaitBase.LongTimeOut = 360000;
                    ProcessDataPage.Process(false);
                    ProcessDataPage.CloseWindow();
                }

                using (TestExecution.CreateTestStepGroup("Step 2 - Export Stock Items by Manual Sync to BC"))
                {
                    SyncStatus.OpenScreen();
                    SyncStatus.SetManualByLocalId(store, Entities.StockItem, stockItemGIExtList.FirstOrDefault().Description);

                    Browser.Instance.Open("BC301000", true);
                    SyncStatus.SetManualByLocalId(store, Entities.StockItem, stockItemGIExtList.FirstOrDefault().Description);

                    WaitBase.LongTimeOut = 1;
                    try
                    {
                        SyncStatus.Sync();
                    }
                    catch (WaitTimeoutException)
                    {
                    }

                    Browser.Instance.SelectWindow(1);
                    WaitBase.LongTimeOut = 360000;
                    SyncStatus.Sync(false);
                    SyncStatus.CloseWindow();
                }

                using (TestExecution.CreateTestStepGroup("Step 3 - Verify Export Process Success in Acumatica."))
                {
                    VerifySyncSuccessInAcumatica(stockItemGIExtList.FirstOrDefault());
                }

                using (TestExecution.CreateTestStepGroup("Step 4 - Save ID"))
                {
                    SaveID(this.GetType());
                }
            }
        }

        private void PrepareData(List<string> itemsToCreate)
        {
            if (itemsToCreate.Count != 0)
            {
                itemClass = DataService.GetItemClassEntity(BcDataFilePath.ConcurrentSyncCreateTemplateItem);
                warehouse = DataService.GetWarehouseEntity(DataFilePath.WarehouseCreateItem);
                calcRule = DataService.GetAvailCalcRule(DataFilePath.AvailCalcRuleCreateItem);
                ConfigureInventoryAutoNumbering();
                CreateAvailCalcRule(calcRule);
                CreateWarehouse(warehouse);
                CreateItemClass(itemClass);

                var itemsEx = DataService.GetStockItemsEntity(BcDataFilePath.StockItemConcurrentSyncSingleItem);
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
    }
}
