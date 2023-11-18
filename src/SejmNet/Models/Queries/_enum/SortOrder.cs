using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace SejmNet.Models.Queries
{
	/// <summary>
	/// Sort order.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SortOrder
	{
		/// <summary>
		/// Ascending order.
		/// </summary>
		[EnumMember(Value = "asc")]
		Ascending = 0,
		
		/// <summary>
		/// Descending order.
		/// </summary>
		[EnumMember(Value = "desc")]
		Descending = 1
	}
}
