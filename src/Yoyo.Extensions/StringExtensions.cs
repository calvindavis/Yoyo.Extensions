using System;

namespace Yoyo.Extensions
{
	public static class StringExtensions
	{
		/// <summary>
		/// Returns true if a string is null, empty, or contains only whitespace.
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		public static bool IsEmpty(this string s)
		{
			return string.IsNullOrWhiteSpace(s);
		}

		/// <summary>
		/// Returns true if a string is not null and contains at least one non-whitespace character.
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		public static bool IsNotEmpty(this string s)
		{
			return !s.IsEmpty();
		}

		/// <summary>
		/// Attemps to parse a string to an Enum.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="s"></param>
		/// <param name="ignoreCase"></param>
		/// <returns></returns>
		public static T ToEnum<T>(this string s, bool ignoreCase = true)
			where T : struct
		{
			var result = default(T);

			if (s.IsNotEmpty())
			{
				Enum.TryParse(s, ignoreCase, out result);
			}

			return result;
		}
	}
}