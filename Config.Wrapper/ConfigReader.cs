using Microsoft.Extensions.Configuration;

namespace Config.Wrapper;

public class ConfigReader
    : IConfigReader
{
  private readonly IConfiguration configuration;

  public ConfigReader(
    IConfiguration configuration)
  {
    this.configuration = configuration;
    ArgumentNullException.ThrowIfNull(this.configuration);
  }

  public TData? GetConfigSection<TData>(string sectionName)
  {
    return configuration
      .GetRequiredSection(sectionName)
        .Get<TData>();
  }

  public TData GetConfigSection<TData>(string sectionName, TData defaultConfig)
  {
    try
    {
			var section = configuration.GetRequiredSection(sectionName); 
      return section.Get<TData>() ?? defaultConfig;
    }
    catch (Exception)
    {
      return defaultConfig;
    }
  }
}