
using Ef_Core_Application.Models;
using FluentValidation;

namespace Ef_Core_Application.Validators
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(s => s.Name)
                .NotEmpty().WithMessage("Student name is required.")
                .MaximumLength(100).WithMessage("Student name cannot exceed 100 characters.");

            RuleFor(s => s.Level)
                .GreaterThan(0).WithMessage("Level must be greater than 0.")
                .LessThanOrEqualTo(4).WithMessage("Level must be between 1 and 4.");

            RuleFor(s => s.SessionId)
                .GreaterThan(0).WithMessage("Session ID must be a valid reference.");

        }
    }
}
