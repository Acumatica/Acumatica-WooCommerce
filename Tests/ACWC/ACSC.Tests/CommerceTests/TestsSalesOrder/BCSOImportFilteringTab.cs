using System;
using System.Collections.Generic;
using System.Linq;
using ACSC.Tests.BigCommerceRest;
using ACSC.Tests.Custom;
using ACSC.Tests.Entity.SalesOrder;
using ACSC.Tests.EntityDataService;
using Core.TestExecution;
using ACSC.Tests.BigCommerceRest.Rest.Domain.Entities.Orders;
using ACSC.Tests.BigCommerceTests.EntityData;
using ACSC.Tests.EntityValidators;
using BCApiClient.Rest.Domain.Entities.Orders;
using PX.QA.Tools;

namespace ACSC.Tests.BigCommerceTests.TestsSalesOrder
{
    public class BCSOImportFilteringTab : BCTestSalesOrderBase
    {
        public override void Execute()
        {
            using (TestExecution.CreateTestCaseGroup("Sales Order: Import Filtering tab (Additional)"))
            {
                using (TestExecution.CreateTestStepGroup("Step 0 - Clearing"))
                {
                    BCClearing(this.GetType());
                    PrepareData();
                }

                using (TestExecution.CreateTestStepGroup("Step 1 - Sync Data"))
                {
                    FetchDataPage.OpenScreen();
                    FetchDataPage.SetProcessFilter(FetchMode.Reconciliation, store: Stores.BigCommerce, Entities.StockItem, Entities.SalesCategory, Entities.Customer);
                    FetchDataPage.Process();
                    ProcessDataPage.OpenScreen();
                    ProcessDataPage.SetProcessFilter(Stores.BigCommerce, new[] { Statuses.Pending }, Entities.SalesCategory);
                    ProcessDataPage.ProcessAll();
                    ManualSyncByLocalId(Entities.StockItem, "Acer Laptop Computer");
                    ManualSyncByLocalId(Entities.Customer, "ABC Holdings Inc");
                }

                using (TestExecution.CreateTestStepGroup("Step 2 - Set Import Filtering"))
                {
                    connectorEntity = DataService.GetConnectorEntityMapping(BcDataFilePath.SOImportFiltering);
                    ConnectorEntity.OpenScreen();
                    ConnectorEntity.SetImportFilter(connectorEntity);
                    ConnectorEntity.Save();
                }

                using (TestExecution.CreateTestStepGroup("Step 3 - Create a Sales Order in BigCommerce"))
                {
                    var orderData = GetOrderDataObj();
                    newBcOrder = CreateBCOrder(orderData);
                }

                using (TestExecution.CreateTestStepGroup("Step 4 - Fetch Sales Orders into AC"))
                {
                    FetchDataPage.FetchData(store, FetchMode.Incremental, Entities.SalesOrder);
                    ConnectorEntity.OpenScreen();
                    ConnectorEntity.ClearImportFilter(connectorEntity);
                    ConnectorEntity.Save();
                }

                using (TestExecution.CreateTestStepGroup("Step 5 - Verify Fetch Process"))
                {
                    VerifyPrepareStatusByExternalIdNegative(Entities.SalesOrder, newBcOrder.Id.ToString())
                        .VerifyEquals(true, "Sales Order not imported").Assert();
                    externalOrderID = newBcOrder.Id.ToString();
                }

                //using (TestExecution.CreateTestStepGroup("Step 6 - Verify Acumatica"))
                //{
                //    SalesOrderGI.OpenScreen();
                //    SalesOrderGI.Records.Columns.SOOrder_customerID_description.Equals("ABC Holdings Inc");
                //    SalesOrderGI.Records.Columns.SOOrder_createdDateTime.Today();
                //    var soCount = SalesOrderGI.Records.RowsCount().ToString();
                //    int.TryParse(soCount, out var soRowCount);
                //    soRowCount.VerifyEquals(0, $"Sales Order for requested date: {DateTime.Today} not imported").Assert();
                //}

                using (TestExecution.CreateTestStepGroup("Step 6 - Save ID"))
                {
                    SaveID(this.GetType());
                }
            }
        }

        private void PrepareData()
        {
            store = Stores.BigCommerce;
            ConnectorEntity.OpenScreen();
            ConnectorEntity.SetConnectorSettings(Entities.Customer, "Bidirectional", "Local", store);
            ConnectorEntity.Save();
        }

        private OrderData GetOrderDataObj()
        {
            SyncStatus.OpenScreen();
            SyncStatus.SetVerifyFilter(Entities.Customer, Statuses.Synchronized, store: store);
            SyncStatus.DetailsFilter.LocalID.Contains("ABCHOLDING");
            extCustID = GetCustomerExtId();
            SyncStatus.SetVerifyFilter(Entities.StockItem, Statuses.All, localID: "Acer Laptop Computer", store: store);
            productStatus = SyncStatus.Get();
            productId = productStatus?.DetailsView?.FirstOrDefault(l => l.LocalID == "Acer Laptop Computer")?.ExternalID;
            var customerDataProvider = BigCommerceApiService.Instance.сustomerRestDataProvider;
            var bcCustomer = customerDataProvider.GetByID(int.Parse(extCustID));

            var orderDataEx = new OrderData
            {
                CustomerId = int.Parse(extCustID),
                Customer = bcCustomer,
                Products = new List<OrderProductData> { new OrderProductData { Id = int.Parse(productId), Quantity = 1 } },
                BillingAddress = GetOrderBillingAddress(bcCustomer.Addresses.FirstOrDefault()),
                ShippingAddresses = new List<OrderShippingAddressData> { GetOrderShippingAddress(bcCustomer.Addresses.FirstOrDefault()) },
                DiscountAmount = 10.00m,
                StatusId = 0
            };

            return orderDataEx;
        }
    }
}
