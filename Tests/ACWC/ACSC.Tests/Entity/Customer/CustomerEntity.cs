using System;
using System.Collections.Generic;

namespace ACSC.Tests.Entity.Customer
{
    public class CustomerEntity
    {
        public CustomerEntity()
        {
            MainContact = new CustomerEntityContact();
            MainAddress = new CustomerEntityAddress();
            DefaultLocationSettings = new CustomerEntityLocationSettings();
            Locations = new List<CustomerEntityLocations>();
            Attributes = new List<CustomerEntityAttributes>();
        }

        public string UsrTitle { get; set; }
        public string UsrCustom { get; set; }
        public string AcctCD { get; set; }
        public string AcctName { get; set; }
        public string Status { get; set; }
        public string CustomerClassID { get; set; }
        public string CuryID { get; set; }
        public bool AcceptsMarketing { get; set; }
        public bool IsBillSameAsMain { get; set; }
        public bool IsBillContSameAsMain { get; set; }
        public DateTime AcceptsMarketingUpdatedAt { get; set; }
        public CustomerEntityContact MainContact { get; set; }
        public CustomerEntityAddress MainAddress { get; set; }
        public CustomerEntityLocationSettings DefaultLocationSettings { get; set; }
        public List<CustomerEntityLocations> Locations { get; set; }
        public List<CustomerEntityAttributes> Attributes { get; set; }
    }
}