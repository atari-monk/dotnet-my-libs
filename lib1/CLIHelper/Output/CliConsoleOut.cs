using CommandDotNet;

namespace CLIHelper;

public class CliConsoleOut 
	: IOutput
{
    private readonly IConsole console;

    public CliConsoleOut(IConsole console)
    {
        this.console = console;
    }

	public void WriteLine(string? text) =>
		console.WriteLine(text);

	public void Write(string? text) =>
		console.Write(text);

	public void Clear() =>
		console.Clear();

    public void Log(string? text) =>
		console.WriteLine($"--> {text}");
}