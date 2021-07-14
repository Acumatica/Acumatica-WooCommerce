using System;

namespace ACSC.Tests.Entity.SalesOrder
{
    public class SalesOrderEntityShippingSettings: ICloneable
    {
        public string ShipVia { get; set; }
        public string ShipTermsID { get; set; }
        public string ShipZoneID { get; set; }
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}