using Newtonsoft.Json;

namespace SejmNet.Models
{
	/// <summary>
	/// Contains information about a print and legislative process.
	/// </summary>
	public sealed class PrintReference
	{
		/// <summary>
		/// Term of the parliament when the print was published
		/// </summary>
		[JsonProperty("term")]
		public required int Term { get; init; }

		/// <summary>
		/// Number of the print.
		/// </summary>
		[JsonProperty("number")]
		public required string Number { get; init; }

		/// <summary>
		/// Link to the display version of the process details.
		/// </summary>
		[JsonProperty("link")]
		public required string ProcessDisplayLink { get; init; }

		/// <summary>
		/// Link to the details of the print.
		/// </summary>
		[JsonProperty("linkPrintAPI")]
		public required string PrintDetailsLink { get; init; }

		/// <summary>
		/// Link to the details of the legislative process.
		/// </summary>
		[JsonProperty("linkProcessAPI")]
		public required string ProcessDetailsLink { get; init; }

		/// <summary>
		/// Initializes a new instance of the <see cref="PrintReference"/> class.
		/// </summary>
		public PrintReference()
		{
		}
	}
}
