using SARS.RPN.Parser;

namespace SARS.RPN.Tests;

public class InfixConverterTests
{
    [Theory]
    [InlineData("3 4 +", "(3 + 4)")]
    [InlineData("3 4 5 * +", "(3 + (4 * 5))")]
    [InlineData("2.5 4.2 +", "(2.5 + 4.2)")]
    public void Converts_Valid_Rpn(string rpn, string expected)
        => Assert.Equal(expected, InfixConverter.ToInfix(rpn));

    [Theory]
    [InlineData("3 a +")]
    [InlineData("3 +")]
    public void Throws_On_Invalid_Rpn(string rpn)
        => Assert.Throws<RpnParseException>(() => InfixConverter.ToInfix(rpn));
}
