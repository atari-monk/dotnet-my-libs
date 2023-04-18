using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;

namespace EFCore.Helper;

public abstract class DbContextDbConfig
    : DbContextShadowProps
{
  public DbContextDbConfig()
      : base()
  {
  }

  public DbContextDbConfig(DbContextOptions<DbContextDbConfig> options)
      : base(options)
  {
  }

  protected DbContextDbConfig(DbContextOptions options)
      : base(options)
  {
  }

  private static readonly LoggerFactory debugLoggerFactory =
      new LoggerFactory(new[] { new DebugLoggerProvider() });

  protected override void SetConfig(DbContextOptionsBuilder builder)
  {
    var helper = new DbConfigHelper();

    if (helper.Config == null) return;

    var connectionString = helper.GetConnectionString();

    if (string.IsNullOrWhiteSpace(connectionString) == false)
      builder.UseSqlServer(connectionString);

    if (helper.Config.UseLogger)
      builder.UseLoggerFactory(debugLoggerFactory);
  }
}