using ACSC.Tests.Cleanup;
using ACSC.Tests.Entity.Customer;
using ACSC.Tests.Entity.SyncStatus;
using ACSC.Tests.EntityData;
using ACSC.Tests.EntityDataService;
using ACSC.Tests.EntityValidators;
using ACSC.Tests.PageVisitors;
using ACSC.Tests.ShopifyRest;
using Core.TestExecution;
using System;
using System.Collections.Generic;
using System.Linq;
using ACSC.Tests.PageVisitors.Customer;
using ACSC.Tests.ShopifyRest.Domain.Entities.Customers;
using ACSC.Tests.Custom;
using Controls.Grid;
using Core.Wait;

namespace ACSC.Tests.TestsCustomer
{
    public class ExportACCustomers_Filtering_ToSP : TestCustomerBase
    {
        private CustomerGI customerGI;
        private Dictionary<string, string> externalIds = new Dictionary<string, string>();
        private List<CustomerEntity> customers;

        public override void Execute()
        {
            using (TestExecution.CreateTestCaseGroup("Export Customers from AC to SP using Filtering"))
            {
                using (TestExecution.CreateTestStepGroup("Step 0 - Clearing"))
                {
                    Clearing(this.GetType());
                }

                using (TestExecution.CreateTestStepGroup("Step 1 - Prepare data"))
                {
                    PrepareData();
                }

                using (TestExecution.CreateTestStepGroup("Step 2 - Identify Customers in Acumatica"))
                {
                    CustomerGI.OpenScreen();
                    CustomerGI.ResultsGridHeader.Customer_createdDateTime.ShowColumn();
                    CustomerGI.ResultsGridHeader.Customer_customerClassID.Equals("DOM");
                    CustomerGI.ResultsGridHeader.Customer_createdDateTime.SortDescending();

                    customerGI = CustomerGI.Get();
                    var removedDups = customerGI.ResultRows.ToList()
                        .GroupBy(customer => customer.CustomerName)
                        .Select(group => group.OrderBy(row => row.CustomerID))
                        .Select(group => group.LastOrDefault())
                        .ToList().OrderBy(x=>x.CustomerName).ToList();
                    customerGI.ResultRows = removedDups;
                    var customerGIExt = GetCustomerGIExt();
                    EntityComparer.Instance.Validate(customerGIExt, customerGI)
                                           .Trace("Validate Filtered Customers");
                }

                using (TestExecution.CreateTestStepGroup("Step 3 - Set Export Filtering for Customers"))
                {
                    var connectorEntity = DataService.GetConnectorEntityMapping(DataFilePath.CustomerExportFiltering);
                    ConnectorEntity.OpenScreen();
                    ConnectorEntity.SetConnectorSettings(Entities.Customer, "Bidirectional", "Local", "Shopify");
                    ConnectorEntity.SetExportFilter(connectorEntity);
                    ConnectorEntity.Save();
                }

                using (TestExecution.CreateTestStepGroup("Step 4 - Export Customers to SP"))
                {
                    FetchDataPage.FetchData(store, FetchMode.Incremental, Entities.Customer);
                    ProcessDataPage.OpenScreen();
                    ProcessDataPage.SetProcessFilter(Stores.Shopify, new []{Statuses.Pending}, Entities.Customer);

                    using (new Wait(PX.QA.Tools.WaitBase.LongTimeOut * 5))
                    {
                        ProcessDataPage.ToolBar.Process.WaitActionOverride = () => Wait.WaitForLongOperationToComplete();
                        ProcessDataPage.ProcessAll();
                        ProcessDataPage.ProcessingGridDetails.Close();
                    }
                }

                using (TestExecution.CreateTestStepGroup("Step 5 - Verify Export Process Success in Acumatica."))
                {
                    SyncStatus.OpenScreen();
                    SyncStatus.SetVerifyFilter(Entities.Customer, Statuses.Synchronized);

                    foreach (var customer in customerGI.ResultRows)
                    {
                        var customerID = customer.CustomerID;
                        var localID = $"{customerID}, {customer.CustomerName}";
                        SyncStatus.DetailsFilter.LocalID.Contains(customerID);
                        var syncStatusExt = GetSyncStatus(localID);
                        syncStatus = SyncStatus.Get();
                        if (syncStatus != null)
                        {
                            externalIds.Add(syncStatus.ExternalIds.FirstOrDefault(), customer.CustomerName);
                        }

                        EntityComparer.Instance.Validate(syncStatusExt, syncStatus)
                                               .Trace($"Validate SyncStatus for Customer ({customerID})");
                    }
                }

                using (TestExecution.CreateTestStepGroup("Step 6 - Verify Shopify."))
                {
                    var customerDataProvider = ShopifyApiService.Instance.CustomerRestDataProvider;

                    var customerDataExts = GetCustomerDataValidationObj();
                    foreach (var item in externalIds)
                    {
                        var customerDataExt = customerDataExts.FirstOrDefault(c => c.Addresses.Any(a => a.Company.StartsWith(item.Value)));
                        customerData = customerDataProvider.GetByID(item.Key);
                        EntityComparer.Instance.Validate(customerDataExt, customerData)
                                               .Trace($"Shopify Customer: Validate Customer ( ExternalID: {item.Key}, CompanyID {item.Value})");
                    }
                }

                using (TestExecution.CreateTestStepGroup("Step 5 - Save ID"))
                {
                    SaveID(this.GetType());
                }
            }
        }

