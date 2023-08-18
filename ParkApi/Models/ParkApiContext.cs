using Microsoft.EntityFrameworkCore;

namespace ParkApi.Models
{
    public class ParkApiContext : DbContext
    {
        public DbSet<Park> Parks { get; set; }

        public ParkApiContext(DbContextOptions<ParkApiContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Park>()
              .HasData(
                new Park { ParkId = 1, Name = "Crater Lake National Park", Location = "Oregon", Type = "National" },
                new Park { ParkId = 2, Name = "Zion National Park", Location = "Utah", Type = "National" },
                new Park { ParkId = 3, Name = "Smith Rock State Park", Location = "Oregon", Type = "State" },
                new Park { ParkId = 4, Name = "Yosemite National Park", Location = "California", Type = "National" },
                new Park { ParkId = 5, Name = "Ponderosa State Park", Location = "Idaho", Type = "State" }
              );
        }
    }

}