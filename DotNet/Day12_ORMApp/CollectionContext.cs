using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using BOL;
using System.Reflection.Emit;

namespace DAL;

public class CollectionContext : DbContext
{
    public DbSet<Product> products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        string conString = @"server=192.168.10.150;port=3306;user=dac19; password=welcome;database=dac19";
        optionsBuilder.UseMySQL(conString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Title);
            entity.Property(e => e.Description);
            entity.Property(e => e.Prize);
        });
        modelBuilder.Entity<Product>().ToTable("prod");
    }


}

