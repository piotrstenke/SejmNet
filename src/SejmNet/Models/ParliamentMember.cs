using Newtonsoft.Json;
using System;

namespace SejmNet.Models
{
	/// <summary>
	/// Contains information about a member of the Polish parliament (Sejm).
	/// </summary>
	public sealed class ParliamentMember
	{
		/// <summary>
		/// ID of the member.
		/// </summary>
		[JsonProperty("id")]
		public required int Id { get; init; }

		/// <summary>
		/// Determines whether the member is active.
		/// </summary>
		[JsonProperty("active")]
		public bool Active { get; init; }

		/// <summary>
		/// Club the member belongs to.
		/// </summary>
		[JsonProperty("club")]
		public required string Club { get; init; }

		/// <summary>
		/// Name of district the member was elected in.
		/// </summary>
		[JsonProperty("districtName")]
		public required string DistrcictName { get; init; }

		/// <summary>
		/// Id of district the member was elected in. 
		/// </summary>
		[JsonProperty("districtNum")]
		public required int DistrictId { get; init; }

		/// <summary>
		/// Education level of the member.
		/// </summary>
		[JsonProperty("educationLevel")]
		public required string EducationLevel { get; init; }

		/// <summary>
		/// E-mail address of the member.
		/// </summary>
		[JsonProperty("email")]
		public required string Email { get; init; }

		/// <summary>
		/// Date of birth.
		/// </summary>
		[JsonProperty("birthDate")]
		public required DateTime BirthDate { get; init; }

		/// <summary>
		/// Place of birth.
		/// </summary>
		[JsonProperty("birthLocation")]
		public required string BirthPlace { get; init; }

		/// <summary>
		/// First name of the member.
		/// </summary>
		[JsonProperty("firstName")]
		public required string FirstName { get; init; }

		/// <summary>
		/// Last name of the member.
		/// </summary>
		[JsonProperty("lastName")]
		public required string LastName { get; init; }

		/// <summary>
		/// Last and first name of the member.
		/// </summary>
		[JsonProperty("lastFirstName")]
		public required string LastFirstName { get; init; }

		/// <summary>
		/// First and last name of the member.
		/// </summary>
		[JsonProperty("firstLastName")]
		public required string FirstLastName { get; init; }

		/// <summary>
		/// Second name of the member.
		/// </summary>
		[JsonProperty("secondName")]
		public string? SecondName { get; init; }

		/// <summary>
		/// Profession of the member.
		/// </summary>
		[JsonProperty("profession")]
		public required string Profession { get; init; }

		/// <summary>
		/// Voivodeship where the member was elected.
		/// </summary>
		[JsonProperty("voivodeship")]
		public required string Voivodeship { get; init; }

		/// <summary>
		/// Number of votes the member got.
		/// </summary>
		[JsonProperty("numberOfVotes")]
		public required int NumberOfVotes { get; init; }

		/// <summary>
		/// Reason why the member became inactive.
		/// </summary>
		[JsonProperty("inactiveCause")]
		public string? InactiveCause { get; init; }

		/// <summary>
		/// Reason why the member has recounced his/her mandate. 
		/// </summary>
		[JsonProperty("waiverDesc")]
		public string? WaiverDescription { get; init; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ParliamentMember"/> class.
		/// </summary>
		public ParliamentMember()
		{
		}
	}
}
