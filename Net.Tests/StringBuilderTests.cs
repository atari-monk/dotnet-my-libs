using System.Text;
using Xunit;

namespace Net.Tests;

public class StringBuilderTests
{
	[Theory]
	[InlineData("print number: {0}", 10, "print number: 10")]
	public void TestAppendFormat(
        string format
        , int number
        , string expected)
	{
        var sut = new StringBuilder();

        var acctual = sut.AppendFormat(format, number).ToString();
		
        Assert.Equal(expected, acctual);
	}

    [Theory]
	[InlineData("print number: {0}, {1}, {2}", new object[] { 10, 20, 30 }, "print number: 10, 20, 30")]
	public void TestAppendFormatParams(
        string format
        , object[] numbers
        , string expected)
	{
        var sut = new StringBuilder();

        var acctual = sut.AppendFormat(format, numbers).ToString();
		
        Assert.Equal(expected, acctual);
	}
}