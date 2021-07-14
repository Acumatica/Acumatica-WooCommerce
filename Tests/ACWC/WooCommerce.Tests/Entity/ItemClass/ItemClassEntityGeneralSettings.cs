namespace ACSC.Tests.Entity.ItemClass
{
    public class ItemClassEntityGeneralSettings
    {
        public bool StkItem { get; set; }
        public string ItemType { get; set; }
        public string ValMethod { get; set; }
        public string TaxCategory { get; set; }
        public string PostingClass { get; set; }
        public string LotSerClass { get; set; }
        public string DefWarehouse { get; set; }
        public string AvailabilityCalcRule { get; set; }
        public string BaseUnit { get; set; }
        public string SalesUnit { get; set; }
        public string PurchaseUnit { get; set; }
        public bool DecimalBaseUnit { get; set; }
        public bool DecimalSalesUnit { get; set; }
        public bool DecimalPurchaseUnit { get; set; }   
        public decimal MinMarkup { get; set; }
        public decimal Markup { get; set; }
    }
}