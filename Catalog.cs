using System.IO.Compression;
using Microsoft.Extensions.Logging;

public class Catalog
{
    Logger _logger  = new Logger();

    public void ProcessHardPart(string filePath)
    {

        string catalogTempDir = Path.Combine(Config.tempPath, "HardPart");

        // cleanup the temp folder
        if (Directory.Exists(catalogTempDir))
        {
            Directory.Delete(catalogTempDir, true);
        }

        // create the temp folder
        Directory.CreateDirectory(catalogTempDir);

        // print extract the zip file to the temp folder
        _logger.LogInformation($"Extracting {filePath} to {catalogTempDir}");
        ZipFile.ExtractToDirectory(filePath, catalogTempDir);

        Csv csv = new Csv();
        csv.AddLieferant(catalogTempDir);
        csv.GenerateBrands(catalogTempDir);

        // send all files from catalogTempDir to Ameise
        var ameise = new Ameise();
        foreach (var file in Directory.GetFiles(catalogTempDir, "*.csv"))
        {
            _logger.LogInformation($"Processing {file}");
            ameise.importHardParts(file);
        }
    }

    public void ProcessRiderGear(string filePath)
    {

        string catalogTempDir = Path.Combine(Config.tempPath, "RiderGear");

        // cleanup the temp folder
        if (Directory.Exists(catalogTempDir))
        {
            Directory.Delete(catalogTempDir, true);
        }

        // create the temp folder
        Directory.CreateDirectory(catalogTempDir);

        // print extract the zip file to the temp folder
        _logger.LogInformation($"Extracting {filePath} to {catalogTempDir}");
        ZipFile.ExtractToDirectory(filePath, catalogTempDir);

        Csv csv = new Csv();
        csv.AddLieferant(catalogTempDir);

        // send all files from catalogTempDir to Ameise
        var ameise = new Ameise();
        foreach (var file in Directory.GetFiles(catalogTempDir, "*.csv"))
        {
            _logger.LogInformation($"Processing {file}");
            ameise.importHardParts(file);
        }
    }


}