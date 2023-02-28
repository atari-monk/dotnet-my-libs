using Config.Wrapper;
using Config.Wrapper.CLI.TestApp;
using Microsoft.Extensions.Configuration;

try
{
  Console.WriteLine($"Cli app testing json config wrapper");

  var settings = new ConfigReader(
    new ConfigBuilder(
      new ConfigurationBuilder()
        , new DirectorySys()
    ).BuildConfig())
      .GetConfigSection<TestSettings>(
        nameof(TestSettings));

  ArgumentNullException.ThrowIfNull(settings);

  Console.WriteLine($"{nameof(settings.Key)}:{settings.Key}");
  Console.WriteLine($"{nameof(settings.Number)}:{settings.Number}");
  Console.WriteLine($"{nameof(settings.Flag)}:{settings.Flag}");
}
catch (FileNotFoundException ex)
{
  Console.WriteLine(ex);
}
catch (Exception ex)
{
  Console.WriteLine(ex);
}