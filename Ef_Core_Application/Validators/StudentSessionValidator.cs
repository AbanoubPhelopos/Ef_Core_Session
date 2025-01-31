using Ef_Core_Application.Models;
using FluentValidation;

namespace Ef_Core_Application.Validators
{
    public class StudentSessionValidator : AbstractValidator<StudentSessionHelper>
    {
        public StudentSessionValidator()
        {
            RuleFor(ss => ss.StudentId)
                .GreaterThan(0).WithMessage("Student ID must be valid.");

            RuleFor(ss => ss.SessionId)
                .GreaterThan(0).WithMessage("Session ID must be valid.");

            RuleFor(ss => ss.HelpDate)
                .NotEmpty().WithMessage("Help date is required.")
                .LessThanOrEqualTo(DateTime.UtcNow).WithMessage("Help date cannot be in the future.");
        }
    }
}
