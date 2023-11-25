using Newtonsoft.Json;
using System;

namespace SejmNet.Models
{
	/// <summary>
	/// Contains information about a video transimission.
	/// </summary>
	public sealed class Video
	{
		/// <summary>
		/// Unique ID of the transmission.
		/// </summary>
		[JsonProperty("unid")]
		public required string Id { get; init; }

		/// <summary>
		/// Description of the transmission.
		/// </summary>
		[JsonProperty("description")]
		public string? Description { get; init; }

		/// <summary>
		/// Link to the transmission.
		/// </summary>
		[JsonProperty("videoLink")]
		public required string Link { get; init; }

		/// <summary>
		/// Link to the messages of the transmission.
		/// </summary>
		[JsonProperty("videoMessagesLink")]
		public string? MessageLink { get; init; }

		/// <summary>
		/// Link to the transmission with sign language support.
		/// </summary>
		[JsonProperty("signLangLink")]
		public string? SignLanguageLink { get; init; }

		/// <summary>
		/// Link to audio file.
		/// </summary>
		[JsonProperty("audio")]
		public string? AudioLink { get; init; }

		/// <summary>
		/// Title of the transmission.
		/// </summary>
		[JsonProperty("title")]
		public required string Title { get; init; }

		/// <summary>
		/// Room where the transmission is taking place in parliament building.
		/// </summary>
		[JsonProperty("room")]
		public required string Room { get; init; }

		/// <summary>
		/// Starting date of the transmission.
		/// </summary>
		[JsonProperty("startDateTime")]
		public required DateTime StartDate { get; init; }

		/// <summary>
		/// Ending date of the transmission.
		/// </summary>
		[JsonProperty("endDateTime")]
		public DateTime? EndDate { get; init; }

		/// <summary>
		/// Type of the video transmission.
		/// </summary>
		[JsonProperty("type")]
		public required VideoType Type { get; init; }

		/// <summary>
		/// Determines whether this transmission has available transcription.
		/// </summary>
		[JsonProperty("transcribe")]
		public bool HasTranscription { get; init; }

		/// <summary>
		/// Comma-separated list of committee codes if this is a committee transmission (when <see cref="Type"/> == <see cref="VideoType.Committee"/>).
		/// </summary>
		[JsonProperty("committee")]
		public string? Committees { get; init; }

		/// <summary>
		/// Initializes a new instance of the <see cref="Video"/> class.
		/// </summary>
		public Video()
		{
		}
	}
}
