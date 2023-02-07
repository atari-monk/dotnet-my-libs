using GitPath.Lib;
using Unity;

namespace GitPath.ConsoleApp;

public class GitPathBootstraper
{
    public IUnityContainer Boot()
    {
        var container = new UnityContainer();
        var dependencyProvider = new GitPathDependencySet(container);
        dependencyProvider.Register();
        return container;
    }
}