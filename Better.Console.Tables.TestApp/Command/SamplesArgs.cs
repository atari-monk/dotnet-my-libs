using CommandDotNet;

namespace Better.Console.Tables.TestApp;

public class SamplesArgs
    : IArgumentModel
{
    public string GetKey()
    {
        return nameof(TablesPrintout);
    }
}