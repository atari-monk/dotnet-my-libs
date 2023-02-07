namespace GitPath.Lib;

public class SlashConverter
    : IConvert<string>
{
    public string Convert(string input)
    {
        return input.Replace('\\', '/');
    }
}