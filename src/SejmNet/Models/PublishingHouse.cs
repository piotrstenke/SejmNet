using Newtonsoft.Json;

namespace SejmNet.Models
{
	/// <summary>
	/// Information about a publisher of legal acts.
	/// </summary>
	public sealed class PublishingHouse
	{
		/// <summary>
		/// Unique identifier of the publisher.
		/// </summary>
		[JsonProperty("code")]
		public required string Code { get; init; }

		/// <summary>
		/// Short name used to designate an act.
		/// </summary>
		[JsonProperty("shortName")]
		public required string ShortName { get; init; }

		/// <summary>
		/// Full name of the publisher.
		/// </summary>
		[JsonProperty("name")]
		public required string Name { get; init; }

		/// <summary>
		/// Number of acts published by this publisher.
		/// </summary>
		[JsonProperty("actsCount")]
		public required int ActsCount { get; init; }

		/// <summary>
		/// List of years for which there are acts published by this publisher.
		/// </summary>
		[JsonProperty("years")]
		public required int[] Years { get; init; }

		/// <summary>
		/// Initializes a new instance of the <see cref="PublishingHouse"/> class.
		/// </summary>
		public PublishingHouse()
		{
		}
	}
}
