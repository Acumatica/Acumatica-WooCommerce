using System;
using System.ComponentModel;
using ACSC.Tests.ShopifyRest.Commerce;
using Newtonsoft.Json;

namespace ACSC.Tests.ShopifyRest.Domain.Entities.Order
{
    /// <summary>
    /// Information about the credit card used for the transaction.
    /// </summary>
    [JsonObject(Description = "Payment Detail")]
    [Description(ShopifyCaptions.PaymentDetail)]
    public class PaymentDetail
    {
        /// <summary>
        /// avs_result_code: The response code from the address verification system. The code is a single letter; see this chart for the codes and their definitions.
        /// </summary>
        [JsonProperty("avs_result_code", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.AvsResultCode)]
        public string AvsResultCode { get; set; }

        /// <summary>
        /// credit_card_bin: The issuer identification number (IIN), formerly known as bank identification number (BIN) of the customer's credit card.
        /// This is made up of the first few digits of the credit card number.
        /// </summary>
        [JsonProperty("credit_card_bin", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.CreditCardBin)]
        public String CreditCardBin { get; set; }

        /// <summary>
        /// credit_card_company: The name of the company that issued the customer's credit card.
        /// </summary>
        [JsonProperty("credit_card_company")]
        [Description(ShopifyCaptions.CreditCardCompany)]
        public string CreditCardCompany { get; set; }

        /// <summary>
        /// credit_card_number: The customer's credit card number, with most of the leading digits redacted.
        /// </summary>
        [JsonProperty("credit_card_number", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.CreditCardNumber)]
        public string CreditCardNumber { get; set; }

        /// <summary>
        ///  cvv_result_code: The response code from the credit card company indicating whether the customer entered the card security code, or card verification value, correctly. The code is a single letter or empty string;
        /// </summary>
        [JsonProperty("cvv_result_code", NullValueHandling = NullValueHandling.Ignore)]
        [Description(ShopifyCaptions.CvvResultCode)]
        public string CvvResultCode { get; set; }
    }
}