using CommonLayer.Models;
using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Validations
{
    public class TeamValidation: AbstractValidator<Team>
    {
        public TeamValidation()
        {
            RuleFor(team => team.ManagerId).NotEmpty().WithMessage("ManagerId is required.");
            RuleFor(team => team.TeamName).NotEmpty().WithMessage("TeamName is required.");
            RuleFor(team => team.Wins).GreaterThanOrEqualTo(0).WithMessage("Wins must be a non-negative integer.");
            RuleFor(team => team.Loses).GreaterThanOrEqualTo(0).WithMessage("Loses must be a non-negative integer.");
            RuleFor(team => team.Points).GreaterThanOrEqualTo(0).WithMessage("Points must be a non-negative integer.");
        }

    }
}
