namespace ACSC.Tests.Entity.ItemWarehouseDetails
{
    public class ItemWarehouseDetailsEntity
    {
        public ItemWarehouseDetailsEntity()
        {
            Header = new ItemWarehouseDetailsEntityHeader();
        }

        public ItemWarehouseDetailsEntityHeader Header { get; set; }
    }
}
