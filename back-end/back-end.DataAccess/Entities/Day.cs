namespace back_end.DataAccess.Entities
{
    public class Day
    {
        public Guid Id { get; set; }
        public required double EarlyWeight { get; set; }
        public required DateTime StartSleep { get; set; }
        public required DateTime FinishSleep { get; set; }
        public required FatigueType Fatigue { get; set; }
        public required SleepyType Sleepy { get; set; }
        public required MoodType Mood { get; set; } 
        public bool DoDrink { get; set; }
        public bool DoSmoke { get; set; }
        public bool DoMorningExamples { get; set; }
        public Guid ProfileId { get; set; }

        public required ICollection<Activity> Activities { get; set; }
        public required ICollection<Dish> Dishes { get; set; }
    }
}
