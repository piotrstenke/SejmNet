using Newtonsoft.Json;

namespace SejmNet.Models
{
	/// <summary>
	/// Contains information about a parliamentary club.
	/// </summary>
	public sealed class Club
	{
		/// <summary>
		/// Unique identifier of the club (usualy simple abbreviation).
		/// </summary>
		[JsonProperty("id")]
		public required string Id { get; init; }

		/// <summary>
		/// Full name of the club.
		/// </summary>
		[JsonProperty("name")]
		public required string Name { get; init; }

		/// <summary>
		/// Number of parliament members in the club.
		/// </summary>
		[JsonProperty("membersCount")]
		public required int MemberCount { get; init; }

		/// <summary>
		/// Official phone number of the club.
		/// </summary>
		[JsonProperty("phone")]
		public string? Phone { get; init; }

		/// <summary>
		/// Official fax number of the club.
		/// </summary>
		[JsonProperty("fax")]
		public string? Fax { get; init; }

		/// <summary>
		/// Official e-mail(s) of the club.
		/// </summary>
		[JsonProperty("email")]
		public string? Email { get; init; }

		/// <summary>
		/// Initializes a new instance of the <see cref="Club"/> class.
		/// </summary>
		public Club()
		{
		}
	}
}
