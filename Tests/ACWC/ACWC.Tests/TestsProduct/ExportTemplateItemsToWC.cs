using ACSC.Tests.Custom;
using ACSC.Tests.EntityData;
using ACSC.Tests.EntityDataService;
using ACSC.Tests.EntityValidators;
using Core.TestExecution;
using PX.QA.Tools;
using System.Linq;
using ACSC.Tests.PageVisitors;
using ACSC.Tests.PageVisitors.TemplateItem;
using static ACSC.Tests.Helpers.ValidatorHelper;

namespace ACSC.Tests.TestsProduct
{
    public class ExportTemplateItemsToWC : TestProductBase
    {
        public override void Execute()
        {
            using (TestExecution.CreateTestCaseGroup("Export Template Items from AC to SP"))
            {
                using (TestExecution.CreateTestStepGroup("Step 0 - Clearing"))
                {
                    Clearing(this.GetType());
                    PrepareData();
                }

                using (TestExecution.CreateTestStepGroup("Step 1 - Identify Matrix Items in Acumatica"))
                {
                    TemplateItemGI.OpenScreen();
                    templateItemGIExtList = DataService.GetTemplateItemGI(DataFilePath.ExportTemplateItemsGI);
                    foreach (var templateItemGIExt in templateItemGIExtList)
                    {
                        TemplateItemGI.ResultsGridHeader.InventoryItem_inventoryCD.Equals(templateItemGIExt.InventoryCD);
                        templateItemGI = TemplateItemGI.Get().ResultRows.FirstOrDefault();

                        EntityComparer.Instance.Validate(templateItemGIExt, templateItemGI)
                            .Trace(Messages.ValidateSyncStatusFor(Entities.TemplateItem, templateItemGIExt.InventoryCD))
                            .IsValid
                            .VerifyEquals(true);

                        //Validate variants
                        TemplateItemPage.OpenScreen();
                        TemplateItemPage.Summary.InventoryCD.Select(templateItemGI?.InventoryCD);
                        variantsExt = DataService.GetTemplateItemVariantsEntity(DataFilePath.ExportTemplateItemsVariants);
                        var variants = TemplateItemPage.Get().MatrixItemsResult;
                        foreach (var variantExt in variantsExt)
                        {
                            var variant = variants.FirstOrDefault(x => RemoveEmptySpaces(x.InventoryCD) == RemoveEmptySpaces(variantExt.InventoryCD));
                            EntityComparer.Instance.Validate(variantExt, variant)
                                .Trace(Messages.ValidateSyncStatusFor(Entities.TemplateItem, variantExt.InventoryCD))
                                .IsValid
                                .VerifyEquals(true);
                        }
                    }
                }

                using (TestExecution.CreateTestStepGroup("Step 3 - Export Template Items to SP."))
                {
                    FetchDataPage.FetchData(Stores.Shopify, FetchMode.Incremental, Entities.TemplateItem);
                    ManualSyncListByLocalId(Entities.TemplateItem, templateItemGIExtList.Select(x => x.Description).ToList());
                }

                using (TestExecution.CreateTestStepGroup("Step 4 - Verify Export Process Success in Acumatica."))
                {
                    VerifySyncSuccessInAcumatica(templateItemGIExtList.FirstOrDefault(), Entities.TemplateItem);
                }

                //using (TestExecution.CreateTestStepGroup("Step 5 - Verify Product List in WooCommerce"))
                //{
                //    var variants = productRestDataProvider.GetByID(externalIds?.FirstOrDefault().Key).Variants;
                //    foreach (var variantExt in variantsExt)
                //    {
                //        var variant = variants.FirstOrDefault(x => RemoveEmptySpaces(x.Sku.ToUpperInvariant()) == RemoveEmptySpaces(variantExt.InventoryCD));
                //        EntityComparer.Instance.Validate(RemoveEmptySpaces(variantExt.InventoryCD), RemoveEmptySpaces(variant?.Sku.ToUpperInvariant()))
                //            .Trace(Messages.ValidateSyncStatusFor(Entities.TemplateItem, variantExt.InventoryCD))
                //            .IsValid
                //            .VerifyEquals(true);
                //    }
                //}

                using (TestExecution.CreateTestStepGroup("Step 6 - Update Matrix Items in Acumatica"))
                {
                    templateItem = DataService.GetTemplateItem(DataFilePath.ExportTemplateItemsUpdatedItem);
                    UpdateTemplateItem(templateItem);
                }

                using (TestExecution.CreateTestStepGroup("Step 7 - Export Template Items to SP."))
                {
                    FetchDataPage.FetchData(Stores.WooCommerce, FetchMode.Incremental, Entities.TemplateItem);
                    ManualSyncByLocalId(Entities.TemplateItem, templateItem.Description);
                }

                using (TestExecution.CreateTestStepGroup("Step 8 - Verify Export Process Success in Acumatica."))
                {
                    VerifySyncSuccessInAcumatica(templateItem);
                }

                using (TestExecution.CreateTestStepGroup("Step 9 - Verify Updated Product in Shopify"))
                {
                    var templateItemExt = DataService.GetProductData(DataFilePath.ExportTemplateItemsUpdatedProductData);
                    var templateItem = productRestDataProvider.GetByID(externalIds?.FirstOrDefault().Key);

                    EntityComparer.Instance.Validate(templateItemExt.ProductName, templateItem.ProductName)
                        .Trace($"Shopify Stock Item: Validate Template Item ( ExternalID: {externalIds.FirstOrDefault().Key}, Title: {externalIds.FirstOrDefault().Value})");

                    var variants = templateItem.Variants;
                    variantsExt = DataService.GetTemplateItemVariantsEntity(DataFilePath.ExportTemplateItemsUpdatedVariants);
                    foreach (var variantExt in variantsExt)
                    {
                        var variant = variants.FirstOrDefault(x => RemoveEmptySpaces(x.Sku.ToUpperInvariant()) == RemoveEmptySpaces(variantExt.InventoryCD));

                        EntityComparer.Instance.Validate(variantExt, variant)
                            .Trace($"Shopify Template Item Variants: Validate Template Item Variants (" +
                                   $"SKU: {variantExt.InventoryCD}, " +
                                   $"Weight: {variantExt.Weight}, " +
                                   $"Default Price: {variantExt.DefaultPrice} ");
                    }
                }


                using (TestExecution.CreateTestStepGroup("Step 10 - Save ID"))
                {
                    SaveID(this.GetType());
                }
            }
        }

