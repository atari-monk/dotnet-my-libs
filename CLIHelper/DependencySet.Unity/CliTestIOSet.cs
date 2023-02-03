using System.Diagnostics;
using CommandDotNet;
using CommandDotNet.TestTools;
using DIHelper.Unity;
using Unity;

namespace CLIHelper.Unity;

public class CliTestIOSet 
    : UnityDependencySet
{
    public CliTestIOSet(
        IUnityContainer container)
        : base(container)
    {
    }

    public override void Register()
    {
        Container
            .RegisterSingleton<IConsole, TestConsole>()
            .RegisterSingleton<IInput, Input>()
            .RegisterSingleton<IOutput, CliConsoleOut>();
    }
}