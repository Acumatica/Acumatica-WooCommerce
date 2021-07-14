namespace ACSC.Tests.Custom
{
    public static class Entities
    {
        public const string StockItem = "Stock Item";
        public const string SalesCategory = "Sales Category";
        public const string TemplateItem = "Template Item";
        public const string NonStockItem = "Non-Stock Item";
        public const string Customer = "Customer";
        public const string CustomerLocation = "Customer Location";
        public const string ProductImage = "Product Image";
        public const string ProductAvailability = "Product Availability";
        public const string SalesOrder = "Sales Order";
        public const string Payment = "Payment";
        public const string Shipment = "Shipment";
        public const string CustomerPriceClass = "Customer Price Class";
        public const string PriceList = "Price List";
        public const string BaseSalesPrice = "Base Sales Price";
    }

    public static class Statuses
    {
        public const string FailedAndPending = "Failed & Pending";
        public const string Failed = "Failed";
        public const string Synchronized = "Processed";
        public const string Skipped = "Skipped";
        public const string Deleted = "Deleted";
        public const string All = "All";
        public const string Pending = "Pending";
        public const string Filtered = "Filtered";
    }

    public static class FetchMode
    {
        public const string Incremental = "Incremental";
        public const string Reconciliation = "Reconciliation";
        public const string Full = "Full";
    }

    public static class Stores
    {
        public const string BigCommerce = "BigCommerce";
        //  public const string Shopify = "Shopify";
        public const string Shopify = "MySite";
        public const string WooCommerce = "MySite";
    }
    public static class SyncMode
    {
        public const string None = "None";
        public const string PendingAndFailed = "Pending & Failed";
    }

    public static class Order
    {
        public const string OrderNbr = "OrderNbr";
        public const string OrderType = "OrderType";
    }
}
