using Better.Console.Tables.Wrapper;
using Serilog.Wrapper.Unity;
using Unity;

namespace Better.Console.Tables.TestApp;

public class AppSuite 
    : BetterTableSuite
{
    public AppSuite(
        IUnityContainer container) 
        : base(container) 
    {
    }

    protected override void RegisterAppData()
    {
        base.RegisterAppData();
        RegisterSet<ExampleSet>();
        RegisterSet<ExampleDictionarySet>();
    }
}