using System;

namespace ACSC.Tests.Entity.SalesOrder
{
    public class SalesOrderEntityPayments : ICloneable
    {
        public string ReferenceNbr { get; set; }
        public string PaymentRef { get; set; }
        public decimal Amt { get; set; }
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}