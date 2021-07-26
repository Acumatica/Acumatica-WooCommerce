using System;
using System.Collections.Generic;
using BCApiClient.Rest.Domain.Entities.Common;
using BCApiClient.Rest.Domain.Entities.Orders;
using BCApiClient.Rest.ExtensionMethods;
using Newtonsoft.Json;

namespace ACSC.Tests.BigCommerceRest.Rest.Domain.Entities.Orders
{
    public class OrderDataResponse : IBCEntityData
    {
        //Products
        /// <summary>
        /// The ID of the order. This is auto-generated for new orders.
        /// </summary>
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        /// <summary>
        /// The ID of the customer that placed the order or 0 if it was a guest order.
        /// </summary>
        [JsonProperty("customer_id")]
        public virtual int CustomerId { get; set; }

        /// <summary>
        /// The date the order was placed. If not supplied, the current date will be used. Please note that orders processed 
        /// by live online payment gateways first arrive in the orders data with an "Incomplete" status and are then updated 
        /// (see the date_modified field) with final payment information. If your application relies on the arrival of new 
        /// orders you may need to check both date_created and status fields (or status_id).
        /// </summary>
        [JsonIgnore]
        public virtual DateTime? DateCreated { get; set; }


        [JsonProperty("date_created")]
        public virtual string DateCreatedUT
        {
            get
            {
                return DateCreated.DateTimeToString();
            }
            set
            {
                DateCreated = value.StringToDateTime();
            }
        }

        /// <summary>
        /// The date the order was last modified.
        /// </summary>
        [JsonIgnore]
        public virtual DateTime? DateModified { get; set; }

        [JsonIgnore]
        public virtual string DateModifiedUT
        {
            get
            {
                return DateModified.DateTimeToString();
            }
            set
            {
                DateModified = value.StringToDateTime();
            }
        }

        /// <summary>
        /// The subtotal of the order excluding tax.
        /// </summary>
        [JsonProperty("subtotal_ex_tax")]
        public virtual decimal SubtotalExcludingTax { get; set; }

        /// <summary>
        /// The subtotal of the order including tax.
        /// </summary>
        [JsonProperty("subtotal_inc_tax")]
        public virtual decimal SubtotalIncludingTax { get; set; }

        /// <summary>
        /// The amount of tax on the subtotal.
        /// </summary>
        [JsonIgnore]
        public virtual decimal SubtotalTax { get; set; }

        /// <summary>
        /// The total tax for the order.
        /// </summary>
        [JsonIgnore]
        public virtual decimal TotalTax { get; set; }


        /// <summary>
        /// The base shipping cost of the order. The base shipping cost is the 
        /// sum of all of the shipping costs minus any discount amounts to the 
        /// shipping costs. It may be inc or ex tax depending on the "Prices Entered With Tax?" 
        /// tax setting.The base shipping * cost is the sum of all of the base shipping costs on 
        /// each address. A * base shipping cost is a price entered by the store owner, either 
        /// inc or * ex tax.
        /// </summary>
        [JsonProperty("base_shipping_cost")]
        public virtual decimal BaseShippingCost { get; set; }

        /// <summary>
        /// The total shipping cost of the order excluding tax.
        /// </summary>
        [JsonProperty("shipping_cost_ex_tax")]
        public virtual decimal ShippingCostExcludingTax { get; set; }

        /// <summary>
        /// The total shipping cost of the order including tax.
        /// </summary>
        [JsonProperty("shipping_cost_inc_tax")]
        public virtual decimal ShippingCostIncludingTax { get; set; }

        /// <summary>
        /// The total tax for the shipping cost.
        /// </summary>
        [JsonProperty("shipping_cost_tax")]
        public virtual decimal ShippingCostTax { get; set; }

        /// <summary>
        /// The ID of the tax class used for taxing shipping costs
        /// </summary>
        [JsonProperty("shipping_cost_tax_class_id")]
        public virtual int ShippingCostTaxClassId { get; set; }


        /// <summary>
        /// The base handling cost of the order. The base handling cost is the 
        /// sum of the all the handling costs. It may be inc or ex tax depending 
        /// on the "Prices Entered With Tax?" tax setting.
        /// </summary>
        [JsonProperty("base_handling_cost")]
        public virtual decimal BaseHandlingCost { get; set; }

