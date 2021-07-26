namespace ACSC.Tests.Entity.Payment
{
    public class PaymentEntity 
    {
        public PaymentEntity()
        {
            Summary = new PaymentEntityHeader();
        }

        public string StoreID { get; set; }
        public string spPaymentID { get; set; }
        public string spOrderID { get; set; }
        public string spExtID { get; set; }
        public PaymentEntityHeader Summary { get; set; }
    }
}