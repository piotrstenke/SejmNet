using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SejmNet.Models
{

	/// <summary>
	/// Contains full information about a legal act.
	/// </summary>
	public sealed class Act
	{
		/// <summary>
		/// Address of publication of the act.
		/// <para>An address is in format <i>{publisher}{year}{volume}{position}</i>, eg. <b>WDU20170002196</b>.</para>
		/// </summary>
		[JsonProperty("address")]
		public required string Address { get; init; }

		/// <summary>
		/// Unique identifier of the act's publisher.
		/// </summary>
		[JsonProperty("publisher")]
		public required string PublisherCode { get; init; }

		/// <summary>
		/// Year the act was published in.
		/// </summary>
		[JsonProperty("year")]
		public required int Year { get; init; }

		/// <summary>
		/// Volume of publication of the act as a year.
		/// </summary>
		/// <remarks><b>NOTE:</b> For acts published after 2012 volumes are no longer used, and as such this value is <c>0</c>.</remarks>
		[JsonProperty("volume")]
		public int Volume { get; init; }

		/// <summary>
		/// Position of the act in year (for acts published after 2012) or in volume (for acts published in 2012 or before).
		/// </summary>
		[JsonProperty("pos")]
		public required int Position { get; init; }

		/// <summary>
		/// Title of the act.
		/// </summary>
		[JsonProperty("title")]
		public required string Title { get; init; }

		/// <summary>
		/// Display-friendly version of the <see cref="Address"/>.
		/// </summary>
		[JsonProperty("displayAddress")]
		public required string DisplayAddress { get; init; }

		/// <summary>
		/// Promulgation date of the act.
		/// </summary>
		[JsonProperty("promulgation")]
		public required DateTime PromulgationDate { get; init; }

		/// <summary>
		/// Announcement date of the act.
		/// </summary>
		[JsonProperty("announcementDate")]
		public required DateTime AnnouncementDate { get; init; }

		/// <summary>
		/// Determines whether this act has a PDF version.
		/// </summary>
		[JsonProperty("textPDF")]
		public bool HasPdf { get; init; }

		/// <summary>
		/// Determines whether this act has a HTML version.
		/// </summary>
		[JsonProperty("textHTML")]
		public bool HasHtml { get; init; }

		/// <summary>
		/// Date and time of last change to the act.
		/// </summary>
		[JsonProperty("changeDate")]
		public required DateTime ChangeDate { get; init; }

		/// <summary>
		/// European Legislation Identifier.
		/// </summary>
		[JsonProperty("ELI")]
		public required string Eli { get; init; }

		/// <summary>
		/// Type of the act.
		/// </summary>
		[JsonProperty("type")]
		public required string ActType { get; init; }

		/// <summary>
		/// Status of the act.
		/// </summary>
		[JsonProperty("status")]
		public required string Status { get; init; }

		/// <summary>
		/// Date of entry into force of the act.
		/// </summary>
		[JsonProperty("entryIntoForce")]
		public required DateTime ForceEntryDate { get; init; }

		/// <summary>
		/// Date of binding force of the act.
		/// </summary>
		[JsonProperty("validFrom")]
		public required DateTime ValidFrom { get; init; }

		/// <summary>
		/// Date of repeal of the act.
		/// </summary>
		[JsonProperty("repealDate")]
		public required DateTime RepealDate { get; init; }

		/// <summary>
		/// Date of expiration of the act.
		/// </summary>
		[JsonProperty("expirationDate")]
		public required DateTime ExpirationDate { get; init; }

		/// <summary>
		/// Date of legal status of the act.
		/// </summary>
		[JsonProperty("legalStatusDate")]
		public required DateTime LegalStatusDate { get; init; }

		/// <summary>
		/// Determines whether the act is in force.
		/// </summary>
		[JsonProperty("inForce")]
		public required ActForce InForce { get; init; }

		/// <summary>
		/// Comments on the act.
		/// </summary>
		[JsonProperty("comments")]
		public string? Comments { get; init; }

		/// <summary>
		/// Name of the issuing authority.
		/// </summary>
		[JsonProperty("releasedBy")]
		public required string ReleasedBy { get; init; }

		/// <summary>
		/// Names of the authorized bodies.
		/// </summary>
		[JsonProperty("authorizedBody")]
		public required string[] AuthorizedBodies { get; init; }

		/// <summary>
		/// Names of the obligated authorities.
		/// </summary>
		[JsonProperty("obligated")]
		public required string[] ObligatedAuthorities { get; init; }

		/// <summary>
		/// List of associated EU directives.
		/// </summary>
		[JsonProperty("directives")]
		public required Directive[] Directives { get; init; }

		/// <summary>
		/// List of keywords associated with the act.
		/// </summary>
		[JsonProperty("keywords")]
		public required string[] Keywords { get; init; }

		/// <summary>
		/// List of names associated with the act.
		/// </summary>
		[JsonProperty("keywordsNames")]
		public required string[] KeywordNames { get; init; }

		/// <summary>
		/// Information about text of the act.
		/// </summary>
		[JsonProperty("texts")]
		public required ActText[] Texts { get; init; }

		/// <summary>
		/// List of previous titles of the act.
		/// </summary>
		[JsonProperty("previousTitle")]
		public required string[] PreviousTitles { get; init; }

		/// <summary>
		/// List of associated prints.
		/// </summary>
		[JsonProperty("prints")]
		public required PrintReference[] Prints { get; init; }

		/// <summary>
		/// List of references to different acts.
		/// </summary>
		[JsonProperty("references")]
		public required Dictionary<string, ActReference[]> References { get; init; }

		/// <summary>
		/// Initializes a new instance of the <see cref="Act"/> class.
		/// </summary>
		public Act()
		{
		}
	}
}
