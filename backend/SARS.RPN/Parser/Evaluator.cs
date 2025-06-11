namespace SARS.RPN.Parser;

/// <summary>
/// Evaluates an RPN expression to its numeric result.
/// </summary>
public static class Evaluator
{
    public static decimal Evaluate(string rpn)
    {
        var stack = new Stack<decimal>();
        foreach (var tok in RpnTokenizer.Tokenize(rpn))
        {
            if (tok.Type is TokenType.Number)
            {
                stack.Push(decimal.Parse(tok.Lexeme));
                continue;
            }

            if (stack.Count < 2)
                throw new RpnParseException("Malformed expression – insufficient operands.");

            var b = stack.Pop();
            var a = stack.Pop();
            stack.Push(tok.Lexeme switch
            {
                "+" => a + b,
                "-" => a - b,
                "*" => a * b,
                "/" => a / b,
                _ => throw new InvalidOperationException()
            });
        }
        return stack.Count == 1
            ? stack.Pop()
            : throw new RpnParseException("Unbalanced expression.");
    }
}
