using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace SejmNet.Models
{
	/// <summary>
	/// Specifies all levels of urgency of a legislative process.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ProcessUrgency
	{
		/// <summary>
		/// No urgency specified.
		/// </summary>
		[EnumMember(Value = "NONE")]
		None = 0,

		/// <summary>
		/// Normal urgency.
		/// </summary>
		[EnumMember(Value = "NORMAL")]
		Normal = 1,

		/// <summary>
		/// Urgent.
		/// </summary>
		[EnumMember(Value = "URGENT")]
		Urgent = 2,

		/// <summary>
		/// Urgent status withdrawn.
		/// </summary>
		[EnumMember(Value = "URGENT_WITHDRAWN")]
		UrgentWithdrawn = 3,
	}
}
