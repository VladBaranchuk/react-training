namespace back_end.DataAccess.Entities
{
    public class Sleepy
    {
        public SleepyType Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
    }
}
