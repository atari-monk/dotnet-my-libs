using DIHelper.Unity;
using Serilog.Sinks.InMemory;
using Unity;

namespace Serilog.Wrapper.Unity;

public class TestSerilogSet 
    : UnityDependencySet
{
    public TestSerilogSet(
        IUnityContainer container) 
        : base(container)
    {
    }

    public override void Register()
    {
        Container.RegisterSingleton<ISerilogBuilder, TestSerilogBuilder>();
        Container.RegisterInstance(
            Container.Resolve<ISerilogBuilder>()
                .BuildLog());
        Container.RegisterInstance("InMemorySink", InMemorySink.Instance);
    }
}