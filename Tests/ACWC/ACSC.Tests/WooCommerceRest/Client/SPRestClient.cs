using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using ACSC.Tests.ShopifyRest.Client.Common;
using ACSC.Tests.ShopifyRest.Domain.Entities.Common;
using ACSC.Tests.ShopifyRest.Interfaces;
using ACSC.Tests.ShopifyRest.Logger;
using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Serializers;

namespace ACSC.Tests.ShopifyRest.Client
{
    public class SPRestClient : SPRestClientBase, IWooCommerceRestClient
    {
        public IShopifyClientLogger Logger {get;}

        public SPRestClient(IDeserializer deserializer, ISerializer serializer, IRestOptions options, IShopifyClientLogger logger) : base(deserializer, serializer, options, logger)
        {
            Logger = logger;
        }

        #region API Request

        public T Post<T, TR>(IRestRequest request, T obj, bool usingTRasBodyObj = true)
            where T : class, new() where TR : class, IEntityResponse<T>, new()
        {
            request.Method = Method.POST;
            //object _obj = usingTRasBodyObj ? (object)(new TR() { Data = obj }) : (object)obj;
                request.AddJsonBody(obj);

            var response = ExecuteRequest<T>(request);
            if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Created)
            {
                return response.Data;
            }

            LogError(BaseUrl, request, response);

            throw new RestException(response);
        }

        public T Post<T>(IRestRequest request, T obj, bool usingTRasBodyObj = true) where T : class, new()
        {
            request.Method = Method.POST;
            request.AddJsonBody(obj);

            IRestResponse<T> response = ExecuteRequest<T>(request);
            if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Created)
            {
                return response.Data;
            }

            LogError(BaseUrl, request, response);

            throw new RestException(response);
        }

        public T Put<T, TR>(IRestRequest request, T obj, bool usingTRasBodyObj = true)
            where T : class, new() where TR : class, IEntityResponse<T>, new()
        {
            request.Method = Method.PUT;
            if (obj != null)
            {
                object _obj = usingTRasBodyObj ? (object)(new TR() { Data = obj }) : (object)obj;
                request.AddBody(_obj);
            }
            var response = ExecuteRequest<TR>(request);
            if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Created)
            {
                return response.Data?.Data;
            }

            LogError(BaseUrl, request, response);

            throw new RestException(response);
        }

        public bool Delete(IRestRequest request)
        {
            request.Method = Method.DELETE;
            var response = ExecuteRequest(request);
            if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.NotFound)
            {
                return true;
            }

            LogError(BaseUrl, request, response);
            throw new RestException(response);
        }

        public TR Get<T, TR>(IRestRequest request)
            where T : class, new() where TR : class, IEntityResponse<T>, new()
        {
            return Get<T, TR>(request, out _);
        }

        public TR Get<T, TR>(IRestRequest request, out IList<Parameter> headers)
            where T : class, new() where TR : class, IEntityResponse<T>, new()
        {
            request.Method = Method.GET;
            var response = ExecuteRequest<T>(request);
            headers = response.Headers;
            if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.NotFound)
            {
                return new TR { Data = response.Data };
            }

            LogError(BaseUrl, request, response);
            throw new RestException(response);
        }

        public T GetCount<T>(IRestRequest request)
            where T : class, new()
        {
            request.Method = Method.GET;
            var response = ExecuteRequest<T>(request);

            if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.NotFound)
            {
                return response.Data;
            }

            LogError(BaseUrl, request, response);
            throw new RestException(response);
        }

        public List<T> GetCurrentList<T, TR>(IRestRequest request, out string previousList, out string nextList) where T : class, new() where TR : class, IEntitiesResponse<T>, new()
        {
            request.Method = Method.GET;
            var response = ExecuteRequest<TR>(request);
            previousList = nextList = default;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var responseHeader = response.Headers;
                var result = new List<T>();
                var entities = response.Data?.Data;
                if (entities != null && entities.Count > 0)
                {
                    result.AddRange(entities);
                    if (TryGetNextPageUrl(responseHeader, out var previousUrl, out var nextUrl))
                    {
                        previousList = previousUrl;
                        nextList = nextUrl;
                    }
                }
                return result;
            }

            LogError(BaseUrl, request, response);
            throw new RestException(response);
        }

        public List<T> GetAll<T, TR>(IRestRequest request) where T : class, new() where TR : class, IEntitiesResponse<T>, new()
        {
            request.Method = Method.GET;
            var response = ExecuteRequest<TR>(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var responseHeader = response.Headers;
                var result = new List<T>();
                var entities = response.Data?.Data;
                if (entities != null && entities.Count > 0)
                {
                    result.AddRange(entities);
                    while (TryGetNextPageUrl(responseHeader, out _, out var nextUrl))
                    {
                        request = MakeRequest(nextUrl);
                        request.Method = Method.GET;
                        response = ExecuteRequest<TR>(request);
                        responseHeader = response.Headers;
                        entities = response.Data?.Data;
                        if (entities != null && entities.Count > 0)
                        {
                            result.AddRange(entities);
                        }
                    }
                }
                return result;
            }

            LogError(BaseUrl, request, response);
            throw new RestException(response);
        }

        private bool TryGetNextPageUrl(IList<Parameter> header, out string previousUrl, out string nextUrl)
        {
            previousUrl = nextUrl = default;
            if (header == null || header.Count == 0) return false;
            var paraLink = header.FirstOrDefault(x => x.Name.Equals("Link", StringComparison.InvariantCultureIgnoreCase));
            if (paraLink != null && paraLink.Value != null && !string.IsNullOrWhiteSpace(paraLink.Value.ToString()))
            {
                var linkStr = paraLink.Value.ToString();
                Match previousMatch = Regex.Match(linkStr, $@"<{BaseUrl}([^\s]*)>;\s*rel=""previous""", RegexOptions.IgnoreCase);
                if (previousMatch.Success && !string.IsNullOrWhiteSpace(previousMatch.Groups[1].Value))
                {
                    nextUrl = previousMatch.Groups[1].Value;
                }
                Match nextMatch = Regex.Match(linkStr, $@"<{BaseUrl}([^\s]*)>;\s*rel=""next""", RegexOptions.IgnoreCase);
                if (nextMatch.Success && !string.IsNullOrWhiteSpace(nextMatch.Groups[1].Value))
                {
                    nextUrl = nextMatch.Groups[1].Value;
                    nextUrl = Regex.Replace(nextUrl, $@"limit=\d+", "limit=250");
                    return true;
                }
            }
            return false;
        }

        public bool Post(IRestRequest request)
        {
            throw new NotImplementedException();
        }

        //public T Post<T>(IRestRequest request, T obj, bool usingTRasBodyObj = true) where T : class, new()
        //{
        //    throw new NotImplementedException();
        //}

        #endregion API Request
    }
}