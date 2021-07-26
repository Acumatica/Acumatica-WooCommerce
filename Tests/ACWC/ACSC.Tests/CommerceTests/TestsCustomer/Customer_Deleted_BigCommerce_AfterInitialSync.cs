using ACSC.Tests.Custom;
using ACSC.Tests.Entity.SyncStatus;
using ACSC.Tests.EntityData;
using ACSC.Tests.EntityDataService;
using ACSC.Tests.EntityValidators;
using ACSC.Tests.PageVisitors;
using ACSC.Tests.PageVisitors.Customer;
using ACSC.Tests.TestsCustomer;
using Core.Core.Browser;
using Core.TestExecution;
using PX.QA.Tools;
using System.Linq;

namespace ACSC.Tests.BigCommerceTests.TestsCustomer
{
    public class Customer_Deleted_BigCommerce_AfterInitialSync : TestCustomerBase
    {
        public override void Execute()
        {
            using (TestExecution.CreateTestCaseGroup("Create Customer in AC and deleting Customer in BigCommerce after initial sync"))
            {
                using (TestExecution.CreateTestStepGroup("Step 0 - Clearing"))
                {
                    BCClearing(this.GetType());
                }
                using (TestExecution.CreateTestStepGroup("Step 1 - Create Customer in AC"))
                {
                    store = Stores.BigCommerce;
                    SegmentedKeysPage.OpenScreen();
                    SegmentedKeysPage.Summary.DimensionID.Select("CUSTOMER");
                    SegmentedKeysPage.Summary.NumberingID.Select("CUSTOMER");
                    SegmentedKeysPage.Details.SelectRow(1);
                    SegmentedKeysPage.Details.Row.AutoNumber.SetTrue();
                    SegmentedKeysPage.Save();
                    customerEntity = DataService.GetCustomer(DataFilePath.CustomerCAAddressExportToSPJson, Browser.InstanceTime);
                    CustomerGI.OpenScreen();
                    CustomerGI.Results.Columns.Customer_acctName.Equals(customerEntity.AcctName);
                    CustomerGI.Insert();
                    var visitors = VisitorsManager.Get<ICustomerVisitor>(customerEntity, typeof(CustomerVisitor));
                    customerEntity.MainContact.EMail = GenerateRandomEmail();
                    CustomerPage.Full(visitors);
                    CustomerPage.Save();
                    customerEntity.AcctCD = CustomerPage.Summary.AcctCD.GetValue();
                }

                using (TestExecution.CreateTestStepGroup("Step 2 - Set Export Filtering for Customers"))
                {
                    ConnectorEntity.OpenScreen();
                    ConnectorEntity.SetConnectorSettings(Entities.Customer, "Bidirectional", "Local", "BigCommerce");
                    ConnectorEntity.ClearExportFilter();
                    ConnectorEntity.SetExportFilter("Customer ID", "Equals", customerEntity.AcctCD, "And");
                    ConnectorEntity.Save();
                }

                using (TestExecution.CreateTestStepGroup("Step 3 - Export Customers to BC"))
                {
                    FetchDataPage.FetchData(store, FetchMode.Incremental, Entities.Customer);
                    ManualSyncByLocalId(Entities.Customer, customerEntity.AcctCD);
                }

                using (TestExecution.CreateTestStepGroup("Step 4 - Verify Export Process Success in Acumatica."))
                {
                    SyncStatus.OpenScreen();
                    SyncStatus.SetVerifyFilter(Entities.Customer, Statuses.Synchronized, "BigCommerce");

                    var localID = customerEntity.AcctCD;
                    SyncStatus.DetailsFilter.LocalID.Contains(localID);
                    syncStatus = SyncStatus.Get();
                    externalID = syncStatus.DetailsView.FirstOrDefault()?.ExternalID;

                    EntityComparer.Instance.Validate(GetSyncStatusExt(localID, Statuses.Synchronized), syncStatus)
                                    .Trace(Messages.ValidateSyncStatusFor(Entities.Customer, localID))
                                    .IsValid
                                    .VerifyEquals(true);
                }

                using (TestExecution.CreateTestStepGroup("Step 5 - Delete customer"))
                {
                    bcCustomerRestDataProvider.Delete(int.Parse(externalID));
                }

                using (TestExecution.CreateTestStepGroup("Step 6 - Import Customers to AC"))
                {
                    ConnectorEntity.OpenScreen();
                    ConnectorEntity.SetConnectorSettings(Entities.Customer, "Bidirectional", "External", "BigCommerce");
                    ConnectorEntity.Save();
                    FetchDataPage.FetchData(store, FetchMode.Reconciliation, Entities.Customer);
                    ManualSyncByLocalId(Entities.Customer, customerEntity.AcctCD);
                }

                using (TestExecution.CreateTestStepGroup("Step 7 - Verify deleted and recreated customer in BigCommerce"))
                {
                    SyncStatus.OpenScreen();
                    SyncStatus.SetVerifyFilter(Entities.Customer, Statuses.Synchronized, "BigCommerce");

                    var localID = customerEntity.AcctCD;
                    SyncStatus.DetailsFilter.LocalID.Contains(localID);
                    syncStatus = SyncStatus.Get();
                    long.Parse(externalID).VerifyEquals(long.Parse(syncStatus.DetailsView?.FirstOrDefault()?.ExternalID) - 1, "Customer is recreated in BC").Assert();
                    externalID = syncStatus.DetailsView?.FirstOrDefault()?.ExternalID;
                    EntityComparer.Instance.Validate(GetSyncStatusExt(localID, Statuses.Synchronized), syncStatus)
                                    .Trace(Messages.ValidateSyncStatusFor(Entities.Customer, localID))
                                    .IsValid
                                    .VerifyEquals(true);
                }

                using (TestExecution.CreateTestStepGroup("Step 8 - Save ID"))
                {
                    SaveID(this.GetType());
                }
            }
        }

        private SyncStatus GetSyncStatusExt(string acctCD, string status)
        {
            var syncStatusExt = new SyncStatus();
            syncStatusExt.DetailsView.Add(new SyncStatusDetails
            {
                LocalID = $"{acctCD}, Holiday Plaza",
                Status = status
            });

            return syncStatusExt;
        }
    }
}

