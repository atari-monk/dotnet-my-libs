using System;
using System.Globalization;
using System.Threading;
using Xunit;

namespace Net.Tests;

public class DateTimeTests
{
	[Theory]
	[InlineData("pl", "29/08/2021", 2021, 8, 29)]
	[InlineData("en", "2021-08-29", 2021, 8, 29)]
	public void Prase_to_dateTime_date(
		string cultureName
		, string text
		, int year
		, int month
		, int day)
	{
		var cultureInfo = CultureInfo.CreateSpecificCulture(cultureName);
		Thread.CurrentThread.CurrentCulture = cultureInfo;
		Thread.CurrentThread.CurrentUICulture = cultureInfo;

		var actual = DateTime.Parse(text);

		Assert.Equal(new DateTime(year, month, day), actual);
	}

	[Theory]
	[InlineData("pl", "29/08/2021 15:06:10", 2021, 8, 29, 15, 6, 10)]
	[InlineData("en", "2021-08-29 15:06:10", 2021, 8, 29, 15, 6, 10)]
	public void Prase_to_dateTime_date_time(
		string cultureName
		, string text
		, int year
		, int month
		, int day
		, int hour
		, int minute
		, int second)
	{
		var cultureInfo = CultureInfo.CreateSpecificCulture(cultureName);
		Thread.CurrentThread.CurrentCulture = cultureInfo;
		Thread.CurrentThread.CurrentUICulture = cultureInfo;

		var actual = DateTime.Parse(text);

		Assert.Equal(new DateTime(year, month, day, hour, minute, second), actual);
	}
}