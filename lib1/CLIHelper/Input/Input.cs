namespace CLIHelper;

public class Input
    : IInput
{
	public string? ReadLine() =>
		Console.ReadLine();
}