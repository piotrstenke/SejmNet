using Newtonsoft.Json;
using System;

namespace SejmNet.Models
{
	/// <summary>
	/// Contains basic information about a legal act.
	/// </summary>
	public sealed class ActHeader
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
		public required string Type { get; init; }

		/// <summary>
		/// Status of the act.
		/// </summary>
		[JsonProperty("status")]
		public required string Status { get; init; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ActHeader"/> class.
		/// </summary>
		public ActHeader()
		{
		}
	}
}
