using ACSC.Tests.Entity.Items.TemplateItem;
using ACSC.Tests.Extensions.TemplateItems;
using Controls.Editors.Selector;
using Core.Log;
using System;
using System.Linq;
using Controls.Editors.DropDown;
using Controls.Input;

namespace ACSC.Tests.PageVisitors.TemplateItem
{
    public class TemplateItemVisitor : ITemplateItemVisitor
    {
        private TemplateItemEntity _templateItem;

        public TemplateItemVisitor(TemplateItemEntity templateItem)
        {
            _templateItem = templateItem;
        }

        public TemplateItemVisitor()
        {
            _templateItem = new TemplateItemEntity();
        }

        public void SetData(TemplateItemEntity templateItem)
        {
            _templateItem = templateItem;
        }

        public void Full(Extensions.TemplateItems.TemplateItem page)
        {
            if (ValidateItemExistence(page)) return;
            page.OpenScreen();
            FullGeneralInfo(page);
            FullItemDetails(page);
            FullVendorDetails(page);
            FullAttrConfig(page);
            CreateMatrixItems(page);
        }

        private bool ValidateItemExistence(Extensions.TemplateItems.TemplateItem page)
        {
            try
            {
                page.Summary.InventoryCD.Select(_templateItem.InventoryCD);
            }
            catch (Exception e)
            {
                string selectorLabel = page.Summary.InventoryCDLabel.GetValue();
                if (e.Message == $"The specified value: {_templateItem.InventoryCD} is not present in the selector: {selectorLabel.Split(':')[0]}")
                {
                    return false;
                }

                Log.Error(e.Message);
                return true;
            }

            return true;
        }


        public TemplateItemEntity Get(Extensions.TemplateItems.TemplateItem page)
        {
            var templateItem = new TemplateItemEntity
            {
                InventoryCD = page.Summary.InventoryCD.GetValue(),
                Description = page.Summary.Descr.GetValue(),
                GeneralSettings =
                {
                    ItemClass = page.ItemSettings.ItemClassID.GetValue(),
                    TaxCategory = page.ItemSettings.TaxCategoryID.GetValue(),
                    PostClass = page.ItemSettings.PostClassID.GetValue(),
                    LotSerClass = page.ItemSettings.LotSerClassID.GetValue(),
                    DefWarehouse = page.ItemSettings.DfltSiteID.GetValue()
                },
                PriceInfo =
                {
                    BasePrice = decimal.Parse(page.ItemSettings.BasePrice.GetValue()),
                    RecPrice = decimal.Parse(page.ItemSettings.RecPrice.GetValue())
                }
            };

            var attrCount = page.Attributes.RowsCount().ToString();
            int.TryParse(attrCount, out var attrRowCount);
            for (var i = 1; i <= attrRowCount; i++)
            {
                page.Attributes.SelectRow(i);
                var row = page.Attributes.Row;
                if (row != null)
                {
                    templateItem.Attributes.Add(new Attributes
                    {
                        AttributeID = row.AttributeID.GetValue()
                    });
                }
            }

            var variantsCount = page.MatrixItems.RowsCount().ToString();
            int.TryParse(variantsCount, out var variantsRowCount);
            for (var i = 1; i <= variantsRowCount; i++)
            {
                page.MatrixItems.SelectRow(i);
                var row = page.MatrixItems.Row;
                if (row != null)
                {
                    var matrixItem = new TemplateItemEntityMatrixItemsResult
                    {
                        InventoryCD = row.InventoryID.GetValue(),
                        Description = row.Descr.GetValue(),
                        DfltSiteID = row.DfltSiteID.GetValue(),
                        Option1 = row.AttributeValue0.GetValue(),
                        TaxCategory = row.TaxCategoryID.GetValue(),
                        DefaultPrice = decimal.Parse(row.BasePrice.GetValue()),
                        StockItem = row.StkItem.GetValue()
                    };
                    switch (templateItem.Attributes.Count)
                    {
                        case 2:
                            matrixItem.Option2 = row.DynamicControl<DropDown>(templateItem.Attributes[1].AttributeID).GetValue();
                            break;
                        case 3:
                            matrixItem.Option2 = row.DynamicControl<DropDown>(templateItem.Attributes[1].AttributeID).GetValue();
                            matrixItem.Option3 = row.DynamicControl<DropDown>(templateItem.Attributes[2].AttributeID).GetValue();
                            break;
                    }
                    templateItem.MatrixItemsResult.Add(matrixItem);
                }
            }

            return templateItem;
        }

        private void FullGeneralInfo(Extensions.TemplateItems.TemplateItem page)
        {
            page.Summary.InventoryCD.Type(_templateItem.InventoryCD);
            page.Summary.Descr.Type(_templateItem.Description);
        }

