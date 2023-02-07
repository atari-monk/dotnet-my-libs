namespace DotNetTool;

public interface ITimer
{
	double ElapsedSeconds { get; }

	void Start();

	void Stop();

	void Reset();
}