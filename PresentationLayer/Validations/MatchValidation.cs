using CommonLayer.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Validations
{
    public class MatchValidation: AbstractValidator<Match>
    {
        public MatchValidation()
        {
            RuleFor(x => x.HomeTeamId)
            .NotEmpty().WithMessage("Home team is required")
            .GreaterThan(0).WithMessage("Please select a valid home team");

            RuleFor(x => x.AwayTeamId)
                .NotEmpty().WithMessage("Away team is required")
                .GreaterThan(0).WithMessage("Please select a valid away team")
                .NotEqual(x => x.HomeTeamId).WithMessage("Away team must be different from home team");

            RuleFor(x => x.StatusId)
                .NotEmpty().WithMessage("Status is required")
                .GreaterThan(0).WithMessage("Please select a valid status");

            RuleFor(x => x.Score)
                .NotEmpty().WithMessage("Score is required")
                .Matches(@"^\d+-\d+$").WithMessage("Score must be in format '0-0'");

            RuleFor(x => x.MatchDate)
                .NotEmpty().WithMessage("Match date is required")
                .Must(date => date != default(DateTime)).WithMessage("Please select a valid date");

            RuleFor(x => x.Fouls)
                .GreaterThanOrEqualTo(0).WithMessage("Fouls cannot be negative");

            RuleFor(x => x.Corners)
                .GreaterThanOrEqualTo(0).WithMessage("Corners cannot be negative");
        }
    }
}
