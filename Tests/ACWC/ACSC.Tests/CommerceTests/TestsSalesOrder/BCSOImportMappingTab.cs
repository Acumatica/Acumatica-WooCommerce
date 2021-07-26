using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACSC.Tests.BigCommerceRest;
using ACSC.Tests.Custom;
using ACSC.Tests.Entity.SalesOrder;
using ACSC.Tests.EntityData;
using ACSC.Tests.EntityDataService;
using ACSC.Tests.TestsSalesOrder;
using BCApiClient.Rest.Domain.Entities.Customers;
using Core.TestExecution;
using ACSC.Tests.BigCommerceRest.Rest.Domain.Entities.Customers;
using ACSC.Tests.BigCommerceRest.Rest.Domain.Entities.Orders;
using ACSC.Tests.BigCommerceTests.EntityData;
using BCApiClient.Rest.Domain.Entities.Orders;

namespace ACSC.Tests.BigCommerceTests.TestsSalesOrder
{
    public class BCSOImportMappingTab : BCTestSalesOrderBase
    {
        public override void Execute()
        {
            using (TestExecution.CreateTestCaseGroup("Sales Order: Import Mapping tab (Additional)"))
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
                    ManualSyncByLocalId(Entities.Customer, "New York Cares");
                }

                using (TestExecution.CreateTestStepGroup("Step 2 - Set Import Mapping"))
                {
                    connectorEntity = DataService.GetConnectorEntityMapping(BcDataFilePath.SOImportMapping);
                    ConnectorEntity.OpenScreen();
                    ConnectorEntity.SetImportMapping(connectorEntity);
                    ConnectorEntity.Save();
                }

                using (TestExecution.CreateTestStepGroup("Step 3 - Create a Sales Order in BigCommerce"))
                {
                    var orderData = GetOrderDataObj();
                    newBcOrder = CreateBCOrder(orderData);
                }

                using (TestExecution.CreateTestStepGroup("Step 4 - Import Sales Orders into AC"))
                {
                    FetchDataPage.FetchDataByEntityUsingFetchModeWithSyncMode(store, FetchMode.Incremental,SyncMode.PendingAndFailed,Entities.SalesOrder, newBcOrder.Id.ToString());
                    
                    ConnectorEntity.OpenScreen();
                    ConnectorEntity.ClearImportMapping(connectorEntity);
                    ConnectorEntity.Save();
                }

                using (TestExecution.CreateTestStepGroup("Step 5 - Verify Import Process Success in Acumatica."))
                {
                    VerifySyncSuccessInAcumatica(newBcOrder.Id.ToString(), false);
                }

                using (TestExecution.CreateTestStepGroup("Step 6 - Verify Acumatica"))
                {
                    var soOrderEx = GetOrderValidationObj();
                    VerifyACSalesOrder(localOrderNbr, soOrderEx);
                }

                using (TestExecution.CreateTestStepGroup("Step 7 - Save ID"))
                {
                    SaveID(this.GetType());
                }
            }
        }

        private void PrepareData()
        {
            ConfigureBCPaymentsMapping();
            store = Stores.BigCommerce;
            ConnectorEntity.OpenScreen();
            ConnectorEntity.SetConnectorSettings(Entities.Customer, "Bidirectional", "Local", store);
            ConnectorEntity.ExportFilters.RemoveAllRows();
            ConnectorEntity.Save();
        }

        private OrderData GetOrderDataObj()
        {
            SyncStatus.OpenScreen();
            SyncStatus.SetVerifyFilter(Entities.Customer, Statuses.Synchronized, store: store);
            SyncStatus.DetailsFilter.LocalID.Contains("NYCARES");
            extCustID = GetCustomerExtId();
            
            //get synchronized products id's from sync screen
            SyncStatus.SetVerifyFilter(Entities.StockItem, Statuses.Synchronized, localID: "Acer Laptop Computer", store: store);
            productStatus = SyncStatus.Get();
            productId = productStatus?.DetailsView?.FirstOrDefault(l => l.LocalID == "Acer Laptop Computer")?.ExternalID;
            var customerDataProvider = BigCommerceApiService.Instance.сustomerRestDataProvider;
            var bcCustomer = customerDataProvider.GetByID(int.Parse(extCustID));
            var orderDataEx = new OrderData
            {
                CustomerId = int.Parse(extCustID),
                Customer = bcCustomer,
                Products = new List<OrderProductData> {new OrderProductData {Id = int.Parse(productId), Quantity = 1}},
                BillingAddress = GetOrderBillingAddress(bcCustomer.Addresses.FirstOrDefault()),
                ShippingAddresses = new List<OrderShippingAddressData> { GetOrderShippingAddress(bcCustomer.Addresses.FirstOrDefault()) },
                DiscountAmount = 10.00m,
                StatusId = 0
            };
           
            return orderDataEx;

        }
        
        private SalesOrderEntity GetOrderValidationObj()
        {
            var orderEx = new SalesOrderEntity
            {
                Summary =
                {
                    Custom_1 = newBcOrder.Id.ToString(),
                    Project = "TMR03"
                }
            };
         
            orderEx.DocumentDetails.Add(new SalesOrderEntityDetails
            {
                InventoryID = "AACOMPUT01",
                OrderQty = 1.00m,
                UnitPrice = 500.00m,
                CuryDiscAmt = 10.00m,
                ProjectTask = "101 PM"
            });

            orderEx.Totals = new SalesOrderEntityTotals
            {
                CuryPaymentTotal = null,
                SubTotal = null,
                CuryTaxTotal = null,
                CuryOrderTotal = 480.00m,
                CuryDiscTot = 10.00m,
                OrderQty = 1.00m,
                FreightPrice = null
            };

            return orderEx;
        }
    }
}
