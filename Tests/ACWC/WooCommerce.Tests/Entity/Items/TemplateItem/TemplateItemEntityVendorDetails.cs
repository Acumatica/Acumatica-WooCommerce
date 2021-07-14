namespace ACSC.Tests.Entity.Items.TemplateItem
{
    public class TemplateItemEntityVendorDetails
    {
        public string VendorID { get; set; }
        public string VendorName { get; set; }
        public string Location { get; set; }
        public string PurchaseUnit { get; set; }
        public decimal AddLeadTimeDays { get; set; }
        public decimal MinOrdFreq { get; set; }
        public decimal MinOrdQty { get; set; }
        public decimal MaxOrdQty { get; set; }
        public decimal LotSize { get; set; }
        public decimal ERQ { get; set; }
    }
}