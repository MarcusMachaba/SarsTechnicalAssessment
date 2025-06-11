using SARS.RPN.Parser;

namespace SARS.RPN.Tests;

public class EvaluatorTests
{
    [Fact]
    public void Evaluates_Addition()
        => Assert.Equal(7m, Evaluator.Evaluate("3 4 +"));

    [Fact]
    public void Throws_On_Invalid_Rpn()
        => Assert.Throws<RpnParseException>(() => Evaluator.Evaluate("3 +"));
}