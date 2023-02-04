using CommandDotNet;

namespace Better.Console.Tables.TestApp;

[Command("test")]
public class AppCommands
{
    private readonly IDictionary<string, IExample> examples;

    public AppCommands(IDictionary<string, IExample> examples)
    {
        this.examples = examples;
    }

    [DefaultCommand()]
    public void DefaultCommand(SamplesArgs args)
    {
        examples[args.GetKey()].Run();
    }

    [Command("data")]
    public void Command(SamplesArgs args)
    {
        examples[args.GetKey()].Run();
    }
}