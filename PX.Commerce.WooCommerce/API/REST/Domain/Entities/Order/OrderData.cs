using Newtonsoft.Json;
using PX.Commerce.Core;
using System;
using Meta = PX.Commerce.WooCommerce.API.REST.Domain.Entities.Common;
using System.Collections.Generic;
using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Customer;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order
{
    public class OrderData : BCAPIEntity, IWooEntity
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("parent_id")]
        public int? ParentId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("prices_include_tax")]
        public bool? PricesIncludeTax { get; set; }

        [JsonProperty("date_created")]
        public DateTime? DateCreatedUT { get; set; }

        [JsonProperty("date_modified")]
        public DateTime? DateModified { get; set; }

        [JsonProperty("discount_total")]
        public string DiscountTotal { get; set; }

        public decimal? DiscountTotalDecimal { get { return decimal.TryParse(DiscountTotal, out decimal val) ? val : 0; } }

        [JsonProperty("discount_tax")]
        public string DiscountTax { get; set; }

        [JsonProperty("shipping_total")]
        public string ShippingTotal { get; set; }

        public decimal? ShippingTotalInDecimal
        {
            get
            {
                decimal val;
                return decimal.TryParse(ShippingTotal, out val) ? val : 0;
            }
        }

        [JsonProperty("shipping_tax")]
        public string ShippingTax { get; set; }

        [JsonProperty("cart_tax")]
        public string CartTax { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }

        public decimal? TotalInDecimal
        {
            get
            {
                decimal val;
                val = decimal.TryParse(Total, out val) ? val : 0;
                return val;
            }
        }

        [JsonProperty("total_tax")]
        public string TotalTax { get; set; }

        public decimal? TotalTaxInDecimal
        {
            get
            {
                decimal val;
                return decimal.TryParse(TotalTax, out val) ? val : 0;
            }
        }

        [JsonProperty("customer_id")]
        public int? CustomerId { get; set; }

        [JsonProperty("order_key")]
        public string OrderKey { get; set; }

        [JsonProperty("billing")]
        public CustomerAddressData Billing { get; set; }

        [JsonProperty("shipping")]
        public CustomerAddressData Shipping { get; set; }

        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        [JsonProperty("payment_method_title")]
        public string PaymentMethodTitle { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("customer_ip_address")]
        public string CustomerIpAddress { get; set; }

        [JsonProperty("customer_user_agent")]
        public string CustomerUserAgent { get; set; }

        [JsonProperty("created_via")]
        public string CreatedVia { get; set; }

        [JsonProperty("customer_note")]
        public string CustomerNote { get; set; }

        [JsonProperty("date_completed")]
        public object DateCompleted { get; set; }

        [JsonProperty("date_paid")]
        public object DatePaid { get; set; }

        [JsonProperty("cart_hash")]
        public string CartHash { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("line_items")]
        public List<OrderLineItemData> LineItems { get; set; }

        [JsonProperty("tax_lines")]
        public List<TaxLineData> TaxLines { get; set; }

        [JsonProperty("shipping_lines")]
        public List<ShippingLineData> ShippingLines { get; set; }

        [JsonProperty("fee_lines")]
        public List<object> FeeLines { get; set; }

        [JsonProperty("coupon_lines")]
        public List<CouponLineData> CouponLines { get; set; }

        [JsonProperty("refunds")]
        public List<OrderRefundData> Refunds { get; set; }

        [JsonProperty("date_created_gmt")]
        public DateTime? DateCreatedGmt { get; set; }

        [JsonProperty("date_modified_gmt")]
        public DateTime? DateModifiedGmt { get; set; }

        [JsonProperty("date_completed_gmt")]
        public object DateCompletedGmt { get; set; }

        [JsonProperty("date_paid_gmt")]
        public object DatePaidGmt { get; set; }

        [JsonProperty("currency_symbol")]
        public string CurrencySymbol { get; set; }

        [JsonProperty("meta_data")]
        public List<Meta.Metadata> Metadata { get; set; }

        public List<OrdersTransactionData> Transactions { get; set; }
    }
}
