using DIHelper.Unity;
using Unity;

namespace Better.Console.Tables.Wrapper;

public class TableSet
    : UnityDependencySet
{
    public TableSet(
        IUnityContainer container) 
        : base(container)
    {
    }

    public override void Register()
    {
        RegisterTable<LogTable, LogModel>();
        RegisterTable<LogTable2, LogModel>();
        RegisterTable<LogTable3, LogModel>();
    }
    
    private void RegisterTable<TType, TEntity>()
        where TType : IBetterTable<TEntity>
    {
        Container
            .RegisterSingleton<IBetterTable<TEntity>, TType>(
                typeof(TType).Name);
    }
}