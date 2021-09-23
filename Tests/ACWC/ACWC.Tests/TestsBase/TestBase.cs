using ACSC.Tests.Entity.Attribute;
using ACSC.Tests.Entity.ItemClass;
using ACSC.Tests.Entity.Warehouse;
using ACSC.Tests.Extensions;
using ACSC.Tests.Extensions.FinancialCalendar;
using ACSC.Tests.Extensions.ItemClass;
using ACSC.Tests.Extensions.StockItem;
using ACSC.Tests.Extensions.TemplateItems;
using Core.Config;
using Core.Core.Browser;
using Core.Log;
using Core.Login;
using Core.TestExecution;
using System;
using System.Collections.Generic;
using System.Text;
using ACSC.Tests.Custom;
using ACSC.Tests.Entity.Items.NonStockItems;
using ACSC.Tests.Entity.Items.StockItems;
using ACSC.Tests.Entity.Items.TemplateItem;
using Core.Verifications;
using ACSC.Tests.ShopifyRest.Domain.Entities.Customers;
using Newtonsoft.Json;

namespace ACSC.Tests.TestsBase
{
    public abstract class TestBase : Check
    {
        protected static ACWooCommerceStore ShopifyStore => new ACWooCommerceStore();
        protected static ACWooCommerceStore WooCommerceStore => new ACWooCommerceStore();
        protected static ACBigCommerceStore BigCommerceStore => new ACBigCommerceStore();
       
        protected static ACConnectorPrepeareData FetchDataPage => new ACConnectorPrepeareData();
        protected static FinancialPeriod MasterFinPeriodMaintPage => new FinancialPeriod();
        protected static ManageFinancialPeriodGl FinPeriodStatusProcessPage => new ManageFinancialPeriodGl();
        protected static SegmentedKey SegmentedKeysPage => new SegmentedKey();
        protected static ACConnectorSyncStatus SyncStatus => new ACConnectorSyncStatus();
        protected static TemplateItem TemplateItemPage => new TemplateItem();
        protected static ACConnectorEntities ConnectorEntity => new ACConnectorEntities();
        protected ACConnectorProcessData ProcessDataPage => new ACConnectorProcessData();
        protected static ItemClass ItemClassPage => new ItemClass();
        protected static Warehouse ACWarehousePage => new Warehouse();
        protected static AttributeCs AttributesPage => new AttributeCs();
        protected static AvailabilityCalculationRules AvailCalcRulesPage => new AvailabilityCalculationRules();
        protected static Random rand => new Random();
        protected static Features Features => new Features();
        protected ItemClassEntity itemClass;
        protected AvailCalcRuleEntity calcRule;
        protected WarehouseEntity warehouse;
        protected List<StockItemEntity> stockItems;
        protected List<StockItemEntity> stockItemGIExtList;
        protected List<NonStockItemEntity> nonStockItemExtList;
        protected string store;
        protected TemplateItemEntity templateItem;
        public DateTimeVerifiableValue BusinessDate { get; set; }

        protected TestBase()
        {
            nonStockItemExtList = new List<NonStockItemEntity>(0);
            stockItems = new List<StockItemEntity>();
            calcRule = new AvailCalcRuleEntity();
            itemClass = new ItemClassEntity();
            warehouse = new WarehouseEntity();
        }
        public override void BeforeExecute()
        {
            Browser.StartingUrl = Config.SITE_DST_URL;
            PxLogin LoginPage = new PxLogin();
            LoginPage.Username.Type(Config.SITE_DST_LOGIN);
            LoginPage.Password.Type(Config.SITE_DST_PASSWORD);
            LoginPage.SignIn.Click();
        }

        public static string GenerateRandomEmail()
        {
            var guid = Guid.NewGuid().ToString("D");
            const string domain = "@acumatica.com";

            return string.Join(string.Empty, guid, domain);
        }
        public static string GenerateRandomUserName()
        {
            var guid = Guid.NewGuid().ToString("D");
            const string domain = "Thari";

            return string.Join(string.Empty, guid, domain);
        }


