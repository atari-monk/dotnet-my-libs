using System.Text.RegularExpressions;

namespace CLIHelper;

public class DateTimeValidator : IValidator
{
	private readonly Regex regex;

	public DateTimeValidator()
	{
		regex = new Regex(@"^(\d{2}).(\d{2}).(\d{4}) (\d{2}):(\d{2})$");
	}

	public bool Validate(string text)
	{
		return regex.Match(text).Success || text == string.Empty;
	}
}