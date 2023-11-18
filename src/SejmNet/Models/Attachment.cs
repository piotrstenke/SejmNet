using Newtonsoft.Json;
using System;

namespace SejmNet.Models
{
	/// <summary>
	/// Represents an attached file.
	/// </summary>
	public sealed class Attachment
	{
		/// <summary>
		/// Date of last modification.
		/// </summary>
		[JsonProperty("lastModified")]
		public required DateTime LastModified { get; init; }

		/// <summary>
		/// Name of the attachment.
		/// </summary>
		[JsonProperty("name")]
		public required string Name { get; init; }

		/// <summary>
		/// Url to the attached file.
		/// </summary>
		[JsonProperty("URL")]
		public required string Url { get; init; }

		/// <summary>
		/// Initializes a new instance of the <see cref="Attachment"/> class.
		/// </summary>
		public Attachment()
		{
		}
	}
}
