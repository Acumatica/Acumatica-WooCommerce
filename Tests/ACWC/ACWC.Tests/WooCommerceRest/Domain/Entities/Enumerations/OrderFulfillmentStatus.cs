using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ACSC.Tests.ShopifyRest.Domain.Entities.Enumerations
{
	/// <summary>
	/// The order's status in terms of fulfilled line items. Valid values:
	/// fulfilled: Every line item in the order has been fulfilled.
	/// null: None of the line items in the order have been fulfilled.
	/// partial: At least one line item in the order has been fulfilled.
	/// restocked: Every line item in the order has been restocked and the order canceled.
	/// not_eligible
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum OrderFulfillmentStatus
	{
		/// <summary>
		/// fulfilled: Every line item in the order has been fulfilled.
		/// </summary>
		[EnumMember(Value = "fulfilled")]
		Fulfilled = 0,

		/// <summary>
		/// null: None of the line items in the order have been fulfilled.
		/// </summary>
		[EnumMember(Value = "null")]
		Null = 1,

		/// <summary>
		/// partial: At least one line item in the order has been fulfilled.
		/// </summary>
		[EnumMember(Value = "partial")]
		Partial = 2,

		/// <summary>
		/// restocked: Every line item in the order has been restocked and the order canceled.
		/// </summary>
		[EnumMember(Value = "restocked")]
		Restocked = 3,

		/// <summary>
		/// not_eligible
		/// </summary>
		[EnumMember(Value = "not_eligible")]
		NotEligible = 4
	}
}
