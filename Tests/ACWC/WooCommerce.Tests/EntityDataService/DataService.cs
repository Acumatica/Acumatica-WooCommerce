using ACSC.Tests.Entity.Attribute;
using ACSC.Tests.Entity.Customer;
using ACSC.Tests.Entity.ItemClass;
using ACSC.Tests.Entity.Items.NonStockItems;
using ACSC.Tests.Entity.Items.StockItems;
using ACSC.Tests.Entity.Items.TemplateItem;
using ACSC.Tests.Entity.Location;
using ACSC.Tests.Entity.SalesOrder;
using ACSC.Tests.Entity.Warehouse;
using ACSC.Tests.ShopifyRest.Domain.Entities.Common;
using ACSC.Tests.ShopifyRest.Domain.Entities.Customers;
using ACSC.Tests.ShopifyRest.Domain.Entities.Order;
using ACSC.Tests.ShopifyRest.Domain.Entities.PriceRule;
using ACSC.Tests.ShopifyRest.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.IO;
using ACSC.Tests.Entity.ConnectorEntity;
using ACSC.Tests.Entity.CustomerPriceClasses;
using ACSC.Tests.Entity.SalesPrices;
using ACSC.Tests.Entity.ItemWarehouseDetails;
using ACSC.Tests.BigCommerceRest.Rest.Domain.Entities.PriceList;

namespace ACSC.Tests.EntityDataService
{
    public class DataService
    {
        private readonly IFileDataProvider builder;

        private DataService(IFileDataProvider builder)
        {
            this.builder = builder;
        }

        public static DataService FileReader<T>() where T : IFileDataProvider
        {
            var builder = Activator.CreateInstance<T>() as IFileDataProvider;
            return new DataService(builder);
        }

        public IFileDataProvider Construct(string fileName)
        {
            builder.FilePath = Path.Combine(Environment.CurrentDirectory, fileName);
            return builder;
        }

        public static BigCommerceRest.Rest.Domain.Entities.Customers.CustomerData GetBCCustomerData(string fileName)
        {
            return FileReader<JsonFileReader>().Construct(fileName).Get<BigCommerceRest.Rest.Domain.Entities.Customers.CustomerData>();
        }

        public static CustomerData GetCustomerData(string fileName)
        {
            return FileReader<JsonFileReader>().Construct(fileName).Get<CustomerData>();
        }

        public static CustomerEntity GetCustomer(string fileName)
        {
            return FileReader<JsonFileReader>().Construct(fileName).Get<CustomerEntity>();
        }

        public static CustomerEntity GetCustomer(string fileName, DateTime? dateTime)
        {
            var customer = GetCustomer(fileName);

            if (dateTime != null && dateTime.HasValue)
            {
                customer.MainContact.ConsentDate = dateTime;
            }

            return customer;
        }

        public static List<LocationEntity> GetLocations(string fileName)
        {
            return FileReader<JsonFileReader>().Construct(fileName).Get<List<LocationEntity>>();
        }

        public static SalesOrderEntity GetSalesOrder(string fileName, DateTime? dateTime)
        {
            var salesOrder = GetSalesOrder(fileName);
            if (dateTime != null)
            {
                salesOrder.Summary.OrderDate = dateTime;
            }

            return salesOrder;
        }

        public static SalesOrderEntity GetSalesOrder(string fileName)
        {
            return FileReader<JsonFileReader>().Construct(fileName).Get<SalesOrderEntity>();
        }

        public static OrderData GetOrderData(string fileName)
        {
            return FileReader<JsonFileReader>().Construct(fileName).Get<OrderData>();
        }

        public static PriceRuleData GetPriceRuleData(string fileName)
        {
            return FileReader<JsonFileReader>().Construct(fileName).Get<PriceRuleData>();
        }

        public static List<NonStockItemEntity> GetNonStockItems(string fileName)
        {
            return FileReader<JsonFileReader>().Construct(fileName).Get<List<NonStockItemEntity>>();
        }

