namespace Core.v1.Entities
{
    public class Trip
    {
        public Guid Id { get; set; }
        public required string TripName { get; set; }
        public required string TripDescription { get; set; }
    }
}
