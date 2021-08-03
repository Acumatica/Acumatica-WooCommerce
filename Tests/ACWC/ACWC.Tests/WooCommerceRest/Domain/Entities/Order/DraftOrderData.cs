﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using ACSC.Tests.ShopifyRest.Commerce;
using ACSC.Tests.ShopifyRest.Domain.Entities.Common;
using ACSC.Tests.ShopifyRest.Domain.Entities.Customers;
using ACSC.Tests.ShopifyRest.Domain.Entities.Enumerations;

namespace ACSC.Tests.ShopifyRest.Domain.Entities.Order
{
    public class DraftOrderResponse : IEntityResponse<DraftOrderData>
    {
        [JsonProperty("draft_order")]
        public DraftOrderData Data { get; set; }
    }

    public class DraftOrdersResponse : IEntitiesResponse<DraftOrderData>
    {
        [JsonProperty("orders")]
        public List<DraftOrderData> Data { get; set; }
    }

    [JsonObject(Description = "Order")]
    [Description(ShopifyCaptions.DraftOrderData)]
    public class DraftOrderData
    {
        public DraftOrderData()
        {
            LineItems = new List<OrderLineItem>();
        }

        /// <summary>
        /// The mailing address associated with the payment method. This address is an optional field that won't be available on orders that do not require a payment method.
        /// </summary>
        [JsonProperty("billing_address", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.BillingAddress)]
        public OrderAddressData BillingAddress { get; set; }

        /// <summary>
        /// [READ-ONLY] The autogenerated date and time (ISO 8601 format) when the order was created in Shopify. The value for this property cannot be changed.
        /// </summary>
        [JsonProperty("created_at")]
        [Description(ShopifyCaptions.DateCreated)]
        [ShouldNotSerialize]
        public DateTime? DateCreatedAt { get; set; }

