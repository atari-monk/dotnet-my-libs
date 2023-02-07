namespace GitPath.Lib;

public interface IConvert<T>
{
	T Convert(T input);
}