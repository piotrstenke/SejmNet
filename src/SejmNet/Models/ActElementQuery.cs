using Newtonsoft.Json;

namespace SejmNet.Models
{
	/// <summary>
	/// Contains data used for searching for a specific act element (e.g. chapter, article, point).
	/// </summary>
	public sealed class ActElementQuery
	{
		/// <summary>
		/// Number of book to search for.
		/// </summary>
		[JsonProperty("book")]
		public int Book { get; init; }

		/// <summary>
		/// Number of title to search for.
		/// </summary>
		[JsonProperty("title")]
		public int Title { get; init; }

		/// <summary>
		/// Number of branch to search for.
		/// </summary>
		[JsonProperty("branch")]
		public int Branch { get; init; }

		/// <summary>
		/// Number of chapter to search for.
		/// </summary>
		[JsonProperty("chapter")]
		public int Chapter { get; init; }

		/// <summary>
		/// Number of subchapter to search for.
		/// </summary>
		[JsonProperty("subchapter")]
		public int Subchapter { get; init; }

		/// <summary>
		/// Number of article to search for.
		/// </summary>
		[JsonProperty("article")]
		public int Article { get; init; }

		/// <summary>
		/// Number of pass to search for.
		/// </summary>
		[JsonProperty("pass")]
		public int Pass { get; init; }

		/// <summary>
		/// Number of paragraph to search for.
		/// </summary>
		[JsonProperty("paragraph")]
		public int Paragraph { get; init; }

		/// <summary>
		/// Number of point to search for.
		/// </summary>
		[JsonProperty("point")]
		public int Point { get; init; }

		/// <summary>
		/// Number of letter to search for.
		/// </summary>
		[JsonProperty("letter")]
		public int Letter { get; init; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ActElementQuery"/> class.
		/// </summary>
		public ActElementQuery()
		{
		}
	}
}
