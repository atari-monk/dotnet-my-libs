using Xunit;

namespace Config.Wrapper.Tests;

public class ConfigReaderTests
    : ConfigFileTests
{
  [Fact]
  public void Test_Required_Dependencies()
  {
    var dep = () => SetConfigReader(null!);

    Assert.Throws<ArgumentNullException>("this.configuration", dep);
  }

  [Fact]
  public void Test_No_Section_Exception()
  {
    IConfigReader sut = SetConfigReaderForNotOkFile();

    var act = () => sut.GetConfigSection<TestSettings>(nameof(TestSettings));

    Assert.Throws<InvalidOperationException>(act);
  }

  [Fact]
  public void Test_Ok()
  {
    var expected = new TestSettings
    {
      Key = "test",
      Number = 3,
      Flag = true
    };
    IConfigReader sut = SetConfigReaderForOkFile();

    var result = sut.GetConfigSection<TestSettings>(nameof(TestSettings));

    Assert.Equal(expected.Key, result?.Key);
    Assert.Equal(expected.Number, result?.Number);
    Assert.Equal(expected.Flag, result?.Flag);
  }
}