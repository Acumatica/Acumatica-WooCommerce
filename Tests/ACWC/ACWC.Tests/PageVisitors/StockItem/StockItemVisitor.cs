using ACSC.Tests.Entity.Items.StockItems;
using ACSC.Tests.Extensions.StockItem;
using System;
using Controls.Editors.DropDown;

namespace ACSC.Tests.PageVisitors.StockItem
{
    public class StockItemVisitor : IStockItemVisitor
    {
        private StockItemEntity _stockItem;

        public StockItemVisitor(StockItemEntity stockItem)
        {
            _stockItem = stockItem;
        }

        public StockItemVisitor()
        {
            _stockItem = new StockItemEntity();
        }

        public void SetData(StockItemEntity stockItem)
        {
            _stockItem = stockItem;
        }

        public void Full(Extensions.StockItem.StockItem page)
        {
            FullGeneralInfo(page);
            FullItemDetails(page);
            FullAttributes(page);
            FullCategories(page);
            FullPackaging(page);
            FullVendorDetails(page);
            FullPriceCostInfo(page);
            //FullEcommerceInfo(page);
        }

        private void FullEcommerceInfo(Extensions.StockItem.StockItem page)
        {
            if (!string.IsNullOrEmpty(_stockItem.Ecommerce.Visibility))
            {
                page.Tabs.Visibility.Select(_stockItem.Ecommerce.Visibility);
            }
        }

       

        private void FullGeneralInfo(Extensions.StockItem.StockItem page)
        {
            page.Summary.InventoryCD.Type(_stockItem.InventoryCD);
            page.Summary.Descr.Type(_stockItem.Description);
            FullEcommerceInfo(page);
            page.Summary.ItemStatus.Select(_stockItem.ItemStatus);
        }

        private void FullAttributes(Extensions.StockItem.StockItem page)
        {

            foreach (var attr in _stockItem.Attributes)
            {
                var rowsCount = page.Attributes.RowsCount();

                for (int i = 1; i <= rowsCount; i++)
                {
                    page.Attributes.SelectRow(i);
                    var attrId = page.Attributes.Row.AttributeID.GetValue();

                    if (attrId == attr.AttributeID)
                    {
                        page.Attributes.Row.Value.DynamicControl<DropDown>().Select(attr.Value);
                    }
                }
            }
        }

        public StockItemEntity Get(Extensions.StockItem.StockItem page)
        {
            var stockItem = new StockItemEntity
            {
                InventoryCD = page.Summary.InventoryCD.GetValue(),
                Description = page.Summary.Descr.GetValue(),
                ItemStatus = page.Summary.ItemStatus.GetValue(),
                ItemDetails =
                {
                    ItemType = page.Tabs.ItemType.GetValue(),
                    ItemClass = page.Tabs.ItemClassID.GetValue(),
                    TaxCategory = page.Tabs.TaxCategoryID.GetValue(),
                    RecPrice = decimal.Parse(page.Tabs.RecPrice.GetValue()),
                    BasePrice = decimal.Parse(page.Tabs.BasePrice.GetValue()),
                    Weight = decimal.Parse(page.Tabs.BaseItemWeight.GetValue()),
                    WeightUOM = page.Tabs.WeightUOM.GetValue()
                }
            };

            return stockItem;
        }

