using Newtonsoft.Json;
using System;

namespace SejmNet.Models
{
	/// <summary>
	/// Contains aggregated information about prints of a specific term.
	/// </summary>
	public sealed class PrintsInTerm
	{
		/// <summary>
		/// Number of prints.
		/// </summary>
		[JsonProperty("count")]
		public required int Count { get; init; }

		/// <summary>
		/// Date of the last change to any document.
		/// </summary>
		[JsonProperty("lastChanged")]
		public required DateTime LastChanged { get; init; }

		/// <summary>
		/// Link to the print endpoint.
		/// </summary>
		[JsonProperty("link")]
		public required string Link { get; init; }

		/// <summary>
		/// Initializes a new instance of the <see cref="PrintsInTerm"/> class.
		/// </summary>
		public PrintsInTerm()
		{
		}
	}
}
