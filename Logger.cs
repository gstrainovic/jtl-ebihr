using Serilog;

public class Logger
{
    public Logger()
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            .WriteTo.File("C:\\temp\\jtl-bihr\\logs\\jtl_bihr_log2_.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();
    }

    public void LogInformation(string message)
    {
        Log.Information(message);
    }
    public void LogError(string message)
    {
        Log.Error(message);
    }
}