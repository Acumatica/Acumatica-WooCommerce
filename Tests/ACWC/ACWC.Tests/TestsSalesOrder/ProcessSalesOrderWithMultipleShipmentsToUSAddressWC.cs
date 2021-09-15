﻿using ACSC.Tests.Custom;
using ACSC.Tests.Entity.SalesOrder;
using ACSC.Tests.Entity.Shipment;
using ACSC.Tests.EntityData;
using ACSC.Tests.EntityDataService;
using ACSC.Tests.EntityValidators;
using ACSC.Tests.ShopifyRest;
using ACSC.Tests.ShopifyRest.Domain.Entities.Enumerations;
using ACSC.Tests.ShopifyRest.Domain.Entities.Order;
using Core.TestExecution;
using PX.QA.Tools;
using System;
using System.Linq;
using ACSC.Tests.ShopifyRest.Domain.Entities.Customers;

namespace ACSC.Tests.TestsSalesOrder
{
    public class ProcessSalesOrderWithMultipleShipmentsToUSAddressWC : TestSalesOrderBase
    {
        public override void Execute()
        {
            using (TestExecution.CreateTestCaseGroup("Process Sales Order with multiple shipments to a US address"))
            {
                using (TestExecution.CreateTestStepGroup("Step 1 - Sync Data"))
                {
                    FetchDataPage.FetchData(store, FetchMode.Incremental, Entities.Customer, Entities.StockItem);
                    ManualSyncByLocalId(Entities.Customer, customer.AcctCD);
                    ManualSyncByLocalId(Entities.StockItem, "WC Coffee Mug");
                    SaveCustomerID(GetCustomerTypeName(this.GetType()), "eCommerce Guest Customer");
                }

                using (TestExecution.CreateTestStepGroup("Step 2 - Create a Sales Order in WooCommerce"))
                {
                    var orderData = GetOrderDataObj();

                    newOrder = CreateOrder(orderData);
                }

                using (TestExecution.CreateTestStepGroup("Step 3 - Import Sales Orders into WooCommerce"))
                {
                    FetchDataPage.FetchDataByEntityUsingFetchModeWithSyncMode(store, FetchMode.Incremental,
                        SyncMode.PendingAndFailed, Entities.SalesOrder, newOrder.Id.ToString());
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
                    //PaymentPage.Release();
                    var payment = PaymentPage.Get();
                    payment.Summary.CustomerID = payment.Summary.CustomerID.Split('-')[1].Trim();

                    var paymentEx = GetPaymentValidationObj("Acumatica", 706.75m);
                    EntityComparer.Instance.Validate(paymentEx, payment)
                        .Trace("Acumatica Payment: Validate Payment")
                        .IsValid
                        .VerifyEquals(true);
                }

                //1 Shipment
                using (TestExecution.CreateTestStepGroup("Step 6 - Create Shipment in Acumatica"))
                {
                    SalesOrderPage.OpenScreen();
                    SalesOrderPage.Summary.OrderType.Select(localOrderNbr?.Split(',')[0]);
                    SalesOrderPage.Summary.OrderNbr.Select(localOrderNbr?.Split(',')[1].Trim());

                    SalesOrderPage.AddShipment(warehouse.WarehouseID);
                }

                using (TestExecution.CreateTestStepGroup("Step 7 - Confirm Shipment in Acumatica"))
                {
                    localShipmentNbr = ShipmentPage.Summary.ShipmentNbr.GetValue();
                    ShipmentPage.ConfirmShipment(1);
                }

                using (TestExecution.CreateTestStepGroup("Step 8 - Export Shipments to WC"))
                {
                    FetchDataPage.FetchData(store, FetchMode.Incremental, Entities.Shipment);
                    ManualSyncByLocalId(Entities.Shipment, localShipmentNbr);
                }

                using (TestExecution.CreateTestStepGroup("Step 9 - Verify Export Process Success in Acumatica"))
                {
                    VerifySyncSuccessInAcumatica(localShipmentNbr, true, Entities.Shipment);

                    //Validate Shipment on Shipment screen
                    ShipmentPage.OpenScreen();
                    ShipmentPage.Summary.ShipmentNbr.Type(localShipmentNbr);
                    var shipment = ShipmentPage.Get();
                    shipment.Summary.CustomerID = shipment.Summary.CustomerID.Split('-')[1].Trim();
                    var shipmentEx = GetShipmentValidationObj_MONITOR26(localOrderNbr?.Split(',')[1].Trim());

                    EntityComparer.Instance.Validate(shipmentEx, shipment)
                        .Trace("Acumatica Payment: Validate Shipment")
                        .IsValid
                        .VerifyEquals(true);
                }

                using (TestExecution.CreateTestStepGroup("Step 10 - Verify WooCommerce"))
                {
                    var orderDataProvider = WooCommerceApiService.Instance.OrderRestDataProvider;
                    var orderData = orderDataProvider.GetByID(externalOrderID);
                    orderData.FulfillmentStatus.ToString().VerifyEquals(OrderFulfillmentStatus.Fulfilled.ToString());
                }

                using (TestExecution.CreateTestStepGroup("Step 11 - Save ID"))
                {
                    SaveID(this.GetType());
                }
            }
        }

