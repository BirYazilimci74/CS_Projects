using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.FluentValidation
{
    public class LocationValidator : AbstractValidator<Location>
    {
        public LocationValidator()
        {
            RuleFor(location => location.Name).NotEmpty().WithMessage("Location name cannot be empty!!!");
            RuleFor(location => location.Name).MinimumLength(2).WithMessage("Location name must contain at least 2 character!!!");
        }
    }
}
