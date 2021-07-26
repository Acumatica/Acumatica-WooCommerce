using ACSC.Tests.Entity.StockItems;
using System.Collections.Generic;

namespace ACSC.Tests.Entity.Items.StockItems
{
    public class StockItemEntity : IItem
    {
        public StockItemEntity()
        {
            ItemDetails = new StockItemEntityDetails();
            PriceCostInfo = new StockItemPriceCostInfo();
            GeneralSettings = new StockItemEntityGeneralSettings();
            Attributes = new List<StockItemEntityAttributes>();
            AttributeCategories = new StockItemAttributesCategories();
            Packaging = new StockItemEntityPackaging();
            DescriptionTab = new StockItemEntityDescription();
            VendorDetails = new StockItemEntityVendorDetails();
            Ecommerce = new StockItemEntityEcommerce();
        }

        public string Custom_1 { get; set; }
        public string Custom_2 { get; set; }
        public string InventoryCD { get; set; }
        public string Description { get; set; }
       // public string ProductName { get; set; }
        public string ItemStatus { get; set; }
        public decimal? QtyOnHand { get; set; }

        public StockItemEntityDetails ItemDetails { get; set; }
        public StockItemPriceCostInfo PriceCostInfo { get; set; }
        public StockItemEntityGeneralSettings GeneralSettings { get; set; }
        public List<StockItemEntityAttributes> Attributes { get; set; }
        public StockItemAttributesCategories AttributeCategories { get; set; }
        public StockItemEntityPackaging Packaging { get; set; }
        public StockItemEntityDescription DescriptionTab { get; set; }
        public StockItemEntityVendorDetails VendorDetails { get; set; }
        public StockItemEntityWarehouseDetails WarehouseDetails { get; set; }
        public StockItemEntityEcommerce Ecommerce { get; set; }
    }
}