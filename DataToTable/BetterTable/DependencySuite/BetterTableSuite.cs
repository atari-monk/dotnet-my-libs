using DIHelper.Unity;
using Unity;

namespace Better.Console.Tables.Wrapper;

public class BetterTableSuite 
    : UnityDependencySuite
{
    public BetterTableSuite(
        IUnityContainer container) 
        : base(container) 
    {
    }

    protected override void RegisterAppData()
    {
        RegisterSet<TableToolSet>();
        RegisterSet<TableSet>();
        RegisterSet<TableDictionarySet>();
    }
}