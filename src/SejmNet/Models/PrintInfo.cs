using Newtonsoft.Json;
using System;

namespace SejmNet.Models
{
	/// <summary>
	/// Contains simplified information about prints.
	/// </summary>
	public sealed class PrintInfo
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
		[JsonProperty("count")]
		public required string Link { get; init; }

		/// <summary>
		/// Initializes a new instance of the <see cref="PrintInfo"/> class.
		/// </summary>
		public PrintInfo()
		{
		}
	}
}
