using SejmNet.Models;
using System;
using System.Collections.Generic;

// 
// --- Actions that are not included, because they are redundant:
//
// GET /eli
// 
// --- Actions, that seem broken and don't work properly:
//
// GET /eli/changes/acts
//

namespace SejmNet
{
	/// <summary>
	/// Provides access to the official API of the Parliament of Republic of Poland (Sejm) compliant with the European Legislation Identifier (ELI) system.
	/// </summary>
	public interface ISejmEliClient
	{
		/// <summary>
		/// Returns a collection of all legal act publishers.
		/// </summary>
		PublishingHouse[] GetPublishers();

		/// <summary>
		/// Returns a publisher with the specified <paramref name="publisherCode"/> or <see langword="null"/> if the publisher is not found.
		/// </summary>
		/// <param name="publisherCode">Unique identifier of the publisher.</param>
		/// <exception cref="ArgumentException"><paramref name="publisherCode"/> is <see langword="null"/> or empty.</exception>
		PublishingHouse? GetPublisher(string publisherCode);

		/// <summary>
		/// Return an act published by a subject with the specified <paramref name="publisherCode"/> in the given <paramref name="year"/> and at the given <paramref name="position"/>.
		/// </summary>
		/// <param name="publisherCode">Unique identifier of the publisher.</param>
		/// <param name="year">Year the acts where published in.</param>
		/// <param name="position">Position of the act.</param>
		/// <exception cref="ArgumentException"><paramref name="publisherCode"/> is <see langword="null"/> or empty.</exception>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="year"/> is less than <see cref="SejmClient.Constants.MinPublishYear"/> or greater than <see cref="SejmClient.Constants.MaxPublishYear"/>. -or-
		/// <paramref name="position"/> is less than <c>1</c>.</exception>
		Act? GetAct(string publisherCode, int year, int position);

		/// <summary>
		/// Return all references associated with an act published by the publisher with the specified <paramref name="publisherCode"/> in the given <paramref name="year"/> and at the given <paramref name="position"/>.
		/// </summary>
		/// <param name="publisherCode">Unique identifier of the publisher.</param>
		/// <param name="year">Year the acts where published in.</param>
		/// <param name="position">Position of the act.</param>
		/// <exception cref="ArgumentException"><paramref name="publisherCode"/> is <see langword="null"/> or empty.</exception>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="year"/> is less than <see cref="SejmClient.Constants.MinPublishYear"/> or greater than <see cref="SejmClient.Constants.MaxPublishYear"/>. -or-
		/// <paramref name="position"/> is less than <c>1</c>.</exception>v
		Dictionary<string, ActHeaderReference[]> GetActReferences(string publisherCode, int year, int position);

		/// <summary>
		/// Returns all acts published by a subject with the specified <paramref name="publisherCode"/> in the given <paramref name="year"/>.
		/// </summary>
		/// <param name="publisherCode">Unique identifier of the publisher.</param>
		/// <param name="year">Year the acts where published in.</param>
		/// <exception cref="ArgumentException"><paramref name="publisherCode"/> is <see langword="null"/> or empty.</exception>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="year"/> is less than <see cref="SejmClient.Constants.MinPublishYear"/> or greater than <see cref="SejmClient.Constants.MaxPublishYear"/>.</exception>
		ResultList<ActHeader, ActResultQuery> GetActs(string publisherCode, int year);

		/// <summary>
		/// Returns all acts published by a subject with the specified <paramref name="publisherCode"/> in the given <paramref name="year"/> and <paramref name="volume"/>.
		/// </summary>
		/// <param name="publisherCode">Unique identifier of the publisher.</param>
		/// <param name="year">Year the acts where published in.</param>
		/// <param name="volume">Volume associated with the act.</param>
		/// <exception cref="ArgumentException"><paramref name="publisherCode"/> is <see langword="null"/> or empty.</exception>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="year"/> is less than <see cref="SejmClient.Constants.MinPublishYear"/> or greater than <see cref="SejmClient.Constants.MaxPublishYear"/>. -or-
		/// <paramref name="volume"/> is less than <c>1</c>.</exception>
		ResultList<ActHeader, ActResultQuery> GetActs(string publisherCode, int year, int volume);

		/// <summary>
		/// Returns the structural contents of the legal act published by a subject with the specified <paramref name="publisherCode"/> in the given <paramref name="year"/> and at the given <paramref name="position"/>.
		/// </summary>
		/// <param name="publisherCode">Unique identifier of the publisher.</param>
		/// <param name="year">Year the acts where published in.</param>
		/// <param name="position">Position of the act.</param>
		/// <exception cref="ArgumentException"><paramref name="publisherCode"/> is <see langword="null"/> or empty.</exception>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="year"/> is less than <see cref="SejmClient.Constants.MinPublishYear"/> or greater than <see cref="SejmClient.Constants.MaxPublishYear"/>. -or-
		/// <paramref name="position"/> is less than <c>1</c>.</exception>
		ActElement[] GetActStructure(string publisherCode, int year, int position);

