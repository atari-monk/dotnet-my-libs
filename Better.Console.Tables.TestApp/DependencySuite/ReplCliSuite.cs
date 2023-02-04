using CommandDotNet.Unity.Helper;
using Unity;

namespace Better.Console.Tables.TestApp;

public class ReplCliSuite 
    : AppSuite
{
    public ReplCliSuite(
        IUnityContainer container) 
        : base(container) 
    {
    }

    protected override void RegisterProgram() =>
        RegisterSet<AppProgSet<ReplCli>>();
}