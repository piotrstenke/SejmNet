using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace SejmNet.Models
{
	/// <summary>
	/// Defines all possible video types.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum VideoType
	{
		/// <summary>
		/// Not a video.
		/// </summary>
		[EnumMember(Value = "none")]
		None = 0,

		/// <summary>
		/// Committee.
		/// </summary>
		[EnumMember(Value = "komisja")]
		Committee = 1,

		/// <summary>
		/// Subcommittee.
		/// </summary>
		[EnumMember(Value = "podkomisja")]
		Subcommittee = 2,

		/// <summary>
		/// Sitting.
		/// </summary>
		[EnumMember(Value = "posiedzenie")]
		Sitting = 3,

		/// <summary>
		/// Press conference.
		/// </summary>
		[EnumMember(Value = "posiedzenie")]
		Conference = 4,

		// 'Other' should be the last member in this enum.
		// There's a possibility that more video types will be added in the future,
		// so it's better to just give 'Other' the largest possible value.

		/// <summary>
		/// Other.
		/// </summary>
		[EnumMember(Value = "inne")]
		Other = int.MaxValue,
	}
}
