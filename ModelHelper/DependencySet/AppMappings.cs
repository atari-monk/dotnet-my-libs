using AutoMapper;
using DIHelper.Unity;
using Unity;

namespace ModelHelper;

public abstract class AppMappings
    : UnityDependencySet
{
    public AppMappings(
        IUnityContainer container)
        : base(container)
    {
    }

    public override void Register() =>
        Container.RegisterInstance(CreateMap().CreateMapper());

    protected abstract MapperConfiguration CreateMap();
}