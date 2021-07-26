using System;

namespace ACSC.Tests.ShopifyRest.Domain.Entities.Products
{
    public class ApiHeaderRequestAttribute : Attribute
    {
        public ApiHeaderRequestAttribute(string headerParameterName, string headerParameterValue)
        {
            HeaderParameterName = headerParameterName;
            HeaderParameterValue = headerParameterValue;
        }

        public string HeaderParameterName { get; set; }
        public string HeaderParameterValue { get; set; }
    }
}