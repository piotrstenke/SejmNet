using Newtonsoft.Json;
using System;

namespace SejmNet.Models
{
	/// <summary>
	/// Contains full information about a print.
	/// </summary>
	public sealed class Print
	{
		/// <summary>
		/// Number of parliament term the print is associated with.
		/// </summary>
		[JsonProperty("term")]
		public required int Term { get; init; }

		/// <summary>
		/// Number associated with the print.
		/// </summary>
		[JsonProperty("number")]
		public required string Number { get; init; }
		
		/// <summary>
		/// List of associated prints.
		/// </summary>
		[JsonProperty("numberAssociated")]
		public string[]? AssociatedPrints { get; init; }

		/// <summary>
		/// Title of the print.
		/// </summary>
		[JsonProperty("title")]
		public required string Title { get; init; }

		/// <summary>
		/// Date of the document.
		/// </summary>
		[JsonProperty("documentDate")]
		public required DateTime DocumentDate { get; init; }

		/// <summary>
		/// Date the document was delivered at.
		/// </summary>
		[JsonProperty("deliveryDate")]
		public required DateTime DeliveryDate { get; init; }

		/// <summary>
		/// Date of last modification to the document.
		/// </summary>
		[JsonProperty("changeDate")]
		public required DateTime ChangeDate { get; init; }

		/// <summary>
		/// List of prints that started a legislative process associated with the print.
		/// </summary>
		[JsonProperty("processPrint")]
		public required string[] ProcessPrints { get; init; }

		/// <summary>
		/// List of file names attached to the document.
		/// </summary>
		[JsonProperty("attachments")]
		public required string[] Attachments { get; init; }

		/// <summary>
		/// List of additional prints associated with the print.
		/// </summary>
		[JsonProperty("additionalPrints")]
		public Print[]? AdditionalPrints { get; init; }

		/// <summary>
		/// Initializes a new instance of the <see cref="Print"/> class.
		/// </summary>
		public Print()
		{
		}
	}
}
