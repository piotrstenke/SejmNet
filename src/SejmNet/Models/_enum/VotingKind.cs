using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace SejmNet.Models
{
	/// <summary>
	/// Defines all possible kinds of votings.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum VotingKind
	{
		/// <summary>
		/// No voting kind.
		/// </summary>
		[EnumMember(Value = "NONE")]
		None = 0,

		/// <summary>
		/// Electronic voting.
		/// </summary>
		[EnumMember(Value = "ELECTRONIC")]
		Electronic = 1,

		/// <summary>
		/// Traditional voting.
		/// </summary>
		[EnumMember(Value = "TRADITIONAL")]
		Traditional = 2,

		/// <summary>
		/// On list voting.
		/// </summary>
		[EnumMember(Value = "ON_LIST")]
		OnList = 3,
	}
}
