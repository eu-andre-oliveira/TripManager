using Application.v1.ViewModels.Requests.Base;
using FluentValidation;
using FluentValidation.Results;

namespace Application.v1.ViewModels.Requests.Trips
{
    public class AddTripRequest : IRequestValidation<AddTripRequest>
    {
        public int Id { get; set; }
        public string? TripName { get; set; }
        public string? TripDescription { get; set; }
        public AbstractValidator<AddTripRequest> Validator { get => new AddTripRequestValidator(); }

        public bool Validate()
        {
            if (Validator is null)
                return false;

            ValidationResult result = Validator.Validate(this);

            return result.IsValid;
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
}
