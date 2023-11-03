using Newtonsoft.Json;
using System;

namespace SejmNet.Models
{
	/// <summary>
	/// Contains information about a parliamentary committee.
	/// </summary>
	public sealed class Committee
	{
		/// <summary>
		/// Unique code associated with the committee.
		/// </summary>
		[JsonProperty("code")]
		public required string Code { get; init; }

		/// <summary>
		/// Full name of the committee.
		/// </summary>
		[JsonProperty("name")]
		public required string Name { get; init; }

		/// <summary>
		/// Full name of the committee in genitive case.
		/// </summary>
		[JsonProperty("nameGenitive")]
		public required string NameGenitive { get; init; }

		/// <summary>
		/// Type of the committee.
		/// </summary>
		[JsonProperty("type")]
		public required CommitteeType Type { get; init; }

		/// <summary>
		/// Phone number(s) used by the committee.
		/// </summary>
		[JsonProperty("phone")]
		public required string Phone { get; init; }

		/// <summary>
		/// Description of the committee's objective.
		/// </summary>
		[JsonProperty("scope")]
		public required string Scope { get; init; }

		/// <summary>
		/// Date of first meeting of the committee.
		/// </summary>
		[JsonProperty("appointmentDate")]
		public required DateTime AppointmentDate { get; init; }

		/// <summary>
		/// Date all members of the committee were assembled at.
		/// </summary>
		[JsonProperty("compositionDate")]
		public required DateTime CompositionDate { get; init; }

		/// <summary>
		/// Members of the committee.
		/// </summary>
		[JsonProperty("members")]
		public required CommitteeMember[] Members { get; init; }

		/// <summary>
		/// Initializes a new instance of the <see cref="Committee"/> class.
		/// </summary>
		public Committee()
		{
		}
	}
}
