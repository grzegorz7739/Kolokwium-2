using Kolokwium2.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2.Data;

public class DatabaseContext : DbContext
{
    protected DatabaseContext() 
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Backpacks> Backpacks { get; set; }
    public DbSet<Character_titles> CharacterTitles { get; set; }
    public DbSet<Characters> Characters { get; set; }
    public DbSet<Items> Items { get; set; }
    public DbSet<Titles> Titles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Backpacks>().HasData(new List<Backpacks>
        {
            new Backpacks
            {
                CharacterId = 1,
                Amount = 200,
                ItemId = 2
            }
        });

        modelBuilder.Entity<Items>().HasData(new List<Items>
        {
            new Items
            {
                Id = 1,
                Name = "item1",
                Weight = 20
            },
            new Items
            {
                Id = 2,
                Name = "item2",
                Weight = 30
            }
        });

        modelBuilder.Entity<Titles>().HasData(new List<Titles>
        {
            new Titles
            {
                Id = 1,
                Name = "Title1"
            }
        });
        modelBuilder.Entity<Characters>().HasData(new List<Characters>
        {
            new Characters
            {
                Id = 1,
                CurrentWeight = 20,
                FirstName = "FirstName1",
                LastName = "LastName1",
                MaxWeight = 200
            }
        });

        modelBuilder.Entity<Character_titles>().HasData(new List<Character_titles>
        {
            new Character_titles
            {
                CharacterId = 1,
                AcquierdAt = DateTime.Parse("2024-05-31"),
                TitleId = 1
            }
        });
    }

}