        /// <summary>
        /// The handling cost of the order excluding tax.
        /// </summary>
        [JsonProperty("handling_cost_ex_tax")]
        public virtual decimal HandlingCostExcludingTax { get; set; }

        /// <summary>
        /// The handing cost of the order including tax.
        /// </summary>
        [JsonProperty("handling_cost_inc_tax")]
        public virtual decimal HandlingCostIncludingTax { get; set; }

        /// <summary>
        /// The total tax for the handling cost.
        /// </summary>
        [JsonProperty("handling_cost_tax")]
        public virtual decimal HandlingCostTax { get; set; }

        /// <summary>
        /// The ID of the tax class used for taxing handling costs.
        /// </summary>
        [JsonProperty("handling_cost_tax_class_id")]
        public virtual int HandlingCostTaxClassId { get; set; }

        /// <summary>
        /// The base wrapping cost of the order. The base wrapping cost is the sum 
        /// of all the wrapping costs on the items. It may be inc or ex tax depending 
        /// on the "Prices Entered With Tax?" tax setting.
        /// </summary>
        [JsonProperty("base_wrapping_cost")]
        public virtual decimal BaseWrappingCost { get; set; }

        /// <summary>
        /// The wrapping cost of the order including tax.
        /// </summary>
        [JsonProperty("wrapping_cost_ex_tax")]
        public virtual decimal WrappingCostExcludingTax { get; set; }

        /// <summary>
        /// The wrapping cost of the order excluding tax.
        /// </summary>
        [JsonProperty("wrapping_cost_inc_tax")]
        public virtual decimal WrappingCostIncludingTax { get; set; }

        /// <summary>
        /// The total tax for the wrapping cost.
        /// </summary>
        [JsonProperty("wrapping_cost_tax")]
        public virtual decimal WrappingCostTax { get; set; }

        /// <summary>
        /// The ID of the tax class used for taxing wrapping costs.
        /// </summary>
        [JsonProperty("wrapping_cost_tax_class_id")]
        public virtual int WrappingCostTaxClassId { get; set; }


        /// <summary>
        /// The total of the order excluding tax.
        /// </summary>
        [JsonProperty("total_ex_tax")]
        public virtual decimal TotalExcludingTax { get; set; }

        /// <summary>
        /// The total of the order including tax.
        /// </summary>
        [JsonProperty("total_inc_tax")]
        public virtual decimal TotalIncludingTax { get; set; }

        /// <summary>
        /// The status of the order. A list of available statuses can be retrieved 
        /// from Order Statuses
        /// </summary>
        [JsonProperty("status_id")]
        public virtual int StatusId { get; set; }

        /// <summary>
        /// The textual description of the status. 
        /// 
        /// [string(100)]
        /// </summary>
        [JsonProperty("status")]
        public virtual string Status { get; set; }

        /// <summary>
        /// The total quantity of the items (sum of products * quantity) in the order.
        /// </summary>
        [JsonProperty("items_total")]
        public virtual int ItemsTotal { get; set; }

        /// <summary>
        /// The quantity of items that have been shipped.
        /// </summary>
        [JsonProperty("items_shipped")]
        public virtual int ItemsShipped { get; set; }

        /// <summary>
        /// The payment method used for the order.
        /// 
        /// [string(100)]
        /// </summary>
        [JsonProperty("payment_method")]
        public virtual string PaymentMethod { get; set; }

        /// <summary>
        /// The ID or reference number of a payment from the payment provider/gateway.
        /// 
        /// [string(255)]
        /// </summary>
        [JsonProperty("payment_provider_id")]
        public virtual string PaymentProviderId { get; set; }

        /// <summary>
        /// The status of the payment. A payment status may be one of the following, 
        /// depending on the payment method used: 
        /// 
        /// authorized
        /// captured
        /// refunded
        /// partially
        /// refunded
        /// voided
        /// </summary>
        /// 
        [JsonIgnore]
        public virtual string PaymentStatus { get; set; }

        /// <summary>
        /// The amount that that has been refunded for the order.
        /// </summary>
        [JsonProperty("refunded_amount")]
        public virtual decimal RefundedAmount { get; set; }

        /// <summary>
        /// Indicates if the order contains purely digital delivery products.
        /// </summary>
        [JsonProperty("order_is_digital")]
        public virtual bool OrderIsDigital { get; set; }

