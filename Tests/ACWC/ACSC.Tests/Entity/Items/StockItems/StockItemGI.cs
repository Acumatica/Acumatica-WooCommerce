using System.Collections.Generic;

namespace ACSC.Tests.Entity.Items.StockItems
{
    public class StockItemGI
    {
        public StockItemGI()
        {
            ResultRows = new List<StockItemGIRow>();
        }

        public List<StockItemGIRow> ResultRows;
    }

    public class StockItemGIRow : IItem
    {
        public string InventoryCD { get; set; }
        public string Description { get; set; }
        public string ItemStatus { get; set; }
        public string ItemType { get; set; }
        public string ItemClass { get; set; }
    }
}