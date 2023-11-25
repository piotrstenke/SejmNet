using Newtonsoft.Json;
using System;

namespace SejmNet.Models
{
	/// <summary>
	/// Contains information about a voting.
	/// </summary>
	public sealed class Voting
	{
		/// <summary>
		/// Number of parliament term the voting is associated with.
		/// </summary>
		[JsonProperty("term")]
		public required int Term { get; init; }

		/// <summary>
		/// Number associated with the voting.
		/// </summary>
		[JsonProperty("number")]
		public required int Number { get; init; }

		/// <summary>
		/// Number of parliament sitting during which the voting took place.
		/// </summary>
		[JsonProperty("sitting")]
		public required int Sitting { get; init; }

		/// <summary>
		/// Number of parliament sitting day during which the voting took place.
		/// </summary>
		[JsonProperty("sittingDay")]
		public required int SittingDay { get; init; }

		/// <summary>
		/// Date of the voting.
		/// </summary>
		[JsonProperty("date")]
		public required DateTime Date { get; init; }

		/// <summary>
		/// Title of the voting.
		/// </summary>
		[JsonProperty("title")]
		public required string Title { get; init; }

		/// <summary>
		/// Description of the voting.
		/// </summary>
		[JsonProperty("description")]
		public string? Description { get; init; }

		/// <summary>
		/// Topic of the voting.
		/// </summary>
		[JsonProperty("topic")]
		public required string Topic { get; init; }

		/// <summary>
		/// Number of 'yes' votes.
		/// </summary>
		[JsonProperty("yes")]
		public required int Yes { get; init; }

		/// <summary>
		/// Number of 'no' votes.
		/// </summary>
		[JsonProperty("no")]
		public required int No { get; init; }

		/// <summary>
		/// Number of 'abstain' votes.
		/// </summary>
		[JsonProperty("abstain")]
		public required int Abstain { get; init; }

		/// <summary>
		/// Number of parliament members who did not participate in the voting.
		/// </summary>
		[JsonProperty("notParticipating")]
		public required int Absent { get; init; }

		/// <summary>
		/// Kind of the voting.
		/// </summary>
		[JsonProperty("kind")]
		public required VotingKind Kind { get; init; }

		/// <summary>
		/// Link to PDF file of the voting.
		/// </summary>
		[JsonProperty("pdfLink")]
		public string? PdfLink { get; init; }

		/// <summary>
		/// List of options when voting on a list (when <see cref="Kind"/> == <see cref="VotingKind.OnList"/>).
		/// </summary>
		[JsonProperty("votingOptions")]
		public VotingOption[]? Options { get; init; }

		/// <summary>
		/// Initializes a new instance of the <see cref="Voting"/> class.
		/// </summary>
		public Voting()
		{
		}
	}
}
