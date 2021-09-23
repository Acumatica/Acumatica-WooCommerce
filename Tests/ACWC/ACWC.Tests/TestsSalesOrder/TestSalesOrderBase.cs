using ACSC.Tests.Cleanup;
using ACSC.Tests.Custom;
using ACSC.Tests.Entity.Attribute;
using ACSC.Tests.Entity.Customer;
using ACSC.Tests.Entity.Items.StockItems;
using ACSC.Tests.Entity.Payment;
using ACSC.Tests.Entity.SalesOrder;
using ACSC.Tests.Entity.SyncStatus;
using ACSC.Tests.EntityData;
using ACSC.Tests.EntityDataService;
using ACSC.Tests.EntityValidators;
using ACSC.Tests.Extensions.Customer;
using ACSC.Tests.Extensions.NonStockItem;
using ACSC.Tests.Extensions.Payment;
using ACSC.Tests.Extensions.PurchaseOrders;
using ACSC.Tests.Extensions.SalesOrder;
using ACSC.Tests.Extensions.Shipment;
using ACSC.Tests.Extensions.StockItem;
using ACSC.Tests.Extensions.Taxes;
using ACSC.Tests.Extensions.TemplateItems;
using ACSC.Tests.PageVisitors;
using ACSC.Tests.PageVisitors.Customer;
using ACSC.Tests.PageVisitors.StockItem;
using ACSC.Tests.PageVisitors.TemplateItem;
using ACSC.Tests.ShopifyRest;
using ACSC.Tests.ShopifyRest.Client.DataRepository.Order;
using ACSC.Tests.ShopifyRest.Domain.Entities.Enumerations;
using ACSC.Tests.ShopifyRest.Domain.Entities.Products;
using ACSC.Tests.TestsBase;
using Core.Core.Browser;
using Core.Log;
using PX.QA.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using ACSC.Tests.BigCommerceRest;
using ACSC.Tests.BigCommerceRest.Rest.Domain.Entities.Orders;
using ACSC.Tests.Extensions.CustomerClass;
using ACSC.Tests.ShopifyRest.Domain.Entities.Customers;
using BCApiClient.Rest.Domain.Entities.Common;
using BCApiClient.Rest.Domain.Entities.Orders;
using static ACSC.Tests.Helpers.ValidatorHelper;
using OrderData = ACSC.Tests.ShopifyRest.Domain.Entities.Order.OrderData;
using OrderTransaction = ACSC.Tests.ShopifyRest.Domain.Entities.Order.OrderTransaction;
using WooCommerce.Tests.TestData;
using ACSC.Tests.ShopifyRest.Domain.Entities.Order;
using ACSC.Tests.ShopifyRest.Client.DataRepository.Refund;
using ACSC.Tests.ShopifyRest.Client.Common;

namespace ACSC.Tests.TestsSalesOrder
{
    public abstract class TestSalesOrderBase : TestBase
    {
        protected static StockItemsGi StockItemGI => new StockItemsGi();
        protected static StockItem StockItemPage => new StockItem();
        protected static ACTemplateItemGI TemplateItemGI => new ACTemplateItemGI();
        protected static TemplateItem TemplateItemPage => new TemplateItem();
        protected static ReceiptIn INReceiptEntryPage => new ReceiptIn();
        protected static NonStockItemsGI NonStockItemGI => new NonStockItemsGI();
        protected static NonStockItem NonStockItemPage => new NonStockItem();
        protected static ShippingZones ShippingZonePage => new ShippingZones();
        protected static CustomerClassAr ACCustomerClassPage => new CustomerClassAr();
        protected static SalesOrdersGI SalesOrderGI => new SalesOrdersGI();
        protected static OrderSo SalesOrderPage => new OrderSo();
        protected static Shipment ShipmentPage => new Shipment();
        protected static PaymentAr PaymentPage => new PaymentAr();

        protected static SubstitutionLists SubstitutionList => new SubstitutionLists();

        protected static ShipVia CarrierPage => new ShipVia();
        protected static ShipViaGI CarrierGI => new ShipViaGI();

