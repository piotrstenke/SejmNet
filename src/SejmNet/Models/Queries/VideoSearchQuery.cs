using Newtonsoft.Json;
using System;

namespace SejmNet.Models.Queries
{
	/// <summary>
	/// Represents a query for searching videos.
	/// </summary>
	public sealed class VideoSearchQuery
	{
		private readonly int _limit;
		private readonly int _offset;

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
		/// Filters videos starting from this date.
		/// </summary>
		[JsonProperty("since")]
		public DateTime? SinceDate { get; init; }

		/// <summary>
		/// Filters videos starting before this date.
		/// </summary>
		[JsonProperty("till")]
		public DateTime? TillDate { get; init; }

		/// <summary>
		/// Code of committee to search the videos of.
		/// </summary>
		[JsonProperty("committee")]
		public string? CommitteeCode { get; init; }

		/// <summary>
		/// String of characters to filter the title by.
		/// </summary>
		[JsonProperty("title")]
		public string? Title { get; init; }

		/// <summary>
		/// Type of videos to search for.
		/// </summary>
		[JsonProperty("type")]
		public VideoType Type { get; init; }

		/// <summary>
		/// Initializes a new instance of the <see cref="VideoSearchQuery"/> class.
		/// </summary>
		public VideoSearchQuery()
		{
		}
	}
}
