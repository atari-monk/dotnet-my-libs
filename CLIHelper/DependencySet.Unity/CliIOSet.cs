using DIHelper.Unity;
using Unity;

namespace CLIHelper.Unity;

public class CliIOSet 
    : UnityDependencySet
{
    public CliIOSet(
        IUnityContainer container)
        : base(container)
    {
    }

    public override void Register()
    {
        Container
            .RegisterSingleton<IInput, Input>()
            .RegisterSingleton<IOutput, ConsoleOut>();
    }
}