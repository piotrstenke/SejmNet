using Newtonsoft.Json;
using System;

namespace SejmNet.Models
{
	/// <summary>
	/// Contains information about a document associated with a legislative process.
	/// </summary>
	public sealed class ProcessDocument
	{
		/// <summary>
		/// Print number.
		/// </summary>
		[JsonProperty("number")]
		public required string Number { get; init; }

		/// <summary>
		/// Date when the document was registered.
		/// </summary>
		[JsonProperty("registerDate")]
		public required DateTime RegistrationDate { get; init; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ProcessDocument"/> class.
		/// </summary>
		public ProcessDocument()
		{
		}
	}
}
