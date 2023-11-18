using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SejmNet.Models.Queries
{
	/// <summary>
	/// Field to sort the interpellations by.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum InterpellationSortField
	{
		/// <summary>
		/// Default sort order.
		/// </summary>
		Default = 0,

		/// <summary>
		/// Sort by <see cref="Interpellation.Number"/>.
		/// </summary>
		Number = 1,

		/// <summary>
		/// Sort by <see cref="Interpellation.SentDate"/>.
		/// </summary>
		SentDate = 2,

		/// <summary>
		/// Sort by <see cref="Interpellation.ReceiptDate"/>.
		/// </summary>
		ReceiptDate = 3,

		/// <summary>
		/// Sort by <see cref="Interpellation.LastModified"/>.
		/// </summary>
		LastModified = 4,
	}
}
