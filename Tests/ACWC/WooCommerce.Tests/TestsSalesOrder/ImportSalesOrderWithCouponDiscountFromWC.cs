using ACSC.Tests.Custom;
using ACSC.Tests.Entity.Items.StockItems;
using ACSC.Tests.Entity.SalesOrder;
using ACSC.Tests.EntityData;
using ACSC.Tests.EntityDataService;
using ACSC.Tests.EntityValidators;
using ACSC.Tests.ShopifyRest;
using ACSC.Tests.ShopifyRest.Domain.Entities.Customers;
using ACSC.Tests.ShopifyRest.Domain.Entities.Enumerations;
using ACSC.Tests.ShopifyRest.Domain.Entities.Order;
using Core.TestExecution;
using PX.QA.Tools;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ACSC.Tests.TestsSalesOrder
{
    public class ImportSalesOrderWithCouponDiscountFromWC : TestSalesOrderBase
    {
        public override void Execute()
        {
            using (TestExecution.CreateTestCaseGroup("Import a Sales Order with a Coupon Discount from Shopify"))
            {

                using (TestExecution.CreateTestStepGroup("Step 1 - Sync Data"))
                {
                    FetchDataPage.FetchData(store, FetchMode.Incremental, Entities.StockItem, Entities.StockItem);
                    ManualSyncByLocalId(Entities.Customer, customer.AcctCD);
                    ManualSyncByLocalId(Entities.StockItem, "Headset");

                }

                using (TestExecution.CreateTestStepGroup("Step 2 - Create a Sales Order in Shopify"))
                {
                    var orderData = GetOrderDataObj();

                    newOrder = CreateOrder(orderData);
                }

                using (TestExecution.CreateTestStepGroup("Step 3 - Import Sales Orders into AC"))
                {
                    FetchDataPage.FetchDataByEntityUsingFetchModeWithSyncMode(store, FetchMode.Incremental, SyncMode.PendingAndFailed, Entities.SalesOrder, newOrder.Id.ToString());
                }

                using (TestExecution.CreateTestStepGroup("Step 4 - Verify Import Process Success in Acumatica."))
                {
                    VerifySyncSuccessInAcumatica(newOrder.Id.ToString(), false);
                    VerifySyncSuccessInAcumatica(newOrder.Id.ToString(), false, Entities.Payment);
                }

                using (TestExecution.CreateTestStepGroup("Step 5 - Verify Acumatica"))
                {
                    var soOrderEx = GetOrderValidationObj();
                    VerifyACSalesOrder(localOrderNbr, soOrderEx);

                    //Validate Payment
                    var paymentType = SalesOrderPage.Applications.Row.AdjgDocType.GetValue();
                    PaymentPage.OpenScreen();
                    var paymentNbr = salesOrder.Payments.FirstOrDefault()?.ReferenceNbr;
                    PaymentPage.Summary.DocType.Select(paymentType);
                    PaymentPage.Summary.RefNbr.Select(paymentNbr);
                    var payment = PaymentPage.Get();
                    payment.Summary.CustomerID = payment.Summary.CustomerID.Split('-')[1].Trim();

                    var paymentEx = GetPaymentValidationObj("Jacques Plante", 142.50m);
                    EntityComparer.Instance.Validate(paymentEx, payment)
                        .Trace("Acumatica Payment: Validate Payment")
                        .IsValid
                        .VerifyEquals(true);
                }

                using (TestExecution.CreateTestStepGroup("Step 6 - Save ID"))
                {
                    SaveID(GetType());
                }
            }
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
            SyncStatus.SetVerifyFilter(Entities.StockItem, Statuses.Synchronized, "Headset", store: store);
            var syncStatus = SyncStatus.Get();

            var HEADSET = syncStatus?.DetailsView?.FirstOrDefault(l => l.LocalID == "Headset")?.ExternalID;

            var productDataProvider = WooCommerceApiService.Instance.ProductRestDataProvider;
            //var productId = productDataProvider.GetByID(HEADSET).Variants[0].Id;
            var productId = productDataProvider.GetByID(HEADSET).Id;

            long.TryParse(extCustID, out long customerId);

            // var orderDataExt = new OrderData();

            orderData = DataService.GetOrderData(DataFilePath.ImportSalesOrderWithCouponDiscountFromWC);

            return orderData;
        }

        private SalesOrderEntity GetOrderValidationObj()
        {
            var orderEx = new SalesOrderEntity
            {
                Summary = GetOrderSummary("Jacques Plante"),
                Totals = new SalesOrderEntityTotals()
                {
                    OrderQty = 1.00m,
                    CuryOrderTotal = 142.50m,
                    FreightPrice = null
                }
            };

            orderEx.Summary.NoteText = "Discount Order";
            orderEx.DocumentDetails.Add(new SalesOrderEntityDetails
            {
                InventoryID = "HEADSET",
                OrderQty = 1.00m,
                UnitPrice = 150.00m
            });

            orderEx.DiscountDetails.Add(new SalesOrderEntityDiscountDetails
            {
                DiscAmt = 7.50m,
                DiscountPct = 5.00m,
                ExtDiscCode = "disc_coupon"
            });

            return orderEx;
        }
    }
}