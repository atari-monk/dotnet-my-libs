using System.Diagnostics;

namespace DotNetTool;

public class ProcessStarter : IProcessStarter
{
	private Process? process;

	public void StartProcess(
		string executeablePath
		, params string[] arguments)
	{
		process = new Process
		{
			StartInfo = new ProcessStartInfo(executeablePath)
			{
				WindowStyle = ProcessWindowStyle.Normal
			}
		};
		foreach (var argument in arguments)
		{
			process.StartInfo.ArgumentList.Add(argument);
		}
		process.Start();
		process.WaitForExit();
	}
}