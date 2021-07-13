namespace PX.Commerce.WooCommerce.WC.Descriptor
{
    public class Constants
    {
        public static class UserTypes
        {
            public static string Customer = "Customer";
        }

        public static class PhoneTypes
        {
            public static string Business1 = "B1";
        }

        public static class ProductTypes
        {
            public static string Simple = "simple";
            public static string Grouped = "grouped";
            public static string External = "external";
            public static string Variable = "variable";
        }

        public static class CatelogVisibilities
        {
            public static string Visible = "visible";
            public static string Catalog = "catalog";
            public static string Search = "search";
            public static string Hidden = "hidden";
        }

        public static class ProductStatuses
        {
            public static string Draft = "draft";
            public static string Pending = "pending";
            public static string Private = "private";
            public static string Published = "publish";
        }

        public static class StockStatuses
        {
            public static string InStock =    "instock";
            public static string OutOfStock  =  "outofstock";
            public static string OnBackOrder =  "onbackorder";
        }

        public static class OrderStatuses
        {
            public static string Pending = "pending";
            public static string Processing = "processing";
            public static string OnHold = "on - hold";
            public static string Completed = "completed";
            public static string Cancelled = "cancelled";
            public static string Refunded = "refunded";
            public static string Failed = "failed";
            public static string Trash = "trash";
        }

        public static class CouponTypes
        {
            public static string Percent = "percent";
            public static string FixedCart = "fixed_cart";
            public static string FixedProduct = "fixed_product";
        }

        public static class WCPaymentMethods
        {
            public const string Authnet = "authorize_net_cim_credit_card";
            public const string Stripe = "stripe";
            public const string PayPal = "paypal";
            public const string PayPalCheckout = "ppec_paypal";
            public const string CashOnDelivery = "cod";
            public const string BrainTreePaypal = "braintree_paypal";
        }

        public static class PaymentCaptureKey
        {
            public static string AuthNet = "_wc_authorize_net_cim_credit_card_charge_captured";
            public static string Stripe = "_stripe_charge_captured";
            public static string BraintreePayPal = "_wc_braintree_paypal_charge_captured";
        }
    }
}