using Newtonsoft.Json;
using System;

namespace SejmNet.Models.Queries
{
	/// <summary>
	/// Contains data used for searching for a specific act element (e.g. chapter, article, point).
	/// </summary>
	public sealed class ActElementSearchQuery
	{
		private readonly int _book;
		private readonly int _title;
		private readonly int _branch;
		private readonly int _chapter;
		private readonly int _subchapter;
		private readonly int _article;
		private readonly int _pass;
		private readonly int _paragraph;
		private readonly int _point;
		private readonly int _letter;

		/// <summary>
		/// Number of book to search for.
		/// </summary>
		/// <exception cref="ArgumentOutOfRangeException">Value is less than <c>0</c>.</exception>
		[JsonProperty("book")]
		public int Book
		{
			get => _book;
			init
			{
				Validation.ValidateLessThan(value, 0, nameof(Book));

				_book = value;
			}
		}

		/// <summary>
		/// Number of title to search for.
		/// </summary>
		/// <exception cref="ArgumentOutOfRangeException">Value is less than <c>0</c>.</exception>
		[JsonProperty("title")]
		public int Title
		{
			get => _title;
			init
			{
				Validation.ValidateLessThan(value, 0, nameof(Title));

				_title = value;
			}
		}

		/// <summary>
		/// Number of branch to search for.
		/// </summary>
		/// <exception cref="ArgumentOutOfRangeException">Value is less than <c>0</c>.</exception>
		[JsonProperty("branch")]
		public int Branch
		{
			get => _branch;
			init
			{
				Validation.ValidateLessThan(value, 0, nameof(Branch));

				_branch = value;
			}
		}

		/// <summary>
		/// Number of chapter to search for.
		/// </summary>
		/// <exception cref="ArgumentOutOfRangeException">Value is less than <c>0</c>.</exception>
		[JsonProperty("chapter")]
		public int Chapter
		{
			get => _chapter;
			init
			{
				Validation.ValidateLessThan(value, 0, nameof(Chapter));

				_chapter = value;
			}
		}

		/// <summary>
		/// Number of subchapter to search for.
		/// </summary>
		/// <exception cref="ArgumentOutOfRangeException">Value is less than <c>0</c>.</exception>
		[JsonProperty("subchapter")]
		public int Subchapter
		{
			get => _subchapter;
			init
			{
				Validation.ValidateLessThan(value, 0, nameof(Subchapter));

				_subchapter = value;
			}
		}

		/// <summary>
		/// Number of article to search for.
		/// </summary>
		/// <exception cref="ArgumentOutOfRangeException">Value is less than <c>0</c>.</exception>
		[JsonProperty("article")]
		public int Article
		{
			get => _article;
			init
			{
				Validation.ValidateLessThan(value, 0, nameof(Article));

				_article = value;
			}
		}

		/// <summary>
		/// Number of pass to search for.
		/// </summary>
		/// <exception cref="ArgumentOutOfRangeException">Value is less than <c>0</c>.</exception>
		[JsonProperty("pass")]
		public int Pass
		{
			get => _pass;
			init
			{
				Validation.ValidateLessThan(value, 0, nameof(Pass));

				_pass = value;
			}
		}

		/// <summary>
		/// Number of paragraph to search for.
		/// </summary>
		/// <exception cref="ArgumentOutOfRangeException">Value is less than <c>0</c>.</exception>
		[JsonProperty("paragraph")]
		public int Paragraph
		{
			get => _paragraph;
			init
			{
				Validation.ValidateLessThan(value, 0, nameof(Paragraph));

				_paragraph = value;
			}
		}

		/// <summary>
		/// Number of point to search for.
		/// </summary>
		/// <exception cref="ArgumentOutOfRangeException">Value is less than <c>0</c>.</exception>
		[JsonProperty("point")]
		public int Point
		{
			get => _point;
			init
			{
				Validation.ValidateLessThan(value, 0, nameof(Point));

				_point = value;
			}
		}

		/// <summary>
		/// Number of letter to search for.
		/// </summary>
		/// <exception cref="ArgumentOutOfRangeException">Value is less than <c>0</c>.</exception>
		[JsonProperty("letter")]
		public int Letter
		{
			get => _letter;
			init
			{
				Validation.ValidateLessThan(value, 0, nameof(Letter));

				_letter = value;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ActElementSearchQuery"/> class.
		/// </summary>
		public ActElementSearchQuery()
		{
		}
	}
}
