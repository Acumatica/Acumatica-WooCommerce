namespace ACSC.Tests.Entity.Items.StockItems
{
    public class StockItemEntityDetails
    {
        public string ItemType { get; set; }
        public decimal BasePrice { get; set; }
        public string ItemClass { get; set; }
        public string TaxCategory { get; set; }
        public string PostingClass { get; set; }
        public decimal Weight { get; set; }
        public string WeightUOM { get; set; }
        public string DefSiteID { get; set; }
        public decimal RecPrice { get; set; }
        public string ValMethod { get; set; }
        public string BaseUnit { get; set; }
        public string SalesUnit { get; set; }
        public string PurchaseUnit { get; set; }
    }
}