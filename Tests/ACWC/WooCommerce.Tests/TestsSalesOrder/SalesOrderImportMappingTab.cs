//using System.Linq;
//using ACSC.Tests.Custom;
//using ACSC.Tests.Entity.SalesOrder;
//using ACSC.Tests.EntityData;
//using ACSC.Tests.EntityDataService;
//using ACSC.Tests.ShopifyRest;
//using ACSC.Tests.ShopifyRest.Domain.Entities.Customers;
//using ACSC.Tests.ShopifyRest.Domain.Entities.Order;
//using Core.TestExecution;

//namespace ACSC.Tests.TestsSalesOrder
//{
//    public class SalesOrderImportMappingTab : TestSalesOrderBase
//    {
//         public override void Execute()
//         {
//            using (TestExecution.CreateTestCaseGroup("Import a Sales Order for an existing Customer and Item"))
//            {
//                using (TestExecution.CreateTestStepGroup("Step 0 - Clearing"))
//                {
//                    Clearing(this.GetType());
//                    PrepareData();
//                }
                
//                using (TestExecution.CreateTestStepGroup("Step 1 - Sync Data"))
//                {
//                    FetchDataPage.FetchData(store, FetchMode.Reconciliation, Entities.Customer, Entities.StockItem);
//                    ManualSyncByLocalId(Entities.Customer, customer.AcctCD);
//                    SetManualSyncListByLocalId(Entities.StockItem, stockItems.Select(x => x.Description).ToList());
//                    SaveCustomerID(GetCustomerTypeName(this.GetType()), "Mag Darrow");
//                }

//                using (TestExecution.CreateTestStepGroup("Step 2 - Set Import Mapping"))
//                {
//                    var connectorEntity = DataService.GetConnectorEntityMapping(DataFilePath.SOImportMapping);
//                    ConnectorEntity.OpenScreen();
//                    ConnectorEntity.SetImportMapping(connectorEntity);
//                    ConnectorEntity.Save();
//                }

//                using (TestExecution.CreateTestStepGroup("Step 3 - Create a Sales Order in Shopify"))
//                {
//                    var orderData = GetOrderDataObj();
//                    newOrder = CreateOrder(orderData);
//                }

//                using (TestExecution.CreateTestStepGroup("Step 4 - Import Sales Orders into AC"))
//                {
//                    FetchDataPage.FetchDataByEntityUsingFetchModeWithSyncMode(store, FetchMode.Incremental, SyncMode.PendingAndFailed, Entities.SalesOrder, newOrder.Id.ToString());
//                    ConnectorEntity.OpenScreen();
//                    ConnectorEntity.ImportMappings.RemoveAllRows();
//                    ConnectorEntity.Save();
//                }

//                using (TestExecution.CreateTestStepGroup("Step 5 - Verify Import Process Success in Acumatica."))
//                {
//                    VerifySyncSuccessInAcumatica(newOrder.Id.ToString(), false, Entities.SalesOrder);
//                }

//                using (TestExecution.CreateTestStepGroup("Step 6 - Verify Acumatica"))
//                {
//                    SalesOrderEntity soOrderEx = GetOrderValidationObj();
//                    VerifyACSalesOrder(localOrderNbr, soOrderEx);
//                }

//                using (TestExecution.CreateTestStepGroup("Step 7 - Save ID"))
//                {
//                    SaveID(this.GetType());
//                }
//            }
//         }

//        private void PrepareData()
//        {
//            store = Stores.Shopify;
//            GenerateCalendar();
//            CreateStockItems(DataFilePath.SOImportMappingTab);
//            ConfigurePaymentsMapping();
//            CreateCustomerAndLocation(DataFilePath.MagDarrow, "Mag Darrow");
//        }

//        private OrderData GetOrderDataObj()
//        {
//            SyncStatus.OpenScreen();
//            if (string.IsNullOrEmpty(extCustID))
//            {
//                SyncStatus.SetVerifyFilter(Entities.Customer, Statuses.Synchronized);
//                SyncStatus.DetailsFilter.LocalID.Contains(customer.AcctCD);
//                extCustID = GetCustomerExtId();
//            }
//            //get synchronized products id's from sync screen
//            SyncStatus.SetVerifyFilter(Entities.StockItem, Statuses.Synchronized, "Acer Laptop Computer", store:store);
//            productStatus = SyncStatus.Get();

//            var AACOMPUT01 = productStatus?.DetailsView?.FirstOrDefault(l => l.LocalID == "Acer Laptop Computer")?.ExternalID;

//            var orderDataProvider = ShopifyApiService.Instance.ProductRestDataProvider;
//            var variantId1 = orderDataProvider.GetByID(AACOMPUT01).Variants?.FirstOrDefault()?.Id;
//            long.TryParse(extCustID, out long customerId);
//            var orderDataExt = new OrderData();
//            orderDataExt.Note = "Imported by mapping";
//            orderDataExt.Customer = new CustomerData
//            {
//                Id = customerId
//            };
           
//            orderDataExt.LineItems.Add(new OrderLineItem
//            {
//                VariantId = variantId1,
//                Quantity = 1,
//            });
//            return orderDataExt;
//        }

//        private SalesOrderEntity GetOrderValidationObj()
//        {
//            var orderEx = new SalesOrderEntity
//            {
//                Summary = GetOrderSummary("Mag Darrow")
//            };
//            orderEx.DocumentDetails.Add(new SalesOrderEntityDetails
//            {
//                InventoryID = "AACOMPUT01",
//                OrderQty = 1.00m,
//                UnitPrice = 600.00m,
//                CuryDiscAmt = null
//            });

//            orderEx.Totals = new SalesOrderEntityTotals
//            {
//                CuryPaymentTotal = null,
//                SubTotal = null,
//                CuryTaxTotal = null,
//                CuryOrderTotal = 600.00m,
//                CuryDiscTot = null,
//                OrderQty = 1.00m,
//                FreightPrice = null
//            };

//            return orderEx;
//        }
//    }
//}