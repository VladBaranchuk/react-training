namespace back_end.DataAccess.Entities
{
    public class Profile
    {
        public Guid Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required double Weight { get; set; }
        public required DateTime StartDay { get; set; }

        public required ICollection<Day> Days { get; set; }
    }
}
