using System.IO.Compression;

public class Catalog {
    public static void ProcessGeneratedCatalog(string filePath) {
        // cleanup the temp folder
        if (Directory.Exists(Env.env.tempPath)) {
            Directory.Delete(Env.env.tempPath, true);
        }
        // create the temp folder
        Directory.CreateDirectory(Env.env.tempPath);
        // extract the zip file
        ZipFile.ExtractToDirectory(filePath, Env.env.tempPath);
    }
}