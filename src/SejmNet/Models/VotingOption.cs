using Newtonsoft.Json;

namespace SejmNet.Models
{
	/// <summary>
	/// Contains information about a voting option.
	/// </summary>
	public sealed class VotingOption
	{
		/// <summary>
		/// Name of the option.
		/// </summary>
		[JsonProperty("option")]
		public required string Name { get; init; }

		/// <summary>
		/// Description of the option.
		/// </summary>
		[JsonProperty("description")]
		public string? Description { get; init; }

		/// <summary>
		/// Number of voters that supported this option.
		/// </summary>
		[JsonProperty("votes")]
		public required int VoteCount { get; init; }

		/// <summary>
		/// Initializes a new instance of the <see cref="VotingOption"/> class.
		/// </summary>
		public VotingOption()
		{
		}
	}
}
