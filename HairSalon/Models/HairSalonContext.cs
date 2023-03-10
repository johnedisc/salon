using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
  public class HairSalonContext : DbContext
  {
    public DbSet<> Categories { get; set; }
    public DbSet<Item> Items { get; set; }

    public HairSalonContext(DbContextOptions options) : base(options) { }
  }
}
