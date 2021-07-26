using ACSC.Tests.Entity.Customer;
using ACSC.Tests.Extensions.Customer;

namespace ACSC.Tests.PageVisitors.Customer
{
    public interface ICustomerVisitor
    {
        void Full(CustomerAr page);
        CustomerEntity Get(CustomerAr page);
        void SetData(CustomerEntity customer);
    }
}