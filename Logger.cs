class Logger
{
    public static void Info(string message)
    {
        var level = LogLevel.Info;
        Logger.Info($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} - {level} - {message}");
        using (var db = new LoggingContext())
        {
            db.Logs.Add(new Log { Message = message , Level = level, Created = DateTime.Now });
            db.SaveChanges();
        }
    }
}




  