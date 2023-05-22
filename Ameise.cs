using System.Diagnostics;
using System.Reflection;

public class Ameise
{

    public const string logFileName = "Ameise.log";
    string? logFilePath;

    public Ameise()
    {
        // find JTL-wawi-ameise.exe in the JTL-Software folder
        var ameiseExe = Directory.GetFiles(Config.jtlSoftwarePath, Config.ameiseExe, SearchOption.AllDirectories).FirstOrDefault();
        if (ameiseExe == null)
        {
            Logger.Error($"{Config.ameiseExe} not found in {Config.jtlSoftwarePath}");
            return;
        }

        logFilePath = Path.Combine(Config.tempPath, logFileName);
        if (logFilePath == null)
        {
            Logger.Error("logFilePath is null");
            return;
        }
        // start a full sql backup of the JTL database
        // this is needed because the import of the brands will change the database
        // and we want to be able to restore the database if something goes wrong
        Backup backup = new Backup();
        backup.FullBackup();
    }

    private void run(string template, string inputfile)
    {
        Logger.Info($"Running Ameise with template {template} and inputfile {inputfile}");

        if (logFilePath == null)
        {
            Logger.Error("logFilePath is null");
            return;
        }

        // change to the JTL-Software folder
        Directory.SetCurrentDirectory(Config.jtlSoftwarePath);

        // delete the logfile if it exists
        if (File.Exists(logFilePath))
        {
            File.Delete(logFilePath);
        }

        var args = $"--server={Secret.SQLServerName} --database={Secret.SQLDatabaseName} --dbuser={Secret.SQLUserName} --dbpass={Secret.SQLPassword} --templateid={template} --inputfile={inputfile} --log={logFilePath} --nostdout";
        // call JTL-wawi-ameise.exe with the arguments
        var process = Process.Start(Config.ameiseExe, args);
        process.WaitForExit();
        // log the log
        var log = File.ReadAllText(logFilePath);
        Logger.Info(log);
    }

    public void importBrands(string importBrandsFilePath)
    {
        // run the import of the brands
        run(Config.AmeiseBrandVorlageId, importBrandsFilePath);
    }
}