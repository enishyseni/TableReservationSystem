using Application.DTOs;
using Domain;
using FluentValidation;

namespace Application.Validators
{
    public class ReservationValidator : AbstractValidator<ReservationDTO> 
    {
        public ReservationValidator()
        {
            RuleFor(x => x.PhoneNumber).NotEmpty();
            RuleFor(x => x.Email).NotEmpty();
            RuleFor(x => x.StartDateTime).NotEmpty();
            RuleFor(x => x.NumberOfPersons).NotEmpty();
            RuleFor(x => x.Status).NotEmpty();
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.User).NotEmpty();
            RuleFor(x => x.Restaurant).NotEmpty();
        }
    }
}