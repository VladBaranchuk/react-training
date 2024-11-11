using back_end.DataAccess.Configurations;
using back_end.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace back_end.DataAccess
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Day> Days { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Fatigue> Fatigue { get; set; }
        public DbSet<Mood> Mood { get; set; }
        public DbSet<Sleepy> Sleepy { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ActivityConfig());
            modelBuilder.ApplyConfiguration(new DayConfig());
            modelBuilder.ApplyConfiguration(new DishConfig());
            modelBuilder.ApplyConfiguration(new FatigueConfig());
            modelBuilder.ApplyConfiguration(new MoodConfig());
            modelBuilder.ApplyConfiguration(new ProfileConfig());
            modelBuilder.ApplyConfiguration(new SleepyConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
