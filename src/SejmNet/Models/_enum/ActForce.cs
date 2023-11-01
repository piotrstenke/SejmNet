using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel;

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
		[Description("UNKNOWN")]
		Unknown = 0,

		/// <summary>
		/// The act is in force.
		/// </summary>
		[Description("IN_FORCE")]
		InForce = 1,

		/// <summary>
		/// The act is not in force.
		/// </summary>
		[Description("NOT_IN_FORCE")]
		NotInForce = 2
	}
}
