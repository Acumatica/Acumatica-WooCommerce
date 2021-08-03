using System;
using BCApiClient.Rest.Client;
using BCApiClient.Rest.Client.Common;
using BCApiClient.Rest.Domain.Entities.Orders;
using BCApiClient.Rest.Interfaces;
using RestSharp;

namespace ACSC.Tests.BigCommerceRest.Rest.Client.DataRepository.Orders
{
    public class OrderPaymentRestDataProvider : RestDataProviderV3
    {
        protected override string GetListUrl => "/payments";
        protected override string GetSingleUrl => "v3/payments/access_tokens";
        protected override string GetCountUrl => throw new NotImplementedException();

        //protected string paymentBaseUrl = "https://payments.bigcommerce.com/stores/";
        protected string paymentBaseUrl = "https://payments.bigcommerce.com/stores/sy4le8dl1q/payments";

        public OrderPaymentRestDataProvider(IBigCommerceRestClient restClient)
        {
            _restClient = restClient;
        }
        public OrderPaymentTokenData GetPaymentAccessToken(PaymentTokenOrderData order)
        {
            OrderPaymentTokenData token = base.GetPaymentAccessToken<PaymentTokenOrderData, OrderPaymentTokenData>(order);
            return token;
        }

        public ProcesssPaymentResult ProcessPayment(OrderPaymentData payment, OrderPaymentTokenData token)
        {
            RestRequest request = new RestRequest(GetListUrl) { JsonSerializer = new RestJsonSerializer(), RequestFormat = DataFormat.Json };
            request.Method = Method.POST;
            request.AddHeader("Accept", "application/vnd.bc.v1+json");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "PAT " + token.Data.Id);
            request.AddJsonBody(payment);

            string storeHash = ((BCRestClient)_restClient).BaseUrl.Segments[2];

            RestClient client = new RestClient(new Uri(paymentBaseUrl + storeHash));
            var response = client.Execute<ProcesssPaymentResult>(request);
            return response.Data;
        }
    }
}
