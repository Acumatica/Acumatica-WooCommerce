using System.Collections.Generic;

namespace ACSC.Tests.Entity.Items.TemplateItem
{
    public class TemplateItemEntityAttributeConfig
    {
        public TemplateItemEntityAttributeConfig()
        {
            InventoryIDSegmentSettings = new List<InventoryIDSegmentSettings>();
        }
        public string DefaultColumnMatrixAttribute { get; set; }
        public string DefaultRowMatrixAttribute { get; set; }
        public List<InventoryIDSegmentSettings> InventoryIDSegmentSettings { get; set; }
    }

    public class InventoryIDSegmentSettings
    {
        public string SegmentType { get; set; }
        public string AttributeID { get; set; }
        public int NumberOfCharacters { get; set; }
    }
}