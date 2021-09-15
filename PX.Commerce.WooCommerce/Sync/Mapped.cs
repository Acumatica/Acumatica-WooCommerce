using PX.Commerce.Core;
using PX.Commerce.Core.API;
using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Customer;
using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order;
using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Product;
using System;

namespace PX.Commerce.WooCommerce.Sync
{
    #region WCMappedEntity
    public abstract class WCMappedEntity<ExternType, LocalType> : MappedEntity<ExternType, LocalType>
        where ExternType : BCAPIEntity, IExternEntity
        where LocalType : CBAPIEntity, ILocalEntity
    {
        public WCMappedEntity(string entType)
            : base(WCConnector.TYPE, entType)
        { }
        public WCMappedEntity(BCSyncStatus status)
            : base(status)
        {
        }
        public WCMappedEntity(string entType, LocalType entity, Guid? id, DateTime? timestamp)
            : base(WCConnector.TYPE, entType, entity, id, timestamp)
        {
        }
        public WCMappedEntity(string entType, ExternType entity, string id, DateTime? timestamp)
            : base(WCConnector.TYPE, entType, entity, id, timestamp)
        {
        }
        public WCMappedEntity(string entType, ExternType entity, string id, string hash)
            : base(WCConnector.TYPE, entType, entity, id, hash)
        {
        }
    }
    #endregion

    #region MappedCustomer
    public class MappedCustomer : WCMappedEntity<CustomerData, Customer>
    {
        public const string TYPE = BCEntitiesAttribute.Customer;

        public MappedCustomer()
            : base(TYPE)
        { }
        public MappedCustomer(Customer entity, Guid? id, DateTime? timestamp)
            : base(TYPE, entity, id, timestamp) { }
        public MappedCustomer(CustomerData entity, string id, DateTime? timestamp)
            : base(TYPE, entity, id, timestamp) { }
    }
    #endregion

    #region MappedStockItem
    public class MappedStockItem : WCMappedEntity<ProductData, StockItem>
    {
        public const string TYPE = BCEntitiesAttribute.StockItem;

        public MappedStockItem()
            : base(TYPE)
        { }
        public MappedStockItem(StockItem entity, Guid? id, DateTime? timestamp)
            : base(TYPE, entity, id, timestamp) { }
        public MappedStockItem(ProductData entity, string id, DateTime? timestamp)
            : base(TYPE, entity, id, timestamp) { }
    }
    #endregion

    #region MappedContact
    public class MappedContact : WCMappedEntity<API.REST.Domain.Entities.Customer.ShippingAddressData, Contact>
    {
        public const string TYPE = BCEntitiesAttribute.Customer;

        public MappedContact()
            : base(TYPE)
        { }
        public MappedContact(Contact entity, Guid? id, DateTime? timestamp)
            : base(TYPE, entity, id, timestamp) { }
        public MappedContact(API.REST.Domain.Entities.Customer.ShippingAddressData entity, string id, DateTime? timestamp)
            : base(TYPE, entity, id, timestamp) { }
    }
    #endregion

    #region MappedCategory
    public class MappedCategory : WCMappedEntity<CategoryData, BCItemSalesCategory>
    {
        public const String TYPE = BCEntitiesAttribute.SalesCategory;

        public MappedCategory()
            : base(TYPE)
        { }
        public MappedCategory(BCItemSalesCategory entity, Guid? id, DateTime? timestamp)
            : base(TYPE, entity, id, timestamp) { }
        public MappedCategory(CategoryData entity, String id, DateTime? timestamp)
            : base(TYPE, entity, id, timestamp) { }
        public MappedCategory(CategoryData entity, String id, String hash)
            : base(TYPE, entity, id, hash) { }
    }
    #endregion

    #region MappedAttributes
    public class MappedAttributes : WCMappedEntity<AttributeData, AttributeValue>
    {
        public const String TYPE = BCEntitiesAttribute.ProductOption;

        public MappedAttributes()
            : base(TYPE)
        { }
        public MappedAttributes(AttributeValue entity, Guid? id, DateTime? timestamp)
            : base(TYPE, entity, id, timestamp) { }
        public MappedAttributes(AttributeData entity, String id, DateTime? timestamp)
            : base(TYPE, entity, id, timestamp) { }
        public MappedAttributes(AttributeData entity, String id, String hash)
            : base(TYPE, entity, id, hash) { }
    }
    #endregion

