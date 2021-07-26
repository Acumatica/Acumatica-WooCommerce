namespace ACSC.Tests.ShopifyRest.Configuration
{
    public class ShopifyRestConfigBase
    {
        public virtual string BaseUri { get; set; }         //ShopifyApiBaseUrl
        public virtual string XAuthClient { get; set; }     //ShopifyApiKey
        public virtual string XAuthTocken { get; set; }     //ShopifyApiPassword
        public virtual string SharedSecret { get; set; }    //StoreSharedSecret
        public virtual int ApiCallLimit { get; }
    }
}