using back_end.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace back_end.DataAccess.Configurations
{
    public class FatigueConfig : IEntityTypeConfiguration<Fatigue>
    {
        public void Configure(EntityTypeBuilder<Fatigue> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.HasData(
                new Fatigue()
                {
                    Id = FatigueType.FullyAlert,
                    Title = "Fully alert, wide awake",
                    Description = @"You are completely awake, alert, and feel no signs of fatigue.
                        You are well-rested and have high mental and physical energy."
                },
                new Fatigue()
                {
                    Id = FatigueType.VeryLively,
                    Title = "Very lively, responsivem but not at peak",
                    Description = @"You are mostly awake but might feel slightly tired or fatigued.
                        Your alertness is generally good, but you may notice a minor decrease 
                        in energy compared to being fully alert."
                },
                new Fatigue()
                {
                    Id = FatigueType.Okay,
                    Title = "Okay, somewhat fresh",
                    Description = @"You are more awake than asleep, but do feel some fatigue. You
                        might be experiencing some difficultly in maintaining peak alterness
                        and your energy levels are decreasing."
                },
                new Fatigue()
                {
                    Id = FatigueType.LittleTired,
                    Title = "A little tired, less than fresh",
                    Description = @"You are equally awake and asleep, indicating moderate fatigue.
                        You might find it challenging to stay fully alert and drowsiness is
                        becoming more apparent."
                },
                new Fatigue()
                {
                    Id = FatigueType.ModeratelyTired,
                    Title = "Moderately tired, let down",
                    Description = @"you are more asleep than awake and significant fatigue is setting in.
                        Your ability to stay alert and focussed is compromised and you may struggle
                        to remain awake."
                },
                new Fatigue()
                {
                    Id = FatigueType.ExtremelyTired,
                    Title = "Extremely tired, very difficult to concentrate",
                    Description = @"You are mostly alseep but can still be awakened with relative ease.
                        Extreme fatigue has taken over and is is becoming increasingly challenging
                        to stay awake and alert."
                },
                new Fatigue()
                {
                    Id = FatigueType.CompletelyExhausted,
                    Title = "Completely exhausted, unable to function effectively",
                    Description = @"You are completely asleep and difficult to awaken. This is the
                        highest level of fatigue. You are in a deep sleep and are not fit for tasks
                        requiring wakefulness."
                }
            );
        }
    }
}
