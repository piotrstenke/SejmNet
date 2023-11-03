using Newtonsoft.Json;

namespace SejmNet.Models
{
	/// <summary>
	/// Contains information about a member of a parliamentary committee.
	/// </summary>
	public sealed class CommitteeMember
	{
		/// <summary>
		/// Unique identifier of the parliament member.
		/// </summary>
		[JsonProperty("id")]		
		public required int Id { get; init; }

		/// <summary>
		/// Club the commitee member belongs to.
		/// </summary>
		[JsonProperty("club")]
		public required string Club { get; init; }

		/// <summary>
		/// Full name of the committee member.
		/// </summary>
		[JsonProperty("lastFirstName")]
		public required string FullName { get; init; }

		/// <summary>
		/// Function of the member in the committee.
		/// </summary>
		[JsonProperty("function")]
		public string? Function { get; init; }

		/// <summary>
		/// Initializes a new instance of the <see cref="CommitteeMember"/> class.
		/// </summary>
		public CommitteeMember()
		{
		}
	}
}
