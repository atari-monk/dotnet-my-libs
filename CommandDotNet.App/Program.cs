using CommandDotNet;
using CommandDotNet.App;

public static class Program
{
  public static AppRunner<Calculator> AppRunner { get; }

  static Program()
  {
    AppRunner = new AppRunner<Calculator>();
  }

  public static void Main(string[] args)
  {
    AppRunner.Run(args);
  }
}