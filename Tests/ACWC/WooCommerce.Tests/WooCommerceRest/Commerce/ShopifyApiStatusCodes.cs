using System.Reflection;

namespace ACSC.Tests.ShopifyRest.Commerce
{
    public static class ShopifyApiStatusCodes
	{
		// Token: 0x06000041 RID: 65 RVA: 0x00002B6C File Offset: 0x00000D6C
		public static string GetCodeMessage(string code)
		{
			if (string.IsNullOrEmpty(code))
			{
				return string.Empty;
			}
			string text = string.Empty;
			int num;
			if (int.TryParse(code, out num))
			{
				text = string.Format("Code_{0}", num);
			}
			else
			{
				text = code;
			}
			FieldInfo field = typeof(ShopifyApiStatusCodes).GetField(text, BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.Public);
			if (field != null)
			{
				return field.GetRawConstantValue().ToString();
			}
			return string.Format("Code {0} : Unknown code", text);
		}

		// Token: 0x040001E9 RID: 489
		public const string Code_200 = "Status Code 200/OK : The request was successfully processed by Shopify.";

		// Token: 0x040001EA RID: 490
		public const string Code_201 = "Status Code 201/Created : The request has been fulfilled and a new resource has been created.";

		// Token: 0x040001EB RID: 491
		public const string Code_202 = "Status Code 202/Accepted : The request has been accepted, but not yet processed.";

		// Token: 0x040001EC RID: 492
		public const string Code_303 = "Status Code 303/See Other : The response to the request can be found under a different URL in the Location header and can be retrieved using a GET method on that resource.";

		// Token: 0x040001ED RID: 493
		public const string Code_400 = "Status Code 400/Bad Request : The request was not understood by the server, generally due to bad syntax or because the Content-Type header was not correctly set to application/json. This status is also returned when the request provides an invalid code parameter during the OAuth token exchange process.";

		// Token: 0x040001EE RID: 494
		public const string Code_401 = "Status Code 401/Unauthorized : The necessary authentication credentials are not present in the request or are incorrect.";

		// Token: 0x040001EF RID: 495
		public const string Code_402 = "Status Code 402/Payment Required : The requested shop is currently frozen. The shop owner needs to log in to the shop's admin and pay the outstanding balance to unfreeze the shop.";

		// Token: 0x040001F0 RID: 496
		public const string Code_403 = "Status Code 403/Forbidden : The server is refusing to respond to the request. This is generally because you have not requested the appropriate scope for this action.";

		// Token: 0x040001F1 RID: 497
		public const string Code_404 = "Status Code 404/Not Found : The requested resource was not found but could be available again in the future.";

		// Token: 0x040001F2 RID: 498
		public const string Code_406 = "Status Code 406/Not Acceptable : The requested resource is only capable of generating content not acceptable according to the Accept headers sent in the request.";

		// Token: 0x040001F3 RID: 499
		public const string Code_422 = "Status Code 422/Unprocessable Entity : The request body was well-formed but contains semantic errors. The response body will provide more details in the errors or error parameters.";

		// Token: 0x040001F4 RID: 500
		public const string Code_423 = "Status Code 423/Locked : The requested shop is currently locked. Shops are locked if they repeatedly exceed their API request limit, or if there is an issue with the account, such as a detected compromise or fraud risk. Contact support if your shop is locked.";

		// Token: 0x040001F5 RID: 501
		public const string Code_429 = "Status Code 429/Too Many Requests : The request was not accepted because the application has exceeded the rate limit. See the API Call Limit documentation for a breakdown of Shopify's rate-limiting mechanism.";

		// Token: 0x040001F6 RID: 502
		public const string Code_500 = "Status Code 500/Internal Server Error : An internal error occurred in Shopify. Please post to the API & Technology forum so that Shopify staff can investigate.";

		// Token: 0x040001F7 RID: 503
		public const string Code_501 = "Status Code 501/Not Implemented : The requested endpoint is not available on that particular shop, e.g. requesting access to a Plus-specific API on a non-Plus shop. This response may also indicate that this endpoint is reserved for future use.";

		// Token: 0x040001F8 RID: 504
		public const string Code_503 = "Status Code 503/Service Unavailable : The server is currently unavailable. Check the status page for reported service outages.";

		// Token: 0x040001F9 RID: 505
		public const string Code_504 = "Status Code 504/Gateway Timeout : The request could not complete in time. Try breaking it down in multiple smaller requests.";

		// Token: 0x040001FA RID: 506
		public const string Code_Unknown = "Code {0} : Unknown code";
	}
}