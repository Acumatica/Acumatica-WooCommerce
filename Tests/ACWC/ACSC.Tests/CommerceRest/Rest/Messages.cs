
namespace BCApiClient.Rest
{
    public class Messages
    {
        //Common
        public const string Select = "<SELECT>";

        //Order Type
        public const string OrderRmaType = "RM";

        //Actions
        public const string Import = "Import";
        public const string Export = "Export";
        public const string Update = "Update";
        public const string UpdateProductAvailability = "Update Product Availability";
        public const string ScreenAction = "Screen Action";

        // Origin of the entity
        public const string Acumatica = "A";
        public const string BigCommerce = "B";

        //Entities
        public const string Customer = "Customer";
        public const string Product = "Product";
        public const string ProductVariant = "ProductVariant";
        public const string ProductVariantOptionValue = "ProductVariantOptionValue";
        public const string ProductVariantModifierValue = "ProductVariantModifierValue";
        public const string ProductOption = "ProductOption";
        public const string ProductModifier = "ProductModifier";
        public const string ProductOptionValue = "ProductOptionValue";
        public const string ProductModifierValue = "ProductModifierValue";
        public const string ProductCategories = "ProductCategory";
        public const string ProductAvailability = "ProductAvailability";
        public const string Shipment = "Shipment";
        public const string OrdersShipmentItem = "OrdersShipmentItem";
        public const string CustomerData = "CustomerData";
        public const string CustomerAddressData = "CustomerAddressData";
        public const string Order = "Order";
        public const string ReturnOrder = "ReturnOrder";
        public const string OrdersCouponData = "OrdersCouponData";
        public const string OrdersBillingAddress = "OrderBillingAddress";
        public const string OrdersShippingAddressData = "OrderShippingAddress";
        public const string OrdersProductData = "OrdersProductData";

        //Error level
        public const string Info = "Info";
        public const string Error = "Error";
        public const string Warning = "Warning";
        public const string Debug = "Debug";

        //DataProcessing
        public const string StartImportOperation = "Start Data Transfer Operation (Export)";
        public const string StopImportOperation = "Stop Data Transfer Operation (Export)";

        //Stock Items E-commerce Tab
        public const string InventoryTrackingNone = "none";
        public const string InventoryTrackingProduct = "product";
        public const string InventoryTrackingVariant = "variant";

        public const int Combo = 2;

        //Actions
        public const string ViewBCSyncHistory = "View BC Sync History";

        //Mapping Rules
        public const string UseMapping = "Mapping";
        public const string UseDefault = "Default Value";
        public const string UseSubstitute = "Substitute Value";

        //Acumatica Screens
        public const string Customers = "Customers";
        public const string CustomerLocations = "Customer Locations";
        public const string StockItems = "Stock Items";
        public const string SalesOrders = "Sales Orders";
        public const string ItemSalesCategory = "Item Sales Category";
        public const string Attributes = "Attributes";
        public const string Shipments = "Shipments";

        //Bigcommerce UI Mapping Objects
        public const string CustomerCustomerAddres = "Customer -> Customer Address";
        public const string ProductProductOption = "Product -> Product Option";
        public const string ProductProductOptionOptionValue = "Product -> Product Option -> Product Option Value";
        public const string ProductProductvariant = "Product -> Product Variant";
        public const string ProductProductVariantProductVariantOptionValue = "Product -> Product Variant -> Product Variant Option Value";
        public const string ProductCategory = "Product Category";

        //BigCommerce order statuses
        public const string Pending = "Pending";
        public const string AwaitingPayment = "Awaiting Payment";
        public const string AwaitingFulfillment = "Awaiting Fulfillment";
        public const string AwaitingShipment = "Awaiting Shipment";
        public const string AwaitingPickup = "Awaiting Pickup";
        public const string PartiallyShipped = "Partially Shipped";
        public const string Completed = "Completed";
        public const string Shipped = "Shipped";
        public const string Cancelled = "Canceled";
        public const string Declined = "Declined";
        public const string Refunded = "Refunded";
        public const string Disputed = "Disputed";
        public const string VerificationRequired = "Manual Verification Required";
        public const string PartiallyRefunded = "Partially Refunded";
        public const string Incomplete = "Incomplete";

        public class UI
        {
            //Entities
            public const string Customer = "Customer";
            public const string Product = "Product";
            public const string ProductVariant = "Product Variant";
            public const string ProductVariantOptionValue = "Product Variant Option Value";
            public const string ProductVariantModifierValue = "Product Variant Modifier Value";
            public const string ProductOption = "Product Option";
            public const string ProductModifier = "Product Modifier";
            public const string ProductOptionValue = "Product Option Value";
            public const string ProductModifierValue = "Product Modifier Value";
            public const string ProductCategories = "Product Category";
            public const string ProductAvailability = "Product Availability";
            public const string Shipment = "Shipment";
            public const string OrdersShipmentItem = "Orders Shipment Item";
            public const string CustomerData = "Customer Data";
            public const string CustomerAddressData = "Customer Address Data";
            public const string Order = "Order";
            public const string ReturnOrder = "Return Order";
            public const string OrdersCouponData = "Orders Coupon Data";
            public const string OrdersBillingAddress = "Order Billing Address";
            public const string OrdersShippingAddressData = "Order Shipping Address";
            public const string OrdersProductData = "Orders Product Data";
        }
    }
}
