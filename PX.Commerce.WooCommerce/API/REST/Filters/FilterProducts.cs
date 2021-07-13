using System;
using System.ComponentModel;

namespace PX.Commerce.WooCommerce.API.REST.Filters
{
    public class FilterProducts : Filter
    {
        [Description("context")] 
        public string Context { get; set; }

        [Description("search")] 
        public string Search { get; set; }

        [Description("after")] 
        public DateTime? After { get; set; }

        [Description("before")] 
        public DateTime? Before { get; set; }

        [Description("exclude")] 
        public string Exclude { get; set; }

        [Description("include")] 
        public string Include { get; set; }

        [Description("orderby")] 
        public string Orderby { get; set; }

        [Description("parent")] 
        public string Parent { get; set; }

        [Description("parent_exclude")]
        public string ParentExclude { get; set; }

        [Description("slug")] 
        public string Slug { get; set; }

        [Description("status")] 
        public string Status { get; set; }

        [Description("type")] 
        public string Type { get; set; } //simple, grouped, external and variable

        [Description("sku")] 
        public string Sku { get; set; }

        [Description("featured")] 
        public string Featured { get; set; }

        [Description("category")] 
        public string Category { get; set; }

        [Description("tag")] 
        public string Tag { get; set; }

        [Description("shipping_class")] 
        public string ShippingClass { get; set; }

        [Description("attribute")] 
        public string Attribute { get; set; }

        [Description("attribute_term")] 
        public string AttributeTerm { get; set; }

        [Description("on_sale")] 
        public string OnSale { get; set; }

        [Description("min_price")] 
        public string MinPrice { get; set; }

        [Description("max_price")] 
        public string MaxPrice { get; set; }

        [Description("stock_status")]
        public string StockStatus { get; set; }

    }


}
