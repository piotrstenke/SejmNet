using Newtonsoft.Json;
using System;

//
// NOTE:
//
// The 'to' field does not seem to work (all requests result in an error), thus it is excluded from this class. 
//

namespace SejmNet.Models.Queries
{
	/// <summary>
	/// Represents a query for searching interpellations.
	/// </summary>
	public sealed class InterpellationSearchQuery
	{
		private readonly int _from;
		private readonly int _limit;
		private readonly int _offset;

		/// <summary>
		/// Id of parliament member the interpellation was sent from.
		/// </summary>
		/// <exception cref="ArgumentOutOfRangeException">Value is less than <c>0</c>.</exception>
		[JsonProperty("from")]
		public int From
		{
			get => _from;
			init
			{
				Validation.ValidateLessThan(value, 0, nameof(From));

				_from = value;
			}
		}

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
		/// Number of results to skip in the response.
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
		/// Earliest allowed date of modification.
		/// </summary>
		[JsonProperty("modifiedSince")]
		public DateTime? ModifiedSince { get; init; }

		/// <summary>
		/// Earliest allowed send date.
		/// </summary>
		[JsonProperty("since")]
		public DateTime? SentSince { get; init; }

		/// <summary>
		/// Latest allowed send date.
		/// </summary>
		[JsonProperty("till")]
		public DateTime? SentTill { get; init; }

		/// <summary>
		/// String of characters to filter the title by.
		/// </summary>
		[JsonProperty("title")]
		public string? Title { get; init; }

		/// <summary>
		/// Specifies order and field to sort by.
		/// </summary>
		[JsonProperty("sort_by")]
		public SortBy<InterpellationSortField>? SortBy { get; init; }

		/// <summary>
		/// Initializes a new instance of the <see cref="InterpellationSearchQuery"/> class.
		/// </summary>
		public InterpellationSearchQuery()
		{
		}
	}
}
