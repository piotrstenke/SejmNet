using Newtonsoft.Json;

namespace SejmNet.Models
{
	/// <summary>
	/// Represents a list of request results.
	/// </summary>
	/// <typeparam name="TResult">Type of single result.</typeparam>
	/// <typeparam name="TQuery">Type of query used to retrieve the results.</typeparam>
	public sealed class ResultList<TResult, TQuery>
		where TResult : class
		where TQuery : class
	{
		/// <summary>
		/// Current page offset.
		/// </summary>
		[JsonProperty("offset")]
		public int Offset { get; init; }

		/// <summary>
		/// Number of returned items.
		/// </summary>
		[JsonProperty("count")]
		public int Count { get; init; }

		/// <summary>
		/// Total number of items.
		/// </summary>
		[JsonProperty("totalCount")]
		public int TotalCount { get; init; }

		/// <summary>
		/// Collection of returned items.
		/// </summary>
		[JsonProperty("items")]
		public required TResult[] Items { get; init; }

		/// <summary>
		/// Search query used to get the list of results.
		/// </summary>
		[JsonProperty("searchQuery")]
		public TQuery? SearchQuery { get; init; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ResultList{TResult, TQuery}"/> class.
		/// </summary>
		public ResultList()
		{
		}
	}
}
