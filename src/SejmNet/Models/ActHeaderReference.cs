using Newtonsoft.Json;
using System;

namespace SejmNet.Models
{
	/// <summary>
	/// Represents a reference to a different act including its basic information.
	/// </summary>
	public sealed class ActHeaderReference
	{
		/// <summary>
		/// Basic information about the act.
		/// </summary>
		[JsonProperty("act")]
		public required ActHeader Header { get; init; }

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
		/// Initializes a new instance of the <see cref="ActHeaderReference"/> class.
		/// </summary>
		public ActHeaderReference()
		{
		}
	}
}
