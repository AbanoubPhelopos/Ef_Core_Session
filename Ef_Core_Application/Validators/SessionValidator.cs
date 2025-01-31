using Ef_Core_Application.Models;
using FluentValidation;

namespace Ef_Core_Application.Validators
{
    public class SessionValidator : AbstractValidator<Session>
    {
        public SessionValidator()
        {
            RuleFor(s => s.Topic)
                .NotEmpty().WithMessage("Session topic is required.")
                .MaximumLength(50).WithMessage("Session topic cannot exceed 50 characters.");
        }
    }
}
