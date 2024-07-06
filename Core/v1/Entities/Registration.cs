namespace Core.v1.Entities
{
    public class Registration
    {
        public int Id { get; set; }
        public required string RegisterName { get; set; }
        public int TripId { get; set; }
    }
}
