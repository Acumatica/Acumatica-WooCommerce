using System.ComponentModel;

namespace PX.Commerce.WooCommerce.API.REST.Filters
{
    public class FilterProductCategories : Filter
    {
        [Description("search")]
        public string Search { get; set; }

        [Description("exclude")]
        public string Exclude { get; set; }

        [Description("include")]
        public string Include { get; set; }

        [Description("parent")]
        public int Parent { get; set; }

        [Description("product")]
        public int Product { get; set; }

        [Description("slug")]
        public string slug { get; set; }

        [Description("hide_empty")]
        public bool HideEmpty { get; set; }
    }

}
