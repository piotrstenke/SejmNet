using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace SejmNet.Models
{
	/// <summary>
	/// Specifies all types of realization of EU law.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EULawRealization
	{
		/// <summary>
		/// Not an EU law.
		/// </summary>
		[EnumMember(Value = "NO")]
		None = 0,

		/// <summary>
		/// Adaptation of EU law.
		/// </summary>
		[EnumMember(Value = "ADAPTATION")]
		Adaptation = 1,
		
		/// <summary>
		/// Enforcement of EU law.
		/// </summary>
		[EnumMember(Value = "ENFORCEMENT")]
		Enforcement = 2
	}
}
