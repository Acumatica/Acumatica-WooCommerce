using ACSC.Tests.BigCommerceRest.Rest.Domain.Entities.Customers;
using ACSC.Tests.BigCommerceTests.EntityData;
using ACSC.Tests.Custom;
using ACSC.Tests.Entity.Customer;
using ACSC.Tests.Entity.SyncStatus;
using ACSC.Tests.EntityDataService;
using ACSC.Tests.EntityValidators;
using ACSC.Tests.TestsCustomer;
using Controls.Input;
using Core.TestExecution;
using PX.QA.Tools;
using System.Collections.Generic;
using System.Linq;

namespace ACSC.Tests.BigCommerceTests.TestsCustomer
{
    public class CustomerBCImportMappingTab : TestCustomerBase
    {
        private string localId;

        public override void Execute()
        {
            using (TestExecution.CreateTestCaseGroup("Export Customers from BC to AC using Filtering"))
            {
                using (TestExecution.CreateTestStepGroup("Step 0 - Clearing"))
                {
                    BCClearing(this.GetType());
                    store = Stores.BigCommerce;
                    SegmentedKeysPage.OpenScreen();
                    SegmentedKeysPage.Summary.DimensionID.Select("CUSTOMER");
                    SegmentedKeysPage.Summary.NumberingID.Select("CUSTOMER");
                    SegmentedKeysPage.Details.SelectRow(1);
                    SegmentedKeysPage.Details.Row.AutoNumber.SetTrue();
                    SegmentedKeysPage.Save();
                }

                using (TestExecution.CreateTestStepGroup("Step 1 - Create Customer in BC"))
                {
                    bcCustomerData = DataService.GetBCCustomerData(BcDataFilePath.CustomerImportMappingTab);
                    bcCustomerData.Email = GenerateRandomEmail();
                    newBcCustomer = bcCustomerRestDataProvider.Create(bcCustomerData);

                    var newCustomerFormFieldValue = new List<CustomerFormFieldValuesData>() { };
                    newCustomerFormFieldValue.Add(new CustomerFormFieldValuesData()
                    {
                        CustomerId = newBcCustomer.Id,
                        FieldName = "VIP",
                        Value = "Yes"
                    });
                    newCustomerFormFieldValue.Add(new CustomerFormFieldValuesData()
                    {
                        CustomerId = newBcCustomer.Id,
                        FieldName = "Text",
                        Value = "abc"
                    });
                    newCustomerFormFieldValue.Add(new CustomerFormFieldValuesData()
                    {
                        CustomerId = newBcCustomer.Id,
                        FieldName = "Numbers",
                        Value = 77
                    });

                    bcCustomerFormFieldValuesDataProvider.Update(newCustomerFormFieldValue);
                }

                using (TestExecution.CreateTestStepGroup("Step 2 - Create a new attribute"))
                {
                    attributes = DataService.GetAttributes(BcDataFilePath.AttributesBCCustomerImportMappingTab);
                    CreateAttributes(attributes);

                    RemoveAttr();

                    ACCustomerClassPage.OpenScreen();
                    ACCustomerClassPage.Summary.CustomerClassID.Select("INTL");
                    ACCustomerClassPage.Attributes.New();
                    ACCustomerClassPage.Attributes.Row.AttributeID.Select("NEWATTR");
                    ACCustomerClassPage.Save();
                    ACCustomerClassPage.Attributes.Row.IsActive.SetTrue();
                    ACCustomerClassPage.Save();
                    ACCustomerClassPage.Attributes.New();
                    ACCustomerClassPage.Attributes.Row.AttributeID.Select("EXTATTR");
                    ACCustomerClassPage.Save();
                    ACCustomerClassPage.Attributes.Row.IsActive.SetTrue();
                    ACCustomerClassPage.Save();
                }

                using (TestExecution.CreateTestStepGroup("Step 3 - Set Import Mapping"))
                {
                    var connectorEntity = DataService.GetConnectorEntityMapping(BcDataFilePath.CustomerImportMapping);
                    ConnectorEntity.OpenScreen();
                    ConnectorEntity.SetConnectorSettings(connectorEntity.EntityType, "Bidirectional", "External", connectorEntity.Store);

                    ConnectorEntity.SetImportMapping(connectorEntity);
                }

                using (TestExecution.CreateTestStepGroup("Step 4 - Import Customers to AC"))
                {
                    FetchDataPage.FetchDataByEntityUsingFetchModeWithSyncMode(store, FetchMode.Incremental, SyncMode.PendingAndFailed, Entities.Customer, newBcCustomer.Id.ToString());
                }

                using (TestExecution.CreateTestStepGroup("Step 5 - Verify Import Process Success in Acumatica."))
                {
                    SyncStatus.OpenScreen();
                    SyncStatus.SetVerifyFilter(Entities.Customer, Statuses.Synchronized, store: Stores.BigCommerce, externalID: newBcCustomer.Id.ToString());
                    syncStatus = SyncStatus.Get();
                    var syncStatusExt = GetSyncStatusExt(newBcCustomer.Id.ToString());
                    //Validate Customer & Customer Locations
                    EntityComparer.Instance.Validate(syncStatusExt, syncStatus)
                                           .Trace($"SyncStatus: Validate Customer synced ({newBcCustomer.Id})");
                    externalID = newBcCustomer.Id.ToString();
                    localId = syncStatus.DetailsView.FirstOrDefault()?.LocalID?.Split(',')[0].Trim();
                }

                using (TestExecution.CreateTestStepGroup("Step 6 - Verify Acumatica."))
                {
                    CustomerPage.OpenScreen();
                    CustomerPage.Summary.AcctCD.Select(localId);
                    var customerDataEntity = CustomerPage.Get();
                    customerDataEntity.UsrTitle = CustomerPage.GeneralSettings.DynamicControl<InputLocalizable>("Title").GetValue();
                    customerDataEntity.UsrCustom = CustomerPage.GeneralSettings.DynamicControl<InputLocalizable>("Custom").GetValue();
                    var customerDataEntityExt = GetCustomerDataValidationObj();
                    EntityComparer.Instance.Validate(customerDataEntityExt, customerDataEntity)
                                  .Trace("Shopify Customer: Validate Customer and Customer Addresses");

                    (customerDataEntity.Locations.Count() == 1).VerifyEquals(true, "Customer Locations exists");

                }

                using (TestExecution.CreateTestStepGroup("Step 7 - Clear test settings"))
                {
                    RemoveAttr();

                    ConnectorEntity.OpenScreen();
                    ConnectorEntity.SetConnectorSettings("Customer");
                    ConnectorEntity.ImportMappings.RemoveAllRows();
                    ConnectorEntity.Save();
                }

                using (TestExecution.CreateTestStepGroup("Step 8 - Save ID"))
                {
                    SaveID(this.GetType());
                }
            }
        }

