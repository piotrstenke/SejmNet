using Newtonsoft.Json;
using System;

namespace SejmNet.Models
{
	/// <summary>
	/// Contains detailed information about a legislative process.
	/// </summary>
	public sealed class LegislativeProcess
	{
		/// <summary>
		/// Number of parliament term the process is associated with.
		/// </summary>
		[JsonProperty("term")]
		public required int Term { get; init; }

		/// <summary>
		/// Number associated with the process.
		/// </summary>
		[JsonProperty("number")]
		public required string Number { get; init; }

		/// <summary>
		/// Title of the process.
		/// </summary>
		[JsonProperty("title")]
		public required string Title { get; init; }

		/// <summary>
		/// Optional description of the process.
		/// </summary>
		[JsonProperty("description")]
		public string? Description { get; init; }

		/// <summary>
		/// Determines whether the process is a realization of EU law(s) and the rules on which the realization takes place.
		/// </summary>
		[JsonProperty("eu")]
		public EULawRealization EULawRealization { get; init; }

		/// <summary>
		/// Date of the associated document.
		/// </summary>
		[JsonProperty("documentDate")]
		public required DateTime DocumentDate { get; init; }

		/// <summary>
		/// Date of last modification to the process.
		/// </summary>
		[JsonProperty("changeDate")]
		public required DateTime ChangeDate { get; init; }

		/// <summary>
		/// Start date of the process.
		/// </summary>
		[JsonProperty("processStartDate")]
		public required DateTime StartDate { get; init; }

		/// <summary>
		/// Date a web page with the process was generated at.
		/// </summary>
		[JsonProperty("webGeneratedDate")]
		public required DateTime GeneratedDate { get; init; }

		/// <summary>
		/// Type of the document.
		/// </summary>
		[JsonProperty("documentType")]
		public required string DocumentType { get; init; }

		/// <summary>
		/// Comments to the legislative process.
		/// </summary>
		[JsonProperty("comments")]
		public string? Comment { get; init; }

		/// <summary>
		/// Determines whether members of the Legislative Committee were assigned tp this process.
		/// </summary>
		[JsonProperty("legislativeCommittee")]
		public bool IsLegistlativeCommittee { get; init; }

		/// <summary>
		/// Determines whether the process is inconsistent with the principle of subsidiarity.
		/// </summary>
		[JsonProperty("principleOfSubsidiarity")]
		public bool BreaksPrincipleOfSubsidiarity { get; init; }

		/// <summary>
		/// Number from goverment part of the process.
		/// </summary>
		[JsonProperty("rclNumber")]
		public string? RclNumber { get; init; }
		
		/// <summary>
		/// Level of urgency of the process.
		/// </summary>
		[JsonProperty("urgencyStatus")]
		public required ProcessUrgency Urgency { get; init; }

		/// <summary>
		/// Date the 'urgent' status was withdrawn at.
		/// </summary>
		[JsonProperty("urgencyWithdrawDate")]
		public DateTime? UrgencyWithdrawalDate { get; init; }

		/// <summary>
		/// Numbers of prints considered jointly in this process.
		/// </summary>
		[JsonProperty("printsConsideredJointly")]
		public string[]? PrintsConsideredJointly { get; init; }

		/// <summary>
		/// Stages of the legislative process.
		/// </summary>
		[JsonProperty("stages")]
		public required	ProcessStage[] Stages { get; init; }

		/// <summary>
		/// Other associated prints.
		/// </summary>
		[JsonProperty("otherDocuments")]
		public ProcessDocument[]? OtherDocuments { get; init; }

		/// <summary>
		/// Initializes a new instance of the <see cref="LegislativeProcess"/> class.
		/// </summary>
		public LegislativeProcess()
		{
		}
	}
}
