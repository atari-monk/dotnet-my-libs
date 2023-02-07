namespace GitPath.Lib;

public interface IFactory<in TInput, out TOutput>
{
	TOutput GetInstance(TInput input);
}