        protected static CustomersGI CustomerGI => new CustomersGI();
        protected static CustomerAr CustomerPage => new CustomerAr();

        protected WooCommerceApiService service = WooCommerceApiService.Instance;
        protected OrderRestDataProvider orderRestDataProvider;

        protected RefundRestDataProvider refundRestDataProvider;

        protected static CreatePurchaseOrders CreatePurchaseOrdersPage => new CreatePurchaseOrders();
        protected static OrderPo PurchaseOrdersPage => new OrderPo();
        protected static ReceiptPo PurchaseOrdersReceiptPage => new ReceiptPo();
        protected static Tax TaxesPage => new Tax();
        protected static TaxZone TaxZonesPage => new TaxZone();
        protected static TaxZonesGI TaxZoneGI => new TaxZonesGI();
        protected IStockItemVisitor visitor;

        protected List<AttributeEntity> attributes;
        protected CustomerEntity customer;
        protected SalesOrderEntity salesOrder;
        protected PaymentEntity payment;
        protected OrderData newOrder;
        protected OrderDataResponse newBcOrder;
        protected ProductData newProduct;
        protected SyncStatus syncStatus;
        protected SyncStatus productStatus;
        protected string externalOrderID;
        protected string externalPayID;
        protected string extCustID;
        protected string localOrderNbr;
        protected string storeID;
        protected string localShipmentNbr;
        protected OrderData orderData;
        protected CustomerData newCustomer;
        protected CustomerData customerData;
        protected OrderRefund refundData;
        protected OrderRefund newRefund;

        protected TestSalesOrderBase()
        {
            customer = new CustomerEntity();
            visitor = VisitorsManager.GetSingle<IStockItemVisitor>(typeof(StockItemVisitor));
            orderRestDataProvider = service.OrderRestDataProvider;
            salesOrder = new SalesOrderEntity();
            refundRestDataProvider = service.RefundRestDataProvider;
        }

        protected virtual void Clearing(Type type)
        {
            var clenupHelper = CleanupHelper.Instance;
            var apiDataProvider = WooCommerceApiService.Instance.OrderRestDataProvider;
            try
            {
                var data = clenupHelper.Get(type);
                if (data.Any())
                {
                    foreach (var id in data.SelectMany(c => c.IDs))
                    {
                        apiDataProvider.Delete(id);
                    }
                    clenupHelper.Clean(type);
                }
            }
            catch (Exception e)
            {
                Log.Error($"Clearing error: {e}");
            }
        }


        protected virtual void SaveID(Type type)
        {
            var clenupHelper = CleanupHelper.Instance;
            clenupHelper.Save(type, new List<ClenupEntity> { new ClenupEntity(typeof(OrderData), externalOrderID) });
        }

        protected OrderData CreateOrder(OrderData order)
        {
            string orderId = orderRestDataProvider.Create(order)?.Id.ToString();
            
            if (string.IsNullOrEmpty(orderId)) throw new Exception(Messages.OrderWasntCreatedException);

            //orderRestDataProvider.PostPaymentToCapture(tranToCapture, orderId);
            return orderRestDataProvider.GetByID(orderId);
        }

        protected OrderRefund CreateRefunds(OrderRefund refund, int soOrderEx)
        {
            var segment = new UrlSegments();
            segment.Add("id", soOrderEx.ToString());
            string refundId = refundRestDataProvider.CreateRefund(refund, segment)?.Id.ToString();
            if (string.IsNullOrEmpty(refundId)) throw new Exception(Messages.RefundWasntCreatedException);
            return refundRestDataProvider.GetByID(refundId);
        }

        protected PaymentEntity GetPaymentValidationObj(string CustomerName, decimal paymentAmt, bool isCreditCard = false)
        {
            var paymentEx = new PaymentEntity
            {
                Summary = new PaymentEntityHeader
                {
                    CustomerID = CustomerName,
                   // DocDesc = ConcatPaymentDesc(newOrder?.Name, externalOrderID, externalPayID, storeID, isCreditCard),
                    RefNbr = salesOrder.Payments?.FirstOrDefault()?.ReferenceNbr,
                    PaymentAmt = paymentAmt
                }
            };

            return paymentEx;
        }

