using DIHelper;
using Unity;

namespace GitPath.Lib;

public class GitPathDependencySet
    : DependencySet<IUnityContainer>
{
    public GitPathDependencySet(
        IUnityContainer unityContainer)
            : base(unityContainer)
    {
    }

    public override void Register()
    {
        Container.RegisterType<IConvert<string>, DriveConverter>(nameof(DriveConverter))
            .RegisterType<IConvert<string>, SlashConverter>(nameof(SlashConverter))
            .RegisterType<IGitPath, GitPathConverter>();
    }
}