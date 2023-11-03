using Newtonsoft.Json;

namespace SejmNet.Models
{
	/// <summary>
	/// Contains information about text of an act.
	/// </summary>
	public sealed class ActText
	{
		/// <summary>
		/// Name of the act file.
		/// </summary>
		[JsonProperty("fileName")]
		public required string FileName { get; init; }

		/// <summary>
		/// Type of the text.
		/// </summary>
		/// <remarks>Allowed values are: <c>[T, O, U, H, I]</c></remarks>
		[JsonProperty("type")]
		public required char Type { get; init; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ActText"/> class.
		/// </summary>
		public ActText()
		{
		}
	}
}
