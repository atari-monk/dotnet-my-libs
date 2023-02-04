using Config.Wrapper;
using DIHelper;
using Serilog.Wrapper;
using Unity;

namespace Better.Console.Tables.TestApp;

public class AppBootstraper
    : IBootstraper
{
    private IDependencySuite? suite;
    private IBootstraper? booter;
    private IUnityContainer? container;

    public IDependencySuite? Suite => suite;
    public Guid AppId { get; private set; }

    public void CreateApp()
    {
        container = new UnityContainer()
            .AddExtension(new Diagnostic());
        var configSuite = new ConfigSuite(container);
        var serilogSuite = new SerilogSuite(container);
        configSuite.Register();
        serilogSuite.Register();
        suite = new SuiteConfig(
            container.Resolve<IConfigReader>())
                .GetSuite(container);
        booter = new Bootstraper(suite);
        booter.CreateApp();
        AppId = Guid.NewGuid();
    }

    public void RunApp(params string[] args)
    {  
        ArgumentNullException.ThrowIfNull(booter);
        booter.RunApp(args);
    }
}