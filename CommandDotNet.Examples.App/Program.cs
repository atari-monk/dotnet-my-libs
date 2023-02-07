using CommandDotNet.Examples.Lib;

namespace CommandDotNet.Examples.App;

public class Program
{
	public static AppRunner AppRunner => new AppRunner<Calculator>();

	static int Main(string[] args) =>
		AppRunner.Run(args);
}