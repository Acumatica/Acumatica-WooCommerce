using ACSC.Tests.Custom;
using ACSC.Tests.Entity.Items.StockItems;
using ACSC.Tests.EntityValidators;
using ACSC.Tests.ShopifyRest;
using ACSC.Tests.ShopifyRest.Domain.Entities.Products;
using Core.TestExecution;
using PX.QA.Tools;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ACSC.Tests.TestsProduct
{
    public class UpdateStockItems_ExportToWC : TestProductBase
    {
        public override void Execute()
        {
            using (TestExecution.CreateTestCaseGroup("Update Stock Items and Export to WooCommerce"))
            {
                using (TestExecution.CreateTestStepGroup("Step 1 - Update Stock Item in AC"))
                {
                    store = Stores.WooCommerce;
                    StockItemGI.OpenScreen();
                    stockItemGIExtList = GetStockItemGIExt().ResultRows;
                    var sku = stockItemGIExtList?.FirstOrDefault()?.InventoryCD;
                    StockItemGI.ResultsGridHeader.InventoryItem_inventoryCD.Equals(sku);
                    StockItemPage.OpenScreen();
                    StockItemPage.Summary.InventoryCD.Select(sku);
                    StockItemPage.Tabs.BasePrice.Type(650);
                    StockItemPage.Tabs.BasePrice.PressEnter();
                    StockItemPage.Save();
                }
                using (TestExecution.CreateTestStepGroup("Step 2 - Export Stock Items to WooCommerce"))
                {
                    FetchDataPage.FetchData(store, FetchMode.Incremental, Entities.StockItem);

                    SetManualSyncListByLocalId(Entities.StockItem, stockItemGIExtList?.Select(x => x.Description).ToList());
                }

                using (TestExecution.CreateTestStepGroup("Step 3 - Verify Export Process Success in Acumatica."))
                {
                    VerifySyncSuccessInAcumatica(stockItemGIExtList?.FirstOrDefault());
                }

                using (TestExecution.CreateTestStepGroup("Step 4 - Verify WooCommerce"))
                {
                    var productDataProvider = WooCommerceApiService.Instance.ProductRestDataProvider;
                    var stockItemExt = GetStockItemDataValidationObj().FirstOrDefault();
                    var stockItem = productDataProvider.GetByID(externalIds.FirstOrDefault(x => string.Equals(x.Value, stockItemExt?.ProductName)).Key);
                    EntityComparer.Instance.Validate(stockItemExt, stockItem)
                        .Trace(Messages.ValidateSyncStatusFor(Entities.StockItem, stockItem.ProductName))
                        .IsValid
                        .VerifyEquals(true);
                }

                using (TestExecution.CreateTestStepGroup("Step 5 - Save ID"))
                {
                    SaveID(this.GetType());
                }
            }
        }

        private List<ProductData> GetStockItemDataValidationObj()
        {
            var res = new List<ProductData>();
            var productData1 = new ProductData
            {
                ProductName = "Acer Laptop Computer"
            };
            productData1.Variants.Add(new ProductVariantData()
            {
                Sku = "AACOMPUT01",
                Price = 650.00m
            });

            res.Add(productData1);
            return res;
        }

        private StockItemGI GetStockItemGIExt()
        {
            return new StockItemGI()
            {
                ResultRows = new List<StockItemGIRow>{
                    new StockItemGIRow{InventoryCD = "AACOMPUT01", Description = "Acer Laptop Computer", ItemType = "Finished Good", ItemClass = "STOCKITEM", ItemStatus = "Active" }
                }
            };
        }
    }
}