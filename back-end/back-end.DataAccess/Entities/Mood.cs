namespace back_end.DataAccess.Entities
{
    public class Mood
    {
        public MoodType Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
    }
}
