using ACSC.Tests.Entity.Items.NonStockItems;
using ACSC.Tests.Extensions.NonStockItem;

namespace ACSC.Tests.PageVisitors.NonStockItem
{
    public class NonStockItemVisitor : INonStockItemVisitor
    {
        private NonStockItemEntity _nonStockItem;

        public NonStockItemVisitor(NonStockItemEntity nonStockItem)
        {
            _nonStockItem = nonStockItem;
        }

        public NonStockItemVisitor()
        {
            _nonStockItem = new NonStockItemEntity();
        }

        public void SetData(NonStockItemEntity nonStockItem)
        {
            _nonStockItem = nonStockItem;
        }
        public void Full(Extensions.NonStockItem.NonStockItem page)
        {
            FullGeneralInfo(page);
            FullItemDetails(page);
        }

        private void FullItemDetails(Extensions.NonStockItem.NonStockItem page)
        {
            page.GeneralSettings.ItemClassID.Select(_nonStockItem.GeneralTab.ItemClass);
            try
            {
                page.MessageBox.Ok();
            }
            catch { }
            page.GeneralSettings.ItemType.Select(_nonStockItem.GeneralTab.ItemType);
            page.GeneralSettings.TaxCategoryID.Select(_nonStockItem.GeneralTab.TaxCategory);
            page.GeneralSettings.PostClassID.Select(_nonStockItem.GeneralTab.PostingClass);
            page.BasePrice.BasePrice.Type(_nonStockItem.GeneralTab.BasePrice);
            page.BasePrice.RecPrice.Type(_nonStockItem.GeneralTab.RecPrice);
            page.GeneralSettings.MetaDescription.Type(_nonStockItem.GeneralTab.MetaDescription);
            page.GeneralSettings.MetaKeywords.Type(_nonStockItem.GeneralTab.MetaKeywords);
            page.GeneralSettings.SearchKeywords.Type(_nonStockItem.GeneralTab.SearchKeywords);
            page.GeneralSettings.NonStockReceipt.Set(_nonStockItem.GeneralTab.RequireReceipt);
            page.GeneralSettings.NonStockShip.Set(_nonStockItem.GeneralTab.RequireShipment);
        }

        private void FullGeneralInfo(Extensions.NonStockItem.NonStockItem page)
        {
            page.Summary.InventoryCD.Type(_nonStockItem.InventoryCD);
            page.Summary.Descr.Type(_nonStockItem.Description);
            page.Summary.ItemStatus.Select(_nonStockItem.ItemStatus);
        }

        public NonStockItemEntity Get(Extensions.NonStockItem.NonStockItem page)
        {
            var nonStockItem = new NonStockItemEntity
            {
                InventoryCD = page.Summary.InventoryCD.GetValue(),
                Description = page.Summary.Descr.GetValue(),
                ItemStatus = page.Summary.ItemStatus.GetValue(),
                GeneralTab =
                {
                    ItemType = page.GeneralSettings.ItemType.GetValue(),
                    ItemClass = page.GeneralSettings.ItemClassID.GetValue(),
                    TaxCategory = page.GeneralSettings.TaxCategoryID.GetValue(),
                    BasePrice = decimal.Parse(page.BasePrice.BasePrice.GetValue()),
                    Weight = decimal.Parse(page.GeneralSettings.BaseItemWeight.GetValue()),
                    WeightUOM = page.GeneralSettings.WeightUOM.GetValue(),
                    RecPrice = decimal.Parse(page.BasePrice.RecPrice.GetValue()),
                    MetaDescription = page.GeneralSettings.MetaDescription.GetValue(),
                    MetaKeywords = page.GeneralSettings.MetaKeywords.GetValue(),
                    SearchKeywords = page.GeneralSettings.SearchKeywords.GetValue()
                }
            };

            return nonStockItem;
        }
    }
}