        private void FullItemDetails(Extensions.TemplateItems.TemplateItem page)
        {
            if (!string.IsNullOrEmpty(_templateItem.GeneralSettings.Body))
            {
                page.ItemSettings.Body.Type(_templateItem.GeneralSettings.Body);
            }

            page.ItemSettings.ItemStatus.Type(_templateItem.GeneralSettings.ItemStatus);
            page.ItemSettings.ItemClassID.Type(_templateItem.GeneralSettings.ItemClass);

            if (!string.IsNullOrEmpty(_templateItem.GeneralSettings.ItemType))
            {
                page.ItemSettings.ItemType.Type(_templateItem.GeneralSettings.ItemType);
            }
            if (!string.IsNullOrEmpty(_templateItem.GeneralSettings.ValMethod))
            {
                page.ItemSettings.ValMethod.Type(_templateItem.GeneralSettings.ValMethod);
            }
            if (!string.IsNullOrEmpty(_templateItem.GeneralSettings.TaxCategory))
            {
                page.ItemSettings.TaxCategoryID.Type(_templateItem.GeneralSettings.TaxCategory);
            }
            if (!string.IsNullOrEmpty(_templateItem.GeneralSettings.PostClass))
            {
                page.ItemSettings.PostClassID.Type(_templateItem.GeneralSettings.PostClass);
            }

            if (!string.IsNullOrEmpty(_templateItem.GeneralSettings.LotSerClass))
            {
                page.ItemSettings.LotSerClassID.Type(_templateItem.GeneralSettings.LotSerClass);
            }
            if (!string.IsNullOrEmpty(_templateItem.GeneralSettings.DefWarehouse))
            {
                page.ItemSettings.DfltSiteID.Type(_templateItem.GeneralSettings.DefWarehouse);
            }

            page.ItemSettings.RecPrice.Type(_templateItem.PriceInfo.RecPrice);
            page.ItemSettings.BasePrice.Type(_templateItem.PriceInfo.BasePrice);
        }

        private void FullVendorDetails(Extensions.TemplateItems.TemplateItem page)
        {
            foreach (var vendor in _templateItem.VendorDetails)
            {
                page.VendorDetails.New();
                page.VendorDetails.Row.VendorID.Select(vendor.VendorID);
                page.VendorDetails.Row.AddLeadTimeDays.Type(vendor.AddLeadTimeDays);
                page.VendorDetails.Row.MaxOrdQty.Type(vendor.MaxOrdQty);
            }
        }

        private void FullAttrConfig(Extensions.TemplateItems.TemplateItem page)
        {
            page.ItemSettings.DefaultColumnMatrixAttributeID.Select(_templateItem.AttributeConfig.DefaultColumnMatrixAttribute);
            page.ItemSettings.DefaultRowMatrixAttributeID.Select(_templateItem.AttributeConfig.DefaultRowMatrixAttribute);
            foreach (var segmentSetting in _templateItem.AttributeConfig.InventoryIDSegmentSettings)
            {
                page.InventorySegmentSettings.New();
                page.InventorySegmentSettings.Row.SegmentType.Select(segmentSetting.SegmentType);
                if (!string.IsNullOrEmpty(segmentSetting.AttributeID))
                {
                    page.InventorySegmentSettings.Row.AttributeID.Select(segmentSetting.AttributeID);
                }
                page.InventorySegmentSettings.Row.NumberOfCharacters.Type(segmentSetting.NumberOfCharacters);

                //full description segment settings
                page.DescriptionSegmentSettings.New();
                page.DescriptionSegmentSettings.Row.SegmentType.Select(segmentSetting.SegmentType);
                if (!string.IsNullOrEmpty(segmentSetting.AttributeID))
                {
                    page.DescriptionSegmentSettings.Row.AttributeID.Select(segmentSetting.AttributeID);
                }
                page.DescriptionSegmentSettings.Row.NumberOfCharacters.Type(segmentSetting.NumberOfCharacters);
            }
        }

        private void CreateMatrixItems(Extensions.TemplateItems.TemplateItem page)
        {
            foreach (var matrixItem in _templateItem.CreateMatrixItemsTab.AdditionalAttributes)
            {
                page.CreateMatrixTab_AdditionalAttr.Row.DynamicControl<Selector>(matrixItem.ColumnName).Select(matrixItem.AttributeValue);
                page.Matrix.Row.Preliminary.SetTrue();
                page.CreateMatrixItems();
                page.MatrixItemsForCreation.Buttons.Confirmation.Click();
            }

            if (_templateItem.CreateMatrixItemsTab.AdditionalAttributes.Any()) return;
            page.Matrix.Row.Preliminary.SetTrue();
            page.CreateMatrixItems();
            page.MatrixItemsForCreation.Buttons.Confirmation.Click();
        }
    }
}