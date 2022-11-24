using Domain;
using FluentValidation;

namespace Application.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.PhoneNumber).NotEmpty();
            RuleFor(x => x.Email).NotEmpty();
            RuleFor(x => x.Age).NotEmpty();
            RuleFor(x => x.Restaurants).NotEmpty();
        }
    }
}