using Newtonsoft.Json;
using System;

namespace SejmNet.Models
{
	/// <summary>
	/// Contains information about a parliament proceeding.
	/// </summary>
	public sealed class Proceeding
	{
		/// <summary>
		/// Title of the proceeding.
		/// </summary>
		[JsonProperty("title")]
		public required string Title { get; init; }

		/// <summary>
		/// Dates the proceeding was held at.
		/// </summary>
		[JsonProperty("dates")]
		public required DateTime[] Dates { get; init; }

		/// <summary>
		/// Number associated with the proceeding.
		/// </summary>
		[JsonProperty("number")]
		public required int Number { get; init; }

		/// <summary>
		/// Initializes a new instance of the <see cref="Proceeding"/> class.
		/// </summary>
		public Proceeding()
		{
		}
	}
}
