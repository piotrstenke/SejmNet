using Newtonsoft.Json;
using System;

namespace SejmNet.Models
{
	/// <summary>
	/// Contains information about a stage of a legislative process.
	/// </summary>
	public sealed class ProcessStage
	{
		/// <summary>
		/// Name of the stage.
		/// </summary>
		[JsonProperty("name")]
		public required string Name { get; init; }

		/// <summary>
		/// Date of the stage.
		/// </summary>
		[JsonProperty("date")]
		public DateTime? Date { get; init; }

		/// <summary>
		/// Child stages.
		/// </summary>
		[JsonProperty("children")]
		public ProcessStage[]? Children { get; init; }

		/// <summary>
		/// Parliament sitting number during which the stage took place.
		/// </summary>
		[JsonProperty("sittingNum")]
		public int SittingNumber { get; init; }

		/// <summary>
		/// Comment on the stage.
		/// </summary>
		[JsonProperty("comment")]
		public string? Comment { get; init; }

		/// <summary>
		/// Decision of the parliament.
		/// </summary>
		[JsonProperty("decision")]
		public string? Decision { get; init; }

		/// <summary>
		/// Link to a text after third reading (in a PDF format).
		/// </summary>
		[JsonProperty("textAfter3")]
		public string? TextAfterThirdReading { get; init; }

		/// <summary>
		/// Information about voting that took place during this stage.
		/// </summary>
		[JsonProperty("voting")]
		public Voting? Voting { get; init; }

		/// <summary>
		/// Code of committee the print was sent to.
		/// </summary>
		[JsonProperty("committeeCode")]
		public string? CommitteeCode { get; init; }

		/// <summary>
		/// Recommended date of referral report.
		/// </summary>
		[JsonProperty("reportDate")]
		public DateTime? ReportDate { get; init; }

		/// <summary>
		/// Remarks on a referral.
		/// </summary>
		[JsonProperty("remarks")]
		public string? ReferrralRemarks { get; init; }

		/// <summary>
		/// Type of the referral.
		/// </summary>
		[JsonProperty("type")]
		public ReferralType ReferralType { get; init; }

		/// <summary>
		/// Date of reading continuation.
		/// </summary>
		[JsonProperty("continuedOn")]
		public DateTime? ContinuationDate { get; init; }

		/// <summary>
		/// Name of organ the print was sent to for opinion.
		/// </summary>
		[JsonProperty("organ")]
		public string? OpinionOrgan { get; init; }

		/// <summary>
		/// Date when the opinion was received.
		/// </summary>
		[JsonProperty("opinionReceived")]
		public DateTime? OpinionDate { get; init; }

		/// <summary>
		/// Date when the opinion was sent to a comission.
		/// </summary>
		[JsonProperty("toCommission")]
		public DateTime? ComissionDate { get; init; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ProcessStage"/> class.
		/// </summary>
		public ProcessStage()
		{
		}
	}
}
