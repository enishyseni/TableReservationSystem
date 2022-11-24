using Domain;
using FluentValidation;

namespace Application.Validators
{
    public class BaseValidator : AbstractValidator<Base>
    {
        public BaseValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.DateCreated).NotEmpty();
            RuleFor(x => x.Active).NotEmpty();
            RuleFor(x => x.Deleted).NotEmpty();
            RuleFor(x => x.DateDeleted).NotEmpty();
            RuleFor(x => x.DeletedBy).NotEmpty();
        }
    }
}