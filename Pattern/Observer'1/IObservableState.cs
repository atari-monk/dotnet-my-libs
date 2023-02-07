namespace Pattern;

public interface IObservableState<TData>
{
	TData? Data { get; }
}