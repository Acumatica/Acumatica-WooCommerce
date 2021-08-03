using System;

namespace ACSC.Tests.Entity.Shipment
{
    public class ShipmentEntityOrders : ICloneable
    {
        public int? LineNbr { get; set; }
        public string OrderNbr { get; set; }
        public decimal ShipmentQty { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
