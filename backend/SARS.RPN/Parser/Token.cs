namespace SARS.RPN.Parser;

/// <summary>
/// Distinguishes numbers from operators while tokenising an RPN string.
/// </summary>
public enum TokenType { Number, Operator }

public sealed record Token(TokenType Type, string Lexeme);
