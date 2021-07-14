using System.Collections.Generic;

namespace ACSC.Tests.Entity.CustomerPriceClasses
{
    public class CustomerPriceClassesEntity
    {
        public CustomerPriceClassesEntity()
        {
            Details = new List<CustomerPriceClassesEntityDetails>();
        }

        public List<CustomerPriceClassesEntityDetails> Details;
    }
}
