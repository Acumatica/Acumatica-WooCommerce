using BCApiClient.Rest.Client.Common;
using BCApiClient.Rest.Domain.Entities.Common;
using BCApiClient.Rest.Interfaces;
using RestSharp;
using System.Net;
using ACSC.Tests.BigCommerceRest.Rest.Client.Common;

namespace BCApiClient.Rest.Client
{
    public class BCRestClient : BCRestClientBase, IBigCommerceRestClient
    {
        public BCRestClient(IRestOptions options) : base(new RestJsonSerializer(), new RestJsonSerializer(), options) { }

        #region API version 2

        public T Post<T>(IRestRequest request, T obj) where T : class, new()
        {
            return Post<T, T>(request, obj);
        }

        public TE Post<T,TE>(IRestRequest request, T obj) where T : class, new() where TE : class, new()
        {
            request.Method = Method.POST;
            request.AddBody(obj);
            var response = Execute<TE>(request);
            if (response.StatusCode == HttpStatusCode.Created || response.StatusCode == HttpStatusCode.OK)
            {
                return response.Data;
            }
            else return default(TE);
        }

        public T Put<T>(IRestRequest request, T obj) where T : class, new()
        {
            return Put<T, T>(request, obj);
        }

        public TE Put<T,TE>(IRestRequest request, T obj) where T : class, new() where TE: class, new ()
        {
            request.Method = Method.PUT;
            request.AddBody(obj);

            var response = Execute<TE>(request);
            if (response.StatusCode == HttpStatusCode.Created || response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.NoContent)
            {
                return response.Data;
            }
            else return default(TE);
        }

        public bool Delete(IRestRequest request)
        {
            request.Method = Method.DELETE;
            var response = Execute(request);
            if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.NoContent || response.StatusCode == HttpStatusCode.NotFound)
            {
                return true;
            }
            else return false;
        }

        public T Get<T>(IRestRequest request) where T : class, new()
        {
            request.Method = Method.GET;
            var response = Execute<T>(request);

            if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.NoContent || response.StatusCode == HttpStatusCode.NotFound)
            {
                return response.Data;
            }
            else return default(T);
        }

        #endregion

        #region API version 3

        public TE Post<T, TE>(IRestRequest request, TE entity) where T : class, new() where TE : IEntityResponse<T>, new()
        {
            request.Method = Method.POST;
            request.AddBody(entity.Data);
            var response = Execute<TE>(request);
            if (response.StatusCode == HttpStatusCode.Created || response.StatusCode == HttpStatusCode.OK)
            {
                return response.Data;
            }
            else return default(TE);
        }

        public TE Put<T, TE>(IRestRequest request, TE entity) where T : class, new() where TE : IEntityResponse<T>, new()
        {
            request.Method = Method.PUT;
            request.AddBody(entity.Data);

            var response = Execute<TE>(request);
            if (response.StatusCode == HttpStatusCode.Created || response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.NoContent)
            {
                return response.Data;
            }
            else return default(TE);
        }

        public TE GetList<T, TE>(IRestRequest request) where T : class, new() where TE : IEntitiesResponse<T>, new()
        {
            request.Method = Method.GET;
            var response = Execute<TE>(request);

            if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.NoContent)
            {
                return response.Data;
            }
            else return default(TE);
        }

        public TE Get<T, TE>(IRestRequest request) where T : class, new() where TE : IEntityResponse<T>, new()
        {
            request.Method = Method.GET;
            var response = Execute<TE>(request);

            if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.NoContent)
            {
                return response.Data;
            }
            else return default(TE);
        }

        #endregion
    }
}
