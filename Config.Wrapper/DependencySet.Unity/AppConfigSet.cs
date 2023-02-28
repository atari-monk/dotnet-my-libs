using DIHelper.Unity;
using Microsoft.Extensions.Configuration;
using Unity;

namespace Config.Wrapper.Unity;

public class AppConfigSet
    : UnityDependencySet
{
  public AppConfigSet(
      IUnityContainer container)
      : base(container)
  {
  }

  public override void Register()
  {
    Container.RegisterSingleton<IConfigurationBuilder, ConfigurationBuilder>()
      .RegisterSingleton<IDirectorySys, DirectorySys>()
      .RegisterSingleton<IConfigBuilder, ConfigBuilder>()
      .RegisterInstance<IConfiguration>(
        Container.Resolve<IConfigBuilder>().BuildConfig())
      .RegisterSingleton<IConfigReader, ConfigReader>();
  }
}