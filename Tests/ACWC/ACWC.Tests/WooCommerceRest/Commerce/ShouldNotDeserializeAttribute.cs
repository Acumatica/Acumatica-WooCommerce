using System;

namespace ACSC.Tests.ShopifyRest.Commerce
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ShouldNotDeserializeAttribute : Attribute
    {
    }
}