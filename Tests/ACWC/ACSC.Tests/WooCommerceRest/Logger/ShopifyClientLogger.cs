using System;
using Core.Log;

namespace ACSC.Tests.ShopifyRest.Logger
{
    public class ShopifyClientLogger : IShopifyClientLogger
    {
        public void Debug(string message, params object[] args)
        {
            Log.Debug(message, args);
        }

        public void Error(string message, params object[] args)
        {
            Log.Error(message, args);
        }

        public void Error(Exception e)
        {
            Log.Error(e);
        }

        public void Info(string message, params object[] args)
        {
            Log.Information(message, args);
        }

        public void Warning(string message, params object[] args)
        {
            Log.Warning(message, args);
        }
    }
}