using FluentValidation;

namespace MediateBookStore.Application.Features.Books.Commands.UpdateBook
{
    public class UpdateBookValidator : AbstractValidator<UpdateBookCommand>
    {
        public UpdateBookValidator()
        {
            RuleFor(p => p.Title).NotEmpty().NotNull().MinimumLength(5).MaximumLength(100);
            RuleFor(p => p.Description).NotEmpty().NotNull().MinimumLength(5);
            RuleFor(p => p.AuthorId).NotEmpty().NotNull();
            RuleFor(p => p.Id).NotEmpty().NotNull();
            RuleFor(p => p.ImageUrl).NotEmpty().NotNull();
        }
    }
}
