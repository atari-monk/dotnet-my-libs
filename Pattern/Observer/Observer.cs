namespace Pattern;

public abstract class Observer : IObserver
{
	protected readonly IObservable Observable;

	public Observer(
		IObservable observable)
	{
		Observable = observable;
	}

	public abstract void Update();
}