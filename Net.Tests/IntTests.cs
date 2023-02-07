using Xunit;

namespace Net.Tests;

public class IntTests
{
	[Theory]
	[InlineData(9, 2, 4)]
	public void Int_division(int divided, int divider, int expectd)
	{
		var actual = divided / divider;

		Assert.Equal(expectd, actual);
	}
}