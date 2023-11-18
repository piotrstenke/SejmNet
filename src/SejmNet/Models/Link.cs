using Newtonsoft.Json;

namespace SejmNet.Models
{
	/// <summary>
	/// Represents a link to other web resource.
	/// </summary>
	public sealed class Link
	{
		/// <summary>
		/// Actual value of the link.
		/// </summary>
		[JsonProperty("href")]
		public required string Href { get; init; }

		/// <summary>
		/// Type of the linked resource.
		/// </summary>
		[JsonProperty("rel")]
		public required LinkResourceType Rel { get; init; }

		/// <summary>
		/// Initializes a new instance of the <see cref="Link"/> class.
		/// </summary>
		public Link()
		{
		}
	}
}
