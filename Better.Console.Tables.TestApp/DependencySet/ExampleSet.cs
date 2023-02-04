using DIHelper.Unity;
using Unity;

namespace Better.Console.Tables.TestApp;

public class ExampleSet 
    : UnityDependencySet
{
    public ExampleSet(
        IUnityContainer container) 
        : base(container)
    {
    }

    public override void Register()
    {
        RegisterExample<TablesPrintout>();
    }
    
    private void RegisterExample<TType>()
        where TType : IExample
    {
        Container
            .RegisterSingleton<IExample, TType>(
                typeof(TType).Name);
    }
}