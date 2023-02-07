namespace GitPath.Lib;

public class GitPathConverter
    : IGitPath
{
    private readonly List<IConvert<string>> converters;

    public GitPathConverter(
        List<IConvert<string>> converters)
    {
        this.converters = converters;
    }

    public string GetGitPath(string windowsPath)
    {
        var index = 0;

        var path = converters[index].Convert(windowsPath);
        index++;

        while (index <= converters.Count - 1)
        {
            path = converters[index].Convert(path);
            index++;
        }

        return path;
    }
}