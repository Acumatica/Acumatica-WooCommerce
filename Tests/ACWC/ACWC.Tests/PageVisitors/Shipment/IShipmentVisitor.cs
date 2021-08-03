using ACSC.Tests.Entity.Shipment;
using ACSC.Tests.Extensions.Shipment;

namespace ACSC.Tests.PageVisitors.Shipment
{
    public interface IShipmentVisitor
    {
        ShipmentEntity Get(Extensions.Shipment.Shipment page);
    }
}
