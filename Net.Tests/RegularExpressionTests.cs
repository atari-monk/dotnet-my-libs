using System;
using System.Text.RegularExpressions;
using Xunit;

namespace Net.Tests;

public class RegularExpressionTests
{
	[Theory]
	[InlineData(2021, 8, 29, 15, 6, 10
		, @"^(\d{4})-(\d{2})-(\d{2}) (\d{2}):(\d{2}):(\d{2})$"
		, "yyyy-MM-dd HH:mm:ss")]//"2021-08-29 15:06:10"
	[InlineData(2021, 12, 23, 21, 20, 0
		, @"^([0]?[0-9]|[12][0-9]|[3][01])[..-]([0]?[1-9]|[1][0-2])[..-]([0-9]{4}|[0-9]{2}) ([0-1]?[0-9]|2[0-3]):([0-5][0-9])$"
		, "dd.MM.yyyy HH:mm")]//"23.12.2021 21:20"
	[InlineData(2021, 12, 23, 0, 0, 0
		, @"^([0]?[0-9]|[12][0-9]|[3][01])[..-]([0]?[1-9]|[1][0-2])[..-]([0-9]{4}|[0-9]{2}) ([0-1]?[0-9]|2[0-3]):([0-5][0-9])$|^([0]?[0-9]|[12][0-9]|[3][01])[..-]([0]?[1-9]|[1][0-2])[..-]([0-9]{4}|[0-9]{2})$"
		, "dd.MM.yyyy")]//"23.12.2021"
	[InlineData(2021, 12, 23, 22, 22, 0
		, @"^([0]?[0-9]|[12][0-9]|[3][01])[..-]([0]?[1-9]|[1][0-2])[..-]([0-9]{4}|[0-9]{2}) ([0-1]?[0-9]|2[0-3]):([0-5][0-9])$|^([0]?[0-9]|[12][0-9]|[3][01])[..-]([0]?[1-9]|[1][0-2])[..-]([0-9]{4}|[0-9]{2})$"
		, "dd.MM.yyyy HH:mm")]//"23.12.2021 22:22"
	public void Match_Regex_With_Date(
		int year
		, int month
		, int day
		, int hour
		, int minute
		, int second
		, string regexString
		, string dateFormat)
	{
		var date = new DateTime(year, month, day, hour, minute, second).ToString(dateFormat);
		var regex = new Regex(regexString);
		
		var match = regex.Match(date);

		Assert.True(match.Success);
	}
}