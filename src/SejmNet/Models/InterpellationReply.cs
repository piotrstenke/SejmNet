using Newtonsoft.Json;
using System;

namespace SejmNet.Models
{
	/// <summary>
	/// Represents a reply to a interperllation.
	/// </summary>
	public sealed class InterpellationReply
	{
		/// <summary>
		/// Identifier of the reply.
		/// </summary>
		[JsonProperty("key")]
		public required string Key { get; init; }

		/// <summary>
		/// Date the reply was received at.
		/// </summary>
		[JsonProperty("receiptDate")]
		public required DateTime ReceiptDate { get; init; }

		/// <summary>
		/// Date the reply was last modified at.
		/// </summary>
		[JsonProperty("lastModified")]
		public required DateTime LastModified { get; init; }

		/// <summary>
		/// Name of the reply author.
		/// </summary>
		[JsonProperty("from")]
		public required string From { get; init; }

		/// <summary>
		/// Associated links.
		/// </summary>
		[JsonProperty("links")]
		public required Link[] Links { get; init; }

		/// <summary>
		/// Determines whether the actual text of the reply is present in an attachment.
		/// </summary>
		[JsonProperty("onlyAttachment")]
		public bool OnlyAttachment { get; init; }

		/// <summary>
		/// Files attached to the reply.
		/// </summary>
		[JsonProperty("attachments")]
		public Attachment[]? Attachments { get; init; }

		/// <summary>
		/// Initializes a new instance of the <see cref="InterpellationReply"/> class.
		/// </summary>
		public InterpellationReply()
		{
		}
	}
}
