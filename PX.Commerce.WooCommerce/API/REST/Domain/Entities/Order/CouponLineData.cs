using Newtonsoft.Json;
using PX.Commerce.Core;
using PX.Commerce.WooCommerce.WC.Descriptor;
using System;
using System.Collections.Generic;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order
{
    [JsonObject(Description = "Sales Order -> CouponLines")]
    [CommerceDescription(WCCaptions.CouponData)]
    public class CouponLineData : BCAPIEntity, IWooEntity
    {
        [JsonProperty("id")]
        [CommerceDescription(WCCaptions.ID, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public int? Id { get; set; }

        [JsonProperty("code")]
        [CommerceDescription(WCCaptions.Code, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public string Code { get; set; }

        [JsonProperty("discount")]
        [CommerceDescription(WCCaptions.Discount, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public string Discount { get; set; }
        public decimal? DiscountInDecimal
        {
            get { decimal val; return decimal.TryParse(Discount, out val) ? val : 0; }
        }

        [JsonProperty("discount_tax")]
        [CommerceDescription(WCCaptions.DiscountTax, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
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
