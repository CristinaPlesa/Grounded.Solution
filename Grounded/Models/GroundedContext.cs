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
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Resource>()
      .HasData
      (
        new Resource
        {
          ResourceId = 1,
          ResourceName = "TestName",
          ResourceQuote = "Let everything happen to you, beauty and terror, just keep going, no feeling is final.",
          ResourceMeditation = "With your eyes closed, close your eyes.",
          ResourceExercise = "Everyday is a half day if you just fucking leave.",
          ResourceColor = "Orange",
          ResourceMusic = "cheerful",
          ResourceImage = "Lets see if this loads",
          ResourceLink = "https://www.sadanduseless.com/legs-or-sausages-gallery/"
        }
      );
    }
  }
}