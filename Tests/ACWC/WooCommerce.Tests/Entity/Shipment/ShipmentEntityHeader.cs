using System;

namespace ACSC.Tests.Entity.Shipment
{
    public class ShipmentEntityHeader : ICloneable
    {
        public string ShipmentNbr { get; set; }
        public string CustomerID { get; set; }
        public DateTime? ShipDate { get; set; }
        public decimal? ShipmentQty { get; set; }
        public bool? OnHold { get; set; }
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
