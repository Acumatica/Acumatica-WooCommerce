using System.Collections.Generic;

namespace ACSC.Tests.Entity.Shipment
{
    public class ShipmentEntity
    {
        public ShipmentEntity()
        {
            Summary = new ShipmentEntityHeader();
            DocumentDetails = new List<ShipmentEntityDetails>();
            Orders = new List<ShipmentEntityOrders>();
        }

        public string StoreID { get; set; }
        public ShipmentEntityHeader Summary { get; set; }
        public List<ShipmentEntityDetails> DocumentDetails { get; set; }
        public List<ShipmentEntityOrders> Orders { get; }

    }
}
