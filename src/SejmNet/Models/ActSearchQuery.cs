using Newtonsoft.Json;
using System;

namespace SejmNet.Models
{
	/// <summary>
	/// Represents a query for searching acts.
	/// </summary>
	public sealed class ActSearchQuery
	{
		private readonly int _year;
		private readonly int _limit;
		private readonly int _offset;
		private readonly int _volume;
		private readonly int _position;

		/// <summary>
		/// Max number of result in the response.
		/// </summary>
		/// <exception cref="ArgumentOutOfRangeException">Value is less than <c>0</c>.</exception>
		[JsonProperty("limit")]
		public int Limit
		{
			get => _limit;
			init
			{
				Validation.ValidateLessThan(value, 0, nameof(Limit));

				_limit = value;
			}
		}

		/// <summary>
		/// Index to start returning acts from.
		/// </summary>
		/// <exception cref="ArgumentOutOfRangeException">Value is less than <c>0</c>.</exception>
		[JsonProperty("offset")]
		public int Offset
		{
			get => _offset;
			init
			{
				Validation.ValidateLessThan(value, 0, nameof(Offset));

				_offset = value;
			}
		}

		/// <summary>
		/// Determines whether to include acts issued by the Polish autorities in exile.
		/// </summary>
		[JsonProperty("exile")]
		public bool InExile { get; init; }

		/// <summary>
		/// Determines whether to only include acts in force.
		/// </summary>
		[JsonProperty("inForce")]
		public bool InForceOnly { get; init; }

		/// <summary>
		/// Unique identifier of the act's publisher.
		/// </summary>
		[JsonProperty("publisher")]
		public string? PublisherCode { get; init; }

		/// <summary>
		/// Selected year of publication.
		/// </summary>
		/// <exception cref="ArgumentOutOfRangeException">Value is less than <see cref="SejmClient.Constants.MinPublishYear"/> or greater than <see cref="SejmClient.Constants.MaxPublishYear"/>.</exception>
		[JsonProperty("year")]
		public int Year
		{
			get => _year;
			init
			{
				Validation.ValidatePublishYear(value, nameof(Year));

				_year = value;
			}
		}

		/// <summary>
		/// Selected volume of publication.
		/// </summary>
		/// <exception cref="ArgumentOutOfRangeException">Value is less than <c>1</c>.</exception>
		[JsonProperty("volume")]
		public int Volume
		{
			get => _volume;
			init
			{
				Validation.ValidateLessThan(value, 1, nameof(Volume));

				_volume = value;
			}
		}

		/// <summary>
		/// Selected position of publication.
		/// </summary>
		/// <exception cref="ArgumentOutOfRangeException">Value is less than <c>1</c>.</exception>
		[JsonProperty("position")]
		public int Position
		{
			get => _position;
			init
			{
				Validation.ValidateLessThan(value, 1, nameof(Position));

				_position = value;
			}
		}

		/// <summary>
		/// Title of act to search for.
		/// </summary>
		[JsonProperty("title")]
		public string? Title { get; init; }

		/// <summary>
		/// Types of the act.
		/// </summary>
		[JsonProperty("type")]
		public string? Type { get; init; }

		/// <summary>
		/// Keywords to search for.
		/// </summary>
		[JsonProperty("keyword")]
		public string[]? Keywords { get; init; }

		/// <summary>
		/// Exact announcement date to search.
		/// </summary>
		[JsonProperty("date")]
		public DateTime? AnnouncementDate { get; init; }

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
		/// Exact effect date to search.
		/// </summary>
		[JsonProperty("dateEffect")]
		public DateTime? EffectDate { get; init; }

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
		/// Exact promulgation date to search.
		/// </summary>
		[JsonProperty("pubDate")]
		public DateTime? PromulgationDate { get; init; }

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
		/// Initializes a new instance of the <see cref="ActSearchQuery"/> class.
		/// </summary>
		public ActSearchQuery()
		{
		}
	}
}