        //public static string GenerateCustomerTestData(CustomerData customerTestData)
        //{
        //    string customerDataObj = JsonConvert.SerializeObject(customerTestData, Formatting.Indented, new JsonSerializerSettings
        //    {
        //        NullValueHandling = NullValueHandling.Ignore
        //    });
        //    return customerDataObj();
        //}

        public static string GenerateRandomUser()
        { 
            var guidU = Guid.NewGuid().ToString("E");
            const string domainU = "test";

            return string.Join(string.Empty, guidU, domainU);
        }
        public static string GetRandomTelNo()
        {
            StringBuilder telNo = new StringBuilder(12);
            int number;
            //for (int i = 0; i < 3; i++)
            //{
            //    number = rand.Next(0, 8); 
            //    telNo = telNo.Append(number.ToString());
            //}
            telNo = telNo.Append("415");
            telNo = telNo.Append("-");
            number = rand.Next(451, 743); 
            telNo = telNo.Append($"{number:D3}");
            telNo = telNo.Append("-");
            number = rand.Next(0, 10000); 
            telNo = telNo.Append($"{number:D4}");
            return telNo.ToString();                  
        }
        public static string GenerateRandomPhone()
        {
            const string domain = "+1212";

            Random rand = new Random();
            int num = rand.Next(000, 999);
            int num1 = rand.Next(0000, 9999);

            return string.Join(string.Empty, domain, num, num1);
        }
        protected void ClearSync(params string[] entities)
        {
            ConnectorEntity.ClearSyncEntity(store, entities);
        }
        public void GenerateCalendar()
        {
            int currentYear = DateTime.Today.Year;
            MasterFinPeriodMaintPage.OpenScreen();
            MasterFinPeriodMaintPage.GenerateYears();
            MasterFinPeriodMaintPage.FinPeriodGenerateParameters.ToYear.Type(currentYear);
            MasterFinPeriodMaintPage.FinPeriodGenerateParameters.Ok();

            FinPeriodStatusProcessPage.OpenScreen();
            FinPeriodStatusProcessPage.Summary.Action.Select("Open");
            FinPeriodStatusProcessPage.Summary.ToYear.Select(currentYear.ToString());
            FinPeriodStatusProcessPage.ProcessAll();
        }

        protected void ConfigureInventoryAutoNumbering()
        {
            SegmentedKeysPage.OpenScreen();
            SegmentedKeysPage.Summary.DimensionID.Select("INVENTORY");
            SegmentedKeysPage.Summary.NumberingID.Select("ALLOCATION");
            SegmentedKeysPage.Details.SelectRow(1);
            SegmentedKeysPage.Details.Row.AutoNumber.SetTrue();
            SegmentedKeysPage.Details.Row.Length.Type(30);
            SegmentedKeysPage.Save();
            SegmentedKeysPage.Details.Row.AutoNumber.SetFalse();
            SegmentedKeysPage.Save();
        }
        protected void ConfigureBCPaymentsMapping()
        {
            BigCommerceStore.OpenScreen();
            BigCommerceStore.PaymentMethods.Columns.StorePaymentMethod.Contains("AUTHORIZENET");
            if (BigCommerceStore.PaymentMethods.RowsCount() == 0)
            {
                BigCommerceStore.PaymentMethods.ResetColumnFilters();
                BigCommerceStore.PaymentMethods.RemoveAllRows();
                BigCommerceStore.Save();
                BigCommerceStore.PaymentMethods.New();
                BigCommerceStore.PaymentMethods.Row.StorePaymentMethod.Type("MANUAL");
                BigCommerceStore.PaymentMethods.Row.PaymentMethodID.Select("CASH");
                BigCommerceStore.PaymentMethods.Row.CashAccountID.Select("10100");
                BigCommerceStore.PaymentMethods.Row.Active.SetTrue();
                BigCommerceStore.Save();
            }
            else
            {
                ShopifyStore.PaymentMethods.Row.StorePaymentMethod.Type("AUTHORIZENET (CREDIT_CARD)");
                ShopifyStore.PaymentMethods.Row.PaymentMethodID.Select("CASH");
                ShopifyStore.PaymentMethods.Row.CashAccountID.Select("10100");
                ShopifyStore.PaymentMethods.Row.Active.SetTrue();
                ShopifyStore.Save();
            }
        }
        protected void UpdateTemplateItem(TemplateItemEntity item)
        {
            TemplateItemPage.OpenScreen();
            TemplateItemPage.Summary.Descr.Type(item.Description);
            TemplateItemPage.ItemSettings.BasePrice.Type(item.PriceInfo.BasePrice);
            TemplateItemPage.ItemSettings.RecPrice.Type(item.PriceInfo.RecPrice);
            TemplateItemPage.ItemSettings.WeightUOM.Select(item.GeneralSettings.WeightUOM);
            TemplateItemPage.ItemSettings.BaseItemWeight.Type(item.GeneralSettings.Weight);
            TemplateItemPage.ApplyToItems();
        }
        protected void  RemoveImportExportMappingFiltering(params string[] entities)
        {
            ConnectorEntity.RemoveImportExportMappingFiltering(store, entities);
        }
        protected void ConfigurePaymentsMapping()
        {
            WooCommerceStore.OpenScreen();
            WooCommerceStore.PaymentMethods.Columns.StorePaymentMethod.Equals("COD");
            WooCommerceStore.PaymentMethods.SelectRow(1);
            WooCommerceStore.PaymentMethods.Row.PaymentMethodID.Select("CASH");
           // WooCommerceStore.PaymentMethods.Row.CashAccountID.Select("10300WH");
            WooCommerceStore.PaymentMethods.Row.CashAccountID.Select("10100");
            WooCommerceStore.PaymentMethods.Row.Active.SetTrue();
            WooCommerceStore.Save();
        }

