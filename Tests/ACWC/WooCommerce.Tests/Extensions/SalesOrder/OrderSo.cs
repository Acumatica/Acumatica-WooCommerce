using ACSC.Tests.Entity.SalesOrder;
using ACSC.Tests.PageVisitors;
using ACSC.Tests.PageVisitors.SalesOrder;
using GeneratedWrappers.Acumatica;
using Controls.Editors.Selector;

namespace ACSC.Tests.Extensions.SalesOrder
{
    public class OrderSo : SO301000_SOOrderEntry
    {
        public c_document_form Summary => Document_form;
        public c_transactions_grid DocumentDetails => Transactions_grid;
        public TransactionsGridHeader TransactionsFilter => new TransactionsGridHeader(this);
        public c_taxes_grid1 Taxes => Taxes_grid1;
        public c_currentdocument_formcalculatedamounts Totals => CurrentDocument_formCalculatedAmounts;
        public c_currentdocument_formdeliverysettings ShippingSettingsInformation => CurrentDocument_formDeliverySettings;
        public c_shipmentlist_grid5 Shipments => ShipmentList_grid5;
        public c_adjustments_detgrid Applications => Adjustments_detgrid;
        public c_discountdetails_formdiscountdetail Discounts => DiscountDetails_formDiscountDetail;
        public c_soparamfilter_formcreateshipment ShipmentParameters => Soparamfilter_formcreateshipment; 
        public c_currentdocument_formfreightinfo FreightInfo
        {
            get { return base.CurrentDocument_formFreightInfo; }
        }

        public class TransactionsGridHeader
        {
            private readonly OrderSo _parent;
            private readonly c_transactions_grid.c_grid_header _header;

            public TransactionsGridHeader(OrderSo parent)
            {
                _parent = parent;
                _header = parent.DocumentDetails.Columns;
            }

            public SelectorColumnFilter InventoryID => _header.InventoryID;
        }

        public SalesOrderEntity Get(ISalesOrderVisitor soVisitor = null)
        {
            var visitor = soVisitor ?? VisitorsManager.GetSingle<ISalesOrderVisitor>(typeof(SalesOrderVisitor));
            return visitor.Get(this);
        }

        public void AddShipment(string warehouse = null)
        {
            CreateShipmentIssue();
            if (warehouse != null)
            {
                string warehouseID = ShipmentParameters.SiteID.GetValue();
                if (string.IsNullOrEmpty(warehouseID))
                {
                    ShipmentParameters.SiteID.Select(warehouse);
                }
            }

            ShipmentParameters.Ok();
        }
    }
}