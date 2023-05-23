using Microsoft.EntityFrameworkCore;

public class LoggingContext : DbContext
{
    public DbSet<BihrImportLog> BihrImportLogs { get; set; }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(Secret.OptionsBuilderString);
}

public class BihrImportLog
{
    public int Id { get; set; }
    public string? Message { get; set; }
    public DateTime Created { get; set; }
    public LogLevel Level { get; set; }

}

// log levels enums
public enum LogLevel
{
    Info,
    Warning,
    Error,
    Critical
}

