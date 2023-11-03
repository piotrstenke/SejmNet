using System;
using System.Runtime.CompilerServices;
using static SejmNet.SejmClient;

namespace SejmNet
{
	internal static class Validation
	{
		internal static void ValidateLessThan(int value, int target, [CallerArgumentExpression(nameof(value))] string? paramName = default)
		{
			if (value < target)
			{
				throw new ArgumentOutOfRangeException(paramName, value, $"Value is less than {target}");
			}
		}

		internal static void ValidatePublishYear(int year, [CallerArgumentExpression(nameof(year))] string? parameterName = default)
		{
			if (year < Constants.MinPublishYear || year > Constants.MaxPublishYear)
			{
				throw new ArgumentOutOfRangeException(parameterName, year, $"Value is less than {Constants.MinPublishYear} or greater than {Constants.MaxPublishYear}");
			}
		}
	}
}
