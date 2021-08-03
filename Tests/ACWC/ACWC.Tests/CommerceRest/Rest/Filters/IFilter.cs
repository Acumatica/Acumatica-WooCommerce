using RestSharp;

namespace BCApiClient.Rest.Filters
{
    public interface IFilter
    {
        void AddFilter(IRestRequest request);
        int? Limit { get; set; }
        int? Page { get; set; }
    }
}
