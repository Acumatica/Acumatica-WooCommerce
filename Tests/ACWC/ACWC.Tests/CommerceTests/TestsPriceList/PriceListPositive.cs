using ACSC.Tests.BigCommerceRest.Rest.Domain.Entities.PriceList;
using ACSC.Tests.BigCommerceTests.EntityData;
using ACSC.Tests.Custom;
using ACSC.Tests.EntityData;
using ACSC.Tests.EntityDataService;
using ACSC.Tests.EntityValidators;
using ACSC.Tests.PageVisitors;
using ACSC.Tests.PageVisitors.ItemWarehouseDetails;
using ACSC.Tests.PageVisitors.SalesPrices;
using ACSC.Tests.PageVisitors.StockItem;
using ACSC.Tests.PageVisitors.TemplateItem;
using ACSC.Tests.TestsProduct;
using Core.TestExecution;
using PX.QA.Tools;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ACSC.Tests.BigCommerceTests.TestsProduct
{
    public class PriceListPositive : TestProductBase
    {
        int randNum;

        public override void Execute()
        {
            using (TestExecution.CreateTestCaseGroup("Price List: Positive"))
            {
                using (TestExecution.CreateTestStepGroup("Step 0 - Preconditions and clearing"))
                {
                    BCClearing(this.GetType());

                    SalesPricePage.OpenScreen();
                    SalesPricePage.Details.Columns.InventoryID.Contains("TEST-ITEM");
                    SalesPricePage.Details.RemoveAllRows();
                    SalesPricePage.Details.Columns.InventoryID.Contains("SHIRT");
                    SalesPricePage.Details.RemoveAllRows();
                    SalesPricePage.Details.Columns.InventoryID.Contains("FAILED");
                    SalesPricePage.Details.RemoveAllRows();
                    SalesPricePage.Save();

                    PrepareData();
                }

                using (TestExecution.CreateTestStepGroup("Step 1 - Create Customer Price Classes"))
                {
                    var customerPriceClassesData = DataService.GetCustomerPriceClassesData(BcDataFilePath.PriceListPositivePriceClass);
                    CustomerPriceClassesPage.OpenScreen();
                    CustomerPriceClassesPage.Full(customerPriceClassesData);
                    CustomerPriceClassesPage.Save();
                }

                using (TestExecution.CreateTestStepGroup("Step 2 - Create Items"))
                {
                    CreateTemplateItem(BcDataFilePath.CreateTemplateItemPriceListPositive);
                    CreateStockItems();
                }

                using (TestExecution.CreateTestStepGroup("Step 3 - Create Sales Prices"))
                {
                    CreateSalesPrices(BcDataFilePath.SalesPricesPriceList);
                }

                using (TestExecution.CreateTestStepGroup("Step 4 - Export Price List to BC"))
                {
                    FetchDataPage.FetchData(store, FetchMode.Full, Entities.CustomerPriceClass);
                    ProcessDataPage.OpenScreen();
                    ProcessDataPage.SetProcessFilter(Stores.BigCommerce, new[] { Statuses.Pending }, Entities.CustomerPriceClass);
                    ProcessDataPage.ProcessAll();

                    FetchDataPage.FetchData(store, FetchMode.Full, Entities.StockItem, Entities.NonStockItem, Entities.TemplateItem, Entities.SalesCategory);
                    ProcessDataPage.OpenScreen();
                    ProcessDataPage.SetProcessFilter(Stores.BigCommerce, new[] { Statuses.Pending }, Entities.SalesCategory);
                    ProcessDataPage.ProcessAll();

                    SetManualSyncListByLocalId(Entities.StockItem, stockItems.Select(x => x.Description).ToList());

                    ManualSyncByLocalId(Entities.TemplateItem, templateItem?.Description);

                    FetchDataPage.FetchData(store, FetchMode.Full, Entities.PriceList);

                    SyncStatus.OpenScreen();
                    SyncStatus.SetVerifyFilter(Entities.PriceList, Statuses.All, store);
                    SyncStatus.DetailsGrid.ResetColumnFilters();
                    for (int i = 1; i <= SyncStatus.DetailsGrid.RowsCount(); i++)
                    {
                        SyncStatus.DetailsGrid.SelectRow(i);
                        SyncStatus.DetailsGrid.SetTrue();
                    }
                    SyncStatus.Sync();
                    SyncStatus.Save();
                }

                using (TestExecution.CreateTestStepGroup("Step 7 - Verify Price List in BigCommerce"))
                {
                    VerifySyncSuccessInAcumatica(stockItems);
                    VerifySyncSuccessInAcumatica(templateItem, Entities.TemplateItem);

                    SyncStatus.OpenScreen();
                    SyncStatus.SetVerifyFilter(Entities.PriceList, Statuses.All, store);
                    SyncStatus.DetailsFilter.LocalID.ClearFilter();

                    syncStatus = SyncStatus.Get();

                    Dictionary<string, (string warehouse, string resultItem)> verifyingItems = new Dictionary<string, (string, string)>();

                    verifyingItems["Test Item 1"] = ("WHOLESALE", BcDataFilePath.ResultTestItem1);
                    verifyingItems["Test Item 2"] = ("RETAIL", BcDataFilePath.ResultTestItem2);
                    verifyingItems["Test Item 3"] = ("RETAIL", BcDataFilePath.ResultTestItem3);
                    verifyingItems["BigCommerce Polo Shirt with Buttons"] = ("OTHERS", BcDataFilePath.ResultTestTemplateItem);

                    foreach (var item in verifyingItems)
                    {
                        VerifyTestItemBC(item.Key, item.Value.warehouse, item.Value.resultItem);
                    }
                }

                using (TestExecution.CreateTestStepGroup("Step 8 - Save ID"))
                {
                    SaveID(this.GetType());
                }
            }
        }

        private void VerifyTestItemBC(string item, string warehouse, string resultItem)
        {
            string wholesaleId = syncStatus.DetailsView.Where(x => x.LocalID.Contains(warehouse + ",")).FirstOrDefault().ExternalID;
            List<PriceListData> priceListTargets = new List<PriceListData>();

            var testItem = string.Join(string.Empty, randNum, item);

            var externalId = externalIds.Where(x => x.Value == testItem).FirstOrDefault().Key;

            priceListTargets.AddRange(PriceListDataProvider.Get(wholesaleId, externalId));

            var priceListEtalons = DataService.GetPriceListData(resultItem);

            foreach (var priceListEtalon in priceListEtalons)
            {
                var priceListTarget = priceListTargets.Where(x => x.Currency == priceListEtalon.Currency).FirstOrDefault();

                priceListTargets.Remove(priceListTarget);

                EntityComparer.Instance.Validate(priceListEtalon, priceListTarget)
                        .Trace(Messages.ValidatePriceList(testItem, priceListTarget.Currency))
                        .IsValid
                        .VerifyEquals(true);
            }
        }

        private void PrepareData()
        {
            BigCommerceStore.ActivateEntity(new[] { Entities.TemplateItem, Entities.CustomerPriceClass });
            store = Stores.BigCommerce;
            Random rand = new Random();
            randNum = rand.Next(000, 999);
            calcRule = DataService.GetAvailCalcRule(DataFilePath.AvailCalcRuleCreateItem);
            itemClass = DataService.GetItemClassEntity(BcDataFilePath.CreateItemClassPriceListPositive);
            attributes = DataService.GetAttributes(BcDataFilePath.AttributesCreateTemplateItemsPriceListPositive);

            CreateAvailCalcRule(calcRule);
            CreateAttributes(attributes);
            CreateItemClass(itemClass);

            ConfigureInventoryAutoNumbering();
        }

        private void CreateTemplateItem(string fileName)
        {
            templateItem = DataService.GetTemplateItem(fileName);
            templateItem.InventoryCD = string.Join(string.Empty, randNum, templateItem.InventoryCD);
            templateItem.Description = string.Join(string.Empty, randNum, templateItem.Description);
            var templateItemVisitor = VisitorsManager.GetSingle<ITemplateItemVisitor>(typeof(TemplateItemVisitor));
            TemplateItemPage.OpenScreen();
            templateItemVisitor.SetData(templateItem);
            TemplateItemPage.Full(templateItemVisitor);


            TemplateItemPage.Matrix.Row.Preliminary.SetTrue();
            TemplateItemPage.CreateMatrixItems();
            TemplateItemPage.MatrixItemsForCreation.Buttons.Confirmation.Click();

            TemplateItemPage.Save();
        }

        private void CreateStockItems()
        {
            stockItems = DataService.GetStockItemsEntity(BcDataFilePath.StockItemsPriceListPositive);
            visitor = VisitorsManager.GetSingle<IStockItemVisitor>(typeof(StockItemVisitor));

            foreach (var item in stockItems)
            {
                item.InventoryCD = string.Join(string.Empty, randNum, item.InventoryCD);
                item.Description = string.Join(string.Empty, randNum, item.Description);
                StockItemPage.OpenScreen();
                visitor.SetData(item);
                StockItemPage.Insert();
                StockItemPage.Full(visitor);
                StockItemPage.Save();


                var countRow = StockItemPage.WarehouseDetails.RowsCount();

                for (int i = 1; i <= countRow; i++)
                {
                    StockItemPage.WarehouseDetails.SelectRow(i);
                    var isRetail = StockItemPage.WarehouseDetails.Row.SiteID.GetValue() == "RETAIL";
                    if (isRetail)
                    {
                        StockItemPage.WarehouseDetails.Row.IsDefault.SetTrue();
                        StockItemPage.Save();
                    }
                }

                StockItemPage.WarehouseDetails.AddWarehouseDetail();

                var warehouseDetail = DataService.GetWarehouseDetailEntity(BcDataFilePath.PriceListPositiveWarehouseDetails);
                var warehouseDetailVisitor = VisitorsManager.GetSingle<IItemWarehouseDetailsVisitor>(typeof(ItemWarehouseDetailsVisitor));

                warehouseDetailVisitor.SetData(warehouseDetail);
                ItemWarehouseDetails.Full(warehouseDetailVisitor);
                ItemWarehouseDetails.Save();
            }
        }

        private void CreateSalesPrices(string fileName)
        {
            salesPrices = DataService.GetSalesPriceEntity(fileName);
            var salesPricesVisitor = VisitorsManager.GetSingle<ISalesPriceVisitor>(typeof(SalesPriceVisitor));

            foreach (var item in salesPrices.Details)
            {
                item.InventoryID = string.Join(string.Empty, randNum, item.InventoryID);
            }

            SalesPricePage.OpenScreen();
            salesPricesVisitor.SetData(salesPrices);
            SalesPricePage.Full(salesPricesVisitor);
            SalesPricePage.Save();
        }
    }
}