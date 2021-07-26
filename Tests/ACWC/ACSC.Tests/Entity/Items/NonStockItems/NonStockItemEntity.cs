namespace ACSC.Tests.Entity.Items.NonStockItems
{
    public class NonStockItemEntity : IItem
    {
        public NonStockItemEntity()
        {
            GeneralTab = new NonStockItemEntityGeneral();
        }

        public string InventoryCD { get; set; }
        public string Description { get; set; }
        public string ItemStatus { get; set; }

        public NonStockItemEntityGeneral GeneralTab { get; set; }
    }
}