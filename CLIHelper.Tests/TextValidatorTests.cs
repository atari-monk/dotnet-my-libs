using Xunit;

namespace CLIHelper.Tests;

public class TextValidatorTests
{
	[Theory]
	[InlineData("abcd", true)]
	[InlineData("1234", true)]
	[InlineData(@"-/?<!{}[]/\", true)]
	public void Valid_text_input_check(string input, bool expected)
	{
		var validator = new TextRequiredValidator();

		var actual = validator.Validate(input);

		Assert.Equal(expected, actual);
	}

	[Theory]
	[InlineData(null, false)]
	[InlineData("", false)]
	[InlineData(" ", false)]
	[InlineData("	", false)]
	[InlineData("      ", false)]
	[InlineData("			       ", false)]
	public void Invalid_text_input_check(string input, bool expected)
	{
		var validator = new TextRequiredValidator();

		var actual = validator.Validate(input);

		Assert.Equal(expected, actual);
	}
}