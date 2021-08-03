using System.Collections.Generic;

namespace ACSC.Tests.Entity.Items.TemplateItem
{
    public class TemplateItemGI
    {
        public TemplateItemGI()
        {
            ResultRows = new List<TemplateItemGIRow>();
        }

        public List<TemplateItemGIRow> ResultRows;
    }

    public class TemplateItemGIRow : IItem
    {
        public string InventoryCD { get; set; }
        public string Description { get; set; }
        public string ItemType { get; set; }
        public string ItemClass { get; set; }
        public string PostingClass { get; set; }
        public string TaxCategory { get; set; }
        public string DefWarehouse { get; set; }
        public string BaseUnit { get; set; }
        public decimal? DefaultPrice { get; set; }
        public string ItemStatus { get; set; }
    }
}