using System.Collections.Generic;

namespace ACSC.Tests.Entity.Customer
{
    public class CustomerGI
    {
        public CustomerGI()
        {
            ResultRows = new List<CustomerGIRow>();
        }

        public List<CustomerGIRow> ResultRows { get; set; }
    }

    public class CustomerGIRow
    {
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerClass { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string CurrentcyID { get; set; }
        public string Terms { get; set; }
        public string Status { get; set; }
    }
}