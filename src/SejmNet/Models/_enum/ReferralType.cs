using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace SejmNet.Models
{
	/// <summary>
	/// Defines all possible types of referral.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ReferralType
	{
		/// <summary>
		/// Not a referral.
		/// </summary>
		[EnumMember(Value = "NONE")]
		None = 0,

		/// <summary>
		/// Normal referral.
		/// </summary>
		[EnumMember(Value = "NORMAL")]
		Normal = 1,

		/// <summary>
		/// Additional referral.
		/// </summary>
		[EnumMember(Value = "ADDITIONAL")]
		Additional = 2,

		/// <summary>
		/// Opinion referral.
		/// </summary>
		[EnumMember(Value = "OPINION")]
		Opinion = 3,

		/// <summary>
		/// Additional opinion referral.
		/// </summary>
		[EnumMember(Value = "ADDITIONAL_OPINION")]
		AdditionalOpinion = 4,

		/// <summary>
		/// Withdrawal of referrral.
		/// </summary>
		[EnumMember(Value = "WITHDRAWAL")]
		Withdrawal = 5,
	}
}
