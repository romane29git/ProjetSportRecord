using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using projet_ribard_cote_colisson_gr3.Models;

public class SportRecordContext : DbContext
{
    public DbSet<Athlete> Athletes { get; set; } = null!;
    public DbSet<Sport> Sports { get; set; } = null!;
    public DbSet<Discipline> Disciplines { get; set; } = null!;
    public DbSet<Record> Records { get; set; } = null!;


    public string DbPath { get; private set; }

    public SportRecordContext()
    {
        // Path to SQLite database file
        DbPath = "projet_ribard_cote_colisson_gr3.db";
    }

    // The following configures EF to create a SQLite database file locally
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // Use SQLite as database
        options.UseSqlite($"Data Source={DbPath}");
        // Optional: log SQL queries to console
        options.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information);
    }
}