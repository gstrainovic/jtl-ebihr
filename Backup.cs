using System.IO.Compression;
using JtlDbModels;
using Microsoft.EntityFrameworkCore;

public class Backup {

    string backupFilePath = Path.Combine(Config.tempPath, "EazyBusiness.bak");

    public void FullBackup() {
        // create a full backup of the EazyBusinessContext database
        Logger.Info("Creating a full backup of the JTL database");

        // zip the old backup file if it exists
        if (File.Exists(backupFilePath)) {
            Logger.Info($"Zipping {backupFilePath}");
            if (File.Exists(backupFilePath + ".zip")) {
                File.Delete(backupFilePath + ".zip");
            }
            using (FileStream zipToOpen = new FileStream(backupFilePath + ".zip", FileMode.Create)) {
                using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Create)) {
                    archive.CreateEntryFromFile(backupFilePath, Path.GetFileName(backupFilePath));
                }
            }
            Logger.Info($"Deleting {backupFilePath}");
            File.Delete(backupFilePath);
        }

        using (var db = new EazyBusinessContext()) {
            db.Database.ExecuteSqlRaw($"BACKUP DATABASE EazyBusiness TO DISK = '{backupFilePath}' WITH FORMAT, MEDIANAME = 'Z_SQLServerBackups', NAME = 'Full Backup of EazyBusiness';");
        }
    }
}