using System.Data;
using Application.DTOs;
using Domain;
using FluentValidation;

namespace Application.Validators
{
    public class RestaurantValidator : AbstractValidator<RestaurantDTO>
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