        protected Dictionary<string, string> GetOrderNbr()
        {
            return new Dictionary<string, string>
            {
                {Order.OrderType,  localOrderNbr?.Split(',')[0]},
                {Order.OrderNbr, localOrderNbr?.Split(',')[1].Trim()}
            };
        }

        protected SalesOrderEntityHeader GetOrderSummary(string CustomerName)
        {
            return new SalesOrderEntityHeader
            {
                //CustomerID = CustomerName,
                //CustomerRefNbr = string.Join(" - ", newOrder?.Name.Trim(), storeID),
                //OrderDesc = string.Join(" | ", storeID, "Order: " + newOrder?.Name, "Status: pending"),
                OrderDesc = string.Join(" | ", storeID, "Order: " + externalOrderID, "Status: pending"),
                OrderDate = Convert.ToDateTime(Browser.InstanceTime.ToShortDateString())
            };
        }

        public void createCustomerWC()
        {
            var customerDataProvider = WooCommerceApiService.Instance.CustomerRestDataProvider;
            WooCommerceStore.OpenScreen();
            WooCommerceStore.SetEntitySettings(Entities.Customer, "Import", "External System");
            WooCommerceStore.Save();
            CustomerGI.OpenScreen();
            customerData = DataService.GetCustomerData(DataFilePath.CreateCustomer_CAAddress_ImportToACData);
            customerData.Email = GenerateRandomEmail();
            customerData.Username = GenerateRandomUserName();
            string customerExt = customerData.Username;
            CustomerGI.Results.Columns.Customer_acctName.Equals(customerExt);
            var existedCust = CustomerGI.Get().ResultRows?.Where(c => c.CustomerID.Contains("C")).OrderBy(c => c.CustomerID).LastOrDefault();
            if (existedCust == null)
            {
                newCustomer = customerDataProvider.Create(customerData);
                var newCustomerExtID = newCustomer.Id;
                customer.AcctCD = newCustomerExtID.ToString();
            }

            else
            {
                SyncStatus.OpenScreen();
                SyncStatus.SetVerifyFilter(Entities.Customer, Statuses.Synchronized);
                SyncStatus.DetailsFilter.LocalID.Contains(existedCust.CustomerID);
                var syncDetails = SyncStatus.DetailsGrid;
                if (syncDetails.RowsCount() == 0)
                {
                    CustomerPage.OpenScreen();
                    CustomerPage.Summary.AcctCD.Select(existedCust.CustomerID);
                    CustomerPage.Contact.EMail.Type(GenerateRandomEmail());
                    if (!string.IsNullOrEmpty(CustomerPage.Contact.Phone1.GetValue()))
                    {
                        CustomerPage.Contact.Phone1.Type(GenerateRandomPhone());
                    }
                    CustomerPage.Save();
                    customer.AcctCD = existedCust.CustomerID;
                }
                else
                {
                    extCustID = GetCustomerExtId();
                    customer.AcctCD = existedCust.CustomerID;
                }
            }
        }