		/// <summary>
		/// Returns full contents of a legal act published by a subject with the specified <paramref name="publisherCode"/> in form of HTML text.
		/// </summary>
		/// <param name="publisherCode">Unique identifier of the publisher.</param>
		/// <param name="year">Year the acts where published in.</param>
		/// <param name="position">Position of the act.</param>
		/// <exception cref="ArgumentException"><paramref name="publisherCode"/> is <see langword="null"/> or empty.</exception>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="year"/> is less than <see cref="SejmClient.Constants.MinPublishYear"/> or greater than <see cref="SejmClient.Constants.MaxPublishYear"/>. -or-
		/// <paramref name="position"/> is less than <c>1</c>.</exception>
		string GetActHtml(string publisherCode, int year, int position);

		/// <summary>
		/// Returns a fragment of a legal act published by a subject with the specified <paramref name="publisherCode"/> in form of HTML text.
		/// </summary>
		/// <param name="publisherCode">Unique identifier of the publisher.</param>
		/// <param name="year">Year the acts where published in.</param>
		/// <param name="position">Position of the act.</param>
		/// <param name="query">Data to search the act fragment by.</param>
		/// <exception cref="ArgumentException"><paramref name="publisherCode"/> is <see langword="null"/> or empty.</exception>
		/// <exception cref="ArgumentNullException"><paramref name="query"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="year"/> is less than <see cref="SejmClient.Constants.MinPublishYear"/> or greater than <see cref="SejmClient.Constants.MaxPublishYear"/>. -or-
		/// <paramref name="position"/> is less than <c>1</c>.</exception>
		string GetActElementHtml(string publisherCode, int year, int position, ActElementQuery query);

		/// <summary>
		/// Returns full contents of a legal act published by a subject with the specified <paramref name="publisherCode"/> in form of a PDF file.
		/// </summary>
		/// <param name="publisherCode">Unique identifier of the publisher.</param>
		/// <param name="year">Year the acts where published in.</param>
		/// <param name="position">Position of the act.</param>
		/// <exception cref="ArgumentException"><paramref name="publisherCode"/> is <see langword="null"/> or empty.</exception>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="year"/> is less than <see cref="SejmClient.Constants.MinPublishYear"/> or greater than <see cref="SejmClient.Constants.MaxPublishYear"/>. -or-
		/// <paramref name="position"/> is less than <c>1</c>.</exception>
		byte[] GetActPdf(string publisherCode, int year, int position);

		/// <summary>
		/// Returns a fragment of a legal act published by a subject with the specified <paramref name="publisherCode"/> in form of a PDF file.
		/// </summary>
		/// <param name="publisherCode">Unique identifier of the publisher.</param>
		/// <param name="year">Year the acts where published in.</param>
		/// <param name="position">Position of the act.</param>
		/// <param name="textType">Type of the text. <para>Allowed values are: <c>[T, O, U, H, I]</c></para></param>
		/// <param name="fileName">Name of file to download.</param>
		/// <exception cref="ArgumentException"><paramref name="publisherCode"/> is <see langword="null"/> or empty. -or- <paramref name="fileName"/> is <see langword="null"/> or empty.</exception>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="year"/> is less than <see cref="SejmClient.Constants.MinPublishYear"/> or greater than <see cref="SejmClient.Constants.MaxPublishYear"/>. -or-
		/// <paramref name="position"/> is less than <c>1</c>.</exception>
		byte[] GetActElementPdf(string publisherCode, int year, int position, char textType, string fileName);

		/// <summary>
		/// Returns all volumes published by a subject with the specified <paramref name="publisherCode"/> in the given <paramref name="year"/>.
		/// </summary>
		/// <param name="publisherCode">Unique identifier of the publisher.</param>
		/// <param name="year">Year the volumes where published in.</param>
		/// <exception cref="ArgumentException"><paramref name="publisherCode"/> is <see langword="null"/> or empty.</exception>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="year"/> is less than <see cref="SejmClient.Constants.MinPublishYear"/> or greater than <see cref="SejmClient.Constants.MaxPublishYear"/>.</exception>
		int[] GetVolumes(string publisherCode, int year);

		/// <summary>
		/// Performs a search for acts that match the data specified in the <paramref name="query"/>.
		/// </summary>
		/// <param name="query">Query used to search for acts.</param>
		/// <exception cref="ArgumentNullException"><paramref name="query"/> is <see langword="null"/>.</exception>
		ResultList<Act, ActResultQuery> SearchActs(ActSearchQuery query);

		/// <summary>
		/// Returns all existing types of legal acts.
		/// </summary>
		string[] GetActTypes();

		/// <summary>
		/// Returns all possible statuses an act can have.
		/// </summary>
		string[] GetActStatuses();

		/// <summary>
		/// Returns all fragments of act titles containing the specified <paramref name="word"/>.
		/// </summary>
		/// <param name="word">Word to search the titles by.</param>
		/// <exception cref="ArgumentException"><paramref name="word"/> is <see langword="null"/> or empty.</exception>
		string[] GetActTitleFragments(string word);

		/// <summary>
		/// Returns all possible types of act references.
		/// </summary>
		string[] GetActReferenceTypes();

		/// <summary>
		/// Get all existing act keywords.
		/// </summary>
		string[] GetActKeywords();

		/// <summary>
		/// Get names of all legal act institutions.
		/// </summary>
		string[] GetInstitutions();
	}
}
