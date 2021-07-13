using System;
using System.ComponentModel;

namespace PX.Commerce.WooCommerce.API.REST.Filters
{
    public class FilterOrders : Filter
    {
        [Description("search")] 
        public string Search { get; set; }

        [Description("after")] 
        public string After { get; set; }

        [Description("before")] 
        public string Before { get; set; }

        [Description("exclude")] 
        public int[] Exclude { get; set; }

        [Description("include")] 
        public int[] Include { get; set; }

        [Description("orderby")] 
        public string Orderby { get; set; }

        [Description("parent")] 
        public int[] Parent { get; set; }

        [Description("parent_exclude")]
        public int[] ParentExclude { get; set; }

        [Description("status")] 
        public string[] Status { get; set; }

        [Description("customer")]
        public int? Customer { get; set; }

        [Description("product")] 
        public int? Product { get; set; }

        public DateTime? ModifiedAfter { get; set; }
    }

}
