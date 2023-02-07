namespace CommandDotNet.Examples.Lib;

[Command(
    Description = "Performs mathematical calculations",
    ExtendedHelpTextLines = new[]
    {
        "Include multiple lines of text",
        "Extended help of the root command is a good place to describe directives for the app"
    })]
public class Calculator
{
    [Command(
        Description = "Adds two numbers",
        UsageLines = new[]
        {
            "Add 1 2",
            "%AppName% %CmdPath% 1 2"
        },
        ExtendedHelpText = "single line of extended help here")]
    public void Add(
        IConsole console
        , [Operand(Description = "first value")] int value1
        , [Operand(Description = "second  value")] int value2) =>
            console.Write(value1 + value2);

    [Command(Description = "Subtracts two numbers")]
    public void Subtract(IConsole console, int value1, int value2) =>
        console.Write(value1 - value2);
}