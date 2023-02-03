namespace CLIHelper;

public class TextRequiredValidator : IValidator
{
	public bool Validate(string text)
	{
		return string.IsNullOrWhiteSpace(text) == false;
	}
}