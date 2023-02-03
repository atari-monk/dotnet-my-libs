namespace CLIHelper;

public interface IOutput
{
	void WriteLine(string? text);

	void Write(string? text);

	void Clear();

	void Log(string? text);
}