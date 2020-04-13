using estudo_strategy.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estudo_strategy.Utils.Validator
{
    public class TicketInfoValidator : AbstractValidator<ITicketInfo>
    {
        public TicketInfoValidator()
        {
            RuleFor(a => a.Name)
                .NotEmpty()
                .MaximumLength(255)
                .WithMessage("Name cannot be empty");

            RuleFor(a => a.Description)
                .NotEmpty()
                .MaximumLength(255)
                .WithMessage("Invalid Description");
        }
    }
}
