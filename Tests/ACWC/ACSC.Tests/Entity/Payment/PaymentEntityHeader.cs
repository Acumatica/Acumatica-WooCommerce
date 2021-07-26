using System;

namespace ACSC.Tests.Entity.Payment
{
    public class PaymentEntityHeader : ICloneable
    {
        public string CustomerID { get; set; }
        public DateTime? AppDate { get; set; }
        public string RefNbr { get; set; }
        public string ExtRefNbr { get; set; }
        public string DocDesc { get; set; }
        public decimal? PaymentAmt { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}