        /// <summary>
        /// The three-letter code (ISO 4217 format) for the shop currency.
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.Currency)]
        public string Currency { get; set; }

        /// <summary>
        /// Information about the customer.
        /// The order might not have a customer and apps should not depend on the existence of a customer object.
        /// This value might be null if the order was created through Shopify POS.
        /// </summary>
        [JsonProperty("customer", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.Customer)]
        public CustomerData Customer { get; set; }

        /// <summary>
        /// The customer's email address.
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.Email)]
        public string Email { get; set; }

        ///// <summary>
        ///// The ID of the order, used for API purposes. This is different from the order_number property, which is the ID used by the shop owner and customer.
        ///// </summary>
        //[JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        //[Description(ShopifyCaptions.DraftOrderID)]
        //public long? Id { get; set; }

        /// <summary>
        /// The ID of the order that 's created and associated with the draft order after the draft order is completed.
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.OrderId)]
        public long? OrderID { get; set; }

        /// <summary>
        /// A list of line item objects, each containing information about an item in the order.
        /// </summary>
        [JsonProperty("line_items")]
        [Description(ShopifyCaptions.LineItem)]
        public List<OrderLineItem> LineItems { get; set; } = new List<OrderLineItem>();

        /// <summary>
        /// The order name, generated by combining the order_number property with the order prefix and suffix that are set in the merchant's general settings.
        /// This is different from the id property, which is the ID of the order used by the API.
        /// This field can also be set by the API to be any string value.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.Name)]
        public string Name { get; set; }

        /// <summary>
        /// An optional note that a shop owner can attach to the order.
        /// </summary>
        [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.Note)]
        public String Note { get; set; }

        /// <summary>
        /// Extra information that is added to the order. Appears in the Additional details section of an order details page.
        /// Each array entry must contain a hash with name and value keys.
        /// </summary>
        [JsonProperty("note_attributes", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.NoteAttribute)]
        public List<NoteAttribute> NoteAttributes { get; set; }

        /// <summary>
        /// The mailing address to where the order will be shipped. This address is optional and will not be available on orders that do not require shipping.
        /// </summary>
        [JsonProperty("shipping_address", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.ShippingAddress)]
        public OrderAddressData ShippingAddress { get; set; }

        /// <summary>
        /// The price of the order in the shop currency after discounts but before shipping, taxes, and tips.
        /// </summary>
        [JsonProperty("subtotal_price", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.SubTotal)]
        public decimal? SubTotal { get; set; }

        /// <summary>
        /// Tags attached to the order, formatted as a string of comma-separated values.
        /// Tags are additional short descriptors, commonly used for filtering and searching. Each individual tag is limited to 40 characters in length.
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.Tags)]
        public String Tags { get; set; }

        /// <summary>
        /// An array of tax line objects, each of which details a tax applicable to the order.
        /// </summary>
        [JsonProperty("tax_lines", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.TaxLine)]
        public List<OrderTaxLine> TaxLines { get; set; }

        /// <summary>
        /// Whether taxes are included in the order subtotal.
        /// </summary>
        [JsonProperty("taxes_included", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.TaxesIncluded)]
        public bool? TaxesIncluded { get; set; }

        /// <summary>
        /// The sum of all line item prices, discounts, shipping, taxes, and tips in the shop currency. Must be positive.
        /// </summary>
        [JsonProperty("total_price")]
        [Description(ShopifyCaptions.OrderTotal)]
        public decimal? OrderTotal { get; set; }

        /// <summary>
        /// The sum of all the taxes applied to the order in th shop currency. Must be positive.
        /// </summary>
        [JsonProperty("total_tax", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.TotalTax)]
        public decimal? TotalTax { get; set; }

        /// <summary>
        /// The date and time (ISO 8601 format) when the order was last modified.
        /// Filtering orders by updated_at is not an effective method for fetching orders because its value can change when no visible fields of an order have been updated.
        /// Use the Webhook and Event APIs to subscribe to order events instead.
        /// </summary>
        [JsonProperty("updated_at")]
        [ShouldNotSerialize]
        public DateTime? DateModifiedAt { get; set; }

        /// <summary>
        /// An optional boolean that you can send as part of a draft order object to load customer shipping information.
        /// Valid values: true or false.
        /// </summary>
        [JsonProperty("use_customer_default_address")]
        [ShouldNotSerialize]
        public bool? UseCustomerDefaultAddress { get; set; }

        /// <summary>
        /// An array of objects, each of which details a shipping method used.
        /// </summary>
        [JsonProperty("shipping_line")]
        [Description(ShopifyCaptions.ShippingLine)]
        public OrderShippingLine ShippingLine { get; set; }

        /// <summary>
        /// [READ-ONLY] An ordered list of stacked discount applications.
        /// The discount_applications property includes 3 types: discount_code, manual, and script. All 3 types share a common structure and have some type specific attributes.
        /// </summary>
        [JsonProperty("applied_discount")]
        public DraftOrderDiscount AppliedDiscount { get; set; }
        public object Id { get; internal set; }
        public OrderDiscountCodes CouponLines { get; internal set; }
    }

    public class DraftOrderDiscount
    {
        /// <summary>
        /// The description of the discount application, as defined by the merchant or the Shopify Script. Available only for manual and script discount applications.
        /// </summary>
        /// 

        [JsonProperty("code")]
        [Description(ShopifyCaptions.Code)]
        public string Code { get; set; }
        //[JsonProperty("description")]
        //public string Description { get; set; }

        ///// <summary>
        ///// The title of the discount application, as defined by the merchant. Available only for manual discount applications.
        ///// </summary>
        //[JsonProperty("title")]
        //public string Title { get; set; }

        ///// <summary>
        ///// The value of the discount application as a decimal. This represents the intention of the discount application.
        ///// For example, if the intent was to apply a 20% discount, then the value will be 20.0. If the intent was to apply a $15 discount, then the value will be 15.0.
        ///// </summary>
        //[JsonProperty("value")]
        //public decimal Value { get; set; }

        ///// <summary>
        ///// The type of the value.
        ///// </summary>
        //[JsonProperty("value_type")]
        //public DiscountValueType? ValueType { get; set; }

        ///// <summary>
        ///// Discount amount
        ///// </summary>
        //[JsonProperty("amount")]
        //public decimal? Amount { get; set; }
        //public string Code { get; internal set; }
    }
}
