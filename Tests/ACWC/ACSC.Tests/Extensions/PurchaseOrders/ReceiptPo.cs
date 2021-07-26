using GeneratedWrappers.Acumatica;

namespace ACSC.Tests.Extensions.PurchaseOrders
{
    public class ReceiptPo : PO302000_POReceiptEntry
    {
        public c_document_form Summary => Document_form;
        public c_transactions_grid DocumentDetails => Transactions_grid;
    }
}
