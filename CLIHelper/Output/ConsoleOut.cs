namespace CLIHelper;

public class ConsoleOut 
	: IOutput
{
	public void WriteLine(string? text) =>
		Console.WriteLine(text);

	public void Write(string? text) =>
		Console.Write(text);

	public void Clear() =>
		Console.Clear();

    public void Log(string? text) =>
		Console.WriteLine($"--> {text}");
}