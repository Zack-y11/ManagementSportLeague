using CommonLayer.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Validations
{
    public class UserPlayerValidation: AbstractValidator<CoachPlayer>
    {
        public UserPlayerValidation() {
            RuleFor(x => x.PlayerName)
           .NotEmpty().WithMessage("Player name is required")
           .Length(3, 50).WithMessage("Player name must be between 3 and 50 characters");

            RuleFor(x => x.Position)
                .NotEmpty().WithMessage("Position is required")
                .Length(3, 50).WithMessage("Position must be between 3 and 50 characters");

            RuleFor(x => x.Goals)
                .GreaterThanOrEqualTo(0).WithMessage("Goals cannot be negative");

            RuleFor(x => x.Assists)
                .GreaterThanOrEqualTo(0).WithMessage("Assists cannot be negative");

            RuleFor(x => x.Birthdate)
            .NotEmpty().WithMessage("Birthdate is required")
            .Must(date => DateTime.TryParse(date, out _)).WithMessage("Invalid date format");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required")
                .EmailAddress().WithMessage("Invalid email format");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required")
                .Length(6, 50).WithMessage("Password must be between 6 and 50 characters");
        }
    }
}
