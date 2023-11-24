using Newtonsoft.Json;
using System;

namespace SejmNet.Models
{
	/// <summary>
	/// Represents an interpellation.
	/// </summary>
	public sealed class Interpellation
	{
		/// <summary>
		/// Number of parliament term the interpellation is associated with.
		/// </summary>
		[JsonProperty("term")]
		public required int Term { get; init; }

		/// <summary>
		/// Number associated with the interpellation.
		/// </summary>
		[JsonProperty("num")]
		public required int Number { get; init; }

		/// <summary>
		/// Title of the interpellation.
		/// </summary>
		[JsonProperty("title")]
		public required string Title { get; init; }

		/// <summary>
		/// Date of receiption of the interpellation.
		/// </summary>
		[JsonProperty("receiptDate")]
		public required DateTime ReceiptDate { get; init; }

		/// <summary>
		/// Date of last modification.
		/// </summary>
		[JsonProperty("lastModified")]
		public required DateTime LastModified { get; init; }

		/// <summary>
		/// Links to HTML documents containing the text of the interpellation.
		/// </summary>
		[JsonProperty("links")]
		public required string[] Links { get; init; }

		/// <summary>
		/// List of IDs of parliament members who submitted the question.
		/// </summary>
		[JsonProperty("from")]
		public required int[] From { get; init; }

		/// <summary>
		/// List of ministries the question was sent to.
		/// </summary>
		[JsonProperty("to")]
		public required string[] To { get; init; }

		/// <summary>
		/// Date the interpellation was sent at.
		/// </summary>
		[JsonProperty("sentDate")]
		public required DateTime SentDate { get; init; }

		/// <summary>
		/// List of replies to the interpellation.
		/// </summary>
		[JsonProperty("replies")]
		public required InterpellationReply[] Replies { get; init; }

		/// <summary>
		/// List of interpellations that were submitted after reciving unsatisfactory answer (request for additional explanations).
		/// </summary>
		[JsonProperty("repeatedInterpellation")]
		public string[]? RepeatedInterpellation { get; init; }

		/// <summary>
		/// Initializes a new instance of the <see cref="Interpellation"/> class.
		/// </summary>
		public Interpellation()
		{
		}
	}
}
