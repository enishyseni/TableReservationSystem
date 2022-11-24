using System.Data;
using Domain;
using FluentValidation;

namespace Application.Validators
{
    public class RestaurantValidator : AbstractValidator<Restaurant>
    {
        public RestaurantValidator()
        {
            RuleFor(x => x.Location).NotEmpty();
            RuleFor(x => x.Type).NotEmpty();
            RuleFor(x => x.MainImage).NotEmpty();
            RuleFor(x => x.Images).NotEmpty();
            RuleFor(x => x.Users).NotEmpty();
        }
    }
}