using ACSC.Tests.Entity.Payment;
using ACSC.Tests.Extensions.Payment;

namespace ACSC.Tests.PageVisitors.Payment
{
    public class PaymentVisitor : IPaymentVisitor
    {
        public PaymentEntity Get(PaymentAr page)
        {
            var payment = new PaymentEntity
            {
                Summary =
                {
                    CustomerID = page.Summary.CustomerID.GetValue(),
                    AppDate = page.Summary.AdjDate.GetValue(),
                    //ExtRefNbr = page.Header.ExtRefNbr.GetValue(),
                    RefNbr = page.Summary.RefNbr.GetValue(),
                    DocDesc = page.Summary.DocDesc.GetValue(),
                    PaymentAmt = decimal.Parse(page.Summary.CuryOrigDocAmt.GetValue())
                }
            };

            return payment;
        }
    }
}