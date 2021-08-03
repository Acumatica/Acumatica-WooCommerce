using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Text;
using BCApiClient.Rest.Domain.Error;
using Newtonsoft.Json;
using RestSharp;

namespace BCApiClient.Rest.Client.Common
{
    public class RestException : Exception, IEnumerable<RestError>
    {
        private readonly List<RestError> _errors;
        public string ResponceStatusCode;
        public string ResponceContent;

        public string ErrorMessage => base.Message;
        public Exception ErrorException => base.InnerException;

        public RestException(IRestResponse response)
        : base(response.ErrorMessage, response.ErrorException)
        {
            ResponceStatusCode = response.StatusCode.ToString();
            ResponceContent = response.Content;

            _errors = GetErrorData(response) ?? new List<RestError>();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("REST error.");
            sb.AppendLine($"Status:  {ResponceStatusCode}");
            sb.AppendLine($"Content: {ResponceContent}");

            foreach (var error in _errors)
            {
                sb.AppendLine($"Error: {error?.Errors}");
            }

            return sb.ToString();
        }

        public IEnumerator<RestError> GetEnumerator()
        {
            foreach (var error in _errors)
            {
                yield return error;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private List<RestError> GetErrorData(IRestResponse response)
        {

            if (response.StatusCode == HttpStatusCode.OK ||
                response.StatusCode == HttpStatusCode.Created ||
                response.StatusCode == HttpStatusCode.Accepted ||
                response.StatusCode == HttpStatusCode.NoContent)
            {
                return null;
            }

            var errorList = new List<RestError>();
            try
            {
                errorList.Add(JsonConvert.DeserializeObject<RestError>(response.Content));
            }
            catch (JsonSerializationException)
            {
                errorList.Add(new RestError
                {
                    Status = (int)response.StatusCode,
                    Errors = new Errors { Name = response.Content }
                });
            }

            return errorList;
        }
    }
}
