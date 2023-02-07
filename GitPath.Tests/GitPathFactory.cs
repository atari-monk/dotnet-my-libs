using GitPath.Lib;
using Unity;

namespace GitPath.Tests;

public class GitPathFactory
    : IFactory<IGitPath>
{
    private readonly IUnityContainer container;

    public GitPathFactory()
    {
        container = new UnityContainer();
        var gitPathDependencyProvider = new GitPathDependencySet(container);
        gitPathDependencyProvider.Register();
    }

    public IGitPath GetInstance()
    {
        return container.Resolve<IGitPath>();
    }
}