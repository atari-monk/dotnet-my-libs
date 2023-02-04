using DIHelper.Unity;
using Unity;

namespace Better.Console.Tables.TestApp;

public class ExampleDictionarySet 
	: UnityDependencySet
{
	public ExampleDictionarySet(
		IUnityContainer container) 
		: base(container)
	{
	}

	public override void Register()
	{
		Container.RegisterFactory<IDictionary<string, IExample>>(
			c => FillDictionary(
                new Dictionary<string, IExample>()));
	}

    private IDictionary<string, IExample> FillDictionary(
        IDictionary<string, IExample> store)
    {
		if(store.Count > 0) 
			return store;
		Add(store, nameof(TablesPrintout));
		return store;
    }

	private void Add(
        IDictionary<string, IExample> store
		, string key)
	{
        store.Add(key, ResolveScript(key));
	}

    private IExample ResolveScript(string key)
	{
		return Container.Resolve<IExample>(
			key.ToString());
	}
}