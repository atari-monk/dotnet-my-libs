using Xunit;

namespace Net.Tests;

public class CharTests
{
	[Theory]
	[InlineData('.', true)]
	[InlineData(':', true)]
	public void Test_IsPunctuation(
		char inputChar
		, bool isPunctuation)
	{
		Assert.Equal(isPunctuation, char.IsPunctuation(inputChar));
	}
}