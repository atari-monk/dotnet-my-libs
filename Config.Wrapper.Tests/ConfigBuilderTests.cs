using Xunit;

namespace Config.Wrapper.Tests;

public class ConfigBuilderTests
    : ConfigFileTests
{
  [Fact]
  public void Test_Required_Dependency_1()
  {
    var dep1 = () => SetConfigBuilder(null!, null!);

    Assert.Throws<ArgumentNullException>("this.configurationBuilder", dep1);
  }

  [Fact]
  public void Test_Required_Dependency_2()
  {
    var dep2 = () => SetConfigBuilder(null!);

    Assert.Throws<ArgumentNullException>("this.directorySystem", dep2);
  }

  [Fact]
  public void Test_No_File_Exception()
  {
    IConfigBuilder sut = SetConfigForNoFile();

    var config = () => sut.BuildConfig();

    Assert.Throws<FileNotFoundException>(config);
    Assert.NotNull(sut.ConfigurationBuilder);
  }

  [Fact]
  public void Test_Ok()
  {
    IConfigBuilder sut = SetConfigForOkFile();

    var config = sut.BuildConfig();

    Assert.NotNull(config);
    Assert.NotNull(sut.ConfigurationBuilder);
  }
}