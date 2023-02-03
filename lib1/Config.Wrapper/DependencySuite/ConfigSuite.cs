using Config.Wrapper.Unity;
using DIHelper.Unity;
using Unity;

namespace Config.Wrapper;

public class ConfigSuite 
    : UnityDependencySuite
{
    public ConfigSuite(
        IUnityContainer container)
        : base(container)
    {
    }

    protected override void RegisterAppData()
    {
        RegisterSet<AppConfigSet>();  
    }
}