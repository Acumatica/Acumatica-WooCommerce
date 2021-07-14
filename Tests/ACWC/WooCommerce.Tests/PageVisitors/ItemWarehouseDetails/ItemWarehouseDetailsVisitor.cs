using ACSC.Tests.Entity.ItemWarehouseDetails;
using ACSC.Tests.Extensions.ItemWarehouseDetails;

namespace ACSC.Tests.PageVisitors.ItemWarehouseDetails
{
    public class ItemWarehouseDetailsVisitor : IItemWarehouseDetailsVisitor
    {
        private ItemWarehouseDetailsEntity _itemWarehouseDetails;

        public ItemWarehouseDetailsVisitor()
        {
            _itemWarehouseDetails = new ItemWarehouseDetailsEntity();
        }

        public ItemWarehouseDetailsVisitor(ItemWarehouseDetailsEntity itemWarehouseDetails)
        {
            _itemWarehouseDetails = itemWarehouseDetails;
        }

        public void SetData(ItemWarehouseDetailsEntity itemWarehouseDetails)
        {
            _itemWarehouseDetails = itemWarehouseDetails;
        }

        public void Full(Extensions.ItemWarehouseDetails.ItemWarehouseDetails page)
        {
            page.Summary.InventoryID.Select(_itemWarehouseDetails.Header.InventoryID);
            page.Summary.SiteID.Select(_itemWarehouseDetails.Header.Warehouse);
            page.Summary.SiteStatus.Type(_itemWarehouseDetails.Header.Status);
            page.Summary.ProductManagerOverride.Set(_itemWarehouseDetails.Header.ProductManagerOverride);
        }
    }
}
