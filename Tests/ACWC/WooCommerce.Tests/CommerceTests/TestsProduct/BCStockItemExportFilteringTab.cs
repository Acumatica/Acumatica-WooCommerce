using System.Collections.Generic;
using System.Linq;
using ACSC.Tests.BigCommerceRest.Rest.Domain.Entities.Products;
using ACSC.Tests.BigCommerceTests.EntityData;
using ACSC.Tests.Custom;
using ACSC.Tests.Entity.Items.StockItems;
using ACSC.Tests.EntityDataService;
using ACSC.Tests.EntityValidators;
using ACSC.Tests.TestsProduct;
using BCApiClient.Rest.Domain.Entities.Products;
using Controls.Input;
using Core.Log;
using Core.TestExecution;
using Core.Trace;
using PX.QA.Tools;

namespace ACSC.Tests.BigCommerceTests.TestsProduct
{
    public class BCStockItemExportFilteringTab : TestProductBase
    {
        public override void Execute()
        {
            using (TestExecution.CreateTestCaseGroup("Stock Item: Export Mapping tab"))
            {
                using (TestExecution.CreateTestStepGroup("Step 0 - Preconditions and clearing"))
                {
                    BCClearing(this.GetType());
                }
            }

            using (TestExecution.CreateTestCaseGroup("Step 1 - Create Stock Items"))
            {
                store = Stores.BigCommerce;
                ConfigureInventoryAutoNumbering();
                itemClass = DataService.GetItemClassEntity(BcDataFilePath.ItemClassStockItemExportFilteringTab);
                CreateItemClass(itemClass);
                stockItems = DataService.GetStockItemsEntity(BcDataFilePath.StockItemExportFilteringTab);

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
                        visitor.SetData(item);
                        StockItemPage.Insert();
                        StockItemPage.Full(visitor);
                        StockItemPage.Save();
                    }
                }
            }

            using (TestExecution.CreateTestStepGroup("Step 2 - Set Export Mapping"))
            {
                connectorEntity = DataService.GetConnectorEntityMapping(BcDataFilePath.StockItemExportFiltering);
                ConnectorEntity.OpenScreen();
                ConnectorEntity.SetExportFilter(connectorEntity);
                ConnectorEntity.Save();
            }
            using (TestExecution.CreateTestStepGroup("Step 3 - Export Stock Items to BC"))
            {
                FetchDataPage.FetchData(store, FetchMode.Full, Entities.StockItem, Entities.SalesCategory);
                ProcessDataPage.OpenScreen();
                ProcessDataPage.SetProcessFilter(Stores.BigCommerce, new[] { Statuses.Pending }, Entities.SalesCategory);
                ProcessDataPage.ProcessAll();

                SetManualSyncListByLocalId(Entities.StockItem, stockItems.Select(x => x.Description).ToList());

                ConnectorEntity.OpenScreen();
                ConnectorEntity.ExportFilters.RemoveAllRows();
                ConnectorEntity.Save();
            }
            using (TestExecution.CreateTestStepGroup("Step 4 - Verify Export Process Success in Acumatica."))
            {
                var synced = stockItems.Where(x => x.InventoryCD != "STITEMF").ToList();
                var notSynced = stockItems.Where(x => x.InventoryCD == "STITEMF").ToList();
                VerifySyncSuccessInAcumatica(synced, notSynced);
            }
            using (TestExecution.CreateTestStepGroup("Step 7 - Verify Product List in BigCommerce"))
            {
                var productDataExList = GetProductDataObj();
                foreach (var item in externalIds)
                {
                    var product = bcPoductRestDataProvider.GetByID(int.Parse(item.Key));
                    EntityComparer.Instance.Validate(productDataExList.FirstOrDefault(x => x.Sku == product.Sku), product)
                        .Trace(Messages.ValidateSyncStatusFor(Entities.StockItem, item.Value))
                        .IsValid
                        .VerifyEquals(true);
                }

            }

            using (TestExecution.CreateTestStepGroup("Step 8 - Save ID"))
            {
                SaveID(this.GetType());
            }
        }

        private List<ProductData> GetProductDataObj()
        {

            return new List<ProductData>
            {
                new ProductData
                {
                    Name = "Stock Item X",
                    Sku = "STITEMX",
                    IsVisible = true,
                    Availability = "available"
                },
                new ProductData
                {
                    Name = "Stock Item Y",
                    Sku = "STITEMY",
                    IsVisible = true,
                    Availability = "disabled"
                },
                new ProductData
                {
                    Name = "Stock Item Z",
                    Sku = "STITEMZ",
                    IsVisible = false
                }
            };
        }
    }
}