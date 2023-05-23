class Logger
{
    private static void Log(string message, LogLevel level)
    {
        Console.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} - {level} - {message}");
        using (var db = new LoggingContext())
        {
            db.BihrImportLogs.Add(new BihrImportLog { Message = message , Level = level, Created = DateTime.Now });
            db.SaveChanges();
        }
    }

    public static void Info(string message)
    {
        Log(message, LogLevel.Info);
    }

    //Error
    public static void Error(string message)
    {
        Log(message, LogLevel.Error);
    }
}




  