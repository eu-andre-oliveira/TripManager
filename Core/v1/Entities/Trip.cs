namespace Core.v1.Entities
{
    public class Trip
    {
        public int Id { get; set; }
        public required string TripName { get; set; }
        public required string TripDescription { get; set; }
    }
}