        private ShipmentEntity GetShipmentValidationObj_MONITOR26(string orderNbr)
        {
            var shipmentEx = new ShipmentEntity()
            {
                Summary =
                {
                    CustomerID = "Acumatica",
                    ShipmentQty = 1.00m
                },
            };

            shipmentEx.DocumentDetails.Add(new ShipmentEntityDetails()
            {
                InventoryID = "SH-MUG",
                OrderNbr = orderNbr
            });

            return shipmentEx;
        }

        private ShipmentEntity GetShipmentValidationObj_Full(string orderNbr)
        {
            var shipmentEx = new ShipmentEntity()
            {
                Summary =
                {
                    CustomerID = "Acumatica",
                    ShipmentQty = 10.00m
                },
            };

            shipmentEx.DocumentDetails.Add(new ShipmentEntityDetails()
            {
                InventoryID = "SH-MUG",
                OrderNbr = orderNbr
            });

            shipmentEx.DocumentDetails.Add(new ShipmentEntityDetails()
            {
                InventoryID = "SIMCARD",
                OrderNbr = orderNbr
            });

            return shipmentEx;
        }

        private SalesOrderEntity GetOrderValidationObj()
        {
            var orderEx = new SalesOrderEntity
            {
                Summary = GetOrderSummary("Acumatica")
            };

            orderEx.DocumentDetails.Add(new SalesOrderEntityDetails
            {
                InventoryID = "SH-MUG",
                OrderQty = 1.00m,
                UnitPrice = 17.00m,
                CuryDiscAmt = null,
                SiteID = "WHOLESALE"
            });

            orderEx.DocumentDetails.Add(new SalesOrderEntityDetails
            {
                InventoryID = "SIMCARD",
                OrderQty = 10.00m,
                UnitPrice = 50.00m,
                CuryDiscAmt = null,
                SiteID = "RETAIL"
            });

            orderEx.DiscountDetails.Add(new SalesOrderEntityDiscountDetails
            {
                DiscAmt = null
            });

            orderEx.DiscountDetails.Add(new SalesOrderEntityDiscountDetails
            {
                DiscAmt = null
            });

            orderEx.Totals = new SalesOrderEntityTotals
            {
                OrderQty = 1.00m,
                CuryTaxTotal = 0.95m,
                CuryOrderTotal = 20.45m,
                CuryDiscTot = null,
                CuryPaymentTotal = 20.45m,
                FreightPrice = null
            };

            return orderEx;
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
            var orderData = DataService.GetOrderData(DataFilePath.ProcessSalesOrderWithMultipleShipmentsToUSAddress);

            var productDataProvider = WooCommerceApiService.Instance.ProductRestDataProvider;
            long.TryParse(extCustID, out var customerId);
            

            return orderData;
        }
    }
}