        protected override void SaveID(Type type)
        {
            var cleanupHelper = CleanupHelper.Instance;
            var list = externalIds.Keys.Select(k => k).ToList();
            cleanupHelper.Save(type, new ClenupEntity(typeof(CustomerData), list));
        }

        private void PrepareData()
        {
            store = Stores.Shopify;
            ConnectorEntity.RemoveImportExportMappingFiltering(store);
            ACCustomerClassPage.OpenScreen();
            ACCustomerClassPage.Insert();
            ACCustomerClassPage.Summary.CustomerClassID.Type("DOM");
            ACCustomerClassPage.Summary.Descr.Type("DOM Customer class");
            ACCustomerClassPage.GeneralSettings.CountryID.Select("US");
            ACCustomerClassPage.Save();

            var visitor = VisitorsManager.GetSingle<ICustomerVisitor>(typeof(CustomerVisitor));
            customers = DataService.GetCustomerList(DataFilePath.ExportACCustomersFilteringToSP);
            CustomerPage.OpenScreen();
            foreach (var customer in customers)
            {
                customer.MainContact.EMail = GenerateRandomEmail();
                customer.MainContact.Phone1 = GetRandomTelNo();
                visitor.SetData(customer);
                CustomerPage.Insert();
                CustomerPage.Full(visitor);
                CustomerPage.Save();
                customer.AcctCD = CustomerPage.Summary.AcctCD.GetValue();
            }
        }

        private List<CustomerData> GetCustomerDataValidationObj()
        {
            var res = new List<CustomerData>();
            //1
            var customerData = new CustomerData
            {
                FirstName = "Jevy",
                LastName = "Computers"
            };

            customerData.AddAddresses(new CustomerAddressData
            {
                Company = "Jevy Computers",
                Province = "California",
                City = "San Francisco",
                Country = "United States"
            });
            res.Add(customerData);

            //2
            var customerData2 = new CustomerData
            {
                FirstName = "YY",
                LastName = "Studio"
            };
            customerData2.AddAddresses(new CustomerAddressData
            {
                Company = "YY Studio",
                Province = "California",
                City = "San Francisco",
                Country = "United States"
            });
            res.Add(customerData2);

            //2
            var customerData3 = new CustomerData
            {
                FirstName = "Glog",
                LastName = "Consulting L"
            };
            customerData3.AddAddresses(new CustomerAddressData
            {
                Company = "Glog Consulting Ltd.",
                Province = "California",
                City = "San Francisco",
                Country = "United States"
            });
            res.Add(customerData3);

            //3
            var customerData4 = new CustomerData
            {
                FirstName = "Cognitive",
                LastName = "Solutions Co"
            };
            customerData4.AddAddresses(new CustomerAddressData
            {
                Company = "Cognitive Solutions Co",
                Province = "California",
                City = "San Francisco",
                Country = "United States"
            });
            res.Add(customerData4);

            return res;
        }

        private CustomerGI GetCustomerGIExt()
        {
             return new CustomerGI
            {
                ResultRows = new List<CustomerGIRow>{
                    new CustomerGIRow{
                        CustomerID = customers.LastOrDefault(c => c.AcctName == "Cognitive Solutions Co")?.AcctCD,
                        CustomerName = "Cognitive Solutions Co",
                        CustomerClass = "DOM" },
                    new CustomerGIRow{
                        CustomerID = customers.LastOrDefault(c => c.AcctName == "Glog Consulting Ltd.")?.AcctCD,
                        CustomerName = "Glog Consulting Ltd.",
                        CustomerClass = "DOM" },
                    new CustomerGIRow{
                        CustomerID = customers.LastOrDefault(c => c.AcctName == "Jevy Computers")?.AcctCD,
                        CustomerName = "Jevy Computers",
                        CustomerClass = "DOM" },
                    new CustomerGIRow{
                        CustomerID = customers.LastOrDefault(c => c.AcctName == "YY Studio")?.AcctCD,
                        CustomerName = "YY Studio",
                        CustomerClass = "DOM" },

                }
            };
        }

        private SyncStatus GetSyncStatus(string localID)
        {
            var syncStatus = new SyncStatus();
            syncStatus.DetailsView.Add(new SyncStatusDetails { LocalID = localID, Status = Statuses.Synchronized });
            return syncStatus;
        }
    }
}