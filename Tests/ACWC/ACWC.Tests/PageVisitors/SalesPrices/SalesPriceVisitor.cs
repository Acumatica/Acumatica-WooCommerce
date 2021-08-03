using ACSC.Tests.Entity.SalesPrices;
using ACSC.Tests.Extensions.SalesPrices;
using System;
using ACSC.Tests.Utils;

namespace ACSC.Tests.PageVisitors.SalesPrices
{
    class SalesPriceVisitor : ISalesPriceVisitor
    {
        private SalesPriceEntity _salesPrice;

        public SalesPriceVisitor()
        {
            _salesPrice = new SalesPriceEntity();
        }

        public SalesPriceVisitor(SalesPriceEntity salesPrice)
        {
            _salesPrice = salesPrice;
        }

        public void SetData(SalesPriceEntity salesPrice)
        {
            _salesPrice = salesPrice;
        }

        public void Full(ACSalesPricePage page)
        {
            FullGeneralInfo(page);
            FullItemDetails(page);
        }

        private void FullGeneralInfo(ACSalesPricePage page)
        {
            page.Summary.PriceType.Select(_salesPrice.Summary.PriceType);
            if (!string.IsNullOrEmpty(_salesPrice.Summary.PriceCode))
            {
                page.Summary.PriceCode.Select(_salesPrice.Summary.PriceCode);
            }

            if (!string.IsNullOrEmpty(_salesPrice.Summary.InventoryID))
            {
                page.Summary.InventoryID.Select(_salesPrice.Summary.InventoryID);
            }

            if (!string.IsNullOrEmpty(_salesPrice.Summary.Warehouse))
            {
                page.Summary.InventoryID.Select(_salesPrice.Summary.Warehouse);
            }
            
        }

        private void FullItemDetails(ACSalesPricePage page)
        {
            foreach (var item in _salesPrice.Details)
            {
                page.Details.New();
                if (!string.IsNullOrEmpty(item.PriceType))
                {
                    page.DetailsRow.PriceType.Select(item.PriceType);
                }
                
                if (item.PriceCode != null)
                {
                    page.DetailsRow.PriceCode.Select(item.PriceCode);
                }
                page.DetailsRow.InventoryID.Select(item.InventoryID);
                
                if (!string.IsNullOrEmpty(item.UOM))
                {
                    page.DetailsRow.UOM.Select(item.UOM);
                }
                if (!string.IsNullOrEmpty(item.Warehouse))
                {
                    page.DetailsRow.Warehouse.Select(item.Warehouse);
                }

                page.DetailsRow.BreakQty.Type(item.BreakQty);
                page.DetailsRow.Price.Type(item.Price);

                if (!string.IsNullOrEmpty(item.Currency))
                {
                    page.DetailsRow.Currency.Select(item.Currency);
                }

                if (item.Promotion)
                {
                    page.DetailsRow.IsPromotionalPrice.SetTrue();
                }

                if (item.EffectiveDate.HasValue())
                {
                    page.DetailsRow.EffectiveDate.Type(item.EffectiveDate.ToString());
                }

                if (item.ExpirationDate.HasValue())
                {
                    page.DetailsRow.ExpirationDate.Type(item.ExpirationDate.ToString());
                }
            }
        }

        public SalesPriceEntity Get(ACSalesPricePage page)
        {
            var result = new SalesPriceEntity
            {
                Summary =
                {
                    PriceType = page.Summary.PriceType.GetValue()

                }
            };

            var count = page.Details.RowsCount().ToString();
            int.TryParse(count, out int rowCount);

            for (var i = 1; i <= rowCount; i++)
            {
                page.Details.SelectRow(i);
                var row = page.DetailsRow;
                if (row != null)
                {
                    result.Details.Add(new SalesPriceEntityDetails
                    {
                        InventoryID = row.InventoryID.GetValue(),
                        Description = row.Description.GetValue(),
                        BreakQty = decimal.Parse(row.BreakQty.GetValue()),
                        Price = decimal.Parse(row.Price.GetValue()),
                        UOM = row.UOM.GetValue(),
                        Warehouse = row.Warehouse.GetValue(),
                        PriceType = row.PriceType.GetValue(),
                        Currency = row.Currency.GetValue(),
                        EffectiveDate = row.EffectiveDate.GetValue(),
                        ExpirationDate = row.ExpirationDate.GetValue()
                    });
                }
            }

            return result;
        }
    }
}
