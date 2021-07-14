using System;
using System.Collections.Generic;
using System.Linq;
using ACSC.Tests.BigCommerceRest.Rest.Client.Common;
using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Serializers;

namespace BCApiClient.Rest.Client.Common
{
    public abstract class BCRestClientBase : RestClient
    {
        protected ISerializer _serializer;
        public IRestOptions _options;

        protected BCRestClientBase(IDeserializer deserializer, ISerializer serializer, IRestOptions options)
        {
            _options = options;
            _serializer = serializer;
            AddHandler("application/json", () => deserializer);
            AddHandler("text/json", () => deserializer);
            AddHandler("text/x-json", () => deserializer);

            Authenticator = new Autentificator(options.XAuthClient, options.XAuthToken);
            try
            {
                BaseUrl = new Uri(options.BaseUrl);
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
    }
}