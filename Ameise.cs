using System.Diagnostics;
using System.Reflection;

public class Ameise
{

    Logger _logger  = new Logger();

    public Ameise()
    {
        // find JTL-wawi-ameise.exe in the JTL-Software folder
        var ameiseExe = Directory.GetFiles(Config.jtlSoftwarePath, Config.ameiseExe, SearchOption.AllDirectories).FirstOrDefault();
        if (ameiseExe == null)
        {
            // Logger.Error($"{Config.ameiseExe} not found in {Config.jtlSoftwarePath}");
            _logger.LogError($"{Config.ameiseExe} not found in {Config.jtlSoftwarePath}");
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

        // logfile is template + ms since 1970
        string logFileName = $"{template}_{DateTimeOffset.Now.ToUnixTimeMilliseconds()}.log";
        string logFilePath = Path.Combine(Config.tempPath, logFileName);
        if (logFilePath == null)
        {
            // Logger.Error("logFilePath is null");
            _logger.LogError("logFilePath is null");
            return;
        }

        _logger.LogInformation($"Running Ameise with template {template} and inputfile {inputfile}");
 
        // change to the JTL-Software folder
        Directory.SetCurrentDirectory(Config.jtlSoftwarePath);

        // on error stop the process
        var process = new Process();
        try
        {
            var args = $"--server={Secret.SQLServerName} --database={Secret.SQLDatabaseName} --dbuser={Secret.SQLUserName} --dbpass={Secret.SQLPassword} --templateid={template} --inputfile={inputfile} --log={logFilePath} ";
            // var process = Process.Start(Config.ameiseExe, args);
            process.StartInfo.FileName = Config.ameiseExe;
            process.StartInfo.Arguments = args;
            process.Start();
            // process.WaitForExit();
        }
        catch (Exception e)
        {
            // Logger.Error(e.Message);
            _logger.LogError(e.Message);
            // if process is still running kill it
            if (!process.HasExited)
            {
                process.Kill();
            }

            return;
        }
    }

    public void importBrands(string importBrandsFilePath)
    {
        // run the import of the brands
        run(Config.AmeiseBrandVorlageId, importBrandsFilePath);
    }

    public void importHardParts(string importBrandsFilePath)
    {
        // run the import of the brands
        run(Config.AmeiseHardPartVorlageId, importBrandsFilePath);
    }


}