using ACSC.Tests.Entity.Customer;
using ACSC.Tests.Extensions.Customer;

namespace ACSC.Tests.PageVisitors.Customer
{
    public interface ICustomerGIVisitor
    {
       CustomerGI Get(CustomersGI page);
    }
}