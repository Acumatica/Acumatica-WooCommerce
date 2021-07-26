namespace ACSC.Tests.Entity.Customer
{
    public class CustomerEntityLocation
    {

        public CustomerEntityLocation()
        {
            LocationContact = new CustomerEntityContact();
            LocationAddress = new CustomerEntityAddress();
        }
        
        public string  CustomerID { get; set; }
        public string  LocationID { get; set; }
        public string  LocationName { get; set; }

        public CustomerEntityContact LocationContact { get; set; }
        public CustomerEntityAddress LocationAddress { get; set; }
    }
}