        protected void ActivateFeatures()
        {
            Features.OpenScreen();
            Features.Insert();
            Features.Summary.MatrixItem.SetTrue();
            if (Features.Summary.Status.GetValue() == "Pending Activation")
            {
                Features.RequestValidation();
                Features.Summary.Status.GetValue().VerifyEquals("Validated");

            }
        }

        protected bool IsModifiedItem(StockItemEntity existedItem, StockItemEntity etalonItem)
        {
            var isModified = existedItem.ItemDetails.ItemClass.Split('-')[0].TrimEnd() != etalonItem.ItemDetails.ItemClass ||
                             existedItem.ItemDetails.TaxCategory.Split('-')[0].TrimEnd() != etalonItem.ItemDetails.TaxCategory ||
                             existedItem.ItemDetails.BasePrice != etalonItem.ItemDetails.BasePrice;
            return isModified;
        }
        protected void CreateAvailCalcRule(AvailCalcRuleEntity calcRule)
        {
            AvailCalcRulesPage.OpenScreen();
            bool isRuleExists = true;
            try
            {
                AvailCalcRulesPage.GeneralSettings.AvailabilitySchemeID.Select(calcRule.AvailCalcRuleID);
            }
            catch (Exception e)
            {
                isRuleExists = ValidateSelection(calcRule.AvailCalcRuleID, AvailCalcRulesPage.GeneralSettings.AvailabilitySchemeIDLabel.GetValue(), e.Message);
            }

            if (isRuleExists) return;
            AvailCalcRulesPage.Insert();
            AvailCalcRulesPage.GeneralSettings.AvailabilitySchemeID.Type(calcRule.AvailCalcRuleID);
            AvailCalcRulesPage.GeneralSettings.Description.Type(calcRule.Description);
            AvailCalcRulesPage.Save();
        }

