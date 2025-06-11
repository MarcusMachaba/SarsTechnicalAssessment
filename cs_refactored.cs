using System;
using System.Linq;

namespace Sars.Risk;

/// <summary>Utility methods for risk-rule token sequences.</summary>
public static class RiskExpressionHelper
{
    /// <summary>Reverses a space-delimited RPN string.</summary>
    /// <exception cref="ArgumentNullException"/>
    public static string ReverseTokens(string input)
    {
        ArgumentNullException.ThrowIfNull(input);

        return string.Join(
            ' ',
            input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse());
    }
}
