using System.IO.Compression;
using JtlDbModels;
using Microsoft.EntityFrameworkCore;

public class Backup : Config
{
    Logger _logger  = new Logger();

    public void FullBackup() {
        // string backupFilePath = Path.Combine(jtl_bihr.temp_path, "EazyBusiness.bak");
        // backupFilePatch is iso YYYY-MM-DD-HH-mm-ss + EazyBusiness.bak
        string backupFilePath = Path.Combine(jtl_bihr.temp_path, $"{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}-EazyBusiness.bak");
        // create a full backup of the EazyBusinessContext database
        _logger.LogInformation("Creating a full backup of the JTL database");
        using (var db = new EazyBusinessContext()) {
            db.Database.ExecuteSqlRaw($"BACKUP DATABASE EazyBusiness TO DISK = '{backupFilePath}' WITH FORMAT, MEDIANAME = 'Z_SQLServerBackups', NAME = 'Full Backup of EazyBusiness';");
        }
        if (File.Exists(backupFilePath)) {
            _logger.LogInformation($"Zipping {backupFilePath}");
            using (FileStream zipToOpen = new FileStream(backupFilePath + ".zip", FileMode.Create)) {
                using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Create)) {
                    archive.CreateEntryFromFile(backupFilePath, Path.GetFileName(backupFilePath));
                }
            }
            _logger.LogInformation($"Deleting {backupFilePath}");
            File.Delete(backupFilePath);
        }
    }
}