using ACSC.Tests.Entity.Payment;
using ACSC.Tests.Extensions.Payment;

namespace ACSC.Tests.PageVisitors.Payment
{
    public interface IPaymentVisitor
    {
        PaymentEntity Get(PaymentAr page);
    }
}