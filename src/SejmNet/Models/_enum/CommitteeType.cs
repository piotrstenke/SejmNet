using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SejmNet.Models
{
	/// <summary>
	/// Defines all possible types of parliamentary committees.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CommitteeType
	{
		/// <summary>
		/// Standard committee.
		/// </summary>
		Standard = 0,

		/// <summary>
		/// Extraordinary committee.
		/// </summary>
		Extraordinary = 1,

		/// <summary>
		/// Investigative commitee.
		/// </summary>
		Investigative = 2
	}
}
