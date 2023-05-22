using System.IO.Compression;

public class Catalog {

    public static void ProcessGeneratedCatalog(string filePath) {

        string catalogTempDir = Path.Combine(Config.tempPath, "catalog");

        // cleanup the temp folder
        if (Directory.Exists(catalogTempDir)) {
            Directory.Delete(catalogTempDir, true);
        }

        // create the temp folder
        Directory.CreateDirectory(catalogTempDir);

        // print extract the zip file to the temp folder
        Logger.Info($"Extracting {filePath} to {catalogTempDir}");
        ZipFile.ExtractToDirectory(filePath, catalogTempDir);

        Csv csv = new Csv();
        csv.GenerateBrands(catalogTempDir);

    }
}