using System;

namespace ACSC.Tests.Entity.CustomerPriceClasses
{
    public class CustomerPriceClassesEntityDetails : ICloneable
    {
        public string PriceClassID { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
