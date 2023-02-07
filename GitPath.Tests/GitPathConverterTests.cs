using GitPath.Lib;
using Xunit;

namespace GitPath.Tests;

public class GitPathConverterTests 
{
    [Theory]
    [InlineData(
        @"C:\kmazanek@gmail.com\GitRepos\CSharp\GitPath\.git",
        "/C/kmazanek@gmail.com/GitRepos/CSharp/GitPath/.git")]
    public void Convert_Windows_Path_To_Git_Path_Correctly(
        string windowsPath
        , string gitPath)
    {
        //todo: mock these
        IGitPath converter = new GitPathConverter(
            new List<IConvert<string>> { new DriveConverter(), new SlashConverter() });

        var acctual = converter.GetGitPath(windowsPath);

        Assert.Equal(gitPath, acctual);
    }
}