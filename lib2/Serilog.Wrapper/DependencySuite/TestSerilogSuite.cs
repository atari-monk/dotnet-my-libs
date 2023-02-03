using DIHelper.Unity;
using Serilog.Wrapper.Unity;
using Unity;

namespace Serilog.Wrapper;

public class TestSerilogSuite 
    : UnityDependencySuite
{
    public TestSerilogSuite(
        IUnityContainer container)
        : base(container)
    {
    }

    protected override void RegisterAppData()
    {
        base.RegisterAppData();
        RegisterSet<TestSerilogSet>();  
    }
}