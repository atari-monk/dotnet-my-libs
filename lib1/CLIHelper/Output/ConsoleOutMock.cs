using System.Diagnostics;

namespace CLIHelper;

public class ConsoleOutMock 
    : OutMock
    , IOutput
{
    public void Write(string? text)
    {
        Buffer.Append(text);
        Debug.Write(text);
    }

    public void WriteLine(string? text)
    {
        Buffer.AppendLine(text);
        Debug.WriteLine(text);
    }

    public void Clear() => 
        Buffer.Clear();

    public void Log(string? text)
    {
        Buffer.AppendLine($"--> {text}");
        Debug.WriteLine($"--> {text}");
    }
}