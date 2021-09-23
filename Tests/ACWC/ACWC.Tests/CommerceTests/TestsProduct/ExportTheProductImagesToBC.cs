using ACSC.Tests.Custom;
using ACSC.Tests.Entity.Items.StockItems;
using ACSC.Tests.Entity.SyncStatus;
using ACSC.Tests.EntityData;
using ACSC.Tests.EntityDataService;
using ACSC.Tests.EntityValidators;
using ACSC.Tests.PageVisitors;
using ACSC.Tests.PageVisitors.StockItem;
using BCApiClient.Rest.Domain.Entities.Products;
using Core.TestExecution;
using PX.QA.Tools;
using System;
using System.Collections.Generic;

namespace ACSC.Tests.TestsProduct
{
    public class ExportTheProductImagesToBC : TestProductBase
    {
        StockItemEntity itemToCreate;
        public override void Execute()
        {
            using (TestExecution.CreateTestCaseGroup("Export the Product Images to BC"))
            {
                using (TestExecution.CreateTestStepGroup("Step 0 - Clearing"))
                {
                    BCClearing(this.GetType());
                }

                using (TestExecution.CreateTestStepGroup("Step 1 - Identify Stock Items in Acumatica"))
                {
                    PrepareData();
                }

                using (TestExecution.CreateTestStepGroup("Step 2 - Export Stock Items to BC"))
                {
                    FetchDataPage.FetchData(store, FetchMode.Reconciliation, Entities.StockItem);
                    ProcessDataPage.OpenScreen();
                    ProcessDataPage.SetProcessFilter(Stores.BigCommerce, new[] { Statuses.Pending }, Entities.SalesCategory);
                    ProcessDataPage.ProcessAll();

                    ManualSyncByLocalId(Entities.StockItem, itemToCreate.Description);
                }

                using (TestExecution.CreateTestStepGroup("Step 3 - Verify Export Process Success in Acumatica."))
                {
                    VerifySyncSuccessInAcumatica(itemToCreate);
                }

                using (TestExecution.CreateTestStepGroup("Step 4 - Upload Product Images"))
                {
                    UploadImage();
                }

                using (TestExecution.CreateTestStepGroup("Step 5 - Export Product Images to BigCommerce"))
                {
                    FetchDataPage.FetchData(store, FetchMode.Reconciliation, Entities.ProductImage);
                    ManualSyncByLocalId(Entities.ProductImage, itemToCreate.InventoryCD);
                }

                using (TestExecution.CreateTestStepGroup("Step 6 - Verify Product Images exported to BigCommerce"))
                {
                    SyncStatus.OpenScreen();
                    SyncStatus.SetVerifyFilter(Entities.ProductImage, Statuses.Synchronized, store);

                    var localID = itemToCreate.InventoryCD;
                    SyncStatus.DetailsFilter.LocalID.Contains(localID);
                    var syncStatusExt = GetSyncStatus();
                    syncStatus = SyncStatus.Get();

                    EntityComparer.Instance.Validate(syncStatusExt, syncStatus)
                        .Trace(Messages.ValidateSyncStatusFor(Entities.ProductImage, itemToCreate.InventoryCD))
                        .IsValid
                        .VerifyEquals(true);
                }

                using (TestExecution.CreateTestStepGroup("Step 7 - Verify Product Images in BigCommerce"))
                {
                    foreach (var item in externalIds)
                    {
                        List<ProductsImageData> images = bcProductImageRestDataProvider.Get(int.Parse(item.Key));
                        images.Count.VerifyEquals(1);
                    }
                }

                using (TestExecution.CreateTestStepGroup("Step 8 - Save ID"))
                {
                    SaveID(this.GetType());
                }
            }
        }

        private SyncStatus GetSyncStatus()
        {
            var syncStatus = new SyncStatus();
            syncStatus.DetailsView.Add(new SyncStatusDetails { Status = Statuses.Synchronized });
            return syncStatus;
        }

        private void UploadImage()
        {
            StockItemPage.OpenScreen();
            StockItemPage.Summary.InventoryCD.Select(itemToCreate.InventoryCD);
            StockItemPage.Tabs.ImageUrl.SelectFile(Environment.CurrentDirectory + "\\EntityData\\Images\\WEMUG.jpg");
            StockItemPage.Tabs.ImageUrl.Upload();
            StockItemPage.Save();
        }
        private void PrepareData()
        {
            store = Stores.BigCommerce;
            ConfigureInventoryAutoNumbering();

            calcRule = DataService.GetAvailCalcRule(DataFilePath.AvailCalcRuleCreateItem);
            warehouse = DataService.GetWarehouseEntity(DataFilePath.WarehouseCreateItem);
            itemClass = DataService.GetItemClassEntity(DataFilePath.ExportStockItemToWCCreateItemClass);
            CreateAvailCalcRule(calcRule);
            CreateWarehouse(warehouse);
            CreateItemClass(itemClass);

            itemToCreate = GetStockItem();

            Random rand = new Random();

            int randNum = rand.Next(000, 999);
            itemToCreate.InventoryCD = string.Join(string.Empty, itemToCreate.InventoryCD, randNum);
            itemToCreate.Description = string.Join(string.Empty, itemToCreate.Description, randNum);

            var visitor = VisitorsManager.GetSingle<IStockItemVisitor>(typeof(StockItemVisitor));
            StockItemPage.OpenScreen();

            visitor.SetData(itemToCreate);
            StockItemPage.Insert();
            StockItemPage.Full(visitor);
            StockItemPage.Save();
        }

        private StockItemEntity GetStockItem()
        {
            return new StockItemEntity
            {
                InventoryCD = "WEMUG",
                Description = "WEMUG product",
                ItemStatus = "Active",
                ItemDetails =
                {
                    BasePrice = 600.00m,
                    ItemClass = "STOCKITEM",
                    PostingClass = "ELE",
                    ItemType = "Finished Good",
                    Weight = 2.72m,
                    WeightUOM = "KG"
                }
            };
        }
    }
}
