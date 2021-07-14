using ACSC.Tests.Entity.Shipment;
using ACSC.Tests.Extensions.Shipment;

namespace ACSC.Tests.PageVisitors.Shipment
{
    public class ShipmentVisitor : IShipmentVisitor
    {
        public ShipmentEntity Get(Extensions.Shipment.Shipment page)
        {
            var shipment = new ShipmentEntity
            {
                Summary =
                {
                    ShipmentNbr = page.Summary.ShipmentNbr.GetValue(),
                    CustomerID = page.Summary.CustomerID.GetValue(),
                    ShipmentQty = decimal.Parse(page.Summary.ShipmentQty.GetValue()),
                    ShipDate = page.Summary.ShipDate.GetValue()
                }
            };
            var tranCount = page.DocumentDetails.RowsCount().ToString();
            int.TryParse(tranCount, out var shipRowCount);
            for (var i = 1; i <= shipRowCount; i++)
            {
                page.DocumentDetails.SelectRow(i);
                var row = page.TransactionsRow;
                if (row != null)
                {
                    shipment.DocumentDetails.Add(new ShipmentEntityDetails()
                    {
                        InventoryID = row.InventoryID.GetValue(),
                        OrderNbr = row.OrderNbr.GetValue()
                    });
                }
            }
          

            return shipment;
        }
    }
}