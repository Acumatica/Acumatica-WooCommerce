using System.Collections.Generic;

namespace ACSC.Tests.Entity.Warehouse
{
    public class WarehouseEntity
    {
        public WarehouseEntity()
        {
            LocationTable = new List<LocationTable>();
        }
        public string WarehouseID { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public string ReceiptLocationID { get; set; }
        public string ShipLocationID { get; set; }
        public string DropShipLocationID { get; set; }
        public List<LocationTable> LocationTable;
    }

    public class LocationTable
    {
        public string LocationID { get; set; }
        public string Description { get; set; }
        public bool AssemblyAllowed { get; set; }
        public bool InclQtyAvail { get; set; }
        public bool TransfersValid { get; set; }
        public bool SalesValid { get; set; }
    }
}