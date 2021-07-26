using System;

namespace ACSC.Tests.Entity.Shipment
{
    public class ShipmentEntityDetails : ICloneable
    {
        public int? LineNbr { get; set; }
        public string OrderNbr { get; set; }
        public string InventoryID { get; set; }
        public string TranDesc { get; set; }
        public string BranchID { get; set; }
        public string DiscountID { get; set; }
        public decimal ShippedQty { get; set; }
        public decimal OrderQty { get; set; }
        public decimal OpenOrderQty { get; set; }
        public decimal PackedQty { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
