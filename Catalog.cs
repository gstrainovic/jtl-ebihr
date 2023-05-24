using System.IO.Compression;
using Microsoft.Extensions.Logging;

public class Catalog : Config
{
    Logger _logger = new Logger();

    public void ProcessHardPart(string filePath)
    {

        string catalogTempDir = Path.Combine(this.jtl_bihr.temp_path, "HardPart");

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

        if (jtl_bihr.hersteller_importieren == 1)
        {
            csv.GenerateBrands(catalogTempDir);
        }

        // send all files from catalogTempDir to Ameise
        if (jtl_bihr.artikel_importieren == 1)
        {
            var ameise = new AmeiseImport();
            foreach (var file in Directory.GetFiles(catalogTempDir, "*.csv"))
            {
                _logger.LogInformation($"Processing {file}");
                ameise.importHardPartsAndRiderGears(file);
            }
        }
    }

    public void ProcessRiderGear(string filePath)
    {

        string catalogTempDir = Path.Combine(this.jtl_bihr.temp_path, "RiderGear");

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
        if (jtl_bihr.artikel_importieren == 1)
        {
            var ameise = new AmeiseImport();
            foreach (var file in Directory.GetFiles(catalogTempDir, "*.csv"))
            {
                _logger.LogInformation($"Processing {file}");
                ameise.importHardPartsAndRiderGears(file);
            }
        }
    }


}