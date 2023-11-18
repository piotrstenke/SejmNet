using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace SejmNet.Models
{
	/// <summary>
	/// Determines whether an act is in force.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum	ActForce
	{
		/// <summary>
		/// It is unknown if the act is in force.
		/// </summary>
		[EnumMember(Value = "UNKNOWN")]
		Unknown = 0,

		/// <summary>
		/// The act is in force.
		/// </summary>
		[EnumMember(Value = "IN_FORCE")]
		InForce = 1,

		/// <summary>
		/// The act is not in force.
		/// </summary>
		[EnumMember(Value = "NOT_IN_FORCE")]
		NotInForce = 2
	}
}
