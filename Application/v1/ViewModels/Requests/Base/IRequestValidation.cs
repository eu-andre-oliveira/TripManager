using FluentValidation;
using FluentValidation.Results;
using System.Text.Json.Serialization;

namespace Application.v1.ViewModels.Requests.Base
{
    public interface IRequestValidation<T>
    {
        [JsonIgnore]
        IEnumerable<string>? ValidationErrors { get; set; }
        [JsonIgnore]
        AbstractValidator<T> Validator { get; }
        bool Validate();

        public bool Validate(T instance)
        {
            if (Validator is null)
                return false;

            ValidationResult result = Validator.Validate(instance);
            ValidationErrors = result.Errors.Select(x => x.ErrorMessage);

            return result.IsValid;
        }
    }
}
