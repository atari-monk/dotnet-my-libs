namespace GitPath.Lib;

public interface IConvert<in TIn, out TOut>
{
	TOut Convert(TIn input);
}