        /// <summary>
        /// The date the order was shipped.
        /// </summary>
        [JsonIgnore]
        public virtual DateTime? DateShipped { get; set; }

        [JsonProperty("date_shipped")]
        public virtual string DateShippedUT
        {
            get
            {
                return DateShipped.DateTimeToString();
            }
            set
            {
                DateShipped = value.StringToDateTime();
            }
        }

        /// <summary>
        /// The amount of store credit the customer used to pay for the order.
        /// </summary>
        [JsonProperty("store_credit_amount")]
        public virtual decimal StoreCreditAmount { get; set; }

        /// <summary>
        /// The amount of a gift certificate the customer used to pay for the order.
        /// </summary>
        [JsonProperty("gift_certificate_amount")]
        public virtual decimal GiftCertificateAmount { get; set; }

        /// <summary>
        /// The IP address of the user that placed the order.
        /// 
        /// [string(30)]
        /// </summary>
        [JsonProperty("ip_address")]
        public virtual string IpAddress { get; set; }

        /// <summary>
        /// The country the order was placed from as determined by GeoIP location.
        /// 
        /// [string(50)]
        /// </summary>
        [JsonIgnore]
        public virtual string GeoIpCountry { get; set; }

        /// <summary>
        /// The country code of the geoip_country field.
        /// 
        /// [string(50)]
        /// </summary>
        [JsonIgnore]
        public virtual string GeoIpCountryIso2 { get; set; }

        /// <summary>
        /// The ID of the currency used by the customer to place the order.
        /// </summary>
        [JsonIgnore]
        public virtual int CurrencyId { get; set; }

        /// <summary>
        /// The 3 letter currency code of the currency used to place the order. (Store version 7.3.6+)
        /// 
        /// [string(3)]
        /// </summary>
        [JsonProperty("currency_code")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>
        /// The ID of the store's default currency at the time of the order.
        /// </summary>
        [JsonIgnore]
        public virtual int DefaultCurrencyId { get; set; }

        /// <summary>
        /// The 3 letter currency code of the store's default currency at the time of the order. (Store version 7.3.6+) 
        /// 
        /// [string(3)]
        /// </summary>
        [JsonIgnore]
        public virtual string DefaultCurrencyCode { get; set; }

        /// <summary>
        /// The exchange rate of the currency used to place the order.
        /// </summary>
        [JsonIgnore]
        public virtual decimal CurrencyExchangeRate { get; set; }

        /// <summary>
        /// Staff notes on the order.
        /// </summary>
        [JsonProperty("staff_notes")]
        public virtual string StaffNotes { get; set; }

        /// <summary>
        /// An order message left by the customer when placing the order.
        /// </summary>
        [JsonProperty("customer_message")]
        public virtual string CustomerMessage { get; set; }

        /// <summary>
        /// The total discounts applied to the order, excluding coupons.
        /// </summary>
        [JsonProperty("discount_amount")]
        public virtual decimal DiscountAmount { get; set; }


        /// <summary>
        /// The amount of addresses that items were shipped to for the order.
        /// </summary>
        [JsonIgnore]
        public virtual int ShippingAddressCount { get; set; }

        /// <summary>
        /// The total discount given on the order due to applied coupons.
        /// </summary>
        [JsonProperty("coupon_discount")]
        public virtual decimal CouponDiscount { get; set; }

        /// <summary>
        /// Indicates if the order was deleted (archived).
        /// </summary>
        [JsonProperty("is_deleted")]
        public virtual bool IsDeleted { get; set; }

        /// <summary>
        /// The address that the order is billed to.  
        /// Billing Address section below for a definition of this object. 
        /// 
        /// See https://developer.bigcommerce.com/display/API/Orders
        /// </summary>
        [JsonProperty("billing_address")]
        public virtual OrderBillingAddressData BillingAddress { get; set; }

        [JsonIgnore]
        public virtual Resource Products { get; set; }

        [JsonProperty("shipping_addresses")]
        public virtual IList<OrderShippingAddressData> ReadShippingAddresses { get { return ShippingAddresses; } }

        [JsonIgnore]
        public virtual IList<OrderShippingAddressData> ShippingAddresses { get; set; }
    }
}
