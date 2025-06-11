namespace SARS.RPN.Parser;

/// <summary>
/// Transforms an RPN string into a fully‑parenthesised infix expression.
/// </summary>
public static class InfixConverter
{
    public static string ToInfix(string rpn)
    {
        var stack = new Stack<string>();

        foreach (var tok in RpnTokenizer.Tokenize(rpn))
        {
            switch (tok.Type)
            {
                case TokenType.Number:
                    stack.Push(tok.Lexeme);
                    break;
                case TokenType.Operator when stack.Count >= 2:
                    var right = stack.Pop();
                    var left = stack.Pop();
                    stack.Push($"({left} {tok.Lexeme} {right})");
                    break;
                default:
                    throw new RpnParseException("Malformed expression.");
            }
        }
        return stack.Count == 1
            ? stack.Pop()
            : throw new RpnParseException("Unbalanced expression.");
    }
}
