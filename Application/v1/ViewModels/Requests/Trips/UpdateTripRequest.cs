using Application.v1.ViewModels.Requests.Base;
using FluentValidation;
using System.Text.Json.Serialization;

namespace Application.v1.ViewModels.Requests.Trips
{
    public class UpdateTripRequest : IRequestValidation<UpdateTripRequest>
    {
        public Guid Id { get; set; }
        public string? TripName { get; set; }
        public string? TripDescription { get; set; }
        [JsonIgnore]
        public IEnumerable<string>? ValidationErrors { get; set ; }
        [JsonIgnore]
        public AbstractValidator<UpdateTripRequest> Validator { get; }

        public UpdateTripRequest()
        {
            ValidationErrors = [];
            Validator = new UpdateTripRequestValidator();
        }
        public bool Validate()
        {
            return ((IRequestValidation<UpdateTripRequest>)this).Validate(this);
        }
    }

    public class UpdateTripRequestValidator : AbstractValidator<UpdateTripRequest>
    {
        public UpdateTripRequestValidator()
        {
            RuleFor(x => x.TripName)
            .NotEmpty().WithMessage("Name is required.")
            .MaximumLength(100).WithMessage("Name must not exceed 100 characters.");

            RuleFor(x => x.Id)
             .NotEqual(Guid.Empty).WithMessage("Invalid Trip Id.")
             .NotNull().WithMessage("Trip Id is required.");

        }
    }
}
