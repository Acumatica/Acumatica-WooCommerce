using System.Collections.Generic;

namespace ACSC.Tests.Entity.Items.NonStockItems
{
    public class NonStockItemGI
    {
        public NonStockItemGI()
        {
            ResultRows = new List<NonStockItemGIRow>();
        }

        public List<NonStockItemGIRow> ResultRows { get; set; }
    }

    public class NonStockItemGIRow : IItem
    {
        public string InventoryCD { get; set; }
        public string Description { get; set; }
        public string ItemStatus { get; set; }
        public string ItemType { get; set; }
    }
}
