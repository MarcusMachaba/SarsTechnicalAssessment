using System.Runtime.Serialization;

namespace SARS.RPN.Parser;

/// <summary>
/// Represents a structural or lexical error in an RPN expression.
/// Thrown when an RPN expression contains an invalid token, insufficient operands, or any other structural error.
/// </summary>
[Serializable]                           
public sealed class RpnParseException : Exception
{
    public RpnParseException() { }
    public RpnParseException(string message) : base(message) { }
    public RpnParseException(string message, Exception inner) : base(message, inner) { }
    private RpnParseException(SerializationInfo info, StreamingContext context) : base(info, context) { }
}
