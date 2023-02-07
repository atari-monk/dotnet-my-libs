namespace GitPath.Lib;

public interface IFactory<out T>
{
	T GetInstance();
}