        protected void CreateCustomerAndLocation(string customerFilePath, string customerName, string typeName = null)
        {
            WooCommerceStore.OpenScreen();
            WooCommerceStore.SetEntitySettings(Entities.Customer, "Import", "External System");
            WooCommerceStore.Save();
            CustomerGI.OpenScreen();
            customer = DataService.GetCustomer(customerFilePath, Browser.InstanceTime);
            CustomerGI.Results.Columns.Customer_acctName.Equals(customerName);
            var existedCust = CustomerGI.Get().ResultRows?.Where(c => c.CustomerID.Contains("C")).OrderBy(c => c.CustomerID).LastOrDefault();
            if (existedCust == null)
            {
                CustomerClearing(typeName);
                CustomerGI.Insert();
                var visitors = VisitorsManager.Get<ICustomerVisitor>(customer, typeof(CustomerVisitor));
                customer.MainContact.EMail = GenerateRandomEmail();
                if (customer.MainContact.Phone1 != null)
                {
                    customer.MainContact.Phone1 = GenerateRandomPhone();
                }
                CustomerPage.Full(visitors);
                CustomerPage.Save();
                customer.AcctCD = CustomerPage.Summary.AcctCD.GetValue();
            }
            else
            {
                SyncStatus.OpenScreen();
                SyncStatus.SetVerifyFilter(Entities.Customer, Statuses.Synchronized);
                SyncStatus.DetailsFilter.LocalID.Contains(existedCust.CustomerID);
                var syncDetails = SyncStatus.DetailsGrid;
                if (syncDetails.RowsCount() == 0)
                {
                    CustomerPage.OpenScreen();
                    CustomerPage.Summary.AcctCD.Select(existedCust.CustomerID);
                    CustomerPage.Contact.EMail.Type(GenerateRandomEmail());
                    if (!string.IsNullOrEmpty(CustomerPage.Contact.Phone1.GetValue()))
                    {
                        CustomerPage.Contact.Phone1.Type(GenerateRandomPhone());
                    }
                    CustomerPage.Save();
                    customer.AcctCD = existedCust.CustomerID;
                }
                else
                {
                    extCustID = GetCustomerExtId();
                    customer.AcctCD = existedCust.CustomerID;
                }
            }
        }

        protected void CreateNJTax()
        {
            TaxZoneGI.OpenScreen();
            TaxZoneGI.Details.Columns.TaxZone_TaxZoneID.Equals("NJ");
            if (TaxZoneGI.Details.RowsCount() == 0)
            {
                TaxesPage.OpenScreen();
                TaxesPage.Insert();
                TaxesPage.Settings.TaxID.Type("NJ");
                TaxesPage.Settings.Descr.Type("New Jersey");
                TaxesPage.Settings.TaxType.Select("Sales");
                TaxesPage.Details.New();
                TaxesPage.Details.Row.TaxRate.Type("6.625");
                TaxesPage.Details.Row.TaxBucketID.Select("Default Input Group");
                TaxesPage.Details.New();
                TaxesPage.Details.Row.TaxRate.Type("6.625");
                TaxesPage.Details.Row.TaxBucketID.Select("Default Output Group");
                TaxesPage.Accounts.SalesTaxAcctID.Select("24100");
                TaxesPage.Accounts.SalesTaxSubID.Type("000-000");
                TaxesPage.Accounts.ReportExpenseToSingleAccount.SetFalse();
                TaxesPage.Save();

                //Add Tax Zone
                TaxZonesPage.OpenScreen();
                TaxZonesPage.Insert();
                TaxZonesPage.Summary.TaxZoneID.Type("NJ");
                TaxZonesPage.Summary.Descr.Type("New Jersey");
                TaxZonesPage.Summary.DfltTaxCategoryID.Type("TAXABLE");
                TaxZonesPage.Details.New();
                TaxZonesPage.Details.Row.TaxID.Select("NJ");
                TaxesPage.Save();

                //Configure Substitution List
                SubstitutionList.OpenScreen();
                SubstitutionList.Insert();
                SubstitutionList.Summary.SubstitutionID.Select("SPCTAXCODES");
                SubstitutionList.Details.New();
                SubstitutionList.Details.Row.OriginalValue.Type("NJ State Tax");
                SubstitutionList.Details.Row.SubstitutedValue.Type("NJ");
                SubstitutionList.Save();
            }
        }

