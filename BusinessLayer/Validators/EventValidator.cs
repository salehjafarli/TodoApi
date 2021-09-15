using BusinessLayer.DataTransferObjects;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validators
{
    public class EventValidator : AbstractValidator<EventDto>
    {
        public EventValidator()
        {
            RuleFor(t => t.Name).NotEmpty().WithMessage("Name cannot be empty");
            RuleFor(t => t.StartDate).LessThanOrEqualTo(DateTime.Now).WithMessage("Start date cannot be less than current date");
            RuleFor(t => t.EndDate).GreaterThan(DateTime.Now).WithMessage("End date must be greater than current date");
            RuleFor(t => t.Description).NotEmpty().WithMessage("Description cannot be empty");
        }
    }
}
