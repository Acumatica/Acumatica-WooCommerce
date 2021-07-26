using System;
using ACSC.Tests.ShopifyRest.Configuration;
using ACSC.Tests.Utils;

namespace ACSC.Tests.ShopifyRest.Client.Common
{
    public interface IRestOptions
    {
        string BaseUri { get; set; }
        string XAuthClient { get; set; }
        string XAuthTocken { get; set; }
        string SharedSecret { get; set; }
        int ApiCallLimit { get; }
    }

    public class RestOptions : IRestOptions
    {
        public RestOptions(ShopifyRestConfig config)
        {
            BaseUri = config.BaseUri;
            XAuthClient = config.XAuthClient;
            XAuthTocken = config.XAuthTocken;
            SharedSecret = config.SharedSecret;
            ApiCallLimit = config.ApiCallLimit;
        }

        public string BaseUri { get; set; }
        public string XAuthClient { get; set; }
        public string XAuthTocken { get; set; }
        public string SharedSecret { get; set; }
        public int ApiCallLimit { get; set; }

        public override string ToString()
        {
            return $"Url: {BaseUri},{Environment.NewLine}" +
                   $"XAuthTocken: {XAuthTocken},{Environment.NewLine}" +
                   $"XAuthClient: {XAuthClient},{Environment.NewLine}" +
                   $"SharedSecret: {SharedSecret},{Environment.NewLine}" +
                   $"ApiCallLimit: {ApiCallLimit}";
        }
    }
}