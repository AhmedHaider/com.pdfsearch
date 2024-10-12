using com.pdfsearch.Models;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace com.pdfsearch.Core;

internal class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = new SqliteConnectionStringBuilder { DataSource = @"PDFSearch.db" }.ToString();

        var connection = new SqliteConnection(connectionString);

        // Set the encryption key
        connection.Open();
        using var command = connection.CreateCommand();
        command.CommandText = "PRAGMA key = '123';";
        command.ExecuteNonQuery();
        connection.Close();

        optionsBuilder.UseSqlite(connection);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Username must have value
        modelBuilder.Entity<User>()
            .Property(u => u.Username)
            .IsRequired();

        //Username is unique
        modelBuilder.Entity<User>()
            .HasIndex(u => u.Username)
            .IsUnique();
    }

    public DbSet<User> Users { get; set; }
}