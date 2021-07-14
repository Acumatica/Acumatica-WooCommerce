using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ACSC.Tests.Helpers
{
    internal static class ValidatorHelper
    {
        internal static Dictionary<string, string> GetPaymentInfoFromDesc(string docDesc)
        {
            var res = new Dictionary<string, string>();
            var parts = docDesc.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Count() == 3)
            {
                var storeID = parts[0].Split('-')[1];
                var shopifyOrderID = parts[1].Split(':')[1].Split('/')[0];
                var paymentID = parts[2].Split(':')[1].Split('/')[0];
                res.Add("storeID", storeID);
                res.Add("shopifyOrderID", shopifyOrderID);
                res.Add("paymentID", paymentID);
            }

            return res;
        }

        internal static string ConcatPaymentDesc(string orderName, string externalOrderID, string externalPayID, string storeID, bool isCreditCard)
        {
            //var orderIdPat = $"Order: {orderName.Trim()}/{externalOrderID}";
            
            var orderIdPat = $"Order: {orderName.Trim()}";
            var typePat = $"Type: Sale";
            var status = $"Status: Pending";
            //var payPat = isCreditCard ? $"Gateway: {externalPayID?.Split(';')[1]}/Shopify Payments" : $"Payment ID/Gateway: {externalPayID.Split(';')[1]}/manual";
            var payPat = $"Gateway: manual";

            return string.Join(" | ", storeID, orderIdPat, typePat, status, payPat);
        }

        internal static string RemoveEmptySpaces(string line)
        {
            return Regex.Replace(line, @"\s+", "");
        }
    }
}