        private CustomerEntity GetCustomerDataValidationObj()
        {
            var customerEntityObj = new CustomerEntity()
            {
                AcctName = newBcCustomer.Company,
                UsrTitle = newBcCustomer.Company
            };

            customerEntityObj.MainContact.EMail = newBcCustomer.Email;
            customerEntityObj.MainContact.Phone2 = newBcCustomer.Phone;
            customerEntityObj.Attributes.Add(new CustomerEntityAttributes()
            {
                Attribute = "Extra Attribute",
                Value = newBcCustomer.TaxCode
            });
            customerEntityObj.Attributes.Add(new CustomerEntityAttributes()
            {
                Attribute = "New Attribute",
                Value = "abc"
            });

            return customerEntityObj;
        }

        private SyncStatus GetSyncStatusExt(string extId)
        {
            var syncStatusExt = new SyncStatus();
            syncStatusExt.DetailsView.Add(new SyncStatusDetails
            {
                ExternalID = extId,
                Status = Statuses.Synchronized
            });

            return syncStatusExt;
        }

        private void RemoveAttr()
        {
            ACCustomerClassPage.OpenScreen();
            ACCustomerClassPage.Summary.CustomerClassID.Select("INTL");

            var count = ACCustomerClassPage.Attributes.RowsCount().ToString();
            int.TryParse(count, out int rowCountINTL);

            if (rowCountINTL > 0)
            {
                for (var i = 1; i <= rowCountINTL; i++)
                {
                    ACCustomerClassPage.Attributes.SelectRow(i);
                    ACCustomerClassPage.Attributes.Row.IsActive.SetFalse();

                }

                ACCustomerClassPage.Attributes.RemoveAllRows();
                ACCustomerClassPage.MessageBox.Ok();
                ACCustomerClassPage.Save();
            }
        }
    }
}
