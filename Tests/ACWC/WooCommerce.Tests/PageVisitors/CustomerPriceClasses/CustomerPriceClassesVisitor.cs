using ACSC.Tests.Entity.CustomerPriceClasses;
using ACSC.Tests.Extensions.CustomerPriceClasses;

namespace ACSC.Tests.PageVisitors.CustomerPriceClasses
{
    public class CustomerPriceClassesVisitor : ICustomerPriceClassesVisitor
    {
        private CustomerPriceClassesEntity _customerPriceClasses;

        public CustomerPriceClassesVisitor()
        {
            _customerPriceClasses = new CustomerPriceClassesEntity();
        }

        public CustomerPriceClassesVisitor(CustomerPriceClassesEntity customerPriceClasses)
        {
            _customerPriceClasses = customerPriceClasses;
        }

        public void SetData(CustomerPriceClassesEntity customerPriceClasses)
        {
            _customerPriceClasses = customerPriceClasses;
        }

        public void Full(ACCustomerPriceClassesPage page)
        {
            foreach (var item in _customerPriceClasses.Details)
            {
                page.Details.ClickAndAddNewRow();
                page.DetailsRow.PriceClassID.Type(item.PriceClassID);
                page.DetailsRow.Description.Type(item.Description);
                page.DetailsRow.SortOrder.Type(item.SortOrder);
            }
        }
    }
}