    #region MappedSalesOrder
    public class MappedOrder : WCMappedEntity<OrderData, SalesOrder>
    {
        public const String TYPE = BCEntitiesAttribute.Order;

        public MappedOrder()
            : base(TYPE)
        { }
        public MappedOrder(SalesOrder entity, Guid? id, DateTime? timestamp)
            : base(TYPE, entity, id, timestamp) { }
        public MappedOrder(OrderData entity, String id, DateTime? timestamp)
            : base(TYPE, entity, id, timestamp) { }
    }
    #endregion

    #region MappedRefunds
    public class MappedRefunds : WCMappedEntity<OrderData, SalesOrder>
    {
        public const String TYPE = BCEntitiesAttribute.OrderRefunds;

        public MappedRefunds()
            : base(TYPE)
        { }
        public MappedRefunds(SalesOrder entity, Guid? id, DateTime? timestamp)
            : base(TYPE, entity, id, timestamp) { }
        public MappedRefunds(OrderData entity, String id, DateTime? timestamp)
            : base(TYPE, entity, id, timestamp) { }
    }
    #endregion

    #region MappedPayment
    public class MappedPayment : WCMappedEntity<OrdersTransactionData, Payment>
    {
        public const String TYPE = BCEntitiesAttribute.Payment;

        public MappedPayment()
            : base(TYPE)
        { }
        public MappedPayment(Payment entity, Guid? id, DateTime? timestamp)
            : base(TYPE, entity, id, timestamp) { }
        public MappedPayment(OrdersTransactionData entity, String id, DateTime? timestamp, String hashcode)
            : base(TYPE, entity, id, timestamp) { ExternHash = hashcode; }
    }
    #endregion

    #region MappedShipment
    public class MappedShipment : WCMappedEntity<OrdersShipmentData, BCShipments>
    {
        public const String TYPE = BCEntitiesAttribute.Shipment;

        public MappedShipment()
            : base(TYPE)
        { }
        public MappedShipment(BCShipments entity, Guid? id, DateTime? timestamp)
            : base(TYPE, entity, id, timestamp) { }
        public MappedShipment(OrdersShipmentData entity, String id, DateTime? timestamp, String hashcode)
            : base(TYPE, entity, id, timestamp) { ExternHash = hashcode; }
    }
    #endregion

    #region MappedNonStockItem
    public class MappedNonStockItem : WCMappedEntity<ProductData, NonStockItem>
    {
        public const String TYPE = BCEntitiesAttribute.NonStockItem;

        public MappedNonStockItem()
            : base(TYPE)
        { }
        public MappedNonStockItem(NonStockItem entity, Guid? id, DateTime? timestamp)
            : base(TYPE, entity, id, timestamp) { }
        public MappedNonStockItem(ProductData entity, String id, DateTime? timestamp)
            : base(TYPE, entity, id, timestamp) { }
    }
    #endregion

    #region MappedTemplateItem
    public class MappedTemplateItem : WCMappedEntity<ProductData, TemplateItems>
    {
        public const String TYPE = BCEntitiesAttribute.ProductWithVariant;

        public MappedTemplateItem()
            : base(TYPE)
        { }
        public MappedTemplateItem(TemplateItems entity, Guid? id, DateTime? timestamp)
            : base(TYPE, entity, id, timestamp) { }
        public MappedTemplateItem(ProductData entity, String id, DateTime? timestamp)
            : base(TYPE, entity, id, timestamp) { }
    }
    #endregion

    #region MappedAvailability
    public class MappedAvailability : WCMappedEntity<AvailabilityData, StorageDetailsResult>
    {
        public const String TYPE = BCEntitiesAttribute.ProductAvailability;

        public MappedAvailability()
            : base(TYPE)
        { }
        public MappedAvailability(StorageDetailsResult entity, Guid? id, DateTime? timestamp, Int32? parent)
            : base(TYPE, entity, id, timestamp)
        {
            ParentID = parent;
            UpdateParentExternTS = true;
        }
        public MappedAvailability(AvailabilityData entity, String id, DateTime? timestamp, Int32? parent)
            : base(TYPE, entity, id, timestamp)
        {
            ParentID = parent;
            UpdateParentExternTS = true;
        }
    }
    #endregion


}
