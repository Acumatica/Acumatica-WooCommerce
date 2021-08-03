using ACSC.Tests.Entity.CustomerPriceClasses;
using ACSC.Tests.Extensions.CustomerPriceClasses;

namespace ACSC.Tests.PageVisitors.CustomerPriceClasses
{
    public interface ICustomerPriceClassesVisitor
    {
        void Full(ACCustomerPriceClassesPage page);
        void SetData(CustomerPriceClassesEntity customerPriceClassesEntity);
    }
}
