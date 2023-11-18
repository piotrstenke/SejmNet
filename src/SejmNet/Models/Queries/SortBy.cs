using Newtonsoft.Json;
using System;

namespace SejmNet.Models.Queries
{
	/// <summary>
	/// Specifies order and field to sort by.
	/// </summary>
	public sealed class SortBy<TField> where TField : struct, Enum
	{
		/// <summary>
		/// Sort order.
		/// </summary>
		[JsonProperty("order")]
		public SortOrder Order { get; init; }

		/// <summary>
		/// Field to sort by.
		/// </summary>
		[JsonProperty("field")]
		public required TField Field { get; init; }

		/// <summary>
		/// Initializes a new instance of the <see cref="SortBy{TField}"/> class.
		/// </summary>
		public SortBy()
		{
		}
	}
}