        protected void CreateTemplateItem(string dataFilePath)
        {
            ActivateFeatures();
            templateItem = DataService.GetTemplateItem(dataFilePath);
            TemplateItemGI.OpenScreen();
            TemplateItemGI.ResultsGridHeader.InventoryItem_inventoryCD.Equals(templateItem.InventoryCD);
            if (TemplateItemGI.ResultsGrid.RowsCount() == 0 || StockItemGI.ResultsGridRow.ItemClass.GetValue() != templateItem.GeneralSettings.ItemClass || StockItemGI.ResultsGridRow.BasePrice != templateItem.PriceInfo.BasePrice)
            {
                calcRule = DataService.GetAvailCalcRule(DataFilePath.AvailCalcRuleCreateItem);
                itemClass = DataService.GetItemClassEntity(DataFilePath.CreateTemplateItemInAcumaticaExportToSP);
                attributes = DataService.GetAttributes(DataFilePath.AttributesCreateTemplateItems);
                warehouse = DataService.GetWarehouseEntity(DataFilePath.WarehouseCreateItem);
                CreateAvailCalcRule(calcRule);
                CreateWarehouse(warehouse);
                CreateAttributes(attributes);
                CreateItemClass(itemClass);
                ConfigureInventoryAutoNumbering();
                // Create Template Item
                var templateItemVisitor = VisitorsManager.GetSingle<ITemplateItemVisitor>(typeof(TemplateItemVisitor));
                TemplateItemPage.OpenScreen();
                templateItemVisitor.SetData(templateItem);
                TemplateItemPage.Full(templateItemVisitor);
            }
        }

        protected void CreateStockItems(string dataFilePath)
        {
            stockItems = DataService.GetStockItemsEntity(dataFilePath);
            itemClass = DataService.GetItemClassEntity(DataFilePath.ExportStockItemToWCCreateItemClass);
            warehouse = DataService.GetWarehouseEntity(DataFilePath.WarehouseCreateItem);
            calcRule = DataService.GetAvailCalcRule(DataFilePath.AvailCalcRuleCreateItem);
            var itemsToCreate = new List<StockItemEntity>();
            foreach (var stockItem in stockItems)
            {
                StockItemGI.OpenScreen();
                StockItemGI.ResultsGridHeader.InventoryItem_inventoryCD.Equals(stockItem.InventoryCD);

                if (StockItemGI.Details.RowsCount() == 0)
                {
                    itemsToCreate.Add(stockItem);
                }
                else
                {
                    StockItemPage.OpenScreen();
                    StockItemPage.Summary.InventoryCD.Select(stockItem.InventoryCD);
                    var existedItem = StockItemPage.Get();
                    if (IsModifiedItem(existedItem, stockItem))
                    {
                        itemsToCreate.Add(stockItem);
                    }
                }
            }
            if (!itemsToCreate.Any()) return;

            ConfigureInventoryAutoNumbering();
            CreateAvailCalcRule(calcRule);
            CreateWarehouse(warehouse);
            CreateItemClass(itemClass);

            StockItemPage.OpenScreen();
            foreach (var item in itemsToCreate)
            {
                visitor.SetData(item);
                StockItemPage.Insert();
                StockItemPage.Full(visitor);
                StockItemPage.Save();
            }
        }

        protected void VerifyACSalesOrder(string localOrderNbr, SalesOrderEntity expectedObject)
        {
            SalesOrderPage.OpenScreen();
            SalesOrderPage.Summary.OrderType.Select(GetOrderNbr()[Order.OrderType]);
            SalesOrderPage.Summary.OrderNbr.Select(GetOrderNbr()[Order.OrderNbr]);
            salesOrder = SalesOrderPage.Get();

            salesOrder.Summary.CustomerID = salesOrder.Summary.CustomerID.Split('-')[1].Trim();

            EntityComparer.Instance.Validate(expectedObject, salesOrder)
                .Trace(Messages.ValidateEntity(Entities.SalesOrder, localOrderNbr))
                .IsValid
                .VerifyEquals(true);
        }

