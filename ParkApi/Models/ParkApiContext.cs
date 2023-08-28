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
          new Park { ParkId = 5, Name = "Ponderosa State Park", Location = "Idaho", Type = "State" },
          new Park { ParkId = 6, Name = "Beacon Rock State Park", Location = "Washington", Type = "State" },
          new Park { ParkId = 7, Name = "Yellowstone National Park", Location = "Wyoming", Type = "National" },
          new Park { ParkId = 8, Name = "Acadia National Park", Location = "Maine", Type = "National" },
          new Park { ParkId = 9, Name = "Great Sand Dunes National Park", Location = "Colorado", Type = "National" },
          new Park { ParkId = 10, Name = "Hat Rock State Park", Location = "Oregon", Type = "State" }
        );
    }
  }

}