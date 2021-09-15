using Newtonsoft.Json;
using PX.Commerce.Core;
using PX.Commerce.WooCommerce.API.REST.Domain.Enums;
using PX.Commerce.WooCommerce.WC.Descriptor;
using System;
using System.Collections.Generic;
using Meta = PX.Commerce.WooCommerce.API.REST.Domain.Entities.Common;

namespace PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order
{
    [JsonObject(Description = "Order")]
    [CommerceDescription(WCCaptions.OrderData)]
    public class OrderData : BCAPIEntity, IWooEntity
    {
        [JsonProperty("id")]
        [CommerceDescription(WCCaptions.OrderId, FieldFilterStatus.Filterable, FieldMappingStatus.Import)]
        public int? Id { get; set; }

        [JsonProperty("parent_id")]
        public int? ParentId { get; set; }

        [JsonProperty("status")]
        [CommerceDescription(WCCaptions.Status, FieldFilterStatus.Filterable, FieldMappingStatus.Import)]
        public string Status { get; set; }

        [JsonProperty("currency")]
        [CommerceDescription(WCCaptions.Currency, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public string Currency { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("prices_include_tax")]
        [CommerceDescription(WCCaptions.PriceIncludingTax, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public bool? PricesIncludeTax { get; set; }

        [JsonProperty("discount_total")]
        [CommerceDescription(WCCaptions.DiscountTotal, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public string DiscountTotal { get; set; }

        public decimal? DiscountTotalDecimal { get { return decimal.TryParse(DiscountTotal, out decimal val) ? val : 0; } }

        [JsonProperty("discount_tax")]
        [CommerceDescription(WCCaptions.DiscountTax, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public string DiscountTax { get; set; }

        [JsonProperty("shipping_total")]
        [CommerceDescription(WCCaptions.ShippingTotal, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
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
        [CommerceDescription(WCCaptions.ShippingTaxTotal, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public string ShippingTax { get; set; }

        [JsonProperty("cart_tax")]
        [CommerceDescription(WCCaptions.CartTax, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public string CartTax { get; set; }

        [JsonProperty("total")]
        [CommerceDescription(WCCaptions.Total, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
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
        [CommerceDescription(WCCaptions.TotalTax, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
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
        [CommerceDescription(WCCaptions.CustomerId, FieldFilterStatus.Filterable, FieldMappingStatus.Import)]
        public int? CustomerId { get; set; }

        [JsonProperty("order_key")]
        public string OrderKey { get; set; }

        [JsonProperty("billing")]
        [CommerceDescription(WCCaptions.BillingAddress, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public BillingAddressData Billing { get; set; }

        [JsonProperty("shipping")]
        [CommerceDescription(WCCaptions.ShippingAddress, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public ShippingAddressData Shipping { get; set; }

        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        [JsonProperty("payment_method_title")]
        public string PaymentMethodTitle { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("customer_ip_address")]
        [CommerceDescription(WCCaptions.CustomerIPAddress, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public string CustomerIpAddress { get; set; }

        [JsonProperty("customer_user_agent")]
        [CommerceDescription(WCCaptions.CustomerUserAgent, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public string CustomerUserAgent { get; set; }

        [JsonProperty("created_via")]
        public string CreatedVia { get; set; }

        [JsonProperty("customer_note")]
        [CommerceDescription(WCCaptions.CustomerNote, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public string CustomerNote { get; set; }

        [JsonProperty("date_completed")]
        [CommerceDescription(WCCaptions.DateCompleted, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public object DateCompleted { get; set; }

        [JsonProperty("date_paid")]
        public object DatePaid { get; set; }

        [JsonProperty("cart_hash")]
        [CommerceDescription(WCCaptions.CartHash, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public string CartHash { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("line_items")]
        public List<OrderLineItemData> LineItems { get; set; }

        [JsonProperty("tax_lines")]
        public List<TaxLineData> TaxLines { get; set; }
        [CommerceDescription(WCCaptions.ShipmentItems, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        [JsonProperty("shipping_lines")]

        public List<ShippingLineData> ShippingLines { get; set; }

        [JsonProperty("fee_lines")]
        [CommerceDescription(WCCaptions.FeeItems, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public List<object> FeeLines { get; set; }

        [JsonProperty("coupon_lines")]
        [CommerceDescription(WCCaptions.CouponData, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public List<CouponLineData> CouponLines { get; set; }

        [JsonProperty("refunds")]
        [CommerceDescription(WCCaptions.RefundData, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public List<OrderRefundData> OrderRefunds { get; set; }

        public List<RefundData> Refunds { get; set; }

        [JsonProperty("date_created")]
        [CommerceDescription(WCCaptions.DateCreatedUT, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public DateTime? DateCreatedUT { get; set; }

        [JsonProperty("date_created_gmt")]
        [CommerceDescription(WCCaptions.DateModifiedGMT, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public DateTime? DateCreatedGmt { get; set; }

        [JsonProperty("date_modified")]
        [CommerceDescription(WCCaptions.DateModifiedUT, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public DateTime? DateModified { get; set; }

        [JsonProperty("date_modified_gmt")]
        [CommerceDescription(WCCaptions.DateModifiedGMT, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public DateTime? DateModifiedGmt { get; set; }

        [JsonProperty("date_completed_gmt")]
        [CommerceDescription(WCCaptions.DateCompleted, FieldFilterStatus.Skipped, FieldMappingStatus.Import)]
        public object DateCompletedGmt { get; set; }

        [JsonProperty("date_paid_gmt")]
        public object DatePaidGmt { get; set; }

        [JsonProperty("currency_symbol")]
        public string CurrencySymbol { get; set; }

        [JsonProperty("meta_data")]
        public List<Meta.Metadata> Metadata { get; set; }

        public List<OrdersTransactionData> Transactions { get; set; }

        [ShouldNotSerialize, ShouldNotDeserialize]
        public RefundStatus RefundStatus { get; set; }
    }
}
