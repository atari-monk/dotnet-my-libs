using CommandDotNet.Examples.App;
using CommandDotNet.TestTools;
using FluentAssertions;
using Xunit;

namespace CommandDotNet.Examples.Tests;

public class StandardTests
{
	[Fact]
	public void Given2Numbers_Should_OutputSum()
	{
		var result = Program.AppRunner.RunInMem("Add 40 20");
		result.ExitCode.Should().Be(0);
		result.Console.AllText().Should().Be("60");
	}
}