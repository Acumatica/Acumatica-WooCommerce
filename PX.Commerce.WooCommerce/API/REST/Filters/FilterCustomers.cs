using System.ComponentModel;

namespace PX.Commerce.WooCommerce.API.REST.Filters
{
    public class FilterCustomers : Filter
    {
        [Description("include")]
        public string Include { get; set; }

        [Description("exclude")]
        public string Exclude { get; set; }

        [Description("context")]
        public string Context { get; set; } //Edit/View

        [Description("email")]
        public string Email { get; set; }
    }

}
