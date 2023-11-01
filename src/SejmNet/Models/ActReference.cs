using Newtonsoft.Json;
using System;

namespace SejmNet.Models
{
	/// <summary>
	/// Represents a reference to a different act.
	/// </summary>
	public sealed class ActReference
	{
		/// <summary>
		/// ELI address of the act.
		/// </summary>
		[JsonProperty("id")]
		public required string Address { get; init; }

		/// <summary>
		/// Referenced article.
		/// </summary>
		[JsonProperty("art")]
		public string? Article { get; init; }

		/// <summary>
		/// Associated date (e.g. for repeal).
		/// </summary>
		[JsonProperty("date")]
		public DateTime? Date { get; init; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ActReference"/> class.
		/// </summary>
		public ActReference()
		{
		}
	}
}
