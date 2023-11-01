using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel;

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
		[Description("NONE")]
		None = 0,

		/// <summary>
		/// The date must be the same as this date.
		/// </summary>
		[Description("ON_DAY")]
		OnDay = 1,

		/// <summary>
		/// The date must be before this date.
		/// </summary>
		[Description("BEFORE")]
		Before = 2,

		/// <summary>
		/// The date must be after this date.
		/// </summary>
		[Description("AFTER")]
		After = 3,

		/// <summary>
		/// The date must be between two dates.
		/// </summary>
		[Description("BETWEEN")]
		Between = 4
	}
}
