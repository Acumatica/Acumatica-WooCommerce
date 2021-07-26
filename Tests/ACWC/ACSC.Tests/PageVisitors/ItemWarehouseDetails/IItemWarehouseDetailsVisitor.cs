using ACSC.Tests.Entity.ItemWarehouseDetails;

namespace ACSC.Tests.PageVisitors.ItemWarehouseDetails
{
    public interface IItemWarehouseDetailsVisitor
    {
        void Full(Extensions.ItemWarehouseDetails.ItemWarehouseDetails page);
        void SetData(ItemWarehouseDetailsEntity customerPriceClassesEntity);
    }
}