        private void FullItemDetails(Extensions.StockItem.StockItem page)
        {
            string messageText = null;
            page.Tabs.ItemClassID.Select(_stockItem.ItemDetails.ItemClass);
            try
            {
                messageText = page.MessageBox.Message.GetValue();
            }
            catch (Exception)
            {
                // ignored
            }

            if (!string.IsNullOrEmpty(messageText))
            {
                page.MessageBox.Yes();
            }

            if (!string.IsNullOrEmpty(_stockItem.ItemDetails.ItemType))
            {
                page.Tabs.ItemType.Select(_stockItem.ItemDetails.ItemType);
            }

            string valMethod = page.Tabs.ValMethod.GetValue();
            
            if (IsValMethodError(page))
            {
                page.Tabs.ValMethod.Select(valMethod);
            }

            if (IsValMethodError(page))
            {
                page.Tabs.ValMethod.Select("Specific");
            }

            if (!string.IsNullOrEmpty(_stockItem.ItemDetails.DefSiteID))
            {
                page.Tabs.DfltSiteID.Select(_stockItem.ItemDetails.DefSiteID);
            }

            if (_stockItem.ItemDetails.RecPrice != decimal.Zero)
            {
                page.Tabs.RecPrice.Type(_stockItem.ItemDetails.RecPrice);
            }

            if (_stockItem.ItemDetails.BasePrice != decimal.Zero)
            {
                page.Tabs.BasePrice.Type(_stockItem.ItemDetails.BasePrice);
            }

            if (!string.IsNullOrEmpty(_stockItem.ItemDetails.WeightUOM))
            {
                page.Tabs.WeightUOM.Select(_stockItem.ItemDetails.WeightUOM);
            }

            if (_stockItem.ItemDetails.Weight != decimal.Zero)
            {
                page.Tabs.BaseItemWeight.Type(_stockItem.ItemDetails.Weight);
            }

            if (!string.IsNullOrEmpty(_stockItem.ItemDetails.TaxCategory))
            {
                page.Tabs.TaxCategoryID.Select(_stockItem.ItemDetails.TaxCategory);
            }

            if (!string.IsNullOrEmpty(_stockItem.ItemDetails.PostingClass))
            {
                //page.Tabs.PostClassID.Select("AOL");
                page.Tabs.PostClassID.Select(_stockItem.ItemDetails.PostingClass);
            }

            var baseUnit = page.Tabs.BaseUnit.GetValue();

            if (!string.IsNullOrEmpty(_stockItem.ItemDetails.BaseUnit) && string.IsNullOrEmpty(baseUnit) || !string.IsNullOrEmpty(_stockItem.ItemDetails.BaseUnit) && _stockItem.ItemDetails.BaseUnit != baseUnit)
            {
                page.Tabs.BaseUnit.Select(_stockItem.ItemDetails.BaseUnit);
            }

            if (!string.IsNullOrEmpty(_stockItem.ItemDetails.SalesUnit))
            {
                page.Tabs.SalesUnit.Select(_stockItem.ItemDetails.SalesUnit);
            }

            if (!string.IsNullOrEmpty(_stockItem.ItemDetails.PurchaseUnit))
            {
                page.Tabs.PurchaseUnit.Select(_stockItem.ItemDetails.PurchaseUnit);
            }
        }

        private bool IsValMethodError(Extensions.StockItem.StockItem page)
        {
            return page.Tabs.ValMethod.HasError();
        }

        private void FullCategories(Extensions.StockItem.StockItem page)
        {
            if (!string.IsNullOrEmpty(_stockItem.AttributeCategories.CategoryID))
            {
                //page.SalesCategory.New();
                //page.SalesCategory.Row.CategoryID.Select(_stockItem.AttributeCategories.CategoryID);
            }
        }

        private void FullPackaging(Extensions.StockItem.StockItem page)
        {
            if (_stockItem.Packaging.Weight != decimal.Zero)
            {
                page.Tabs.BaseItemWeight.Type(_stockItem.Packaging.Weight);
            }

            if (!string.IsNullOrEmpty(_stockItem.Packaging.WeightUOM))
            {
                page.Tabs.WeightUOM.Type(_stockItem.Packaging.WeightUOM);
            }

            if (_stockItem.Packaging.Volume != decimal.Zero)
            {
                page.Tabs.BaseItemVolume.Type(_stockItem.Packaging.Volume);
            }

            if (!string.IsNullOrEmpty(_stockItem.Packaging.VolumeUOM))
            {
                page.Tabs.VolumeUOM.Type(_stockItem.Packaging.VolumeUOM);
            }

            if (!string.IsNullOrEmpty(_stockItem.Packaging.PackagingOption))
            {
                page.Tabs.PackageOption.Select(_stockItem.Packaging.PackagingOption);
            }

            if (!string.IsNullOrEmpty(_stockItem.Packaging.BoxID))
            {
                if (page.Boxes.RowsCount() == 0)
                {
                    page.Boxes.New();
                    page.Boxes.Row.BoxID.Select(_stockItem.Packaging.BoxID);
                }
            }
        }

        private void FullVendorDetails(Extensions.StockItem.StockItem page)
        {
            if (!string.IsNullOrEmpty(_stockItem.VendorDetails.VendorName))
            {
                page.ReplenishmentInformation.Columns.VendorID.Contains(_stockItem.VendorDetails.VendorName);
                if (page.ReplenishmentInformation.RowsCount() != 0) return;
                page.ReplenishmentInformation.New();
                page.ReplenishmentInformation.Row.VendorID.Select(_stockItem.VendorDetails.VendorName);
            }
        }

        private void FullPriceCostInfo(Extensions.StockItem.StockItem page)
        {
            if (_stockItem.PriceCostInfo.MSRP != decimal.Zero)
            {
                page.Tabs.RecPrice.Type(_stockItem.PriceCostInfo.MSRP);
            }

            if (_stockItem.PriceCostInfo.DefaultPrice != decimal.Zero)
            {
                page.Tabs.BasePrice.Type(_stockItem.PriceCostInfo.DefaultPrice);
            }

            if (_stockItem.PriceCostInfo.PendingCost != decimal.Zero)
            {
                page.Tabs.PendingStdCost.Type(_stockItem.PriceCostInfo.PendingCost);
            }
        }
    }
}