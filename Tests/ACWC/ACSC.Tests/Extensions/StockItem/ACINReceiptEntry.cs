using ACBC.Tests.Wrappers;
using ACSC.Tests.Wrappers;
using ACSC.Tests.Wrappers.StockItem;

namespace ACSC.Tests.Extensions.StockItem
{
    public class ACINReceiptEntry : IN301000_INReceiptEntry
    {
        public c_receipt_form Form => base.Receipt_form;
        public c_transactions_grid TransactionsGrid => base.Transactions_grid;

        public void CreateReceipt(string inventoryCD, string siteCD, decimal qty)
        {
            OpenScreen();
            Insert();
            TransactionsGrid.ClickAndAddNewRow();
            TransactionsGrid.Row.InventoryID.Select(inventoryCD);
            TransactionsGrid.Row.SiteID.Select(siteCD);
            TransactionsGrid.Row.Qty.Type(qty);
            Form.Hold.SetFalse();
            Release();
        }
    }
}
