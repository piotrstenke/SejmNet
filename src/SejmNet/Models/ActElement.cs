using Newtonsoft.Json;

namespace SejmNet.Models
{
	/// <summary>
	/// Represents a single as element, such as part or article.
	/// </summary>
	public sealed class ActElement
	{
		/// <summary>
		/// Id of the element.
		/// </summary>
		[JsonProperty("id")]
		public required string Id { get; init; }

		/// <summary>
		/// Title of the element.
		/// </summary>
		[JsonProperty("title")]
		public required string Title { get; init; }

		/// <summary>
		/// Type of the element.
		/// </summary>
		[JsonProperty("type")]
		public required string ElementType { get; init; }

		/// <summary>
		/// Id of the element in relation to the parent element.
		/// </summary>
		[JsonProperty("symbol")]
		public required string Symbol { get; init; }

		/// <summary>
		/// Name of the element.
		/// </summary>
		[JsonProperty("name")]
		public string? Name { get; init; }

		/// <summary>
		/// Child elements of this element.
		/// </summary>
		[JsonProperty("children")]
		public ActElement[]? Children { get; init; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ActElement"/> class.
		/// </summary>
		public ActElement()
		{
		}
	}
}
