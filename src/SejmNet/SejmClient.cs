﻿using Newtonsoft.Json;
using SejmNet.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

namespace SejmNet
{
	/// <inheritdoc cref="ISejmClient"/>
	public sealed class SejmClient : ISejmClient
	{
		/// <summary>
		/// Contains various constants used by the client.
		/// </summary>
		public static class Constants
		{
			/// <summary>
			/// Default URL to the Sejm API.
			/// </summary>
			public const string ApiUrl = "https://api.sejm.gov.pl";

			/// <summary>
			/// Default request timeout in seconds.
			/// </summary>
			public const int DefaultTimeout = 60 * 5;

			/// <summary>
			/// If the specified publishing year is less than this value, an exception is thrown.
			/// </summary>
			public const int MinPublishYear = 1000;

			/// <summary>
			/// If the specified publishing year is greater than this value, an excepton is thrown.
			/// </summary>
			public const int MaxPublishYear = 9999;

			/// <summary>
			/// Maximal number of changed acts that can be returned by the API.
			/// </summary>
			public const int MaxChangedActs = 500;

			/// <summary>
			/// Date format used by the client.
			/// </summary>
			public const string DateFormat = "yyyy-MM-dd";
		}

		/// <summary>
		/// The <see cref="System.Net.Http.HttpClient"/> used to send requests to the API.
		/// </summary>
		public HttpClient HttpClient { get; }

