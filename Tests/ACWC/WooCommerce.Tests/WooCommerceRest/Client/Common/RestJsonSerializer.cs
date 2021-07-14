using System.IO;
using Newtonsoft.Json;
using RestSharp.Deserializers;
using RestSharp.Serializers;

namespace ACSC.Tests.ShopifyRest.Client.Common
{
    public class RestJsonSerializer : ISerializer, IDeserializer
    {
        private readonly JsonSerializer _serializer;

        public RestJsonSerializer(JsonSerializer serializer)
        {
            ContentType = "application/json";
            _serializer = serializer;
        }

        public string Serialize(object obj)
        {
            using (var stringWriter = new StringWriter())
            {
                using (var jsonTextWriter = new JsonTextWriter(stringWriter))
                {
                    jsonTextWriter.Formatting = Formatting.Indented;
                    jsonTextWriter.QuoteChar = '"';

                    _serializer.Serialize(jsonTextWriter, obj);

                    var result = stringWriter.ToString();
                    return result;
                }
            }
        }

        public string DateFormat { get; set; }
        public string RootElement { get; set; }
        public string Namespace { get; set; }
        public string ContentType { get; set; }

        public T Deserialize<T>(RestSharp.IRestResponse response)
        {
            var content = response.Content;
            if (string.IsNullOrWhiteSpace(content)) return default;
            var settings = new JsonSerializerSettings { ContractResolver = new GetOnlyContractResolver() };
            return JsonConvert.DeserializeObject<T>(content, settings);
        }
    }
}