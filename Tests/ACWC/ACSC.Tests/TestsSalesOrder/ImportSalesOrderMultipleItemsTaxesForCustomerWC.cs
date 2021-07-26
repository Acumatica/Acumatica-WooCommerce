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

                using (TestExecution.CreateTestStepGroup("Step 1 - Sync Data"))
                {
                    store = Stores.Shopify;
                    FetchDataPage.FetchData(store, FetchMode.Incremental, Entities.Customer, Entities.StockItem);
                    ManualSyncByLocalId(Entities.Customer, customer.AcctCD);
                    ManualSyncByLocalId(Entities.StockItem, "Laptop 14" );
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
                    var paymentEx = GetPaymentValidationObj("Jacques Plante", 706.75m);
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
            GenerateCalendar();
            CreateStockItems(DataFilePath.SOMultipleItemsTaxesCACustItemsToCreate);
            ConfigurePaymentsMapping();
            //Add Tax
            TaxZoneGI.OpenScreen();
            TaxZoneGI.Details.Columns.TaxZone_TaxZoneID.Equals("QCQST");
            if (TaxZoneGI.Details.RowsCount() == 0)
            {
                TaxesPage.OpenScreen();
                TaxesPage.Insert();
                TaxesPage.Settings.TaxID.Type("QCQST");
                TaxesPage.Settings.Descr.Type("Quebec QST");
                TaxesPage.Settings.TaxType.Select("Sales");
                TaxesPage.Details.New();
                TaxesPage.Details.Row.TaxRate.Type("9.975");
                TaxesPage.Details.Row.TaxBucketID.Select("Default Input Group");
                TaxesPage.Details.New();
                TaxesPage.Details.Row.TaxRate.Type("9.975");
                TaxesPage.Details.Row.TaxBucketID.Select("Default Output Group");
                TaxesPage.Accounts.SalesTaxAcctID.Select("24100");
                TaxesPage.Accounts.SalesTaxSubID.Type("000-000");
                TaxesPage.Accounts.ReportExpenseToSingleAccount.SetFalse();
                TaxesPage.Save();

                //Add Tax Zone
                TaxZonesPage.OpenScreen();
                TaxZonesPage.Insert();
                TaxZonesPage.Summary.TaxZoneID.Type("QCQST");
                TaxZonesPage.Summary.Descr.Type("Quabec QST");
                TaxZonesPage.Summary.DfltTaxCategoryID.Type("TAXABLE");
                TaxZonesPage.Details.New();
                TaxZonesPage.Details.Row.TaxID.Select("CAGST");
                TaxZonesPage.Details.New();
                TaxZonesPage.Details.Row.TaxID.Select("QCQST");
                TaxesPage.Save();

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
            CreateCustomerAndLocation(DataFilePath.SimonMann, "Jacques Plante");
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
                InventoryID = "LAPTOP14",
                OrderQty = 1.00m,
                UnitPrice = 650.00m,
                CuryDiscAmt = null
            });


            orderEx.TaxDetails.Add(new SalesOrderEntityTaxDetails
            {
                TaxID = "NY Standard Tax",
                TaxAmt = 64.25m
            });

            orderEx.Payments.Add(new SalesOrderEntityPayments
            {
                ReferenceNbr = salesOrder.Payments?.FirstOrDefault()?.ReferenceNbr
            });

            orderEx.Totals = new SalesOrderEntityTotals
            {
                CuryTaxTotal = 64.25m,
                CuryOrderTotal = 706.75m,
                CuryDiscTot = null,
                CuryPaymentTotal = 0.00m,
                SubTotal = 0.00m,
                OrderQty = 1.00m,
                FreightPrice = null
            };

            return orderEx;
        }
    }
}