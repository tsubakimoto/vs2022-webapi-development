using Microsoft.EntityFrameworkCore;

namespace VS2022WebApiDevelopment.Data;

public class VS2022WebApiDevelopmentContext : DbContext
{
    public VS2022WebApiDevelopmentContext(DbContextOptions<VS2022WebApiDevelopmentContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contact>().HasData(GetSeedDataContacts());
    }

    public DbSet<Contact> Contact { get; set; } = default!;

    private Contact[] GetSeedDataContacts() => new Contact[] {
        new Contact {
            Id = 1,
            Name = "Sayed Hashimi",
            Email = "sayed@example.com",
            Phone = "555-111-2222"
        },
        new Contact {
            Id=2,
            Name = "Mads Kristensen",
            Email = "mads@example.com",
            Phone = "555-111-3333"
        },
        new Contact {
            Id=3,
            Name = "Eline Barstad",
            Email = "elineb@example.com",
            Phone = "555-111-4444"
        },
        new Contact {
            Id=4,
            Name = "Theodore Lamy",
            Email = "theol@example.com",
            Phone = "555-111-5555"
        },
        new Contact {
            Id=5,
            Name = "María Zelaya",
            Email = "mariaz@example.com",
            Phone = "555-111-6666"
        },
        new Contact {
            Id=6,
            Name = "Kubanychbek Sagynbek",
            Email = "kubans@example.com",
            Phone = "555-111-7777"
        },
        new Contact {
            Id=7,
            Name = "Denise Bourgeois",
            Email = "deniseb@example.com",
            Phone = "555-111-8888"
        },
        new Contact {
            Id=8,
            Name = "Robin Danielsen",
            Email = "robind@example.com",
            Phone = "555-111-9999"
        }
    };
}
