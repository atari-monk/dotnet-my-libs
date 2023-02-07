namespace Pattern;

public interface IObservable<TData>
{
	void Add(IObserver<TData> observer);

	void Remove(IObserver<TData> observer);

	void Notify();
}