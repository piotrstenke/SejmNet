using Newtonsoft.Json;
using System;

namespace SejmNet.Models
{
	/// <summary>
	/// Represents a query that was executed when searching for acts.
	/// </summary>
	public sealed class ActResultQuery
	{
		/// <summary>
		/// Determines whether to include acts issued by the Polish autorities in exile.
		/// </summary>
		[JsonProperty("exile")]
		public bool InExile { get; init; }

		/// <summary>
		/// Determines whether to only include acts in force.
		/// </summary>
		[JsonProperty("statusInForce")]
		public bool InForceOnly { get; init; }

		/// <summary>
		/// Unique identifier of the act's publisher.
		/// </summary>
		[JsonProperty("publisher")]
		public required string PublisherCode { get; init; }

		/// <summary>
		/// Name of the selected publisher.
		/// </summary>
		[JsonProperty("publisherName")]
		public required string PublisherName { get; init; }

		/// <summary>
		/// Selected year of publication.
		/// </summary>
		[JsonProperty("year")]
		public required int Year { get; init; }

		/// <summary>
		/// Selected volume of publication.
		/// </summary>
		[JsonProperty("volume")]
		public required int Volume { get; init; }

		/// <summary>
		/// Selected position of publication.
		/// </summary>
		[JsonProperty("position")]
		public required int Position { get; init; }

		/// <summary>
		/// Title of act to search for.
		/// </summary>
		[JsonProperty("title")]
		public required string Title { get;init; }

		/// <summary>
		/// Types of acts to search for.
		/// </summary>
		[JsonProperty("type")]
		public required string[] ActTypes { get; init; }

		/// <summary>
		/// Keywords to search for.
		/// </summary>
		[JsonProperty("keyword")]
		public required string[] Keywords { get; init; }

		/// <summary>
		/// Type of the announcement date query.
		/// </summary>
		[JsonProperty("dateType")]
		public SearchDate AnnouncementDateType { get; init; }

		/// <summary>
		/// Date of announcement to search from.
		/// </summary>
		[JsonProperty("dateFrom")]
		public DateTime? AnnouncementDateFrom { get; init; }

		/// <summary>
		/// Date of announcement to search to.
		/// </summary>
		[JsonProperty("dateTo")]
		public DateTime? AnnouncementDateTo { get; init; }

		/// <summary>
		/// Type of the effect date query.
		/// </summary>
		[JsonProperty("dateEffectType")]
		public SearchDate EffectDateType { get; init; }

		/// <summary>
		/// Date of effect to search from.
		/// </summary>
		[JsonProperty("dateEffectFrom")]
		public DateTime? EffectDateFrom { get; init; }

		/// <summary>
		/// Date of effect to search to.
		/// </summary>
		[JsonProperty("dateEffectTo")]
		public DateTime? EffectDateTo { get; init; }

		/// <summary>
		/// Type of the promulgation date query.
		/// </summary>
		[JsonProperty("pubDateType")]
		public SearchDate PromulgationDateType { get; init; }

		/// <summary>
		/// Date of promulgation to search from.
		/// </summary>
		[JsonProperty("pubDateFrom")]
		public DateTime? PromulgationDateFrom { get; init; }

		/// <summary>
		/// Date of promulgation to search to.
		/// </summary>
		[JsonProperty("pubDateTo")]
		public DateTime? PromulgationDateTo { get; init; }

		/// <summary>
		/// Data used to order the acts.
		/// </summary>
		[JsonProperty("comparator")]
		public ResultComparator? ResultComparator { get; init; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ActResultQuery"/> class.
		/// </summary>
		public ActResultQuery()
		{
		}
	}
}
