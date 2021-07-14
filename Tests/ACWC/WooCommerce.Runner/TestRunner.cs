using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using ACSC.Tests.ShopifyRest;
using ACSC.Tests.ShopifyRest.Client.DataRepository.Customers;
using ACSC.Tests.ShopifyRest.Client.DataRepository.Order;
using ACSC.Tests.ShopifyRest.Client.DataRepository.Products;
using ACSC.Tests.ShopifyRest.Domain.Entities.Customers;
using ACSC.Tests.ShopifyRest.Domain.Entities.Order;
using ACSC.Tests.ShopifyRest.Domain.Entities.Products;

namespace ACSC.Runner
{
    internal class TestRunner
    {
        private static int Main(string[] args)
        {
            var tempArgsList = args.ToList();
            tempArgsList.Add(ConfigurationManager.AppSettings["config"]);
            tempArgsList.Add(ConfigurationManager.AppSettings["xmlpath"]);
            var newArgs = tempArgsList.ToArray();

            return Execution.Launcher.Main(newArgs);
        }
    }
}