        private void PrepareData()
        {
            WooCommerceStore.OpenScreen();
            WooCommerceStore.EntitySettings.Columns.EntityType.Equals(Entities.TemplateItem);
            WooCommerceStore.EntitySettings.SelectRow(1);
            WooCommerceStore.EntitySettings.Row.IsActive.SetTrue();
            WooCommerceStore.Save();
            store = Stores.Shopify;
            calcRule = DataService.GetAvailCalcRule(DataFilePath.AvailCalcRuleCreateItem);
            itemClass = DataService.GetItemClassEntity(DataFilePath.CreateTemplateItemInAcumaticaExportToSP);
            attributes = DataService.GetAttributes(DataFilePath.AttributesCreateTemplateItems);
            warehouse = DataService.GetWarehouseEntity(DataFilePath.WarehouseCreateItem);
            ActivateFeatures();
            CreateAvailCalcRule(calcRule);
            CreateWarehouse(warehouse);
            CreateAttributes(attributes);
            CreateItemClass(itemClass);
            ConfigureInventoryAutoNumbering();

            templateItem = DataService.GetTemplateItem(DataFilePath.CreateTemplateItem);
            var visitor = VisitorsManager.GetSingle<ITemplateItemVisitor>(typeof(TemplateItemVisitor));
            TemplateItemPage.OpenScreen();
            visitor.SetData(templateItem);
            TemplateItemPage.Full(visitor);
            //Revert updated info in case if test executed second time
            UpdateTemplateItem(templateItem);
        }
    }
}