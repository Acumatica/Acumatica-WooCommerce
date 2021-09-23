using ACSC.Tests.Custom;
using ACSC.Tests.Entity.Items.StockItems;
using ACSC.Tests.Entity.SalesOrder;
using ACSC.Tests.ShopifyRest;
using ACSC.Tests.ShopifyRest.Domain.Entities.Customers;
using ACSC.Tests.ShopifyRest.Domain.Entities.Order;
using Core.TestExecution;
using System.Linq;
using ACSC.Tests.EntityData;
using ACSC.Tests.EntityDataService;

namespace ACSC.Tests.TestsSalesOrder
{
    public class ImportSalesOrderQTYRefundFromWC : TestSalesOrderBase
    {
        public long? orderID { get; private set; }
        
        public override void Execute()
        {
            using (TestExecution.CreateTestCaseGroup("Import a Sales Order for an existing Customer and Item"))
            {
                using (TestExecution.CreateTestStepGroup("Step 0 - Clearing"))
                {
                    Clearing(this.GetType());
                    PrepareData();
                }

                using (TestExecution.CreateTestStepGroup("Step 1 - Sync Data"))
                {
                    FetchDataPage.FetchData(store, FetchMode.Incremental, Entities.StockItem, Entities.Customer);
                    ManualSyncByLocalId(Entities.StockItem, "Acer Laptop Computer");
                    FetchDataPage.FetchDataByEntityUsingFetchModeWithSyncMode(store, FetchMode.Incremental, SyncMode.PendingAndFailed, Entities.Customer, customer.AcctCD);
                }

                using (TestExecution.CreateTestStepGroup("Step 2 - Create a Sales Order in WooCommerce"))
                {
                    var orderData = GetOrderDataObj();
                    newOrder = CreateOrder(orderData);
                }

                using (TestExecution.CreateTestStepGroup("Step 3 - Import Sales Orders into WC"))
                {
                    FetchDataPage.FetchDataByEntityUsingFetchModeWithSyncMode(store, FetchMode.Incremental, SyncMode.PendingAndFailed, Entities.SalesOrder, newOrder.Id.ToString());
                }

                using (TestExecution.CreateTestStepGroup("Step 4 - Verify Import Process Success in Acumatica."))
                {
                    VerifySyncSuccessInAcumatica(newOrder.Id.ToString(), false, Entities.SalesOrder);
                }

                using (TestExecution.CreateTestStepGroup("Step 5 - Verify Acumatica"))
                {
                    SalesOrderEntity soOrderEx = GetOrderValidationObj();
                    VerifyACSalesOrder(localOrderNbr, soOrderEx);
                }

                using (TestExecution.CreateTestStepGroup("Step 6 - Create a Refund"))
                {
                    var refundData = GetRefundDataObj();
                    int wcOrderID = (int)newOrder.Id;
                    CreateRefunds(refundData,wcOrderID);
                }
                using (TestExecution.CreateTestStepGroup("Step 7 - Import Refund into AC"))
                {
                    FetchDataPage.FetchDataByEntityUsingFetchModeWithSyncMode(store, FetchMode.Incremental, SyncMode.PendingAndFailed, Entities.Refund, newOrder.Id.ToString());
                }
                using (TestExecution.CreateTestStepGroup("Step 8 - Verify Import Process Success in Acumatica."))
                {
                    VerifySyncSuccessInAcumatica(newOrder.Id.ToString(), false, Entities.SalesOrder);
                }

                using (TestExecution.CreateTestStepGroup("Step 9 - Save ID"))
                {
                    SaveID(this.GetType());
                }
            }
        }

        private void PrepareData()
        {
            store = Stores.WooCommerce;
            //GenerateCalendar();
            CreateStockItems(DataFilePath.SOForExistingCustomerAndItem);
            //ConfigurePaymentsMapping();
            ACCustomerClassPage.OpenScreen();
            ACCustomerClassPage.Insert();
            ACCustomerClassPage.Summary.CustomerClassID.Click();
            ACCustomerClassPage.Summary.CustomerClassID.Type("ECCUSTOMER");
            ACCustomerClassPage.Summary.Descr.Type("Online Customers class");
            ACCustomerClassPage.GeneralSettings.CountryID.Select("US");
            ACCustomerClassPage.Save();
            createCustomerWC();

            //CreateCustomerAndLocation(DataFilePath.GlogConsulting, "Glog Consulting Ltd.");
        }

        private OrderData GetOrderDataObj()
        {
            SyncStatus.OpenScreen();
            if (string.IsNullOrEmpty(extCustID))
            {
                SyncStatus.SetVerifyFilter(Entities.Customer, Statuses.Synchronized);
                SyncStatus.DetailsFilter.LocalID.Contains(customer.AcctCD);

                extCustID = GetCustomerExtId();
            }
            //get synchronized products id's from sync screen
            SyncStatus.SetVerifyFilter(Entities.StockItem, Statuses.Synchronized, "Acer Laptop Computer", store: store);
            productStatus = SyncStatus.Get();

            var AACOMPUT01 = productStatus?.DetailsView?.FirstOrDefault(l => l.LocalID == "Acer Laptop Computer")?.ExternalID;

            var orderDataProvider = WooCommerceApiService.Instance.ProductRestDataProvider;
            //var variantId1 = orderDataProvider.GetByID(AALEGO500).Variants?.FirstOrDefault()?.Id;
            var variantId1 = orderDataProvider.GetByID(AACOMPUT01).Id;
            long.TryParse(extCustID, out long customerId);
            orderData = DataService.GetOrderData(DataFilePath.SalesOrderForExistingCustomerAndItemWCRefund);
            return orderData;
        }

        private OrderRefund GetRefundDataObj()
        {
            refundData = DataService.GetOrderRefund(DataFilePath.ImportSalesOrderRefundFromWC);
            var lineItems = newOrder.LineItems;
            var getLineItems = lineItems.ToArray();
            var tempLineItem = getLineItems[0];

            var tstItem = refundData.RefundLineItems.FirstOrDefault();
            if (tstItem != null)
            {
                tstItem.Id = tempLineItem.Id;
            }

            return refundData;

        }

        private SalesOrderEntity GetOrderValidationObj()
        {
            var orderEx = new SalesOrderEntity
            {
                Summary = GetOrderSummary("Glog Consulting Ltd.")
            };
            orderEx.DocumentDetails.Add(new SalesOrderEntityDetails
            {
                InventoryID = "AACOMPUT01",
                OrderQty = 4.00m,
                UnitPrice = 500.00m,
                CuryDiscAmt = null
            });

            orderEx.Totals = new SalesOrderEntityTotals
            {
                CuryPaymentTotal = null,
                SubTotal = null,
                CuryTaxTotal = null,
                CuryOrderTotal = 2000.00m,
                CuryDiscTot = null,
                OrderQty = 4.00m,
                FreightPrice = 0.00m
            };

            return orderEx;
        }
    }
}