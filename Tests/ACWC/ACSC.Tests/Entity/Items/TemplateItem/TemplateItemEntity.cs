using System.Collections.Generic;

namespace ACSC.Tests.Entity.Items.TemplateItem
{
    public class TemplateItemEntity : IItem
    {
        public TemplateItemEntity()
        {
            GeneralSettings = new GeneralSettings();
            PriceInfo = new PriceInfo();
            VendorDetails = new List<VendorDetails>();
            CreateMatrixItemsTab = new TemplateItemEntityCreateMatrixItemsTab();
            AttributeConfig = new TemplateItemEntityAttributeConfig();
            MatrixItemsResult = new List<TemplateItemEntityMatrixItemsResult>();
            Attributes = new List<Attributes>();
        }

        public string InventoryCD { get; set; }
        public string Description { get; set; }
        public GeneralSettings GeneralSettings { get; set; }
        public PriceInfo PriceInfo { get; set; }
        public TemplateItemEntityCreateMatrixItemsTab CreateMatrixItemsTab { get; set; }
        public TemplateItemEntityAttributeConfig AttributeConfig { get; set; }
        public List<VendorDetails> VendorDetails { get; set; }
        public List<TemplateItemEntityMatrixItemsResult> MatrixItemsResult { get; set; }
        public List<Attributes> Attributes { get; set; }
    }

    public class GeneralSettings
    {
        public string ItemStatus { get; set; }
        public string ItemClass { get; set; }
        public string ItemType { get; set; }
        public string ValMethod { get; set; }
        public string TaxCategory { get; set; }
        public string PostClass { get; set; }
        public string LotSerClass { get; set; }
        public string DefWarehouse { get; set; }
        public string Body { get; set; }
        public string WeightUOM { get; set; }
        public decimal Weight { get; set; }
    }

    public class PriceInfo
    {
        public decimal RecPrice { get; set; }
        public decimal BasePrice { get; set; }
    }

    public class VendorDetails
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

    public class Attributes
    {public string AttributeID { get; set; }
    }
    public class MatrixItemsResult
    {
        public string InventoryCD { get; set; }
        public string Description { get; set; }
        public string DfltSiteID { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string TaxCategory { get; set; }
        public bool StockItem { get; set; }
    }
}