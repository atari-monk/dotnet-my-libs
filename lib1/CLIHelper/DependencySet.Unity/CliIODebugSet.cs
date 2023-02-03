using DIHelper.Unity;
using Unity;

namespace CLIHelper.Unity;

public class CliIODebugSet 
    : UnityDependencySet
{
    public CliIODebugSet(
        IUnityContainer container)
        : base(container)
    {
    }

    public override void Register()
    {
        Container
            .RegisterSingleton<IInput, Input>()
            .RegisterSingleton<IOutput, DebugOut>();
    }
}