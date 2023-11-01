using Newtonsoft.Json;

namespace SejmNet.Models
{
	/// <summary>
	/// Determines how to compare data upon returning it to the caller.
	/// </summary>
	public sealed class ResultComparator
	{
		/// <summary>
		/// Column to compare by.
		/// </summary>
		[JsonProperty("column")]
		public string? Column { get; init; }

		/// <summary>
		/// Direction of the sort algorithm.
		/// </summary>
		[JsonProperty("dir")]
		public string? Direction { get; set; }	

		/// <summary>
		/// Initializes a new instance of the <see cref="ResultComparator"/> class.
		/// </summary>
		public ResultComparator()
		{
		}
	}
}
