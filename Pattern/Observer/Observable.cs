namespace Pattern;

public abstract class Observable : IObservable
{
	private readonly List<IObserver> observers;

	public Observable()
	{
		observers = new List<IObserver>();
	}

	public void Add(IObserver observer)
	{
		observers.Add(observer);
	}

	public void Remove(IObserver observer)
	{
		observers.Remove(observer);
	}

	public void Notify()
	{
		foreach (var observer in observers)
		{
			observer.Update();
		}
	}
}