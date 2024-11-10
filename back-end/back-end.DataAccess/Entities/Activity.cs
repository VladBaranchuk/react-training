namespace back_end.DataAccess.Entities
{
    public class Activity
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required int Consumption {  get; set; }
        public Guid DayId { get; set; }
    }
}
