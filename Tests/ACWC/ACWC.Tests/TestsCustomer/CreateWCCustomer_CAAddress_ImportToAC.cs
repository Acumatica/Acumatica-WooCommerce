using ACSC.Tests.Custom;
using ACSC.Tests.Entity.Customer;
using ACSC.Tests.Entity.SyncStatus;
using ACSC.Tests.EntityData;
using ACSC.Tests.EntityDataService;
using ACSC.Tests.EntityValidators;
using ACSC.Tests.ShopifyRest;
using Core.TestExecution;
using PX.QA.Tools;
using System.Linq;
using ACSC.Tests.ShopifyRest.Domain.Entities.Customers;
using Newtonsoft.Json;
using WooCommerce.Tests.TestData;

namespace ACSC.Tests.TestsCustomer
{
    public class CreateWCCustomer_CAAddress_ImportToAC : TestCustomerBase
    {
        public string NewTestUser { get; private set; }

        public override void Execute()
        {
            using (TestExecution.CreateTestCaseGroup("Create Customer in WooCommerce with US address and Import to AC"))
            {
                var TestAcctName = new string[1];
                using (TestExecution.CreateTestStepGroup("Step 0 - Clearing"))
                {
                    Clearing(this.GetType());
                    PrepareData();
                }
                using (TestExecution.CreateTestStepGroup("Step 1 - Create Customer in WooCommerce"))
                {
                    var customerDataProvider = WooCommerceApiService.Instance.CustomerRestDataProvider;
                    var customerTestData = new CustomerTestData();
                    var customerToCreate = customerTestData.CustomerDataSetup();
                    TestAcctName[0] = customerToCreate.Username;
                    newCustomer = customerDataProvider.Create(customerToCreate);
                }
                using (TestExecution.CreateTestStepGroup("Step 2 - Import Customers to AC"))
                {
                    WooCommerceStore.OpenScreen();
                    WooCommerceStore.SetEntitySettings(Entities.Customer, "Import", "External System");
                    WooCommerceStore.Save();
                    FetchDataPage.FetchDataByEntityUsingFetchModeWithSyncMode(store, FetchMode.Incremental, SyncMode.PendingAndFailed, Entities.Customer, newCustomer.Id.ToString());
                }

                using (TestExecution.CreateTestStepGroup("Step 3 - Verify Import Process Success in Acumatica."))
                {
                    SyncStatus.OpenScreen();
                    SyncStatus.SetVerifyFilter(Entities.Customer, Statuses.Synchronized, externalID: newCustomer.Id.ToString(), store:store);
                    syncStatus = SyncStatus.Get();
                    var syncStatusExt = GetSyncStatusExt(newCustomer.Id.ToString());
                    //Validate Customer & Customer Locations
                    EntityComparer.Instance.Validate(syncStatusExt, syncStatus)
                                           .Trace($"SyncStatus: Validate Customer synced ({newCustomer.Id})");
                    externalID = newCustomer.Id.ToString();
                    customerLocalId = syncStatus.DetailsView.FirstOrDefault()?.LocalID?.Split(',')[0].Trim();

                }

                using (TestExecution.CreateTestStepGroup("Step 4 - Verify Acumatica."))
                {
                    CustomerPage.OpenScreen();
                    CustomerPage.Summary.AcctCD.Select(customerLocalId);
                    var customerDataEntity = CustomerPage.Get();
                    EntityComparer.Instance.Validate(TestAcctName[0], customerDataEntity.AcctName)
                                  .Trace("WooCommerce Customer: Validate Customer and Customer Addresses");
                }

                using (TestExecution.CreateTestStepGroup("Step 5 - Save ID"))
                {
                    SaveID(this.GetType());
                }
            }
        }
        private void PrepareData()
        {
            store = Stores.WooCommerce;
            ConnectorEntity.RemoveImportExportMappingFiltering(store);
        }
        private SyncStatus GetSyncStatusExt(string acctCD)
        {
            var syncStatusExt = new SyncStatus();
            syncStatusExt.DetailsView.Add(new SyncStatusDetails
            {
                ExternalID = acctCD,
                Status = Statuses.Synchronized
            });

            return syncStatusExt;
        }
    }
}