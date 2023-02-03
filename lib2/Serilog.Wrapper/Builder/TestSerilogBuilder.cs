using Serilog.Sinks.InMemory;

namespace Serilog.Wrapper;

public class TestSerilogBuilder 
    : ISerilogBuilder
{
    public ILogger BuildLog()
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            .WriteTo.File("logs/log-.txt", rollingInterval: RollingInterval.Day)
            .WriteTo.InMemory()
            .CreateLogger();
        return Log.Logger;     
    }
}