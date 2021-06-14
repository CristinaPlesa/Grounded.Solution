using Microsoft.EntityFrameworkCore;

namespace Grounded.Models
{
  public class GroundedContext : DbContext
  {
    public GroundedContext(DbContextOptions<GroundedContext> options)
    : base(options)
    { 
    }

    public DbSet<Resource> Resources { get; set; }
    // protected override void OnModelCreating(ModelBuilder builder)
    // {
    //   builder.Entity<Resource>()
    //   .HasData
    //   (
    //   );
    // }
  }
}