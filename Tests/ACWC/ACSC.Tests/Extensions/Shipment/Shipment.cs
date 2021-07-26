using ACSC.Tests.Entity.Shipment;
using ACSC.Tests.PageVisitors;
using ACSC.Tests.PageVisitors.Shipment;
using GeneratedWrappers.Acumatica;
using Controls.Editors.Selector;
using System.Collections.Generic;

namespace ACSC.Tests.Extensions.Shipment
{
    public class Shipment : SO302000_SOShipmentEntry
    {
        public c_document_form Summary => Document_form;
        public c_transactions_grid DocumentDetails => Transactions_grid;
        public TransactionsGridRow TransactionsRow => new TransactionsGridRow(this);
        public c_currentdocument_formf ShippingInformation => CurrentDocument_formF;
        public c_packages_gridpackages Packages => base.Packages_gridPackages;
        public c_packagedetailsplit_gridpackagedetailsplit PackageContents => base.PackageDetailSplit_gridPackageDetailSplit;
        public ShipmentEntity Get()
        {
            var visitor = VisitorsManager.GetSingle<IShipmentVisitor>(typeof(ShipmentVisitor));
            return visitor.Get(this);
        }

        public class TransactionsGridRow
        {
            private readonly Shipment _parent;
            private readonly c_transactions_grid.c_grid_row _row;

            public TransactionsGridRow(Shipment parent)
            {
                _parent = parent;
                _row = _parent.DocumentDetails.Row;
            }

            public Selector InventoryID => _row.InventoryID;
            public Selector OrderNbr => _row.OrigOrderNbr;
        }

        public void ConfirmShipment(int? qty = null)
        {
            AssignQtyAndPackages(qty);
            ConfirmShipmentAction();
        }

        public void AssignQtyAndPackages(int? qty = null)
        {
            List<string> inventories = new List<string>();
            int tranCount = DocumentDetails.RowsCount();

            for (int i = 1; i <= tranCount; i++)
            {
                DocumentDetails.SelectRow(i);
                var row = DocumentDetails.Row;
                if (row != null)
                {
                    if (qty != null)
                    {
                        row.ShippedQty.Type((int) qty);
                    }
                   
                    inventories.Add(row.InventoryID.GetValue());
                }
            }

            Packages.Columns.BoxID.Equals("LARGE");

            if (Packages.RowsCount() == 0)
            {
                Packages.ClickAndAddNewRow();
                Packages.Row.BoxID.Select("LARGE");
            }

            Packages.Row.Confirmed.SetTrue();
            Save();

            Packages.Columns.BoxID.DoesNotEqual("LARGE");
            Packages.RemoveAllRows();
            Packages.Columns.BoxID.ClearFilter();
            Packages.SelectRow(1);

            foreach (string line in inventories)
            {
                PackageContents.ClickAndAddNewRow();
                PackageContents.Row.ShipmentSplitLineNbr.Select(line);
            }

            Save();
        }
    }
}