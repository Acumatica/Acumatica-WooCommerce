using GeneratedWrappers.Acumatica;
using ACSC.Tests.Entity.Payment;
using ACSC.Tests.PageVisitors;
using ACSC.Tests.PageVisitors.Payment;


namespace ACSC.Tests.Extensions.Payment
{
    public class PaymentAr : AR302000_ARPaymentEntry
    {
        public c_document_form Summary => Document_form;

        public PaymentEntity Get(IPaymentVisitor payVisitor = null)
        {
            var visitor = VisitorsManager.GetSingle<IPaymentVisitor>(typeof(PaymentVisitor));
            return visitor.Get(this);
        }
    }
}