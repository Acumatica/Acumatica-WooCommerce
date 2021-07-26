using System;
using System.Collections.Generic;
using System.Linq;
using ACSC.Tests.ShopifyRest.Logger;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Deserializers;
using RestSharp.Serializers;

namespace ACSC.Tests.ShopifyRest.Client.Common
{
    public abstract class SPRestClientBase : RestClient
    {
        protected static int ApiCallLimit;
        protected static int AvailableCallLimit;
        protected static int TotalCallLimit;
        protected static int ApiTimeLimit;
        protected static bool ControlTimeLimit;
        private static readonly Object obj = new Object();

        protected ISerializer _serializer;
        private readonly IShopifyClientLogger _logger;
        protected IDeserializer _deserializer;
        
        protected SPRestClientBase(IDeserializer deserializer, ISerializer serializer, IRestOptions options, IShopifyClientLogger logger)
        {
            _serializer = serializer;
            _logger = logger;
            _deserializer = deserializer;

            AddHandler("application/json", () => deserializer);
            AddHandler("text/json", () => deserializer);
            AddHandler("text/x-json", () => deserializer);

            if (TotalCallLimit == 0)
            {
                lock (obj)
                {
                    TotalCallLimit = 40;
                    AvailableCallLimit = TotalCallLimit;
                    ControlTimeLimit = false;
                }
            }
            Authenticator = new HttpBasicAuthenticator(options.XAuthClient, options.XAuthTocken);
            try
            {
                BaseUrl = new Uri(options.BaseUri);
            }
            catch (UriFormatException e)
            {
                throw new UriFormatException("Invalid URL: The format of the URL could not be determined.", e);
            }


        }

        public RestRequest MakeRequest(string url, Dictionary<string, string> urlSegments = null)
        {
            var request = new RestRequest(url) { JsonSerializer = _serializer, RequestFormat = DataFormat.Json };

            if (urlSegments != null)
            {
                foreach (var urlSegment in urlSegments)
                {
                    request.AddUrlSegment(urlSegment.Key, urlSegment.Value);
                }
            }

            return request;
        }

        protected IRestResponse ExecuteRequest(IRestRequest request)
        {
            IRestResponse response = Execute(request);
            return response;
        }

        protected IRestResponse<TR> ExecuteRequest<TR>(IRestRequest request) where TR : class, new()
        {
            IRestResponse<TR> response = Execute<TR>(request);
            return response;
        }

        protected void LogError(Uri baseUrl, IRestRequest request, IRestResponse response)
        {
            //Get the values of the parameters passed to the API
            var parameters = string.Join(", ", request.Parameters.Select(x => x.Name.ToString() + "=" + (x.Value ?? "NULL")).ToArray());

            //Set up the information message with the URL, the status code, and the parameters.
            var info = "Request to " + baseUrl.AbsoluteUri + request.Resource + " failed with status code " + response.StatusCode + ", parameters: " + parameters;
            var description = "Response content: " + response.Content;

            //Acquire the actual exception
            var ex = (response.ErrorException?.Message) ?? info;

            //Log the exception and info message
            _logger.Error($"{response.ErrorException},  ResponseError: {description}");
        }
    }
}