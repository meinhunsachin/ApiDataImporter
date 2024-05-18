// Data/AppDbContext.cs
using ApiDataImporter.Models;

using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Article> Articles { get; set; }
    public DbSet<Author> Authors { get; set; } 
    public DbSet<Abstract> Abstracts { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Article>().HasKey(e => e.Id);
        modelBuilder.Entity<Article>().HasMany(e => e.Abstract);
        // modelBuilder.Entity<Article>().HasMany(e => e.Author);
        modelBuilder.Entity<Author>().HasKey(e => e.AuthorId);
        modelBuilder.Entity<Abstract>().HasKey(e => e.AbstractId);
        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=apiData.db");
}
