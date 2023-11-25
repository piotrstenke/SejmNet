using Newtonsoft.Json;
using System;

namespace SejmNet.Models
{
	/// <summary>
	/// Represents a written question.
	/// </summary>
	public sealed class WrittenQuestion
	{
		/// <summary>
		/// Number of parliament term the question is associated with.
		/// </summary>
		[JsonProperty("term")]
		public required int Term { get; init; }

		/// <summary>
		/// Number associated with the question.
		/// </summary>
		[JsonProperty("num")]
		public required int Number { get; init; }

		/// <summary>
		/// Title of the question.
		/// </summary>
		[JsonProperty("title")]
		public required string Title { get; init; }

		/// <summary>
		/// Date of receiption of the question.
		/// </summary>
		[JsonProperty("receiptDate")]
		public required DateTime ReceiptDate { get; init; }

		/// <summary>
		/// Date of last modification.
		/// </summary>
		[JsonProperty("lastModified")]
		public required DateTime LastModified { get; init; }

		/// <summary>
		/// Links to HTML documents containing the text of the question.
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
		/// Date the question was sent at.
		/// </summary>
		[JsonProperty("sentDate")]
		public required DateTime SentDate { get; init; }

		/// <summary>
		/// List of replies to the question.
		/// </summary>
		[JsonProperty("replies")]
		public required Reply[] Replies { get; init; }

		/// <summary>
		/// Initializes a new instance of the <see cref="WrittenQuestion"/> class.
		/// </summary>
		public WrittenQuestion()
		{
		}
	}
}
