using System.Diagnostics;

namespace DotNetTool;

public class Timer : ITimer
{
	private readonly Stopwatch stopWatch = new();

	public double ElapsedSeconds
	{
		get
		{
			return stopWatch.ElapsedMilliseconds / 1000.0;
		}
	}

	public void Start()
	{
		stopWatch.Start();
	}

	public void Stop()
	{
		stopWatch.Stop();
	}

	public void Reset()
	{
		stopWatch.Reset();
	}
}