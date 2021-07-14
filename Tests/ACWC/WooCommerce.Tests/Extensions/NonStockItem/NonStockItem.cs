using ACSC.Tests.Entity.Items.NonStockItems;
using ACSC.Tests.PageVisitors;
using ACSC.Tests.PageVisitors.NonStockItem;
using GeneratedWrappers.Acumatica;

namespace ACSC.Tests.Extensions.NonStockItem
{
    public class NonStockItem : IN202000_NonStockItemMaint
    {
        public c_item_form Summary => base.Item_form;
        public c_itemsettings_tab GeneralSettings => base.ItemSettings_tab;
        public c_curysettings_inventoryitem_curysettingsform BasePrice => base.CurySettings_InventoryItem_curySettingsForm;
        public c_curysettings_inventoryitem_curysettingsform2 StdPrice => base.CurySettings_InventoryItem_curySettingsForm2;
        public c_vendoritems_pxgridvendoritems VendorDetails => base.VendorItems_PXGridVendorItems;
        public c_answers_pxgridanswers Attributes => base.Answers_PXGridAnswers;
        public c_category_pxgridcategory SalesCategory => base.Category_PXGridCategory;

        public NonStockItemEntity Get()
        {
            var visitor = VisitorsManager.GetSingle<INonStockItemVisitor>(typeof(NonStockItemVisitor));
            return visitor.Get(this);
        }

        internal void Full(INonStockItemVisitor visitor)
        {
            visitor.Full(this);
        }
    }
}