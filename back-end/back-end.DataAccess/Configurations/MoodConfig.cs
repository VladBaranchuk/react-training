using back_end.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace back_end.DataAccess.Configurations
{
    public class MoodConfig : IEntityTypeConfiguration<Mood>
    {
        public void Configure(EntityTypeBuilder<Mood> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.HasData(
                new Mood()
                {
                    Id = MoodType.Elated,
                    Title = "Elated",
                    Description = @"At this highest stage, you fell extremely happy and excited.
                        Your energy levels are high, and you might feel a strong sense of enthusiasm
                        and optimism."
                },
                new Mood()
                {
                    Id = MoodType.Happy,
                    Title = "Happy",
                    Description = @"You feel positive and content. You might find joy in everyday
                        activities and feel generally satisfied with life."
                },
                new Mood()
                {
                    Id = MoodType.Neutral,
                    Title = "Neutral",
                    Description = @"You feel neither particularly happy or sad. Your mood is stable,
                        and you can go about your day without strong emotional swings."
                },
                new Mood()
                {
                    Id = MoodType.Sad,
                    Title = "Sad",
                    Description = @"You feel down or unhappy, but not as intensely as in a depressed state.
                        This mood can be triggered by specific events or situations."
                },
                new Mood()
                {
                    Id = MoodType.Depressed,
                    Title = "Depressed",
                    Description = @"At this stage, you might feel very low, sad, or hopeless.
                        It can be difficult to find motivation or joy in daily activities."
                }
            );
        }
    }
}
