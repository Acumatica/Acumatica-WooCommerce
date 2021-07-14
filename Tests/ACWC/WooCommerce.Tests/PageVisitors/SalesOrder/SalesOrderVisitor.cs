using System;
using ACSC.Tests.Entity.SalesOrder;
using ACSC.Tests.Extensions.SalesOrder;
using Controls.Input;

namespace ACSC.Tests.PageVisitors.SalesOrder
{
    public class SalesOrderVisitor : ISalesOrderVisitor
    {
        public SalesOrderEntity Get(OrderSo page)
        {
            var salesOrder = new SalesOrderEntity
            {
                Summary =
                {
                    CustomerID = page.Summary.CustomerID.GetValue(),
                    CustomerRefNbr = page.Summary.CustomerRefNbr.GetValue(),
                    OrderDate = page.Summary.OrderDate.GetValue(),
                    OrderDesc = page.Summary.OrderDesc.GetValue(),
                    Project = page.Summary.ProjectID.GetValue()
                },

                ShippingSettings =
                {
                    ShipTermsID = page.ShippingSettingsInformation.ShipTermsID.GetValue(),
                    ShipVia = page.ShippingSettingsInformation.ShipVia.GetValue(),
                    ShipZoneID = page.ShippingSettingsInformation.ShipZoneID.GetValue()
                },
                Totals =
                {
                    CuryOrderTotal = decimal.Parse(page.Summary.CuryOrderTotal.GetValue()),
                    CuryTaxTotal = decimal.Parse(page.Summary.CuryTaxTotal.GetValue()),
                    CuryPaymentTotal = decimal.Parse(page.Totals.CuryPaymentTotal.GetValue()),
                    CuryDiscTot = decimal.Parse(page.Summary.CuryDiscTot.GetValue()),
                    SubTotal = decimal.Parse(page.Summary.CuryVatTaxableTotal.GetValue()),
                    OrderQty = decimal.Parse(page.Summary.OrderQty.GetValue()),
                    FreightPrice = decimal.Parse(page.FreightInfo.CuryFreightAmt.GetValue()),
                    UnshippedAmount = decimal.Parse(page.Totals.CuryOpenOrderTotal.GetValue())
                }
            };
            GetCustomFields(page, salesOrder);
            var tranCount = page.DocumentDetails.RowsCount().ToString();

            int.TryParse(tranCount, out var tranRowCount);


            for (var i = 1; i <= tranRowCount; i++)
            {
                page.DocumentDetails.SelectRow(i);
                var row = page.DocumentDetails.Row;
                if (row != null)
                {
                    salesOrder.DocumentDetails.Add(
                        new SalesOrderEntityDetails
                        {
                            InventoryID = row.InventoryID.GetValue(),
                            OrderQty = decimal.Parse(row.OrderQty.GetValue()),
                            BranchID = row.BranchID.GetValue(),
                            DiscountID = row.DiscountID.GetValue(),
                            CuryDiscAmt = decimal.Parse(row.CuryDiscAmt.GetValue()),
                            TranDesc = row.TranDesc.GetValue(),
                            UnitPrice = decimal.Parse(row.CuryUnitPrice.GetValue()),
                            DiscountPercentage = decimal.Parse(row.DiscPct.GetValue()),
                            ProjectTask = row.TaskID.GetValue()
                        });
                }
            }

            var paymentsCount = page.Applications.RowsCount().ToString();
            int.TryParse(paymentsCount, out var payRowCount);

            for (var i = 1; i <= payRowCount; i++)
            {
                page.Applications.SelectRow(i);
                var row = page.Applications.Row;
                if (row != null)
                {
                    salesOrder.Payments.Add(
                        new SalesOrderEntityPayments
                        {
                            PaymentRef = row.ExtRefNbr.GetValue(),
                            ReferenceNbr = row.AdjgRefNbr.GetValue()
                        });
                }
            }

            var taxDetCount = page.Taxes.RowsCount().ToString();
            int.TryParse(taxDetCount, out var taxRowCount);

            for (var i = 1; i <= taxRowCount; i++)
            {
                page.Taxes.SelectRow(i);
                var row = page.Taxes.Row;
                if (row != null)
                {
                    salesOrder.TaxDetails.Add(
                        new SalesOrderEntityTaxDetails
                        {
                            TaxID = row.TaxID.GetValue(),
                            TaxAmt = decimal.Parse(row.CuryTaxAmt.GetValue())
                        });
                }
            }

            var discCount = page.Discounts.RowsCount().ToString();
            int.TryParse(discCount, out var discRowCount);

            for (var i = 1; i <= discRowCount; i++)
            {
                page.Discounts.SelectRow(i);
                var row = page.Discounts.Row;
                if (row != null)
                {
                    salesOrder.DiscountDetails.Add(
                        new SalesOrderEntityDiscountDetails
                        {
                            DiscCode = row.ExtDiscCode.GetValue(),
                            Description = row.Description.GetValue(),
                            DiscAmt = decimal.Parse(row.CuryDiscountAmt.GetValue()),
                            ExtDiscCode = row.ExtDiscCode.GetValue()
                        });
                }
            }

            var shipCount = page.Shipments.RowsCount().ToString();
            int.TryParse(shipCount, out var shipRowCount);

            for (var i = 1; i <= shipRowCount; i++)
            {
                var row = page.Shipments.Row;
                if (row != null)
                {
                    salesOrder.Shipments.Add(
                        new SalesOrderEntityShipment
                        {
                            ShipmentType = row.ShipmentType.GetValue(),
                            DocumentNbr = row.DisplayShippingRefNoteID.GetValue(),
                            ShipDate = row.ShipDate.GetValue(),
                            ShipmentQty = decimal.Parse(row.ShipmentQty.GetValue())
                        });
                }
            }

            return salesOrder;
        }

        private void GetCustomFields(OrderSo page, SalesOrderEntity salesOrder)
        {
            try
            {
                salesOrder.Summary.Custom_1 = page.Summary.DynamicControl<InputLocalizable>("Custom_Field").GetValue();
            }
            catch (Exception)
            {
                //ignore
            }
        }
    }
}