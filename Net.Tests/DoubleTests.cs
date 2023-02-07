using System.Globalization;
using System.Threading;
using Xunit;

namespace Net.Tests;

public class DoubleTests
{
	[Theory]
	[InlineData("pl", "0,1", 0.1)]
	[InlineData("en", "0.1", 0.1)]
	public void Prase_to_double(string cultureName, string number, double expected)
	{
		var cultureInfo = CultureInfo.CreateSpecificCulture(cultureName);
		Thread.CurrentThread.CurrentCulture = cultureInfo;
		Thread.CurrentThread.CurrentUICulture = cultureInfo;

		double.TryParse(number, NumberStyles.Any, cultureInfo, out double actual);

		Assert.Equal(expected, actual);
	}
}