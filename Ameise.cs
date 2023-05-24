using System.Diagnostics;
using System.Reflection;

public class AmeiseImport : Config
{

    Logger _logger  = new Logger();

    public AmeiseImport()
    {
        // find JTL-wawi-ameise.exe in the JTL-Software folder
        var ameiseExe = Directory.GetFiles(jtl.software_path, jtl.ameise.exe, SearchOption.AllDirectories).FirstOrDefault();
        if (ameiseExe == null)
        {
            // Logger.Error($"{Config.ameiseExe} not found in {Config.jtlSoftwarePath}");
            _logger.LogError($"{jtl.ameise.exe} not found in {jtl.software_path}");
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
        string logFilePath = Path.Combine(jtl_bihr.temp_path, logFileName);
        if (logFilePath == null)
        {
            // Logger.Error("logFilePath is null");
            _logger.LogError("logFilePath is null");
            return;
        }

        _logger.LogInformation($"Running Ameise with template {template} and inputfile {inputfile}");
 
        // get current directory
        var currentDirectory = Directory.GetCurrentDirectory();

        // change to the JTL-Software folder
        Directory.SetCurrentDirectory( jtl.software_path);

        // on error stop the process
        var process = new Process();
        try
        {
            var args = $"--server={sql.server_name} --database={sql.databaseName} --dbuser={sql.user_name} --dbpass={sql.password} --templateid={template} --inputfile={inputfile} --log={logFilePath} ";
            // var process = Process.Start(Config.ameiseExe, args);
            process.StartInfo.FileName =  jtl.ameise.exe;
            process.StartInfo.Arguments = args;
            process.Start();
            process.WaitForExit();
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
        }
        finally
        {
            // change back to the original directory
            Directory.SetCurrentDirectory(currentDirectory);
        }
    }

    public void importBrands(string importBrandsFilePath)
    {
        run(jtl.ameise.brand_vorlage_id, importBrandsFilePath);
    }

    public void importHardPartsAndRiderGears(string importBrandsFilePath)
    {
        run(jtl.ameise.hard_part_vorlage_id, importBrandsFilePath);
    }


}