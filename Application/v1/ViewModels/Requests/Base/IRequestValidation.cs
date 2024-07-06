using FluentValidation;
using FluentValidation.Results;

namespace Application.v1.ViewModels.Requests.Base
{
    public interface IRequestValidation<T>
    {
        bool Validate();
        public AbstractValidator<T> Validator { get; }
    }
}
