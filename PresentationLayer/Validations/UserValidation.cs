using CommonLayer.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Validations
{
    public class UserValidation : AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(user => user.Name)
                .NotEmpty().WithMessage("Name can't be empty")
                .MinimumLength(3).WithMessage("Name must be have more than 3 characters");

            RuleFor(user => user.Password)
                .NotEmpty().WithMessage("Password can't be empty")
                .MinimumLength(6).WithMessage("The password must be at least 6 characters.")
                .Matches("[A-Z]").WithMessage("The password must contain at least one capital letter.")
                .Matches("[a-z]").WithMessage("The password must contain at least one lowercase letter.")
                .Matches("[0-9]").WithMessage("The password must contain at least one number.");

            RuleFor(user => user.Email)
                .NotEmpty().WithMessage("Email can't be empty")
                .EmailAddress().WithMessage("The email must be in a valid format.");

            RuleFor(user => user.RoleId)
                .GreaterThan(0).WithMessage("You must select a valid role.");
        }
    }

}