		/// <summary>
		/// Initializes a new instance of the <see cref="SejmClient"/> class.
		/// </summary>
		public SejmClient() : this(Constants.ApiUrl)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="SejmClient"/> class.
		/// </summary>
		/// <param name="url">Url to the Sejm API.</param>
		/// <exception cref="ArgumentException"><paramref name="url"/> is <see langword="null"/> or empty.</exception>
		/// <exception cref="UriFormatException"><paramref name="url"/> is not a valid URI.</exception>
		public SejmClient(string url)
		{
			ArgumentException.ThrowIfNullOrEmpty(url);

			HttpClient = new HttpClient
			{
				BaseAddress = new Uri(url),
				Timeout = TimeSpan.FromSeconds(Constants.DefaultTimeout)
			};
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="SejmClient"/> class.
		/// </summary>
		/// <param name="client">The <see cref="System.Net.Http.HttpClient"/> used to send requests to the API.</param>
		/// <exception cref="ArgumentNullException"><paramref name="client"/> is <see langword="null"/>.</exception>
		public SejmClient(HttpClient client)
		{
			ArgumentNullException.ThrowIfNull(client);

			client.BaseAddress ??= new Uri(Constants.ApiUrl);

			HttpClient = client;
		}

		/// <inheritdoc/>
		public Term[] GetTerms()
		{
			return SendRequest_Array<Term>("sejm/term");
		}

		/// <inheritdoc/>
		public Term? GetTerm(int number)
		{
			Validation.ValidateLessThan(number, 1);

			Term? result = SendRequest<Term>($"sejm/term{number}");
			return result;
		}

		/// <inheritdoc/>
		public ParliamentMember[] GetMembers(int term)
		{
			Validation.ValidateLessThan(term, 1);

			ParliamentMember[] result = SendRequest_Array<ParliamentMember>($"sejm/term{term}/MP");
			return result;
		}

		/// <inheritdoc/>
		public ParliamentMember? GetMember(int term, int id)
		{
			Validation.ValidateLessThan(term, 1);
			Validation.ValidateLessThan(id, 1);

			ParliamentMember? result = SendRequest<ParliamentMember>($"sejm/term{term}/MP/{id}");
			return result;
		}

		/// <inheritdoc/>
		public byte[] GetMemberPhoto(int term, int id)
		{
			Validation.ValidateLessThan(term, 1);
			Validation.ValidateLessThan(id, 1);

			byte[] result = SendRequest_RawBytes($"sejm/term{term}/MP/{id}/photo");
			return result;
		}

		/// <inheritdoc/>
		public byte[] GetMemberPhotoMini(int term, int id)
		{
			Validation.ValidateLessThan(term, 1);
			Validation.ValidateLessThan(id, 1);

			byte[] result = SendRequest_RawBytes($"sejm/term{term}/MP/{id}/photo-mini");
			return result;
		}

		/// <inheritdoc/>
		public Club[] GetClubs(int term)
		{
			Validation.ValidateLessThan(term, 1);

			Club[] result = SendRequest_Array<Club>($"sejm/term{term}/clubs");
			return result;
		}

		/// <inheritdoc/>
		public Club? GetClub(int term, string id)
		{
			Validation.ValidateLessThan(term, 1);
			ArgumentException.ThrowIfNullOrEmpty(id);

			Club? result = SendRequest<Club>($"sejm/term{term}/clubs/{id}");
			return result;
		}

		/// <inheritdoc/>
		public byte[] GetClubLogo(int term, string id)
		{
			Validation.ValidateLessThan(term, 1);
			ArgumentException.ThrowIfNullOrEmpty(id);

			byte[] result = SendRequest_RawBytes($"sejm/term{term}/clubs/{id}/logo");
			return result;
		}

		/// <inheritdoc/>
		public Committee[] GetCommittees(int term)
		{
			Validation.ValidateLessThan(term, 1);

			Committee[] result = SendRequest_Array<Committee>($"sejm/term{term}/committees");
			return result;
		}

		/// <inheritdoc/>
		public Committee? GetCommittee(int term, string code)
		{
			Validation.ValidateLessThan(term, 1);
			ArgumentException.ThrowIfNullOrEmpty(code);

			Committee? result = SendRequest<Committee>($"sejm/term{term}/committees/{code}");
			return result;
		}

		/// <inheritdoc/>
		public PublishingHouse[] GetPublishers()
		{
			return SendRequest_Array<PublishingHouse>("eli/acts");
		}

		/// <inheritdoc/>
		public PublishingHouse? GetPublisher(string publisherCode)
		{
			ArgumentException.ThrowIfNullOrEmpty(publisherCode);

			string formattedCode = FormatPublisherCode(publisherCode);

			PublishingHouse? result = SendRequest<PublishingHouse>($"eli/acts/{formattedCode}");
			return result;
		}

		/// <inheritdoc/>
		public Act? GetAct(string publisherCode, int year, int position)
		{
			ValidateActInput(publisherCode, year, position);

			string formattedCode = FormatPublisherCode(publisherCode);

			Act? result = SendRequest<Act>($"eli/acts/{formattedCode}/{year}/{position}");
			return result;
		}

		/// <inheritdoc/>
		public Dictionary<string, ActHeaderReference[]> GetActReferences(string publisherCode, int year, int position)
		{
			ValidateActInput(publisherCode, year, position);

			string formattedCode = FormatPublisherCode(publisherCode);

			Dictionary<string, ActHeaderReference[]>? result = SendRequest<Dictionary<string, ActHeaderReference[]>>($"eli/acts/{formattedCode}/{year}/{position}/references");

			if (result is null)
			{
				return new();
			}

			return result;
		}

		/// <inheritdoc/>
		public ResultList<ActHeader, ActResultQuery> GetActs(string publisherCode, int year)
		{
			ArgumentException.ThrowIfNullOrEmpty(publisherCode);

			Validation.ValidatePublishYear(year);

			string formattedCode = FormatPublisherCode(publisherCode);

			ResultList<ActHeader, ActResultQuery>? result = SendRequest<ResultList<ActHeader, ActResultQuery>>($"eli/acts/{formattedCode}/{year}");

			if (result is null)
			{
				return new ResultList<ActHeader, ActResultQuery>()
				{
					Items = Array.Empty<ActHeader>(),
				};
			}

			return result;
		}

		/// <inheritdoc/>
		public ResultList<ActHeader, ActResultQuery> GetActs(string publisherCode, int year, int volume)
		{
			ArgumentException.ThrowIfNullOrEmpty(publisherCode);

			Validation.ValidatePublishYear(year);
			Validation.ValidateLessThan(volume, 1);

			string formattedCode = FormatPublisherCode(publisherCode);

			ResultList<ActHeader, ActResultQuery>? result = SendRequest<ResultList<ActHeader, ActResultQuery>>($"eli/acts/{formattedCode}/{year}/volumes/{volume}");

			if (result is null)
			{
				return new ResultList<ActHeader, ActResultQuery>()
				{
					Items = Array.Empty<ActHeader>(),
				};
			}

			return result;
		}

		/// <inheritdoc/>
		public ActElement[] GetActStructure(string publisherCode, int year, int position)
		{
			ValidateActInput(publisherCode, year, position);

			string formattedCode = FormatPublisherCode(publisherCode);

			ActElement[] result = SendRequest_Array<ActElement>($"eli/acts/{formattedCode}/{year}/{position}/struct");
			return result;
		}

		/// <inheritdoc/>
		public int[] GetVolumes(string publisherCode, int year)
		{
			ArgumentException.ThrowIfNullOrEmpty(publisherCode);

			Validation.ValidatePublishYear(year);

			string formattedCode = FormatPublisherCode(publisherCode);

			int[] result = SendRequest_Array<int>($"eli/acts/{formattedCode}/{year}/volumes");
			return result;
		}

		/// <inheritdoc/>
		public ResultList<Act, ActResultQuery> SearchActs(ActSearchQuery query)
		{
			ArgumentNullException.ThrowIfNull(query);

			string queryText = BuildSearchQuery(query);

			ResultList<Act, ActResultQuery>? result = SendRequest<ResultList<Act, ActResultQuery>>("eli/acts/search" + queryText);

			if (result is null)
			{
				return new ResultList<Act, ActResultQuery>()
				{
					Items = Array.Empty<Act>(),
				};
			}

			return result;
		}

		/// <inheritdoc/>
		public string GetActHtml(string publisherCode, int year, int position)
		{
			ValidateActInput(publisherCode, year, position);

			string formattedCode = FormatPublisherCode(publisherCode);

			string? content = SendRequest_RawText($"eli/acts/{formattedCode}/{year}/{position}/text.html");

			if (string.IsNullOrWhiteSpace(content))
			{
				return string.Empty;
			}

			return content;
		}

		/// <inheritdoc/>
		public string GetActElementHtml(string publisherCode, int year, int position, ActElementQuery query)
		{
			ArgumentNullException.ThrowIfNull(query);
			ValidateActInput(publisherCode, year, position);

			string queryText = BuildSearchQuery(query);

			if (string.IsNullOrEmpty(queryText))
			{
				return string.Empty;
			}

			string formattedCode = FormatPublisherCode(publisherCode);

			string? content = SendRequest_RawText($"eli/acts/{formattedCode}/{year}/{position}/text.html{queryText}");

			if (string.IsNullOrWhiteSpace(content))
			{
				return string.Empty;
			}

			return content;
		}

		/// <inheritdoc/>
		public byte[] GetActPdf(string publisherCode, int year, int position)
		{
			ValidateActInput(publisherCode, year, position);

			string formattedCode = FormatPublisherCode(publisherCode);

			byte[] content = SendRequest_RawBytes($"eli/acts/{formattedCode}/{year}/{position}/text.pdf");
			return content;
		}

		/// <inheritdoc/>
		public byte[] GetActElementPdf(string publisherCode, int year, int position, char textType, string fileName)
		{
			ValidateActInput(publisherCode, year, position);

			ArgumentException.ThrowIfNullOrEmpty(fileName);

			string formattedCode = FormatPublisherCode(publisherCode);

			byte[] content = SendRequest_RawBytes($"eli/acts/{formattedCode}/{year}/{position}/text/{textType}/{fileName}");
			return content;
		}

		/// <inheritdoc/>
		public string[] GetActTypes()
		{
			return SendRequest_Array<string>("eli/types");
		}

		/// <inheritdoc/>
		public string[] GetActStatuses()
		{
			return SendRequest_Array<string>("eli/statuses");
		}

		/// <inheritdoc/>
		public string[] GetActTitleFragments(string word)
		{
			ArgumentException.ThrowIfNullOrEmpty(word);

			return SendRequest_Array<string>($"eli/titles?q={word}");
		}

		/// <inheritdoc/>
		public string[] GetActReferenceTypes()
		{
			return SendRequest_Array<string>("eli/references");
		}

		/// <inheritdoc/>
		public string[] GetActKeywords()
		{
			return SendRequest_Array<string>("eli/keywords");
		}

		/// <inheritdoc/>
		public string[] GetInstitutions()
		{
			return SendRequest_Array<string>("eli/institutions");
		}

		private static void ValidateActInput(string publisherCode, int year, int position)
		{
			ArgumentException.ThrowIfNullOrEmpty(publisherCode);

			Validation.ValidatePublishYear(year);

			Validation.ValidateLessThan(position, 1);
		}

		private static string BuildSearchQuery(ActElementQuery query)
		{
			StringBuilder sb = new();

			TryAppend(query.Book, "book");
			TryAppend(query.Title, "titl");
			TryAppend(query.Branch, "bran");
			TryAppend(query.Chapter, "chpt");
			TryAppend(query.Subchapter, "schp");
			TryAppend(query.Article, "art");
			TryAppend(query.Pass, "pass");
			TryAppend(query.Paragraph, "para");
			TryAppend(query.Point, "pint");
			TryAppend(query.Letter, "lett");

			if (sb.Length == 0)
			{
				return string.Empty;
			}

			return sb.ToString();

			void TryAppend(int value, string parameter)
			{
				if (value > 0)
				{
					sb.Append($"/{parameter}={value}");
				}
			}
		}

		private static string BuildSearchQuery(ActSearchQuery query)
		{
			StringBuilder sb = new();
			sb.Append('?');

			AddDate("date", query.AnnouncementDate);
			AddDate("dateFrom", query.AnnouncementDateFrom);
			AddDate("dateTo", query.AnnouncementDateTo);
			AddDate("dateEffect", query.EffectDate);
			AddDate("dateEffectFrom", query.EffectDateFrom);
			AddDate("dateEffectTo", query.EffectDateTo);
			AddDate("pubDate", query.PromulgationDate);
			AddDate("pubDateFrom", query.PromulgationDateFrom);
			AddDate("pubDateTo", query.PromulgationDateTo);

			AddInt("limit", query.Limit);
			AddInt("offset", query.Offset);
			AddInt("offset", query.Position);
			AddInt("offset", query.Volume);
			AddInt("offset", query.Year);

			AddString("type", query.Type);
			AddString("title", query.Title);
			AddString("publisher", FormatPublisherCode(query.PublisherCode));

			if (query.InExile)
			{
				sb.Append("exile=E&");
			}

			if (query.InForceOnly)
			{
				sb.Append("inForce=1&");
			}

			if (query.Keywords is not null && query.Keywords.Length > 0)
			{
				string keywords = string.Join(',', query.Keywords.Where(k => !string.IsNullOrWhiteSpace(k)));
				sb.Append($"keyword={keywords}&");
			}

			if (sb[^1] is '&' or '?')
			{
				sb.Remove(sb.Length - 1, 1);
			}

			return sb.ToString();

			void AddDate(string parameterName, DateTime? date)
			{
				if (date.HasValue)
				{
					string formattedDate = FormatDate(date.Value);
					sb.Append($"{parameterName}={formattedDate}&");
				}
			}

			void AddInt(string parameterName, int value)
			{
				if (value > 0)
				{
					sb.Append($"{parameterName}={value}&");
				}
			}

			void AddString(string parameterName, string? value)
			{
				if (!string.IsNullOrWhiteSpace(value))
				{
					sb.Append($"{parameterName}={value}&");
				}
			}
		}

		[return: NotNullIfNotNull(nameof(publisherCode))]
		private static string? FormatPublisherCode(string? publisherCode)
		{
			if (publisherCode is null)
			{
				return null;
			}

			return publisherCode.ToUpper();
		}

		private static string FormatDate(DateTime date)
		{
			return date.ToString(Constants.DateFormat);
		}

		private byte[] SendRequest_RawBytes(string url)
		{
			HttpResponseMessage response = HttpClient.GetAsync(url).Result;

			if (!HandleStatusCode(response))
			{
				return Array.Empty<byte>();
			}

			byte[] content = response.Content.ReadAsByteArrayAsync().Result;
			return content;
		}

		private string? SendRequest_RawText(string url)
		{
			HttpResponseMessage response = HttpClient.GetAsync(url).Result;

			if (!HandleStatusCode(response))
			{
				return null;
			}

			string content = response.Content.ReadAsStringAsync().Result;
			return content;
		}

		private TResponse? SendRequest<TResponse>(string url) where TResponse : class
		{
			string? content = SendRequest_RawText(url);

			if (string.IsNullOrWhiteSpace(content))
			{
				return null;
			}

			TResponse result = JsonConvert.DeserializeObject<TResponse>(content)!;

			return result;
		}

		private TResponse[] SendRequest_Array<TResponse>(string url)
		{
			TResponse[]? array = SendRequest<TResponse[]>(url);

			if(array is null)
			{
				return Array.Empty<TResponse>();
			}

			return array;
		}

		private static bool HandleStatusCode(HttpResponseMessage response)
		{
			if(response.StatusCode is HttpStatusCode.OK)
			{
				return true;
			}

			if(response.StatusCode is HttpStatusCode.NotFound or HttpStatusCode.Forbidden)
			{
				return false;
			}

			response.EnsureSuccessStatusCode();
			return false;
		}
	}
}