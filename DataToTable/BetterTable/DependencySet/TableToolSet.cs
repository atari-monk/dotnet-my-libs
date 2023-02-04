using DIHelper.Unity;
using Unity;

namespace Better.Console.Tables.Wrapper;

public class TableToolSet 
    : UnityDependencySet
{
    public TableToolSet(
        IUnityContainer container) 
        : base(container)
    {
    }

    public override void Register()
    {
        Container.RegisterSingleton<ILogModelData, LogModelData>();
    }
}