        protected void CreateWarehouse(WarehouseEntity warehouse)
        {
            ACWarehousePage.OpenScreen();
            bool isWarehouseExists = true;
            try
            {
                ACWarehousePage.Summary.SiteCD.Select(warehouse.WarehouseID);
            }
            catch (Exception e)
            {
                isWarehouseExists = ValidateSelection(warehouse.WarehouseID, ACWarehousePage.Summary.SiteCDLabel.GetValue(), e.Message);
            }

            if (isWarehouseExists) return;
            ACWarehousePage.Insert();
            ACWarehousePage.Summary.SiteCD.Type(warehouse.WarehouseID);
            ACWarehousePage.Summary.Descr.Type(warehouse.Description);
            ACWarehousePage.Summary.Active.SetTrue();

            foreach (var location in warehouse.LocationTable)
            {
                ACWarehousePage.Locations.New();
                ACWarehousePage.Locations.Row.LocationCD.Type(location.LocationID);
                ACWarehousePage.Locations.Row.Descr.Type(location.Description);
               // ACWarehousePage.Locations.Row.AssemblyValid.Set(location.AssemblyAllowed);
                ACWarehousePage.Locations.Row.InclQtyAvail.Set(location.InclQtyAvail);
                ACWarehousePage.Locations.Row.TransfersValid.Set(location.TransfersValid);
                ACWarehousePage.Locations.Row.SalesValid.Set(location.SalesValid);
            }

            ACWarehousePage.Accounts.ReceiptLocationID.Select(warehouse.ReceiptLocationID);
            ACWarehousePage.Accounts.ShipLocationID.Select(warehouse.ShipLocationID);
            ACWarehousePage.Accounts.DropShipLocationID.Select(warehouse.DropShipLocationID);
            ACWarehousePage.Save();
        }

        protected void CreateItemClass(ItemClassEntity itemClass)
        {
            bool isItemClassExists = true;

            ItemClassPage.OpenScreen();
            try
            {
                ItemClassPage.Summary.ItemClassCD.Select(itemClass.ClassID);
            }
            catch (Exception e)
            {
                isItemClassExists = ValidateSelection(itemClass.ClassID, ItemClassPage.Summary.ItemClassCDLabel.GetValue(), e.Message);
            }
            if (isItemClassExists) return;

            ItemClassPage.Insert();
            ItemClassPage.Summary.ItemClassCD.Type(itemClass.ClassID);
            ItemClassPage.Summary.Descr.Type(itemClass.Description);
            ItemClassPage.GeneralSettings.StkItem.Set(itemClass.GeneralSettings.StkItem);
            ItemClassPage.GeneralSettings.ItemType.Select(itemClass.GeneralSettings.ItemType);
            ItemClassPage.GeneralSettings.TaxCategoryID.Select(itemClass.GeneralSettings.TaxCategory);
            ItemClassPage.GeneralSettings.PostClassID.Select(itemClass.GeneralSettings.PostingClass);
            ItemClassPage.GeneralSettings.PostClassID.Select("");
            //ItemClassPage.GeneralSettings.LotSerClassID.Select(itemClass.GeneralSettings.LotSerClass);
            ItemClassPage.GeneralSettings.LotSerClassID.Select("NOTTRACKED");

            ItemClassPage.GeneralSettings.DfltSiteID.Select(itemClass.GeneralSettings.DefWarehouse);
            ItemClassPage.GeneralSettings.AvailabilitySchemeID.Select(itemClass.GeneralSettings.AvailabilityCalcRule);
            ItemClassPage.GeneralSettings.UndershipThreshold.Type(100);
            ItemClassPage.GeneralSettings.OvershipThreshold.Type(100);
            ItemClassPage.GeneralSettings.BaseUnit.Select(itemClass.GeneralSettings.BaseUnit);
            ItemClassPage.GeneralSettings.SalesUnit.Select(itemClass.GeneralSettings.SalesUnit);
            ItemClassPage.GeneralSettings.PurchaseUnit.Select(itemClass.GeneralSettings.PurchaseUnit);
            ItemClassPage.GeneralSettings.DecimalBaseUnit.Set(itemClass.GeneralSettings.DecimalBaseUnit);
            ItemClassPage.GeneralSettings.DecimalSalesUnit.Set(itemClass.GeneralSettings.DecimalSalesUnit);
            ItemClassPage.GeneralSettings.DecimalPurchaseUnit.Set(itemClass.GeneralSettings.DecimalPurchaseUnit);
            ItemClassPage.GeneralSettings.MinGrossProfitPct.Type(itemClass.GeneralSettings.MinMarkup);
            ItemClassPage.GeneralSettings.MarkupPct.Type(itemClass.GeneralSettings.Markup);
            // ItemClassPage.Attributes.New();
            // ItemClassPage.AttributeTest.New();

            foreach (var attribute in itemClass.Attributes)
            {
                ItemClassPage.Attributes.New();
                ItemClassPage.Attributes.Row.AttributeID.Select(attribute.AttributeID);
                ItemClassPage.Attributes.Row.AttributeCategory.Select(attribute.Category);
            }

            ItemClassPage.Save();
        }

