using System.Collections.Generic;
using BCApiClient.Rest.Domain.Entities.Common;
using BCApiClient.Rest.Filters;
using BCApiClient.Rest.Interfaces;

namespace BCApiClient.Rest.Client.Common
{
    public abstract class RestDataProviderBase
    {
        private const string id_string = "id";
        private const string parent_id_string = "parent_id";
        private const string name = "name";

        protected IBigCommerceRestClient _restClient;
        protected abstract string GetListUrl { get; }
        protected abstract string GetSingleUrl { get; }
        protected abstract string GetCountUrl { get; }
        
        public virtual T Create<T>(T entity, UrlSegments urlSegments = null) where T : class, new()
        {
            return Create<T, T>(entity, urlSegments);
        }

        public virtual TE Create<T, TE>(T entity, UrlSegments urlSegments = null) where T : class, new() where TE : class, new()
        {
            var request = _restClient.MakeRequest(GetListUrl, urlSegments?.GetUrlSegments());
            return _restClient.Post<T, TE>(request, entity);
        }

        public virtual T Update<T>(T entity, UrlSegments urlSegments) where T : class, new()
        {
            var request = _restClient.MakeRequest(GetSingleUrl, urlSegments.GetUrlSegments());
            return _restClient.Put<T>(request, entity);
        }

        public virtual TE Update<T, TE>(T entity, UrlSegments urlSegments) where T : class, new() where TE : class, new()
        {
            var request = _restClient.MakeRequest(GetSingleUrl, urlSegments.GetUrlSegments());
            return _restClient.Put<T, TE>(request, entity);
        }

        public virtual bool Delete(UrlSegments urlSegments)
        {
            var request = _restClient.MakeRequest(GetSingleUrl, urlSegments.GetUrlSegments());
            return _restClient.Delete(request);
        }

        protected static UrlSegments MakeUrlSegments(string id)
        {
            var segments = new UrlSegments();
            segments.Add(id_string, id);
            return segments;
        }

        protected static UrlSegments MakeEmailUrlSegments(string email)
        {
            var segments = new UrlSegments();
            segments.Add(email, email);
            return segments;
        }

        protected static UrlSegments MakeParentUrlSegments(string parentId)
        {
            var segments = new UrlSegments();
            segments.Add(parent_id_string, parentId);
            return segments;
        }

        protected static UrlSegments MakeUrlSegments(string id, string parentId)
        {
            var segments = new UrlSegments();
            segments.Add(parent_id_string, parentId);
            segments.Add(id_string, id);
            return segments;
        }

        protected static UrlSegments MakeAddressUrlSegments(string id, string parentId)
        {
            var segments = new UrlSegments();
            segments.Add(parent_id_string, parentId);
            segments.Add(id_string, id);
            return segments;
        }

        protected static UrlSegments MakeParentImageUrlSegments(string parentId)
        {
            var segments = new UrlSegments();
            segments.Add(parent_id_string, parentId);
            return segments;
        }

        protected static UrlSegments MakeNameUrlSegments(string nameValue)
        {
            var segments = new UrlSegments();
            segments.Add(name, nameValue);
            return segments;
        }
    }

    public abstract class RestDataProviderV2 : RestDataProviderBase
    {

        public virtual ItemCount GetCount(UrlSegments urlSegments = null)
        {
            var request = _restClient.MakeRequest(GetCountUrl, urlSegments?.GetUrlSegments());
            var count = _restClient.Get<ItemCount>(request);
            return count;
        }

        public virtual ItemCount GetCount(IFilter filter, UrlSegments urlSegments = null)
        {
            var request = _restClient.MakeRequest(GetCountUrl, urlSegments?.GetUrlSegments());
            filter?.AddFilter(request);
            var count = _restClient.Get<ItemCount>(request);
            return count;
        }

        public virtual List<T> Get<T>(IFilter filter = null, UrlSegments urlSegments = null) where T : class, new()
        {
            var request = _restClient.MakeRequest(GetListUrl, urlSegments?.GetUrlSegments());
            filter?.AddFilter(request);
            var entity = _restClient.Get<List<T>>(request);
            return entity;
        }

