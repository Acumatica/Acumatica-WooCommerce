using PX.Api.ContractBased.Models;
using PX.Commerce.BigCommerce;
using PX.Commerce.Core;
using PX.Commerce.Core.API;
using PX.Commerce.Objects;
using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order;
using PX.Commerce.WooCommerce.API.REST.Domain.Enums;
using PX.Objects.AR;
using System;
using System.Collections.Generic;
using System.Linq;
using static PX.Commerce.WooCommerce.WC.Descriptor.Constants;

namespace PX.Commerce.WooCommerce.WC
{
    public class WCHelper : BCHelper
    {
        private const string YES = "yes";
        private const string AUTHNET_CAPTURE_TRAN_ID = "_wc_authorize_net_cim_credit_card_capture_trans_id";

        public virtual string GetPaymentMethodName(string paymentMethod)
        {
            if (paymentMethod == BCConstants.Emulated)
                return paymentMethod?.ToUpper();
            return string.Format("{0} ({1})", paymentMethod, paymentMethod ?? string.Empty)?.ToUpper();

        }

        public virtual string ParseTransactionNumber(OrdersTransactionData tran, out bool isCreditCardTran)
        {
            String paymentRef = tran?.GatewayTransactionId;
            isCreditCardTran = !string.IsNullOrWhiteSpace(tran?.GatewayTransactionId);
            if (tran == null) return paymentRef;

            if (!String.IsNullOrWhiteSpace(paymentRef) && paymentRef.IndexOf("#") >= 0)
                paymentRef = paymentRef.Substring(0, paymentRef.IndexOf("#"));

            if (String.IsNullOrEmpty(paymentRef))
                paymentRef = tran.Id.ToString();

            return paymentRef;
        }

        public virtual OrdersTransactionData CreateOrderTransactionData(OrderData orderData)
        {
            OrdersTransactionData data = new OrdersTransactionData();
            data.Id = orderData.Id.Value;
            data.Currency = orderData.Currency;
            data.DateCreatedUT = orderData.DateCreatedUT;
            data.PaymentMethod = orderData.PaymentMethod;
            data.Total = orderData.Total;
            data.GatewayTransactionId = orderData.TransactionId;
            data.Metadata = orderData.Metadata;
            return data;
        }


        public virtual void AddCreditCardProcessingInfo(BCPaymentMethods methodMapping, Payment payment, OrderPaymentEvent orderPaymentEvent, string paymentInstrumentToken = "")
        {
            payment.IsNewCard = true.ValueField();
            payment.SaveCard = (!String.IsNullOrWhiteSpace(paymentInstrumentToken)).ValueField();
            payment.ProcessingCenterID = methodMapping?.ProcessingCenterID?.ValueField();

            CreditCardTransactionDetail detail = new CreditCardTransactionDetail();
            detail.TranNbr = payment.PaymentRef;
            detail.TranDate = payment.ApplicationDate;
            detail.ExtProfileId = paymentInstrumentToken.ValueField();
            detail.TranType = GetTransactionType(orderPaymentEvent);

            payment.CreditCardTransactionInfo = new List<CreditCardTransactionDetail>(new[] { detail });
        }

        public virtual StringValue GetTransactionType(OrderPaymentEvent orderPaymentEvent)
        {
            switch (orderPaymentEvent)
            {
                case OrderPaymentEvent.Authorization:
                    return CCTranTypeCode.Authorize.ValueField();
                case OrderPaymentEvent.Capture:
                    return CCTranTypeCode.PriorAuthorizedCapture.ValueField();
                case OrderPaymentEvent.Purchase:
                    return CCTranTypeCode.AuthorizeAndCapture.ValueField();
                case OrderPaymentEvent.Refund:
                    return CCTranTypeCode.Credit.ValueField();
                default:
                    return CCTranTypeCode.Unknown.ValueField();
            }
        }

        public virtual OrderPaymentEvent GetLastEvent(OrdersTransactionData data)
        {
            switch (data.PaymentMethod)
            {
                case WCPaymentMethods.Authnet:
                    if (data.Metadata.SingleOrDefault(s => s.Key == PaymentCaptureKey.AuthNet)?.Value == YES)
                        return OrderPaymentEvent.Purchase;
                    else if (data.Metadata.SingleOrDefault(s => s.Key == PaymentCaptureKey.AuthNet)?.Value == YES 
                        && data.Metadata.Any(a=>a.Key.Equals(AUTHNET_CAPTURE_TRAN_ID, StringComparison.InvariantCultureIgnoreCase)))
                        return OrderPaymentEvent.Capture;
                    return OrderPaymentEvent.Authorization;
                case WCPaymentMethods.Stripe:
                    if (data.Metadata.SingleOrDefault(s => s.Key == PaymentCaptureKey.Stripe)?.Value == YES)
                        return OrderPaymentEvent.Capture;
                    return OrderPaymentEvent.Authorization;
                case WCPaymentMethods.BrainTreePaypal:
                    if (data.Metadata.SingleOrDefault(s => s.Key == PaymentCaptureKey.BraintreePayPal)?.Value == YES)
                        return OrderPaymentEvent.Capture;
                    return OrderPaymentEvent.Authorization;
                default:
                    return OrderPaymentEvent.Pending;
            }

        }
    }
}
