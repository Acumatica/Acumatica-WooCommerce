using System;
using System.Collections.Generic;
using System.Linq;
using ACSC.Tests.BigCommerceTests.EntityData;
using ACSC.Tests.Custom;
using ACSC.Tests.Entity.Items.StockItems;
using ACSC.Tests.EntityData;
using ACSC.Tests.EntityDataService;
using ACSC.Tests.EntityValidators;
using ACSC.Tests.ShopifyRest.Domain.Entities.Products;
using ACSC.Tests.TestsProduct;
using BCApiClient.Rest.Domain.Entities.Products;
using Controls.Input;
using Core.TestExecution;
using PX.QA.Tools;

namespace ACSC.Tests.BigCommerceTests.TestsProduct
{
    public class BCStockItemExportMappingTab : TestProductBase
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

            using (TestExecution.CreateTestCaseGroup("Step 1 - Create Stock Item"))
            {
                store = Stores.BigCommerce;
                ConfigureInventoryAutoNumbering();
                attributes = DataService.GetAttributes(BcDataFilePath.AttributesStockItemExportMappingTab);
                CreateAttributes(attributes);
                ItemClassPage.OpenScreen();
                ItemClassPage.Summary.ItemClassCD.Select("ALLOTHER");
                ItemClassPage.Attributes.Columns.AttributeID.Equals("EXTRAATTR");
                if (ItemClassPage.Attributes.RowsCount() == 0)
                {
                    ItemClassPage.Attributes.New();
                    ItemClassPage.Attributes.Row.AttributeID.Select("EXTRAATTR");
                    ItemClassPage.Save();
                }

                //Create Stock Item
                stockItem = DataService.GetStockItemsEntity(BcDataFilePath.StockItemExportMappingTab).FirstOrDefault();
                StockItemPage.OpenScreen();
                visitor.SetData(stockItem);
                StockItemPage.Insert();
                StockItemPage.Full(visitor);
                StockItemPage.Summary.DynamicControl<InputLocalizable>("Custom_1").Type(stockItem?.Custom_1);
                StockItemPage.Summary.DynamicControl<InputLocalizable>("Custom_2").Type(stockItem?.Custom_2);
                StockItemPage.Save();
            }

            using (TestExecution.CreateTestStepGroup("Step 2 - Set Export Mapping"))
            {
                connectorEntity = DataService.GetConnectorEntityMapping(BcDataFilePath.StockItemExportMapping);
                ConnectorEntity.OpenScreen();
                ConnectorEntity.SetExportMapping(connectorEntity);
                ConnectorEntity.Save();
            }
            using (TestExecution.CreateTestStepGroup("Step 3 - Export Stock Items to BC"))
            {
                FetchDataPage.FetchData(store, FetchMode.Full, Entities.StockItem, Entities.SalesCategory);
                ProcessDataPage.OpenScreen();
                ProcessDataPage.SetProcessFilter(Stores.BigCommerce, new[] { Statuses.Pending }, Entities.SalesCategory);
                ProcessDataPage.ProcessAll();

                ManualSyncByLocalId(Entities.StockItem, stockItem?.Description);

                ConnectorEntity.OpenScreen();
                ConnectorEntity.ExportMappings.RemoveAllRows();
                ConnectorEntity.Save();
            }
            using (TestExecution.CreateTestStepGroup("Step 4 - Verify Export Process Success in Acumatica."))
            {
                VerifySyncSuccessInAcumatica(stockItem);
            }
            using (TestExecution.CreateTestStepGroup("Step 7 - Verify Product List in BigCommerce"))
            {
                var item = externalIds.FirstOrDefault();

                BigCommerceRest.Rest.Domain.Entities.Products.ProductData product = bcPoductRestDataProvider.GetByID(int.Parse(item.Key));
                var productExt = GetProductDataObj();
                EntityComparer.Instance.Validate(productExt, product)
                    .Trace(Messages.ValidateSyncStatusFor(Entities.StockItem, item.Value))
                    .IsValid
                    .VerifyEquals(true);
            }

            using (TestExecution.CreateTestStepGroup("Step 8 - Save ID"))
            {
                SaveID(this.GetType());
            }
        }

        private BigCommerceRest.Rest.Domain.Entities.Products.ProductData GetProductDataObj()
        {
            var productData = new BigCommerceRest.Rest.Domain.Entities.Products.ProductData
            {
                Name = "New Brick",
                Sku = "NEWBRICK",
                ProductTaxCode = "EXEMPT",
                CostPrice = 123.44m,
                SalePrice = 10m,
                Price = 13m

            };

            productData.CustomFields.Add(

                new ProductsCustomField
                {
                    Name = "Default Warehouse",
                    Value = "RETAIL"
                });

            //productData.CustomFields.Add(

            //    new ProductsCustomField
            //    {
            //        Name = "Custom_2",
            //        Value = "1A1"
            //    });

            productData.CustomFields.Add(

                new ProductsCustomField
                {
                    Name = "Extra Attribute",
                    Value = "10"
                });


            return productData;
        }
    }
}