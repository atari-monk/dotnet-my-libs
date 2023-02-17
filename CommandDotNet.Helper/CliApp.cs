using CommandDotNet.DataAnnotations;
using CommandDotNet.NameCasing;
using Config.Wrapper;
using Serilog;
using DIHelper;

namespace CommandDotNet.Helper;

public class CliApp<Commands>
    : IAppProgram
    where Commands : class
{
  private readonly AppRunner appRunner;
  private readonly IConfigReader config;
  private CommandDotNetSettings? settings;
  protected readonly ILogger Log;

  public AppRunner AppRunner => appRunner;

  public CliApp(
        ILogger log
        , IConfigReader config)
  {
    Log = log;
    this.config = config;
    ArgumentNullException.ThrowIfNull(this.config);
    ArgumentNullException.ThrowIfNull(Log);
    appRunner = new AppRunner<Commands>();
    Log.Verbose("AppRunner created");
  }

  public int Main(string[] args)
  {
    Log.Verbose(nameof(Main));
    Log.Verbose(nameof(Run));
    return Run(args);
  }

  public void Setup()
  {
    Log.Verbose(nameof(SetConfig));
    SetConfig();
    Log.Verbose(nameof(SetAppRunner));
    SetAppRunner();
  }

  protected virtual void SetConfig()
  {
    try
    {
      settings = config.GetConfigSection<CommandDotNetSettings>(nameof(CommandDotNetSettings));
    }
    catch (Exception ex)
    {
      Log.Error(ex, "Config error");
      throw;
    }
  }

  protected virtual void SetAppRunner()
  {
    SetDefaults();
    //todo: if(settings != null){}
  }

  private void SetDefaults()
  {
    appRunner
        .UseDefaultMiddleware()
        .UseNameCasing(Case.LowerCase)
        .UseDataAnnotationValidations();
    Log.Verbose("AppRunner on default settings");
  }

  protected virtual int Run(string[] args) =>
        appRunner.Run(args);
}