using CommandDotNet.Unity.Helper;
using Unity;

namespace Better.Console.Tables.TestApp;

public class CommandCliSuite 
    : AppSuite
{
    public CommandCliSuite(
        IUnityContainer container) 
        : base(container) 
    {
    }

    protected override void RegisterProgram() =>
        RegisterSet<AppProgSet<CommandCli>>();
}