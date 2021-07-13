using RestSharp;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace PX.Commerce.WooCommerce
{
    public class Authentication
    {
        public static void GetHeaders(IRestRequest request, string consumerKey, string consumerSecret, string baseUrl)
        {
            const string tokenSecret = "";
            const string tokenValue = "";
            var url = baseUrl + request.Resource;

            string Escape(string s)
            {
                var charsToEscape = new[] { "!", "*", "'", "(", ")" };
                var escaped = new StringBuilder(Uri.EscapeDataString(s));
                foreach (var t in charsToEscape)
                {
                    escaped.Replace(t, Uri.HexEscape(t[0]));
                }
                return escaped.ToString();
            }

            var timeStamp = ((int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds).ToString();
            var nonce = Convert.ToBase64String(Encoding.UTF8.GetBytes(timeStamp));

            string urlParts = "";
            foreach (var item in request.Parameters.Where(a => a.Type == ParameterType.GetOrPost))
            {
                urlParts += $"&{item.Name}={EscapeUriDataStringRfc3986(item.Value.ToString())}";
            }

            string stringToGenerateSignature = $"{urlParts}&oauth_consumer_key ={EscapeUriDataStringRfc3986(consumerKey)}&oauth_nonce={EscapeUriDataStringRfc3986(nonce)}" +
                $"&oauth_signature_method={EscapeUriDataStringRfc3986("HMAC-SHA1")}&oauth_timestamp={EscapeUriDataStringRfc3986(timeStamp)}" +
                $"&oauth_token={EscapeUriDataStringRfc3986(tokenValue)}&oauth_version={EscapeUriDataStringRfc3986("1.0")}";



            StringBuilder signatureBaseString = new StringBuilder($"{Escape(request.Method.ToString().ToUpper())}&");
            signatureBaseString.Append($"{EscapeUriDataStringRfc3986(url.ToLower())}&");
            signatureBaseString.Append(EscapeUriDataStringRfc3986(stringToGenerateSignature));


            var key = EscapeUriDataStringRfc3986(consumerSecret) + "&" + EscapeUriDataStringRfc3986(tokenSecret);
            var signatureEncoding = new ASCIIEncoding();
            var keyBytes = signatureEncoding.GetBytes(key);
            var signatureBaseBytes = signatureEncoding.GetBytes(signatureBaseString.ToString());
            string signatureString;
            using (var hmacsha1 = new HMACSHA1(keyBytes))
            {
                var hashBytes = hmacsha1.ComputeHash(signatureBaseBytes);
                signatureString = Convert.ToBase64String(hashBytes);
            }
            signatureString = EscapeUriDataStringRfc3986(signatureString);

            //string SimpleQuote(string s) => s;
            //var header =
            //    "OAuth realm=" + SimpleQuote("") + "," +
            //    "oauth_consumer_key=" + SimpleQuote(consumerKey) + "," +
            //    "oauth_nonce=" + SimpleQuote(nonce) + "," +
            //    "oauth_signature_method=" + SimpleQuote("HMAC-SHA1") + "," +
            //    "oauth_timestamp=" + SimpleQuote(timeStamp) + "," +
            //    "oauth_token=" + SimpleQuote(tokenValue) + "," +
            //    "oauth_version=" + SimpleQuote("1.0") + "," +
            //    "oauth_signature= " + SimpleQuote(signatureString);

            StringBuilder requestParams = new StringBuilder();
            requestParams.Append($"oauth_consumer_key={consumerKey}");
            requestParams.Append($"&oauth_nonce={nonce}");
            requestParams.Append($"&oauth_signature_method=HMAC-SHA1");
            requestParams.Append($"&oauth_timestamp={timeStamp}");
            requestParams.Append($"&oauth_token={tokenValue}");
            requestParams.Append($"&oauth_version=1.0");
            requestParams.Append($"&oauth_signature={signatureString}");

            request.Resource += request.Resource.Contains("?") ? $"&{requestParams}" : $"?{requestParams}";
        }

        private static readonly string[] UriRfc3986CharsToEscape = new[] { "!", "*", "'", "(", ")" };

        /// <summary>
        /// Escapes a string according to the URI data string rules given in RFC 3986.
        /// </summary>
        /// <param name="value">The value to escape.</param>
        /// <returns>The escaped value.</returns>
        /// <remarks>
        /// The <see cref="Uri.EscapeDataString"/> method is <i>supposed</i> to take on
        /// RFC 3986 behavior if certain elements are present in a .config file.  Even if this
        /// actually worked (which in my experiments it <i>doesn't</i>), we can't rely on every
        /// host actually having this configuration element present.
        /// </remarks>
        internal static string EscapeUriDataStringRfc3986(string value)
        {
            // Start with RFC 2396 escaping by calling the .NET method to do the work.
            // This MAY sometimes exhibit RFC 3986 behavior (according to the documentation).
            // If it does, the escaping we do that follows it will be a no-op since the
            // characters we search for to replace can't possibly exist in the string.
            StringBuilder escaped = new StringBuilder(Uri.EscapeDataString(value));

            // Upgrade the escaping to RFC 3986, if necessary.
            for (int i = 0; i < UriRfc3986CharsToEscape.Length; i++)
            {
                escaped.Replace(UriRfc3986CharsToEscape[i], Uri.HexEscape(UriRfc3986CharsToEscape[i][0]));
            }

            // Return the fully-RFC3986-escaped string.
            return escaped.ToString();
        }
    }

    public class AuthConfig
    {
        public string ConsumerKey { get; set; }

        public string SignatureMethod { get; set; }

        public string Timestamp { get; set; }

        public string Nonce { get; set; }

        public string Version { get; set; }

        public string Signature { get; set; }
    }
}
