using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ACSC.Tests.ShopifyRest.Domain.Entities.Enumerations
{
	/// <summary>
	/// The type of the value. Valid values:
	/// fixed_amount: A fixed amount discount value in the currency of the order.
	/// percentage: A percentage discount value.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PriceRuleValueType
	{
		/// <summary>
		/// fixed_amount: A fixed amount discount value in the currency of the order.
		/// </summary>
		[EnumMember(Value = "fixed_amount")]
		FixedAmount = 0,

		/// <summary>
		/// percentage: A percentage discount value.
		/// </summary>
		[EnumMember(Value = "percentage")]
		percentage = 1
	}
}
