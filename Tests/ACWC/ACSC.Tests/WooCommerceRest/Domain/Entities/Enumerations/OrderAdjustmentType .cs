using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ACSC.Tests.ShopifyRest.Domain.Entities.Enumerations
{
	/// <summary>
	/// The order adjustment type. Valid values: shipping_refund and refund_discrepancy.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum OrderAdjustmentType
	{
		[EnumMember(Value = "shipping_refund")]
		ShippingRefund = 0,

		[EnumMember(Value = "refund_discrepancy")]
		RefundDiscrepancy = 1
	}
}
