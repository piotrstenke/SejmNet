using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace SejmNet.Models
{
	/// <summary>
	/// Type of the linked web resource.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum LinkResourceType
	{
		/// <summary>
		/// No type specified.
		/// </summary>
		[EnumMember(Value ="none")]
		None = 0,

		/// <summary>
		/// Body of a resource in form of raw text.
		/// </summary>
		[EnumMember(Value = "body")]
		Body = 1,

		/// <summary>
		/// Body of a resource in form of a website.
		/// </summary>
		[EnumMember(Value = "web-body")]
		WebBody = 2,

		/// <summary>
		/// Description of a resource in form of a website.
		/// </summary>
		[EnumMember(Value = "web-description")]
		WebDescription = 3,
	}
}
