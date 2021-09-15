using ACSC.Tests.Entity.SalesOrder;
using ACSC.Tests.EntityData;
using ACSC.Tests.EntityValidators;
using ACSC.Tests.ShopifyRest;
using Core.TestExecution;
using System.Linq;
using ACSC.Tests.ShopifyRest.Domain.Entities.Customers;
using ACSC.Tests.ShopifyRest.Domain.Entities.Order;
using ACSC.Tests.Custom;
using ACSC.Tests.EntityDataService;

namespace ACSC.Tests.TestsSalesOrder
{
    public class ImportSalesOrderMultipleItemsTaxesForCustomerWC : TestSalesOrderBase
    {
        public override void Execute()
        {
            using (TestExecution.CreateTestCaseGroup("Import Sales Order in US dollars for Stock Items to a Canadian Customer paid with Cash"))
            {
                using (TestExecution.CreateTestStepGroup("Step 0 - Clearing & Preparing data"))
                {
                    Clearing(this.GetType());
                    PrepareData();
                }

                using (TestExecution.CreateTestStepGroup("Step 1 - Sync Data"))
                {
                    store = Stores.WooCommerce;
                    FetchDataPage.FetchData(store, FetchMode.Incremental, Entities.Customer, Entities.StockItem);
                    //ManualSyncByLocalId(Entities.Customer, customer.AcctCD);
                    FetchDataPage.FetchDataByEntityUsingFetchModeWithSyncMode(store, FetchMode.Incremental, SyncMode.PendingAndFailed, Entities.Customer, newCustomer.Id.ToString());
                    ManualSyncByLocalId(Entities.StockItem, "Lego 500 piece set");
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
                    VerifySyncSuccessInAcumatica(newOrder.Id.ToString(), false);
                    VerifySyncSuccessInAcumatica(newOrder.Id.ToString(), false, Entities.Payment);
                }
                using (TestExecution.CreateTestStepGroup("Step 5 - Verify Acumatica"))
                {
                    //Validate Sales Order
                    var soOrderEx = GetOrderValidationObj();
                    VerifyACSalesOrder(localOrderNbr, soOrderEx);
                    //Validate Payment
                    var paymentType = SalesOrderPage.Applications.Row.AdjgDocType.GetValue();
                    PaymentPage.OpenScreen();
                    var paymentNbr = salesOrder.Payments.FirstOrDefault()?.ReferenceNbr;
                    PaymentPage.Summary.DocType.Select(paymentType);
                    PaymentPage.Summary.RefNbr.Select(paymentNbr);

                    payment = PaymentPage.Get();
                    payment.Summary.CustomerID = payment.Summary.CustomerID.Split('-')[1].Trim();
                    var paymentEx = GetPaymentValidationObj("eCommerce Guest Customer", 101.75m);
                    EntityComparer.Instance.Validate(paymentEx, payment)
                        .Trace("Acumatica Payment: Validate Payment");
                }

                using (TestExecution.CreateTestStepGroup("Step 6 - Save ID"))
                {
                    SaveID(this.GetType());
                }
            }
        }

        private void PrepareData()
        {
            store = Stores.WooCommerce;
            //GenerateCalendar();
            CreateStockItems(DataFilePath.SOMultipleItemsTaxesCACustItemsToCreate);
            ConfigurePaymentsMapping();
            //Add Tax
            TaxZoneGI.OpenScreen();
            TaxZoneGI.Details.Columns.TaxZone_TaxZoneID.Equals("NYSTATE");
            if (TaxZoneGI.Details.RowsCount() == 0)
            {
                TaxesPage.AddNewTax();

                //Add Tax Zone
                TaxesPage.AddNewTaxZone();


                //Configure Carrier
                CarrierPage.OpenScreen();
                CarrierPage.Insert();
                CarrierPage.Summary.CarrierID.Type("BEST");
                CarrierPage.Summary.Description.Type("Best");
                CarrierPage.CarrierDetails.CalendarID.Type("EST");
                CarrierPage.CarrierDetails.FreightSalesAcctID.Type("40010");
                CarrierPage.CarrierDetails.FreightSalesSubID.Type("000-000");
                CarrierPage.CarrierDetails.FreightExpenseAcctID.Type("61500");
                CarrierPage.CarrierDetails.FreightExpenseSubID.Type("000-000");
                CarrierPage.Save();

                //Configure Substitution List
                SubstitutionList.OpenScreen();
                SubstitutionList.Insert();
                SubstitutionList.Summary.SubstitutionID.Select("SPCTAXCODES");
                SubstitutionList.Details.New();
                SubstitutionList.Details.Row.OriginalValue.Type("QST");
                SubstitutionList.Details.Row.SubstitutedValue.Type("QCQST");
                SubstitutionList.Save();
            }

            //Add Customer
            createCustomerWC();

            //CreateCustomerAndLocation(DataFilePath.SimonMann, "Jacques Plante");
        }

        private OrderData GetOrderDataObj()
        {
            SyncStatus.OpenScreen();
            if (string.IsNullOrEmpty(extCustID))
            {
                SyncStatus.SetVerifyFilter(Entities.Customer, Statuses.Synchronized, store);
                SyncStatus.DetailsFilter.LocalID.Contains(customer.AcctCD);
                extCustID = GetCustomerExtId();
            }

            long.TryParse(extCustID, out var customerId);

            orderData = DataService.GetOrderData(DataFilePath.ImportSalesOrderMultipleItemsTaxesForCanadianCustomerWooCom);

            return orderData;
        }

        private SalesOrderEntity GetOrderValidationObj()
        {
            var orderEx = new SalesOrderEntity
            {
                Summary = GetOrderSummary("Jacques Plante")
            };
            orderEx.DocumentDetails.Add(new SalesOrderEntityDetails
            {
                InventoryID = "AALEGO500",
                OrderQty = 1.00m,
                UnitPrice = 100.00m,
                CuryDiscAmt = null
            });


            orderEx.TaxDetails.Add(new SalesOrderEntityTaxDetails
            {
                TaxID = "NY STANDARD TAX",
                TaxAmt = 9.25m
            });

            orderEx.Payments.Add(new SalesOrderEntityPayments
            {
                ReferenceNbr = salesOrder.Payments?.FirstOrDefault()?.ReferenceNbr
            });

            orderEx.Totals = new SalesOrderEntityTotals
            {
                CuryTaxTotal = 9.25m,
                CuryOrderTotal = 101.75m,
                CuryDiscTot = null,
                CuryPaymentTotal = 101.75m,
                SubTotal = 0.00m,
                OrderQty = 1.00m,
                FreightPrice = null
            };

            return orderEx;
        }
    }
}