        protected void UpdateAttributes(List<AttributeEntity> attributeEntities)
        {
            AttributesPage.OpenScreen();
            foreach (var attribute in attributeEntities)
            {
                AttributesPage.Summary.AttributeID.Select(attribute.AttributeID);
                AttributesPage.Summary.Description.Type(attribute.Description);

                foreach (var attributeDetail in attribute.Details)
                {
                    AttributesPage.Details.Columns.ValueID.Equals(attributeDetail.ValueID);
                    if (AttributesPage.Details.RowsCount() == 0)
                    {
                        AttributesPage.Details.New();
                        AttributesPage.Details.Row.ValueID.Type(attributeDetail.ValueID);
                        AttributesPage.Details.Row.Description.Type(attributeDetail.Description);
                    }
                }

                AttributesPage.Save();
            }

        }
        protected void CreateAttributes(List<AttributeEntity> attributeEntities)
        {
            bool isAttrExists = true;

            AttributesPage.OpenScreen();

            foreach (var attribute in attributeEntities)
            {
                try
                {
                    AttributesPage.Summary.AttributeID.Select(attribute.AttributeID);
                }
                catch (Exception e)
                {
                    isAttrExists = ValidateSelection(attribute.AttributeID, AttributesPage.Summary.AttributeIDLabel.GetValue(), e.Message);
                }

                if (isAttrExists) continue;

                AttributesPage.Insert();
                AttributesPage.Summary.AttributeID.Type(attribute.AttributeID);
                AttributesPage.Summary.Description.Type(attribute.Description);
                AttributesPage.Summary.ControlType.Select(attribute.ControlType);

                foreach (var attributeDetail in attribute.Details)
                {
                    AttributesPage.Details.New();
                    AttributesPage.Details.Row.ValueID.Type(attributeDetail.ValueID);
                    AttributesPage.Details.Row.Description.Type(attributeDetail.Description);
                }

                AttributesPage.Save();
            }
        }

        public virtual bool VerifyPrepareStatusByExternalIdNegative(string entity, string entityID)
        {
            ProcessDataPage.OpenScreen();
            ProcessDataPage.ProccessingForm.BindingID.Select(store);
            ProcessDataPage.ProccessingForm.EntityType.Select(entity);
            ProcessDataPage.Grid.ResetColumnFilters();
            ProcessDataPage.Grid.Columns.ExternID.Contains(entityID);
            var rowsCount = ProcessDataPage.Grid.RowsCount();
            var row = ProcessDataPage.Grid.Row;
            return rowsCount == 0 || row.Status.GetValue() != Statuses.Pending;
        }
        public virtual void ManualSyncByLocalId(string entityType, string description)
        {
            SyncStatus.SyncManualByLocalId(store, entityType, description);
        }
        public virtual void ManualSyncListByLocalId(string entityType, List<string> descriptionList)
        {
            SyncStatus.SyncManualListByLocalId(store, entityType, descriptionList);
        }
        public virtual void ManualSyncListByStatusByLocalId(string entityType, List<string> descriptionList, string status)
        {
            SyncStatus.SetSyncManualListByLocalId(store, entityType, descriptionList, status);
        }
        public virtual void SetManualSyncListByLocalId(string entityType, List<string> descriptionList)
        {
            SyncStatus.SetSyncManualListByLocalId(store, entityType, descriptionList);
        }

        public virtual void ClickManualSync()
        {
            SyncStatus.Sync();
        }

        private static bool ValidateSelection(string sku, string skuLabel, string message)
        {
            if (message == $"The specified value: {sku} is not present in the selector: {skuLabel.Split(':')[0]}")
            {
                return false;
            }

            Log.Error(message);
            return true;
        }
    }
}