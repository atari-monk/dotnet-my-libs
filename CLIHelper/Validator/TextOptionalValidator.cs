namespace CLIHelper;

public class TextOptionalValidator : IValidator
{
	public bool Validate(string text)
	{
		return (text != null && text == string.Empty) || string.IsNullOrWhiteSpace(text) == false;
	}
}