using DIHelper.Unity;
using Unity;

namespace Better.Console.Tables.Wrapper;

public class TableDictionarySet 
	: UnityDependencySet
{
	public TableDictionarySet(
		IUnityContainer container) 
		: base(container)
	{
	}

	public override void Register()
	{
		Container.RegisterFactory<IDictionary<string, IBetterTable<LogModel>>>(
			c => FillDictionary(
                new Dictionary<string, IBetterTable<LogModel>>()));
	}

    private IDictionary<string, IBetterTable<LogModel>> FillDictionary(
        IDictionary<string, IBetterTable<LogModel>> store)
    {
		if(store.Count > 0) 
			return store;
		Add(store, nameof(LogTable));
		Add(store, nameof(LogTable2));
		Add(store, nameof(LogTable3));
		return store;
    }

	private void Add(
        IDictionary<string, IBetterTable<LogModel>> store
		, string key)
	{
        store.Add(key, ResolveScript(key));
	}

    private IBetterTable<LogModel> ResolveScript(string key)
	{
		return Container.Resolve<IBetterTable<LogModel>>(
			key.ToString());
	}
}