        public virtual List<T> GetAll<T>(IFilter filter = null, UrlSegments urlSegments = null) where T : class, new()
        {
            var result = new List<T>();
            var localFilter = filter ?? new Filter();
            var needGet = true;

            localFilter.Page = 1;
            localFilter.Limit = 50;

            while (needGet)
            {
                var entities = Get<T>(localFilter, urlSegments);
                if (entities != null)
                {
                    result.AddRange(entities);
                    localFilter.Page++;
                    needGet = localFilter.Limit == entities.Count;
                }
                else
                    break;
            }

            return result;
        }
        
        public virtual T GetByID<T>(UrlSegments urlSegments) where T : class, new()
        {
            var request = _restClient.MakeRequest(GetSingleUrl, urlSegments.GetUrlSegments());
            var entity = _restClient.Get<T>(request);
            return entity;
        }


    }

    public abstract class RestDataProviderV3 : RestDataProviderBase
    {
        public virtual ItemCount GetCount<T, TE>(UrlSegments urlSegments = null) where T : class, new() where TE : IEntitiesResponse<T>, new()
        {
            var filter = new Filter { Limit = 1 };
            var request = _restClient.MakeRequest(GetCountUrl, urlSegments?.GetUrlSegments());
            filter.AddFilter(request);
            var response = _restClient.GetList<T, TE>(request);
            return new ItemCount { Count = response.Meta.Pagination.Total.GetValueOrDefault() };
        }

        public virtual ItemCount GetCount<T, TE>(IFilter filter, UrlSegments urlSegments = null) where T : class, new() where TE : IEntitiesResponse<T>, new()
        {
            var request = _restClient.MakeRequest(GetListUrl, urlSegments?.GetUrlSegments());
            filter?.AddFilter(request);
            var response = _restClient.GetList<T, TE>(request);
            return new ItemCount { Count = response.Meta.Pagination.Total ?? 0 };
        }

        public virtual TE Get<T, TE>(IFilter filter = null, UrlSegments urlSegments = null) where T : class, new() where TE : IEntitiesResponse<T>, new()
        {
            var request = _restClient.MakeRequest(GetListUrl, urlSegments?.GetUrlSegments());
            filter?.AddFilter(request);
            var response = _restClient.GetList<T, TE>(request);
            return response;
        }

        public virtual TE GetAll<T, TE>(IFilter filter = null, UrlSegments urlSegments = null) where T : class, new() where TE : IEntitiesResponse<T>, new()
        {
            var localResult = new List<TE>();
            var localFilter = filter ?? new Filter();
            var needGet = true;

            localFilter.Page = 1;
            localFilter.Limit = 50;

            while (needGet)
            {
                var entity = Get<T, TE>(localFilter, urlSegments);
                localResult.Add(entity);
                needGet = localFilter.Page < entity.Meta.Pagination.TotalPages;
                localFilter.Page++;
            }

            var result = new TE();
            foreach (var entity in localResult)
            {
                result.Data.AddRange(entity.Data);
            }

            return result;
        }

        public virtual TE GetByID<T, TE>(UrlSegments urlSegments) where T : class, new() where TE : IEntityResponse<T>, new()
        {
            var request = _restClient.MakeRequest(GetSingleUrl, urlSegments.GetUrlSegments());
            return _restClient.Get<T, TE>(request);
        }

        public virtual TE Create<T, TE>(TE entity, UrlSegments urlSegments = null) where T : class, new() where TE : IEntityResponse<T>, new()
        {
            var request = _restClient.MakeRequest(GetListUrl, urlSegments?.GetUrlSegments());
            var result = _restClient.Post<T, TE>(request, entity);
            return result;
        }

        public virtual TE Update<T, TE>(TE entity, UrlSegments urlSegments) where T : class, new() where TE : IEntityResponse<T>, new()
        {
            var request = _restClient.MakeRequest(GetSingleUrl, urlSegments.GetUrlSegments());
            return _restClient.Put<T, TE>(request, entity);
        }
        public virtual TE GetPaymentAccessToken<T, TE>(T entity) where T : class, new() where TE : class, new()
        {
            var request = _restClient.MakeRequest(GetSingleUrl);
            var result = _restClient.Post<T, TE>(request, entity);
            return result;
        }
    }
}
