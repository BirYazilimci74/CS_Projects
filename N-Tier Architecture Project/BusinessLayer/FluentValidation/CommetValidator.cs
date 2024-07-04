using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.FluentValidation
{
    public class CommetValidator : AbstractValidator<Comment>
    {
        public CommetValidator()
        {
            RuleFor(comment => comment.Title).NotEmpty().WithMessage("Comment title cannot be empty!!!");
            RuleFor(comment => comment.Title).MaximumLength(250).WithMessage("Comment title cannot be longer than 250 character!!!");
            RuleFor(comment => comment.Status).NotEmpty().WithMessage("Comment status must be True or False");
        }
    }
}
