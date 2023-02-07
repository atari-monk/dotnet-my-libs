namespace Pattern;

public class Observable<TData> :
		IObservable<TData>
		, IObservableState<TData>
{
	private readonly List<IObserver<TData>> observers = new();

	public TData? Data { get; protected set; }

	public void Add(IObserver<TData> observer)
	{
		observers.Add(observer);
	}

	public void Remove(IObserver<TData> observer)
	{
		observers.Remove(observer);
	}

	public void Notify()
	{
        ArgumentNullException.ThrowIfNull(Data);
		foreach (var observer in observers)
		{
			observer.Update(Data);
		}
	}
}