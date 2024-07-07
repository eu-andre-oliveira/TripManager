namespace Application.v1.ViewModels.Responses.Trips
{
    public class TripResponse
    {
        public Guid Id { get; set; }
        public string? TripName { get; set; }
        public string? TripDescription { get; set; }
    }
}
