using System.Diagnostics;

namespace CLIHelper;

public class DebugOut 
	: IOutput
{
	public void WriteLine(string? text) =>
		Debug.WriteLine(text);

	public void Write(string? text) =>
		Debug.Write(text);

	public void Clear()
    {

    }

    public void Log(string? text) =>
		Debug.WriteLine($"--> {text}");
}