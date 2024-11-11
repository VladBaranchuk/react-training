using back_end.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace back_end.DataAccess.Configurations
{
    public class SleepyConfig : IEntityTypeConfiguration<Sleepy>
    {
        public void Configure(EntityTypeBuilder<Sleepy> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.HasData(
                new Sleepy()
                {
                    Id = SleepyType.Cheerful,
                    Title = "Cheerful and rested",
                    Description = @"You feel fully awake, alert, and energetic. Your mind is clear,
                        and you are ready to take on the day with a positive attitude."
                },
                new Sleepy()
                {
                    Id = SleepyType.AwakeButTired,
                    Title = "Awake but tired",
                    Description = @"you are awake and can perform daily activities, but you feel
                        a persistent sense of tiredness. You might need a coffe or a short nap to
                        boost your energy."
                },
                new Sleepy() 
                { 
                    Id = SleepyType.Drowsy,
                    Title = "Drowsy",
                    Description = @"You feel a strong urge to sleep, but you can still function.
                        Your reactions are slower, and you might feel a bit foggy or sluggish."
                },
                new Sleepy()
                {
                    Id = SleepyType.VerySleepy,
                    Title = "Very sleppy",
                    Description = @"You are struggling to stay awake, and your body feels heavy.
                        You might experience frequent yawning and have difficulty focusing on tasks."
                },
                new Sleepy()
                {
                    Id = SleepyType.CompletelyExhausted,
                    Title = "Completely exhausted",
                    Description = @"At this level, you feel completely drained and can barely keep
                        your eyes open. Concentration is nearly impossible. and you might find
                        yourself nodding off frequently."
                }
            );
        }
    }
}
