using System.IO.Compression;

public class Catalog {
    public string Brand { get; internal set; }

    public static void ProcessGeneratedCatalog(string filePath) {
        // print extract the zip file to the temp folder
        Logger.Info($"Extracting {filePath} to {env.tempPath}");
        ZipFile.ExtractToDirectory(filePath, env.tempPath);

        Csv.GenerateBrands();

    }
}