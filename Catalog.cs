using System.IO.Compression;

public class Catalog {
    public static void ProcessGeneratedCatalog(string filePath) {
        // extract the zip file
        ZipFile.ExtractToDirectory(filePath, Env.env.tempPath);
    }
}