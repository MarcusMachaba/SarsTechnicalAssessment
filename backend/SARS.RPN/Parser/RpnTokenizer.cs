using System.Text.RegularExpressions;

namespace SARS.RPN.Parser;

/// <summary>
/// Splits an RPN string into a flat token stream.
/// </summary>
public static class RpnTokenizer
{
    private static readonly Regex _number = new(@"^\d+(\.\d+)?$", RegexOptions.Compiled);

    public static IEnumerable<Token> Tokenize(string input)
    {
        foreach (var part in input.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            if (_number.IsMatch(part))
                yield return new(TokenType.Number, part);
            else if ("+-*/".Contains(part))
                yield return new(TokenType.Operator, part);
            else
                throw new RpnParseException($"Invalid token '{part}'.");
        }
    }
}
