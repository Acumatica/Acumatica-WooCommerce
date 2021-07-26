using System;

namespace ACSC.Tests.BigCommerceRest.Rest.Client.Common
{
    public interface IRestOptions
    {
        string BaseUrl { get; set; }
        string XAuthClient { get; set; }
        string XAuthToken { get; set; }
    }

    public class RestOptions : IRestOptions
    {
        public string BaseUrl { get; set; }
        public string XAuthClient { get; set; }
        public string XAuthToken { get; set; }
        public override string ToString()
        {
            return $"Url: {BaseUrl},{Environment.NewLine}" +
                   $"XAuthTocken: {XAuthToken},{Environment.NewLine}" +
                   $"XAuthClient: {XAuthClient}";
        }
    }
}
