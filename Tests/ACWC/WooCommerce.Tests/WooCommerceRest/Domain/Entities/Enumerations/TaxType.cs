using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ACSC.Tests.ShopifyRest.Domain.Entities.Enumerations
{
	/// <summary>
	/// The tax type. Valid values: normal, null, or harmonized. 
	/// If the value is harmonized, then the tax is compounded of the provincial and federal sales taxes.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum TaxType
	{
		[EnumMember(Value = "normal")]
		Normal = 0,

		[EnumMember(Value = "null")]
		Null = 1,

		[EnumMember(Value = "harmonized")]
		Harmonized = 2
	}
}
