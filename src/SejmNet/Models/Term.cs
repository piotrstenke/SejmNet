using Newtonsoft.Json;
using System;

namespace SejmNet.Models
{
	/// <summary>
	/// Contains information about a specific term of the Polish parliament (Sejm).
	/// </summary>
	public sealed class Term
	{
		/// <summary>
		/// Number of the term.
		/// </summary>
		[JsonProperty("num")]
		public required int Number { get; init; }

		/// <summary>
		/// Start date of the term
		/// </summary>
		[JsonProperty("from")]
		public required DateTime StartDate { get; init; }

		/// <summary>
		/// End date of the term
		/// </summary>
		[JsonProperty("to")]
		public required DateTime EndDate { get; init; }

		/// <summary>
		/// Determines whether this is the current term.
		/// </summary>
		[JsonProperty("current")]
		public bool IsCurrent { get; init; }

		/// <summary>
		/// Information about prints of this term.
		/// </summary>
		[JsonProperty("prints")]
		public required PrintInfo Prints { get; init; }

		/// <summary>
		/// Initializes a new instance of the <see cref="Term"/> class.
		/// </summary>
		public Term()
		{
		}
	}
}
