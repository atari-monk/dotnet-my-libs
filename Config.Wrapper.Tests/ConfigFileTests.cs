using Microsoft.Extensions.Configuration;
using Moq;
using Xunit;

namespace Config.Wrapper.Tests;

public abstract class ConfigFileTests
{
  private const string Repo = "net-my-libs";
  private const string ConfigFile = "appsettings.json";
  private const string RootPath = "C:\\atari-monk";
  private const string TestFolderPath = $"Code\\{Repo}\\Config.Wrapper.Tests\\ConfigFile";
  private const string NoFilePath = $"{RootPath}\\{TestFolderPath}\\NoFile";
  private const string OkFilePath = $"{RootPath}\\{TestFolderPath}\\Ok";
  private const string NotOkFilePath = $"{RootPath}\\{TestFolderPath}\\NotOk";

  protected virtual IConfigBuilder SetConfigForNoFile()
  {
    return SetConfigBuilder(
        SetDirectorySysMock(
            NoFilePath)
                .Object);
  }

  protected IConfigBuilder SetConfigForOkFile()
  {
    return SetConfigBuilder(
        SetDirectorySysMock(
            AssertFile(OkFilePath))
                .Object);
  }

  protected IConfigBuilder SetConfigForNotOkFile()
  {
    return SetConfigBuilder(
        SetDirectorySysMock(
            AssertFile(NotOkFilePath))
                .Object);
  }

  protected IConfigBuilder SetConfigBuilder(
      IDirectorySys directorySys)
  {
    return new ConfigBuilder(
        new ConfigurationBuilder()
        , directorySys);
  }

  protected IConfigBuilder SetConfigBuilder(
      IConfigurationBuilder configurationBuilder
      , IDirectorySys directorySys)
  {
    return new ConfigBuilder(
        configurationBuilder
        , directorySys);
  }

  private Mock<IDirectorySys> SetDirectorySysMock(string path)
  {
    Mock<IDirectorySys> mock = new();
    mock.Setup(m => m.GetAppDir()).Returns(path);
    return mock;
  }

  private string AssertFile(string path)
  {
    Assert.True(File.Exists(Path.Combine(path, ConfigFile)));
    return path;
  }

  protected IConfigReader SetConfigReader(
      IConfiguration configuration)
  {
    return new ConfigReader(
        configuration);
  }

  protected IConfigReader SetConfigReaderForNotOkFile()
  {
    return new ConfigReader(
        SetConfigForNotOkFile()
            .BuildConfig());
  }

  protected IConfigReader SetConfigReaderForOkFile()
  {
    return new ConfigReader(
        SetConfigForOkFile()
            .BuildConfig());
  }
}