        protected void VerifySyncSuccessInAcumatica(string id, bool local, string entity = Entities.SalesOrder)
        {
            SyncStatus.OpenScreen();
            SyncStatus syncStatusToCompare = GetSyncStatus();

            if (local)
            {
                SyncStatus.SetVerifyFilter(entity, Statuses.Synchronized, localID: id, store: store);
            }
            else
            {
                SyncStatus.SetVerifyFilter(entity, Statuses.Synchronized, externalID: id, store: store);
            }

            syncStatus = SyncStatus.Get();

            //Validate Sales Order
            EntityComparer.Instance.Validate(syncStatusToCompare, syncStatus)
                .Trace(Messages.ValidateSyncStatusFor(entity, id))
                .IsValid
                .VerifyEquals(true);

            storeID = syncStatus.Store;
            if (entity == Entities.SalesOrder)
            {
                localOrderNbr = syncStatus.DetailsView.FirstOrDefault()?.LocalID;
                externalOrderID = syncStatus.DetailsView.FirstOrDefault()?.ExternalID;
            }
            else if (entity == Entities.Payment)
            {
                externalPayID = syncStatus.DetailsView.FirstOrDefault()?.ExternalID;
            }
        }
        protected void VerifyRefundSyncSuccessInAcumatica(string id, bool local, string entity = Entities.Refund)
        {
            SyncStatus.OpenScreen();
            SyncStatus syncStatusToCompare = GetSyncStatus();

            if (local)
            {
                SyncStatus.SetVerifyFilter(entity, Statuses.Synchronized, localID: id, store: store);
            }
            else
            {
                SyncStatus.SetVerifyFilter(entity, Statuses.Synchronized, externalID: id, store: store);
            }

            syncStatus = SyncStatus.Get();

            //Validate Sales Order
            EntityComparer.Instance.Validate(syncStatusToCompare, syncStatus)
                .Trace(Messages.ValidateSyncStatusFor(entity, id))
                .IsValid
                .VerifyEquals(true);

            storeID = syncStatus.Store;
            if (entity == Entities.Refund)
            {
                localOrderNbr = syncStatus.DetailsView.FirstOrDefault()?.LocalID;
                externalOrderID = syncStatus.DetailsView.FirstOrDefault()?.ExternalID;
            }
            else if (entity == Entities.Payment)
            {
                externalPayID = syncStatus.DetailsView.FirstOrDefault()?.ExternalID;
            }
        }

        protected virtual void SetCustomerExportFilter()
        {
            ConnectorEntity.OpenScreen();
            ConnectorEntity.SetConnectorSettings(Entities.Customer);
            ConnectorEntity.ClearExportFilter();
            ConnectorEntity.SetExportFilter("Customer ID", "Equals", customer.AcctCD, "And");
            ConnectorEntity.Save();
        }
        protected virtual string GetCustomerExtId()
        {
            var idList = SyncStatus.Get().DetailsView.ToList();
            var expCust = idList.FirstOrDefault(x => x.LocalID.Split(',')[0].Contains("C"))?.ExternalID;
            return expCust ?? idList.FirstOrDefault()?.ExternalID;
        }

        protected virtual string GetCustomerTypeName(Type type)
        {
            return string.Join("", type, "Cust");
        }
        private SyncStatus GetSyncStatus()
        {
            var syncStatusExt = new SyncStatus();
            syncStatusExt.DetailsView.Add(new SyncStatusDetails
            {
                Status = Statuses.Synchronized
            });

            return syncStatusExt;
        }

        protected virtual void CustomerClearing(string name)
        {
            if (name != null)
            {
                var clenupHelper = CleanupHelper.Instance;
                var apiDataProvider = WooCommerceApiService.Instance.CustomerRestDataProvider;
                try
                {
                    var data = clenupHelper.Get(name);
                    if (data.Any())
                    {
                        foreach (var id in data.SelectMany(c => c.IDs))
                        {
                            apiDataProvider.Delete(id);
                        }
                        clenupHelper.Clean(name);
                    }
                }
                catch (Exception e)
                {
                    Log.Error($"Clearing error: {e}");
                }
            }
        }

        protected virtual void SaveCustomerID(string typeName, string customerName)
        {
            if (customer != null && string.IsNullOrEmpty(extCustID))
            {
                SyncStatus.OpenScreen();
                SyncStatus.SetVerifyFilter(Entities.Customer, Statuses.Synchronized, localID: customer.AcctCD);
                SyncStatus.DetailsFilter.LocalID.Contains(customerName);
                //syncStatus = SyncStatus.Get();
                extCustID = GetCustomerExtId();//syncStatus.DetailsView.FirstOrDefault()?.ExternalID;
                var clenupHelper = CleanupHelper.Instance;
                clenupHelper.Save(typeName, new List<ClenupEntity> { new ClenupEntity(typeof(CustomerData), extCustID) });
            }
        }
    }
}