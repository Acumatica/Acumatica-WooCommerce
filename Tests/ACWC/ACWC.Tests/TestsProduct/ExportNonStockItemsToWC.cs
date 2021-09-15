using ACSC.Tests.Custom;
using ACSC.Tests.Entity.Items.NonStockItems;
using ACSC.Tests.EntityData;
using ACSC.Tests.EntityDataService;
using ACSC.Tests.EntityValidators;
using ACSC.Tests.PageVisitors;
using ACSC.Tests.PageVisitors.NonStockItem;
using ACSC.Tests.ShopifyRest;
using ACSC.Tests.ShopifyRest.Domain.Entities.Common;
using Core.TestExecution;
using PX.QA.Tools;
using System.Collections.Generic;
using System.Linq;

namespace ACSC.Tests.TestsProduct
{
    public class ExportNonStockItemsToWC : TestProductBase
    {
        public override void Execute()
        {
            using (TestExecution.CreateTestCaseGroup("Export Non-Stock Items from AC to WC"))
            {
                using (TestExecution.CreateTestStepGroup("Step 0 - Clearing"))
                {
                    Clearing(this.GetType());
                }

                using (TestExecution.CreateTestStepGroup("Step 1 - Identify Non-Stock Items in Acumatica"))
                {
                    nonStockItemExtList = DataService.GetNonStockItems(DataFilePath.ExportNonStockItemsToSPOriginal);
                    PrepareData(nonStockItemExtList);
                }

                using (TestExecution.CreateTestStepGroup("Step 2 - Export Non-Stock Items to WC"))
                {
                    FetchDataPage.FetchData(store, FetchMode.Incremental, Entities.NonStockItem);
                    SetManualSyncListByLocalId(Entities.NonStockItem, nonStockItemExtList.Select(x => x.Description).ToList());
                }

                using (TestExecution.CreateTestStepGroup("Step 3 - Verify Export Process Success in Acumatica."))
                {
                    VerifySyncSuccessInAcumatica(nonStockItemExtList);
                }

                using (TestExecution.CreateTestStepGroup("Step 4 - Verify Product List in WooCommerce"))
                {
                    var productDataProvider = WooCommerceApiService.Instance.ProductRestDataProvider;

                    var nonStockItemExts = DataService.GetStockItems(DataFilePath.ExportNonStockItemsToSPValidationObjWC);

                    foreach (var item in externalIds)
                    {
                        var nonStockItemExt = nonStockItemExts.FirstOrDefault(c => c.Description == item.Value);
                        var nonStockItem = productDataProvider.GetByID(item.Key);
                        EntityComparer.Instance.Validate(nonStockItemExt.Description, nonStockItem.ProductName)
                                               .Trace(Messages.ValidateSyncStatusFor(Entities.NonStockItem, item.Value))
                                               .IsValid
                                               .VerifyEquals(true);
                    }
                }

                using (TestExecution.CreateTestStepGroup("Step 5 - Update Non-Stock Items"))
                {
                    itemClass = DataService.GetItemClassEntity(DataFilePath.ExportNonStockItemsToSPItemClass2);
                    CreateItemClass(itemClass);

                    NonStockItemPage.OpenScreen();
                    foreach (var nonStockItemExt in nonStockItemExtList)
                    {
                        NonStockItemPage.Summary.InventoryCD.Select(nonStockItemExt.InventoryCD);
                        NonStockItemPage.GeneralSettings.ItemClassID.Select(itemClass.ClassID);
                        NonStockItemPage.MessageBox.Ok();
                        //NonStockItemPage.GeneralSettings.BasePrice.Type("400");
                        NonStockItemPage.BasePrice.BasePrice.Type("400");
                        NonStockItemPage.BasePrice.RecPrice.Type("300");
                        //NonStockItemPage.GeneralSettings.RecPrice.Type("300");
                        string desc = NonStockItemPage.Summary.Descr.GetValue();
                        NonStockItemPage.Summary.Descr.Type(desc + " changed.");
                        NonStockItemPage.GeneralSettings.SearchKeywords.Type("Item, Non, Stock");
                        NonStockItemPage.GeneralSettings.MetaKeywords.Type("Item, Non, Stock");
                        NonStockItemPage.GeneralSettings.MetaDescription.Type("Item, Non, Stock");
                        NonStockItemPage.GeneralSettings.COGSAcctID.Type("11000");
                        NonStockItemPage.GeneralSettings.COGSSubID.Type("000-000");
                        NonStockItemPage.Save();
                    }
                }

                using (TestExecution.CreateTestStepGroup("Step 6 - Export Non-Stock Items to WC"))
                {
                    nonStockItemExtList = DataService.GetNonStockItems(DataFilePath.ExportNonStockItemsToSPModified);
                    FetchDataPage.FetchData(store, FetchMode.Incremental, Entities.NonStockItem);
                    SetManualSyncListByLocalId(Entities.NonStockItem, nonStockItemExtList.Select(x => x.Description).ToList());
                }

                using (TestExecution.CreateTestStepGroup("Step 7 - Verify Export Process Success in Acumatica."))
                {
                    VerifySyncSuccessInAcumatica(nonStockItemExtList);
                }

                using (TestExecution.CreateTestStepGroup("Step 8 - Verify Product List in WooCommerce"))
                {
                    var productDataProvider = WooCommerceApiService.Instance.ProductRestDataProvider;

                    var nonStockItemExts = DataService.GetStockItems(DataFilePath.ExportNonStockItemsToSPValidationObj2);
                    //var metafields = DataService.GetMetafields(DataFilePath.ExportNonStockItemsToSPMetafields);

                    foreach (var item in externalIds)
                    {
                        var nonStockItemExt = nonStockItemExts.FirstOrDefault(c => c.Description == item.Value);
                        var nonStockItem = productDataProvider.GetByID(item.Key);
                        EntityComparer.Instance.Validate(nonStockItemExt.Description, nonStockItem.ProductName)
                                               .Trace(Messages.ValidateSyncStatusFor(Entities.NonStockItem, item.Value))
                                               .IsValid
                                               .VerifyEquals(true);

                    }

                }

                using (TestExecution.CreateTestStepGroup("Step 9 - Save ID"))
                {
                    SaveID(this.GetType());
                }
            }
        }

        private void PrepareData(List<NonStockItemEntity> itemsToCreate)
        {
            store = Stores.Shopify;
            ConnectorEntity.RemoveImportExportMappingFiltering(store, Entities.StockItem);
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
    }
}