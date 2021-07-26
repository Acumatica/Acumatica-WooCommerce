using System;

namespace ACSC.Tests.ShopifyRest.Logger
{
    public interface IShopifyClientLogger
    {
        void Info(string message, params object[] args);

        void Warning(string mesage, params object[] args);

        void Debug(string message, params object[] args);

        void Error(string message, params object[] args);

        void Error(Exception e);
    }
}