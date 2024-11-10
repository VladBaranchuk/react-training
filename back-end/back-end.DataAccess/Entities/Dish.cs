namespace back_end.DataAccess.Entities
{
    public class Dish
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required double Protein { get; set; }
        public required double Fat { get; set; }
        public required double Carbohydrate { get; set; }
        public required double Weight { get; set; }

        public required ICollection<Guid> Days { get; set; }
    }
}
