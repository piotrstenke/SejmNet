using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace SejmNet.Models
{
	/// <summary>
	/// Type of date query used by the search engine.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SearchDate
	{
		/// <summary>
		/// No search date specified.
		/// </summary>
		[EnumMember(Value = "NONE")]
		None = 0,

		/// <summary>
		/// The date must be the same as this date.
		/// </summary>
		[EnumMember(Value = "ON_DAY")]
		OnDay = 1,

		/// <summary>
		/// The date must be before this date.
		/// </summary>
		[EnumMember(Value = "BEFORE")]
		Before = 2,

		/// <summary>
		/// The date must be after this date.
		/// </summary>
		[EnumMember(Value = "AFTER")]
		After = 3,

		/// <summary>
		/// The date must be between two dates.
		/// </summary>
		[EnumMember(Value = "BETWEEN")]
		Between = 4
	}
}
