using GeneratedWrappers.Acumatica;

namespace ACSC.Tests.Extensions.StockItem
{
    public class ReceiptIn : IN301000_INReceiptEntry
    {
        public c_receipt_form Summary => base.Receipt_form;
        public c_transactions_grid TransactionDetails => base.Transactions_grid;

        public void CreateReceipt(string inventoryCD, string siteCD, decimal qty)
        {
            OpenScreen();
            Insert();
            TransactionDetails.ClickAndAddNewRow();
            TransactionDetails.Row.InventoryID.Select(inventoryCD);
            TransactionDetails.Row.SiteID.Select(siteCD);
            TransactionDetails.Row.Qty.Type(qty);
            ReleaseFromHold();
            Release();
        }
    }
}
