using GitPath.Lib;
using Xunit;

namespace GitPath.Tests;

public class SlashConverterTests
{
    [Theory]
    [InlineData(
        @"/C\kmazanek@gmail.com\GitRepos\CSharp\GitPath\.git",
        @"/C/kmazanek@gmail.com/GitRepos/CSharp/GitPath/.git")]
    public void Convert_Windows_Drive_To_Git_Drive_Correctly(
        string windowsPath
        , string gitPath)
    {
        IConvert<string> converter = new SlashConverter();

        var acctual = converter.Convert(windowsPath);

        Assert.Equal(gitPath, acctual);
    }
}