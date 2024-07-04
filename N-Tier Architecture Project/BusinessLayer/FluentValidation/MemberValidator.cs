using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.FluentValidation
{
    public class MemberValidator : AbstractValidator<Member>
    {
        public MemberValidator()
        {
            RuleFor(member => member.Name).NotEmpty().WithMessage("Member name cannot be empty!!!");
            RuleFor(member => member.Name).MinimumLength(3).WithMessage("Member name must contain at least 3 character!!!");
            RuleFor(member => member.Name).MaximumLength(20).WithMessage("Member name must contain at most 20 character!!!");
        }
    }
}
