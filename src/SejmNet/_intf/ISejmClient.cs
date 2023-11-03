﻿using SejmNet.Models;
using System;

namespace SejmNet
{
	/// <summary>
	/// Provides access to the official API of the Parliament of Republic of Poland (Sejm).
	/// </summary>
	public interface ISejmClient : ISejmEliClient
	{
		/// <summary>
		/// Returns information about all terms, both current and past.
		/// </summary>
		Term[] GetTerms();

		/// <summary>
		/// Returns information about a term with the specified <paramref name="number"/>.
		/// </summary>
		/// <param name="number">Number of term to search for.</param>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="number"/> is less than <c>1</c>.</exception>
		Term? GetTerm(int number);

		/// <summary>
		/// Returns a collection of all parliament members of the specified <paramref name="term"/>, both active and inactive.
		/// </summary>
		/// <param name="term">Number of term to search for.</param>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="term"/> is less than <c>1</c>.</exception>
		ParliamentMember[] GetMembers(int term);

		/// <summary>
		/// Returns a parliament member with the specified <paramref name="id"/> of the given <paramref name="term"/>.
		/// </summary>
		/// <param name="term">Number of term to search for.</param>
		/// <param name="id">Id of parliament member to search for.</param>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="term"/> is less than <c>1</c>. -or- <paramref name="id"/> is less than <c>1</c>.</exception>
		ParliamentMember? GetMember(int term, int id);

		/// <summary>
		/// Returns a photo of a parliament member with the specified <paramref name="id"/> of the given <paramref name="term"/>.
		/// </summary>
		/// <param name="term">Number of term to search for.</param>
		/// <param name="id">Id of parliament member to search for.</param>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="term"/> is less than <c>1</c>. -or- <paramref name="id"/> is less than <c>1</c>.</exception>
		byte[] GetMemberPhoto(int term, int id);

		/// <summary>
		/// Returns a minimized photo of a parliament member with the specified <paramref name="id"/> of the given <paramref name="term"/>.
		/// </summary>
		/// <param name="term">Number of term to search for.</param>
		/// <param name="id">Id of parliament member to search for.</param>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="term"/> is less than <c>1</c>. -or- <paramref name="id"/> is less than <c>1</c>.</exception>
		byte[] GetMemberPhotoMini(int term, int id);

		/// <summary>
		/// Returns a collection of all parliamentary clubs in the specified <paramref name="term"/>.
		/// </summary>
		/// <param name="term">Number of term to search for.</param>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="term"/> is less than <c>1</c>.</exception>
		Club[] GetClubs(int term);

		/// <summary>
		/// Returns a parliamentary club with the specified <paramref name="id"/> of the given <paramref name="term"/>.
		/// </summary>
		/// <param name="term">Number of term to search for.</param>
		/// <param name="id">Id of club to search for.</param>
		/// <exception cref="ArgumentException"><paramref name="id"/> is <see langword="null"/> or empty.</exception>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="term"/> is less than <c>1</c>.</exception>
		Club? GetClub(int term, string id);

		/// <summary>
		/// Returns a logo of a parliamentary club with the specified <paramref name="id"/> of the given <paramref name="term"/>.
		/// </summary>
		/// <param name="term">Number of term to search for.</param>
		/// <param name="id">Id of club to search for.</param>
		/// <exception cref="ArgumentException"><paramref name="id"/> is <see langword="null"/> or empty.</exception>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="term"/> is less than <c>1</c>.</exception>
		byte[] GetClubLogo(int term, string id);

		/// <summary>
		/// Returns a collection of all parliamentary committees in the specified <paramref name="term"/>.
		/// </summary>
		/// <param name="term">Number of term to search for.</param>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="term"/> is less than <c>1</c>.</exception>
		Committee[] GetCommittees(int term);

		/// <summary>
		/// Returns a parliamentary committee with the specified <paramref name="code"/> of the given <paramref name="term"/>.
		/// </summary>
		/// <param name="term">Number of term to search for.</param>
		/// <param name="code">Code of committee to search for.</param>
		/// <exception cref="ArgumentException"><paramref name="code"/> is <see langword="null"/> or empty.</exception>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="term"/> is less than <c>1</c>.</exception>
		Committee? GetCommittee(int term, string code);
	}
}