using System.Collections.Generic;
using BCApiClient.Rest.Domain.Entities.Common;
using RestSharp;

namespace BCApiClient.Rest.Interfaces
{
    public interface IBigCommerceRestClient
    {
        T Post<T>(IRestRequest request, T obj) where T : class, new();
        TE Post<T, TE>(IRestRequest request, T obj) where T : class, new() where TE : class, new();
        T Put<T>(IRestRequest request, T obj) where T : class, new();
        bool Delete(IRestRequest request);
        T Get<T>(IRestRequest request) where T : class, new();        
        RestRequest MakeRequest(string url, Dictionary<string, string> urlSegments = null);
        TE Post<T, TE>(IRestRequest request, TE entity) where T : class, new() where TE: IEntityResponse<T>, new();
        TE Put<T, TE>(IRestRequest request, TE entity) where T : class, new() where TE: IEntityResponse<T>, new();
        TE Put<T, TE>(IRestRequest request, T entity) where T : class, new() where TE : class, new();
        TE Get<T, TE>(IRestRequest request) where T : class, new() where TE: IEntityResponse<T>, new();
        TE GetList<T, TE>(IRestRequest request) where T : class, new() where TE: IEntitiesResponse<T>, new();
    }
}