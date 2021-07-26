using ACSC.Tests.Entity.Items.StockItems;
using ACSC.Tests.PageVisitors;
using ACSC.Tests.PageVisitors.StockItem;
using GeneratedWrappers.Acumatica;

namespace ACSC.Tests.Extensions.StockItem
{
    public class StockItem : IN202500_InventoryItemMaint
    {
        public c_item_form Summary => base.Item_form;
        public c_itemsettings_tab Tabs => base.ItemSettings_tab;
        public c_vendoritems_pxgridvendoritems ReplenishmentInformation => base.VendorItems_PXGridVendorItems;
        public c_answers_pxgridanswers Attributes => base.Answers_PXGridAnswers;
        public c_category_pxgridcategory SalesCategory => base.Category_PXGridCategory;
        public c_itemsiterecords_grid2 WarehouseDetails => Itemsiterecords_grid2;
        public c_boxes_pxgridboxes Boxes => base.Boxes_PXGridBoxes;
        public c_itemunits_gridunits GridUnits => base.Itemunits_gridunits;

        public StockItemEntity Get()
        {
            var visitor = VisitorsManager.GetSingle<IStockItemVisitor>(typeof(StockItemVisitor));
            return visitor.Get(this);
        }

        internal void Full(IStockItemVisitor visitor)
        {
            visitor.Full(this);
        }
    }
}