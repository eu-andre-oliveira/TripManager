namespace Application.v1.ViewModels.Responses.Registrations
{
    public class RegistrationResponse
    {
        public Guid Id { get; set; }
        public string? RegisterName { get; set; }
        public Guid TripId { get; set; }
        public string? TripName { get; set; }
    }
}
