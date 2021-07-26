using System;

namespace ACSC.Tests.Entity.SalesOrder
{
    public class SalesOrderEntityShipment : ICloneable
    {
        public string ShipmentType { get; set; }
        public string DocumentNbr	{ get; set; }
        public DateTime? ShipDate { get; set; }
        public decimal? ShipmentQty	{ get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
