using System;
using System.ComponentModel;

namespace BCApiClient.Rest.Filters
{
    public class FilterCustomers : Filter
    {
        [Description("min_id")]
        public int? MinimumId { get; set; }
        
        [Description("max_id")]
        public int? MaximumId { get; set; }

        [Description("first_name")]
        public string FirstName { get; set; }

        [Description("last_name")]
        public string LastName { get; set; }

        [Description("company")]
        public string Company { get; set; }

        [Description("email")]
        public string Email { get; set; }

        [Description("phone")]
        public string Phone { get; set; }

        [Description("store_credit")]
        public decimal? StoreCredit { get; set; }

        [Description("customer_group_id")]
        public int? CustomerGroupId { get; set; }

        [Description("min_date_created")]
        public DateTime? MinDateCreated { get; set; }

        [Description("max_date_created")]
        public DateTime? MaxDateCreated { get; set; }

        [Description("min_date_modified")]
        public DateTime? MinDateModified { get; set; }

        [Description("max_date_modified")]
        public DateTime? MaxDateModified  { get; set; }



    }
}