        public static List<MetafieldData> GetMetafields(string fileName)
        {
            return FileReader<JsonFileReader>().Construct(fileName).Get<List<MetafieldData>>();
        }

        public static List<ProductData> GetStockItems(string fileName)
        {
            return FileReader<JsonFileReader>().Construct(fileName).Get<List<ProductData>>();
        }

        public static List<StockItemGIRow> GetStockItemsGI(string fileName)
        {
            return FileReader<JsonFileReader>().Construct(fileName).Get<List<StockItemGIRow>>();
        }

        public static List<StockItemEntity> GetStockItemsEntity(string fileName)
        {
            return FileReader<JsonFileReader>().Construct(fileName).Get<List<StockItemEntity>>();
        }

        public static List<CustomerEntity> GetCustomerList(string fileName)
        {
            return FileReader<JsonFileReader>().Construct(fileName).Get<List<CustomerEntity>>();
        }

        public static ItemClassEntity GetItemClassEntity(string fileName)
        {
            return FileReader<JsonFileReader>().Construct(fileName).Get<ItemClassEntity>();
        }

        public static List<AttributeEntity> GetAttributes(string fileName)
        {
            return FileReader<JsonFileReader>().Construct(fileName).Get<List<AttributeEntity>>();
        }

        public static WarehouseEntity GetWarehouseEntity(string fileName)
        {
            return FileReader<JsonFileReader>().Construct(fileName).Get<WarehouseEntity>();
        }

        public static AvailCalcRuleEntity GetAvailCalcRule(string fileName)
        {
            return FileReader<JsonFileReader>().Construct(fileName).Get<AvailCalcRuleEntity>();
        }

        public static TemplateItemEntity GetTemplateItem(string fileName)
        {
            return FileReader<JsonFileReader>().Construct(fileName).Get<TemplateItemEntity>();
        }

        public static List<TemplateItemEntityMatrixItemsResult> GetTemplateItemVariantsEntity(string fileName)
        {
            return FileReader<JsonFileReader>().Construct(fileName).Get<List<TemplateItemEntityMatrixItemsResult>>();
        }

        public static ProductData GetProductData(string fileName)
        {
            return FileReader<JsonFileReader>().Construct(fileName).Get<ProductData>();
        }

        public static List<ProductVariantData> GetVariantProductData(string fileName)
        {
            return FileReader<JsonFileReader>().Construct(fileName).Get<List<ProductVariantData>>();
        }

        public static List<TemplateItemGIRow> GetTemplateItemGI(string fileName)
        {
            return FileReader<JsonFileReader>().Construct(fileName).Get<List<TemplateItemGIRow>>();
        }

        public static ConnectorEntity GetConnectorEntityMapping(string fileName)
        {
            return FileReader<JsonFileReader>().Construct(fileName).Get<ConnectorEntity>();
        }

        public static CustomerPriceClassesEntity GetCustomerPriceClassesData(string fileName)
        {
            return FileReader<JsonFileReader>().Construct(fileName).Get<CustomerPriceClassesEntity>();
        }

        public static SalesPriceEntity GetSalesPriceData(string fileName)
        {
            return FileReader<JsonFileReader>().Construct(fileName).Get<SalesPriceEntity>();
        }

        public static ItemWarehouseDetailsEntity GetWarehouseDetailEntity(string fileName)
        {
            return FileReader<JsonFileReader>().Construct(fileName).Get<ItemWarehouseDetailsEntity>();
        }

        public static SalesPriceEntity GetSalesPriceEntity(string fileName)
        {
            return FileReader<JsonFileReader>().Construct(fileName).Get<SalesPriceEntity>();
        }

        public static List<PriceListData> GetPriceListData(string fileName)
        {
            return FileReader<JsonFileReader>().Construct(fileName).Get<List<PriceListData>>();
        }
    }
}