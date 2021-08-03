namespace ACSC.Tests.Entity.Items.NonStockItems
{
    public class NonStockItemEntityGeneral
    {
        public string ItemType { get; set; }
        public string PostingClass { get; set; }
        public string ItemClass { get; set; }
        public decimal BasePrice { get; set; }
        public string TaxCategory { get; set; }
        public decimal Weight { get; set; }
        public string WeightUOM { get; set; }
        public decimal RecPrice { get; set; }
        public string SearchKeywords { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public bool RequireReceipt { get; set; }
        public bool RequireShipment { get; set; }
    }
}
