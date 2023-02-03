using DIHelper.Unity;
using Unity;

namespace CLIHelper.Unity;

public class CliIOInMemSet 
    : UnityDependencySet
{
    public CliIOInMemSet(
        IUnityContainer container)
        : base(container)
    {
    }

    public override void Register()
    {
        Container
            .RegisterSingleton<IInput, Input>()
            .RegisterSingleton<IOutput, ConsoleOutMock>();
    }
}