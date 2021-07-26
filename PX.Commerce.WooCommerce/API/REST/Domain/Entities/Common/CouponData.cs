using Newtonsoft.Json;
using PX.Commerce.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Common
{
    public class CouponData : BCAPIEntity, IWooEntity
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        public decimal? AmountInDecimal
        {
            get
            {
                decimal val;
                return decimal.TryParse(Amount, out val) ? val : 0;
            }
        }

        [JsonProperty("date_created")]
        public DateTime? DateCreatedUT { get; set; }

        [JsonProperty("date_created_gmt")]
        public DateTime? DateCreatedGmt { get; set; }

        [JsonProperty("date_modified")]
        public DateTime? DateModified { get; set; }

        [JsonProperty("date_modified_gmt")]
        public DateTime? DateModifiedGmt { get; set; }

        [JsonProperty("discount_type")]
        public string DiscountType { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("date_expires")]
        public string DateExpires { get; set; }

        [JsonProperty("date_expires_gmt")]
        public string DateExpiresGmt { get; set; }

        [JsonProperty("usage_count")]
        public int? UsageCount { get; set; }

        [JsonProperty("individual_use")]
        public bool? IndividualUse { get; set; }

        [JsonProperty("product_ids")]
        public List<int> ProductIds { get; set; }

        [JsonProperty("excluded_product_ids")]
        public List<int> ExcludedProductIds { get; set; }

        [JsonProperty("usage_limit")]
        public int? UsageLimit { get; set; }

        [JsonProperty("usage_limit_per_user")]
        public int? UsageLimitPerUser { get; set; }

        [JsonProperty("limit_usage_to_x_items")]
        public int? LimitUsageToXItems { get; set; }

        [JsonProperty("free_shipping")]
        public bool? FreeShipping { get; set; }

        [JsonProperty("product_categories")]
        public List<int> ProductCategories { get; set; }

        [JsonProperty("excluded_product_categories")]
        public List<int> ExcludedProductCategories { get; set; }

        [JsonProperty("exclude_sale_items")]
        public bool? ExcludeSaleItems { get; set; }

        [JsonProperty("minimum_amount")]
        public string MinimumAmount { get; set; }

        [JsonProperty("maximum_amount")]
        public string MaximumAmount { get; set; }

        [JsonProperty("email_restrictions")]
        public List<string> EmailRestrictions { get; set; }

        [JsonProperty("used_by")]
        public List<string> UsedBy { get; set; }
    }
}
