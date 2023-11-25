using SejmNet.Models;
using SejmNet.Models.Queries;
using System;

// --- Actions, that seem broken and don't work properly:
//
// GET /sejm/term{term}/prints - GetPrints() - EXTREMALY low performance, the 'sort_by' parameter doesn't seem to work.
//

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

		/// <summary>
		/// Returns a collection of interpellations that match the specified <paramref name="query"/>.
		/// </summary>
		/// <param name="term">Number of term to search for.</param>
		/// <param name="query">Query to search by.</param>
		/// <remarks><b>NOTE:</b> By default, only <c>50</c> interpellations are returned.</remarks>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="term"/> is less than <c>1</c>.</exception>
		Interpellation[] GetInterpellations(int term, InterpellationSearchQuery? query = null);

		/// <summary>
		/// Returns an interpellation identified by the specified <paramref name="number"/>.
		/// </summary>
		/// <param name="term">Number of term to search for.</param>
		/// <param name="number">Number of interpellation to search for.</param>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="term"/> is less than <c>1</c>. -or-
		/// <paramref name="number"/> is less than <c>1</c>.</exception>
		Interpellation? GetInterpellation(int term, int number);

		/// <summary>
		/// Returns an interpellation identified by the specified <paramref name="number"/> in form of HTML text.
		/// </summary>
		/// <param name="term">Number of term to search for.</param>
		/// <param name="number">Number of interpellation to search for.</param>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="term"/> is less than <c>1</c>. -or-
		/// <paramref name="number"/> is less than <c>1</c>.</exception>
		string GetInterpellationHtml(int term, int number);

		/// <summary>
		/// Returns a reply to an interpellation identified by the specified <paramref name="number"/> and <paramref name="key"/> in form of HTML text.
		/// </summary>
		/// <param name="term">Number of term to search for.</param>
		/// <param name="number">Number of interpellation to search for.</param>
		/// <param name="key">Key of interpellation reply to search for.</param>
		/// <exception cref="ArgumentException"><paramref name="key"/> is <see langword="null"/> or empty.</exception>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="term"/> is less than <c>1</c>. -or-
		/// <paramref name="number"/> is less than <c>1</c>.</exception>
		string GetInterpellationReplyHtml(int term, int number, string key);

		/// <summary>
		/// Returns a collection of all prints published during the specified <paramref name="term"/>.
		/// </summary>
		/// <param name="term">Number of term to search for.</param>
		/// <remarks><b>NOTE:</b> This method uses the <c>/prints</c> endpoint, which can be EXTREMALY slow. Using it can have serious performance consequences.</remarks>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="term"/> is less than <c>1</c>.</exception>
		Print[] GetPrints(int term);

		/// <summary>
		/// Returns a print identified by the specified <paramref name="number"/>.
		/// </summary>
		/// <param name="term">Number of term to search for.</param>
		/// <param name="number">Number of print to search for.</param>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="term"/> is less than <c>1</c>.</exception>
		/// <exception cref="ArgumentException"><paramref name="number"/> is <see langword="null"/> or empty.</exception>
		Print? GetPrint(int term, string number);

		/// <summary>
		/// Returns contents of a file with the given <paramref name="fileName"/> attached to a print identified by the specified <paramref name="number"/>.
		/// </summary>
		/// <param name="term">Number of term to search for.</param>
		/// <param name="number">Number of print to search for.</param>
		/// <param name="fileName">Name of file to return the contents of.</param>
		/// <exception cref="ArgumentException"><paramref name="fileName"/> is <see langword="null"/> or empty. -or- <paramref name="number"/> is <see langword="null"/> or empty.</exception>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="term"/> is less than <c>1</c>.</exception>
		byte[] GetPrintAttachmentContent(int term, string number, string fileName);

		/// <summary>
		/// Returns a collection of all proceedings held during the specified <paramref name="term"/>.
		/// </summary>
		/// <param name="term">Number of term to search for.</param>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="term"/> is less than <c>1</c>.</exception>
		Proceeding[] GetProceedings(int term);

		/// <summary>
		/// Returns a proceeding identified by the specified <paramref name="number"/>.
		/// </summary>
		/// <param name="term">Number of term to search for.</param>
		/// <param name="number">Number of proceeding to search for.</param>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="term"/> is less than <c>1</c>. -or-
		/// <paramref name="number"/> is less than <c>1</c>.</exception>
		Proceeding? GetProceeding(int term, int number);

		/// <summary>
		/// Returns a collection of all legislative processes that took part during the specified <paramref name="term"/>.
		/// </summary>
		/// <param name="term">Number of term to search for.</param>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="term"/> is less than <c>1</c>.</exception>
		LegislativeProcessHeader[] GetProcesses(int term);

		/// <summary>
		/// Returns information about legislative process of a print with the specified <paramref name="printNumber"/>.
		/// </summary>
		/// <param name="term">Number of term to search for.</param>
		/// <param name="printNumber">Number of print to search for.</param>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="term"/> is less than <c>1</c>.</exception>
		/// <exception cref="ArgumentException"><paramref name="printNumber"/> is <see langword="null"/> or empty.</exception>
		LegislativeProcess? GetProcess(int term, string printNumber);

		/// <summary>
		/// Returns information about all votings that took place during the specified <paramref name="sitting"/>.
		/// </summary>
		/// <param name="term">Number of term to search for.</param>
		/// <param name="sitting">Number of sitting to search for.</param>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="term"/> is less than <c>1</c>. -or-
		/// <paramref name="term"/> is less than <c>1</c>.</exception>
		Voting[] GetVotings(int term, int sitting);

		/// <summary>
		/// Returns a collection of video transmissions that match the specified <paramref name="query"/>.
		/// </summary>
		/// <param name="term">Number of term to search for.</param>
		/// <param name="query">Query to search by.</param>
		/// <remarks><b>NOTE:</b> By default, only <c>50</c> videos are returned.</remarks>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="term"/> is less than <c>1</c>.</exception>
		Video[] GetVideos(int term, VideoSearchQuery? query = null);

		/// <summary>
		/// Returns a collection of video transmissions that start today.
		/// </summary>
		/// <param name="term">Number of term to search for.</param>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="term"/> is less than <c>1</c>.</exception>
		Video[] GetVideosForToday(int term);
	}
}
