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
          ResourceName = "Anxiety",
          ResourceQuote = "It's okay to talk about mental health issues. It's okay to admit that you have anxiety. It doesn't take away from your power. It's totally normal. - Torrey DeVitto",
          ResourceExercise = "Everyday is a half day if you just fucking leave.",
          ResourceColor = "Orange",
          ResourceMusic = "cheerful",
          ResourceImage = "Lets see if this loads",
          ResourceLink = "https://www.sadanduseless.com/legs-or-sausages-gallery/"
        },
        new Resource
        {
          ResourceId = 2,
          ResourceName = "Guilt",
          ResourceQuote = "I think the saddest thing is how people take on guilt and blame that isn't theirs or doesn't belong to them, and how hard it is to forgive yourself. - Wunmi Mosaku",
          ResourceExercise = "",
          ResourceColor = "",
          ResourceMusic = "",
          ResourceImage = "../",
          ResourceLink = ""
        },
        new Resource
        {
          ResourceId = 3,
          ResourceName = "Depression",
          ResourceQuote = "My mental health problems are real and they are valid. I will not judge myself for the bad days when I can barely get out of bed. I will not make myself feel worse because someone else appears to be handling their mental illness better than I am handling mine. Recovery is not a competition. - Matt Joseph Diaz",
          ResourceExercise = "",
          ResourceColor = "",
          ResourceMusic = "",
          ResourceImage = "",
          ResourceLink = ""
        },
         new Resource
        {
          ResourceId = 4,
          ResourceName = "Restless",
          ResourceQuote =  "Sometimes the most important thing in a whole day is the rest we take between two deep breaths. – Etty Hillesum.",
          ResourceExercise = "5, 4, 3, 2, 1 Mindfulness exercise",
          ResourceColor = "blue-green",
          ResourceMusic = "https://open.spotify.com/track/6epIhVc3Zn6AUZ27EsOLZt?si=5d8e25c2b00d4d6e",
          ResourceImage = "",
          ResourceLink = "https://drsarahallen.com/7-ways-to-calm/"
        },
         new Resource
        {
          ResourceId = 5,
          ResourceName = "Fear",
          ResourceQuote = "Fears are nothing more than a state of mind. - Napoleon Hill",
          ResourceExercise = "Box Breathing",
          ResourceColor = "Lavender",
          ResourceMusic = "https://open.spotify.com/track/4z0X671zhnwxj9YklzDyhv?si=abf5c8e6129b498f",
          ResourceImage = "",
          ResourceLink = "https://www.healthline.com/health/box-breathing"
        }, 
         new Resource
        {
          ResourceId = 6,
          ResourceName = "Depression",
          ResourceQuote = "",
          ResourceExercise = "",
          ResourceColor = "",
          ResourceMusic = "",
          ResourceImage = "",
          ResourceLink = ""
        },
         new Resource
        {
          ResourceId = 7,
          ResourceName = "Depression",
          ResourceQuote = "",
          ResourceExercise = "",
          ResourceColor = "",
          ResourceMusic = "",
          ResourceImage = "",
          ResourceLink = ""
        },
         new Resource
        {
          ResourceId = 8,
          ResourceName = "Depression",
          ResourceQuote = "",
          ResourceExercise = "",
          ResourceColor = "",
          ResourceMusic = "",
          ResourceImage = "",
          ResourceLink = ""
        },
         new Resource
        {
          ResourceId = 9,
          ResourceName = "Depression",
          ResourceQuote = "",
          ResourceExercise = "",
          ResourceColor = "",
          ResourceMusic = "",
          ResourceImage = "",
          ResourceLink = ""
        },
         new Resource
        {
          ResourceId = 10,
          ResourceName = "Depression",
          ResourceQuote = "",
          ResourceExercise = "",
          ResourceColor = "",
          ResourceMusic = "",
          ResourceImage = "",
          ResourceLink = ""
        }
      );
    }
  }
}