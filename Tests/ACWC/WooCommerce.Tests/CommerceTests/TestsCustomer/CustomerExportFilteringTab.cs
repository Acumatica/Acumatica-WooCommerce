using ACSC.Tests.BigCommerceTests.EntityData;
using ACSC.Tests.Custom;
using ACSC.Tests.Entity.Customer;
using ACSC.Tests.Entity.SyncStatus;
using ACSC.Tests.EntityDataService;
using ACSC.Tests.EntityValidators;
using ACSC.Tests.PageVisitors;
using ACSC.Tests.PageVisitors.Customer;
using ACSC.Tests.TestsCustomer;
using BCApiClient.Rest.Domain.Entities.Customers;
using Core.TestExecution;
using PX.QA.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using GeneratedWrappers.Acumatica;
using ACSC.Tests.BigCommerceRest.Rest.Domain.Entities.Customers;

namespace ACSC.Tests.BigCommerceTests.TestsCustomer
{
    public class CustomerExportFilteringTab : TestCustomerBase
    {
        List<CustomerEntity> customers;
        private bool existCustomer;
        int randNum;
        public override void Execute()
        {
            using (TestExecution.CreateTestCaseGroup("Export Customers from AC to BC using Filtering"))
            {
                using (TestExecution.CreateTestStepGroup("Step 0 - Clearing"))
                {
                    BCClearing(this.GetType());
                    PrepareData();
                }

                using (TestExecution.CreateTestStepGroup("Step 1 - Create Customers in Acumatica"))
                {
                    var visitor = VisitorsManager.GetSingle<ICustomerVisitor>(typeof(CustomerVisitor));
                    customers = DataService.GetCustomerList(BcDataFilePath.CustomerExportFilteringTab);

                    Random rand = new Random();
                    CustomerGI.OpenScreen();
                    do
                    {
                        randNum = rand.Next(000, 999);
                        CustomerGI.Results.Columns.Customer_acctCD.Equals(string.Join(string.Empty, customers.FirstOrDefault().AcctCD, randNum));
                        existCustomer = CustomerGI.Get().ResultRows.Count > 0;
                    } while (existCustomer);

                    CustomerPage.OpenScreen();

                    foreach (var customer in customers)
                    {
                        customer.AcctCD = string.Join(string.Empty, customer.AcctCD, randNum);
                        customer.MainContact.EMail = GenerateRandomEmail();
                        visitor.SetData(customer);
                        CustomerPage.Insert();
                        CustomerPage.Full(visitor);
                        CustomerPage.Save();
                    }
                }

                using (TestExecution.CreateTestStepGroup("Step 2 - Set Export Mapping"))
                {
                    var connectorEntity = DataService.GetConnectorEntityMapping(BcDataFilePath.CustomerExportFiltering);
                    ConnectorEntity.OpenScreen();
                    ConnectorEntity.SetConnectorSettings(Entities.Customer, "Bidirectional", "Local", "BigCommerce");
                    ConnectorEntity.SetExportFilter(connectorEntity);
                    ConnectorEntity.Save();
                }

                using (TestExecution.CreateTestStepGroup("Step 3 - Export Customer to BC"))
                {
                    FetchDataPage.FetchData(store, FetchMode.Incremental, Entities.Customer);
                    ProcessDataPage.OpenScreen();
                    ProcessDataPage.SetProcessFilter(Stores.BigCommerce, new[] { Statuses.Pending }, Entities.Customer);
                    ProcessDataPage.ProcessAll();
            
                    ConnectorEntity.OpenScreen();
                    ConnectorEntity.SetConnectorSettings(Entities.Customer, "Bidirectional", "Local", "BigCommerce");
                    ConnectorEntity.ExportFilters.RemoveAllRows();
                    ConnectorEntity.Save();
                }

                using (TestExecution.CreateTestStepGroup("Step 4 - Verify Export Process Success in Acumatica."))
                {
                    SyncStatus.OpenScreen();
                    SyncStatus.SetVerifyFilter(Entities.Customer, Statuses.Synchronized, "BigCommerce");
                    var syncCustomer = customers.Find(x => x.AcctCD == string.Join(string.Empty, "CUSTX", randNum));
                    var localID = syncCustomer.AcctCD;
                    SyncStatus.DetailsFilter.LocalID.Contains(localID);
                    syncStatus = SyncStatus.Get();
                    externalID = syncStatus.DetailsView.FirstOrDefault()?.ExternalID;

                    var localIDExt = $"{localID}, {syncCustomer.AcctName}";
                    var customerExt = GetSyncStatusExt(localIDExt, Statuses.Synchronized);

                    EntityComparer.Instance.Validate(customerExt, syncStatus)
                                    .Trace(Messages.ValidateSyncStatusFor(Entities.Customer, localID))
                                    .IsValid
                                    .VerifyEquals(true);

                    customers.Remove(syncCustomer);

                    SyncStatus.OpenScreen();
                    SyncStatus.SetVerifyFilter(Entities.Customer, Statuses.Filtered, "BigCommerce");

                    foreach (var customer in customers)
                    {
                        localID = customer.AcctCD;
                        SyncStatus.DetailsFilter.LocalID.Contains(localID);
                        syncStatus = SyncStatus.Get();

                        localIDExt = $"{localID}, {customer.AcctName}";
                        customerExt = GetSyncStatusExt(localIDExt, Statuses.Filtered);

                        EntityComparer.Instance.Validate(customerExt, syncStatus)
                                        .Trace(Messages.ValidateSyncStatusFor(Entities.Customer, localID))
                                        .IsValid
                                        .VerifyEquals(true);
                    }
                }

                using (TestExecution.CreateTestStepGroup("Step 7 - Verify Customer in BigCommerce"))
                {
                    var customerDataExt = GetCustomerDataObj();

                    var customer = bcCustomerRestDataProvider.GetByID(int.Parse(externalID));
                    EntityComparer.Instance.Validate(customerDataExt, customer)
                        .Trace(Messages.ValidateSyncStatusFor(Entities.Customer, externalID))
                        .IsValid
                        .VerifyEquals(true);

                }

                using (TestExecution.CreateTestStepGroup("Step 8 - Save ID"))
                {
                    SaveID(this.GetType());
                }
            }
        }

        private void PrepareData()
        {
            store = Stores.BigCommerce;
            SegmentedKeysPage.OpenScreen();
            SegmentedKeysPage.Summary.DimensionID.Select("CUSTOMER");
            SegmentedKeysPage.Summary.NumberingID.Select("CUSTOMER");
            SegmentedKeysPage.Details.SelectRow(1);
            SegmentedKeysPage.Details.Row.AutoNumber.SetFalse();
            SegmentedKeysPage.Save();
            CustomerPriceClass.OpenScreen();
            var custPriceClassList = DataService.GetCustomerPriceClassesData(BcDataFilePath.CustomerExportFilteringCustClass);
            CustomerPriceClass.Full(custPriceClassList);
            CustomerPriceClass.Save();
            ACCustomerClassPage.OpenScreen();
            ACCustomerClassPage.Summary.CustomerClassID.Type("LOCAL1");
            ACCustomerClassPage.Summary.Descr.Type("Local Customers");
            ACCustomerClassPage.Save();
        }

        private CustomerData GetCustomerDataObj()
        {
            return new CustomerData() { Company = "New Customer X" };
        }

        private SyncStatus GetSyncStatusExt(string acctCD, string status)
        {
            var syncStatusExt = new SyncStatus();
            syncStatusExt.DetailsView.Add(new SyncStatusDetails
            {
                LocalID = acctCD,
                Status = status
            });

            return syncStatusExt;
        }
    }
}
