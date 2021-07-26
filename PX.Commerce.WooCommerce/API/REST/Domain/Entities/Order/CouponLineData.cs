using Newtonsoft.Json;
using PX.Commerce.Core;
using System;
using System.Collections.Generic;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order
{
    public class CouponLineData : BCAPIEntity, IWooEntity
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("discount")]
        public string Discount { get; set; }
        public decimal? DiscountInDecimal
        {
            get { decimal val; return decimal.TryParse(Discount, out val) ? val : 0; }
        }

        [JsonProperty("discount_tax")]
        public string DiscountTax { get; set; }

        public decimal? DiscountTaxInDecimal
        {
            get { decimal val; return decimal.TryParse(DiscountTax, out val) ? val : 0; }
        }

        [JsonProperty("meta_data")]
        public List<object> MetaData { get; set; }

        public DateTime? DateCreatedUT { get; set; }

        public DateTime? DateModified { get; set; }
    }
}
