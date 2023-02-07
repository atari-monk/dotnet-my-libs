namespace Pattern;

public interface IObserver<TData>
{
	void Update(TData data);
}