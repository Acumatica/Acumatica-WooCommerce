namespace ACSC.Tests.ShopifyRest.Configuration
{
    public class ShopifyRestConfig : ShopifyRestConfigBase
    {
        public ShopifyRestConfig()
        {
            ShopifyStorePlan = $"NP";
        }

        public override string BaseUri { get => "http://localhost:8080/tharindu/wp-json/wc"; }
        public override string XAuthClient { get => "ck_68260022bafe7d3a54dd8d0dde644d817ac723fd"; }
        public override string XAuthTocken { get => "cs_5c1cdcfab14035974cc53b147ae30220c41267ea"; }

        //public override string BaseUri { get => "http://dlk1pde165:8080/woo/wp-json/wc"; }
        //public override string XAuthClient { get => "ck_29866afcdb20364854c28564aad6c8d4497d4211"; }
        //public override string XAuthTocken { get => "cs_9ce900c93c2cacfab225342fe9e5b11b8500bb87"; }

        // public override string SharedSecret { get => "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"; }
        public string ShopifyStorePlan { get; set; }
        public override int ApiCallLimit { get => (ShopifyStorePlan == "PP") ? 4 : 2; }


        //public override string XAuthClient { get => "9019ea151a089b1b77543244eb241422"; }
        //public override string XAuthTocken { get => "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"; }
        //public override string SharedSecret { get => "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"; }

    }
}