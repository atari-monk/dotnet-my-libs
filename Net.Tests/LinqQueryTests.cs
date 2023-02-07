using System.Linq;
using Xunit;

namespace Net.Tests;

public class LinqQueryTests
{
	[Theory]
	[InlineData("0123a5678a0a", 'a', "4,9,11")]
	[InlineData(@"0123\5678\0\", '\\', "4,9,11")]
	public void Get_list_of_indexes_where_searched_char_is(
		string input
		, char searched
		, string expected)
	{
		var indexes = input
			.ToCharArray()
			.ToList()
			.Select((c, i) => new { c, i })
			.Where(a => a.c == searched)
			.Select(a => a.i)
			.ToList();

		var actual = string.Join(",", indexes.ToArray());

		Assert.Equal(expected, actual);
	}
}