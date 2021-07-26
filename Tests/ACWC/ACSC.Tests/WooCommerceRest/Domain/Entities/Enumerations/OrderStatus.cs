using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ACSC.Tests.ShopifyRest.Domain.Entities.Enumerations
{
	/// <summary>
	/// The status of the order. Valid values: open, closed,cancelled.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum OrderStatus
	{
		/// <summary>
		/// open: The order status is open.
		/// </summary>
		[EnumMember(Value = "open")]
		Open,

		/// <summary>
		/// closed: The order status is closed.
		/// </summary>
		[EnumMember(Value = "closed")]
		Closed,

		/// <summary>
		/// cancelled: The order status is cancelled.
		/// </summary>
		[EnumMember(Value = "cancelled")]
		Cancelled

	}
}
