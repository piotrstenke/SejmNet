using Newtonsoft.Json;
using System;

namespace SejmNet.Models
{
	/// <summary>
	/// Represents an EU directive.
	/// </summary>
	public sealed class Directive
	{
		/// <summary>
		/// Unique identifier of the directive.
		/// </summary>
		[JsonProperty("address")]
		public required string Address { get; init; }

		/// <summary>
		/// Title of the directive.
		/// </summary>
		[JsonProperty("title")]
		public required string Title { get; init; }

		/// <summary>
		/// Date of the directive.
		/// </summary>
		[JsonProperty("date")]
		public required DateTime Date { get; init; }

		/// <summary>
		/// Initializes a new instance of the <see cref="Directive"/> class.
		/// </summary>
		public Directive()
		{
		}
	}
}
