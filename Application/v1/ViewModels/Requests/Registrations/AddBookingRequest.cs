using Application.v1.ViewModels.Requests.Base;
using Application.v1.ViewModels.Requests.Trips;
using FluentValidation;
using System.Text.Json.Serialization;

namespace Application.v1.ViewModels.Requests.Registrations
{
    public class AddBookingRequest : IRequestValidation<AddBookingRequest>
    {
        public AddBookingRequest()
        {
            ValidationErrors = [];
            Validator = new AddBookingValidator();

        }
        public string? RegisterName { get; set; }
        public Guid TripId { get; set; }
        [JsonIgnore]
        public IEnumerable<string>? ValidationErrors { get ; set ; }
        [JsonIgnore]

        public AbstractValidator<AddBookingRequest> Validator { get; }

        public bool Validate()
        {
            throw new NotImplementedException();
        }
    }
    public class AddBookingValidator : AbstractValidator<AddBookingRequest>
    {
        public AddBookingValidator()
        {
            RuleFor(x => x.RegisterName)
            .NotEmpty().WithMessage("Name is required.")
            .MaximumLength(50).WithMessage("Name must not exceed 50 characters.");
        }
    }
}
