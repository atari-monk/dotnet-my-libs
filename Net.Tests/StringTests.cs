using Xunit;

namespace Net.Tests;

public class StringTests
{
	[Theory]
	[InlineData(null, true)]
	[InlineData("", true)]
	[InlineData(" ", true)]
	[InlineData("  ", true)]
	[InlineData("   ", true)]
	[InlineData("    ", true)]
	[InlineData("	", true)]
	[InlineData("a", false)]
	public void IsNullOrWhiteSpace_logic(string value, bool expected)
	{
		Assert.Equal(expected, string.IsNullOrWhiteSpace(value));
	}

	[Fact]
	public void Split_result_where_nothing_to_split()
	{
		var split = "log".Split(" ");
		Assert.True(split.Length == 1 && "log" == split[0]);
	}
}