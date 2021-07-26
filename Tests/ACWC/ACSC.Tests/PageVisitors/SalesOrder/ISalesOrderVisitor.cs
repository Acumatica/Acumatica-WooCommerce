using ACSC.Tests.Entity.SalesOrder;
using ACSC.Tests.Extensions.SalesOrder;

namespace ACSC.Tests.PageVisitors.SalesOrder
{
    public interface ISalesOrderVisitor
    {
        SalesOrderEntity Get(OrderSo page);
    }
}