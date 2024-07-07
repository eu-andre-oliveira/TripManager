using Application.v1.ViewModels.Requests.Base;
using FluentValidation;
using System.Text.Json.Serialization;

namespace Application.v1.ViewModels.Requests.Trips
{
    public class AddTripRequest : IRequestValidation<AddTripRequest>
    {
        public string? TripName { get; set; }
        public string? TripDescription { get; set; }
        [JsonIgnore]
        public AbstractValidator<AddTripRequest> Validator { get; }
        [JsonIgnore]
        public IEnumerable<string>? ValidationErrors { get; set; } = [];
        public AddTripRequest()
        {
            ValidationErrors = [];
            Validator = new AddTripRequestValidator();
        }
        public bool Validate()
        {
            return ((IRequestValidation<AddTripRequest>)this).Validate(this);
        }
    }
    public class AddTripRequestValidator : AbstractValidator<AddTripRequest>
    {
        public AddTripRequestValidator()
        {
            RuleFor(x => x.TripName)
            .NotEmpty().WithMessage("Name is required.")
            .MaximumLength(100).WithMessage("Name must not exceed 100 characters.");
        }
    }
}
