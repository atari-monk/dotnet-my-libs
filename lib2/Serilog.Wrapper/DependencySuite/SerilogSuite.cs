using DIHelper.Unity;
using Serilog.Wrapper.Unity;
using Unity;

namespace Serilog.Wrapper;

public class SerilogSuite 
    : UnityDependencySuite
{
    public SerilogSuite(
        IUnityContainer container)
        : base(container)
    {
    }

    protected override void RegisterAppData()
    {
        base.RegisterAppData();
        RegisterSet<SerilogSet>();  
    }
}