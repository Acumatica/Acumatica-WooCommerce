using System.Reflection;
using ACSC.Tests.ShopifyRest.Commerce;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ACSC.Tests.ShopifyRest.Client.Common
{
    public class GetOnlyContractResolver : DefaultContractResolver
    {
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            var property = base.CreateProperty(member, memberSerialization);
            if (property != null)
            {
                var attributes = property.AttributeProvider.GetAttributes(typeof(ShouldNotDeserializeAttribute), true);
                if (attributes != null && attributes.Count > 0)
                    property.ShouldDeserialize = (a) => false;
                attributes = property.AttributeProvider.GetAttributes(typeof(ShouldNotSerializeAttribute), true);
                if (attributes != null && attributes.Count > 0)
                    property.ShouldSerialize = (a) => false;
            }
            return property;
        }
    }
}