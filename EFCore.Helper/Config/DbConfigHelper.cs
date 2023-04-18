using MyConfigTool = Config.Wrapper.ConfigTool;

namespace EFCore.Helper;

public class DbConfigHelper
{
  private DbConfig? config;

  public DbConfig? Config => config;

  public DbConfigHelper()
  {
    try
    {
      config = MyConfigTool.ReadConfig<DbConfig>()!;
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.Message);
    }
  }

  public string? GetConnectionString()
  {
    if (config == null) return default;
    switch (config.DbType)
    {
      case DbType.Local:
        return config.LocalConnectionString!;
      case DbType.LocalTest:
        return config.LocalTestConnectionString!;
      default:
        return config.LocalConnectionString!;
    }
  }
}