using System;

namespace ACSC.Tests.Entity.ItemWarehouseDetails
{
    public class ItemWarehouseDetailsEntityHeader : ICloneable
    {
        public string InventoryID { get; set; }
        public string Warehouse { get; set; }
        public string Status { get; set; }
        public bool ProductManagerOverride { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
