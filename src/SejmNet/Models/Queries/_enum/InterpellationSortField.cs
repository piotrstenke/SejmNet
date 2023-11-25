using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

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
		[EnumMember(Value = "default")]
		Default = 0,

		/// <summary>
		/// Sort by <see cref="Interpellation.Number"/>.
		/// </summary>
		[EnumMember(Value = "num")]
		Number = 1,

		/// <summary>
		/// Sort by <see cref="Interpellation.SentDate"/>.
		/// </summary>
		[EnumMember(Value = "sentDate")]
		SentDate = 2,

		/// <summary>
		/// Sort by <see cref="Interpellation.ReceiptDate"/>.
		/// </summary>
		[EnumMember(Value = "receiptDate")]
		ReceiptDate = 3,

		/// <summary>
		/// Sort by <see cref="Interpellation.LastModified"/>.
		/// </summary>
		[EnumMember(Value = "lastModified")]
		LastModified = 4,
	}
}
