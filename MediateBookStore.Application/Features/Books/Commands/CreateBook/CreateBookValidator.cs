using FluentValidation;

namespace MediateBookStore.Application.Features.Books.Commands.CreateBook
{
    public class CreateBookValidator : AbstractValidator<CreateBookCommand>
    {
        public CreateBookValidator()
        {
            RuleFor(p => p.Title)
                .NotEmpty()
                .NotNull()
                .MaximumLength(100);
            
            RuleFor(p => p.Description)
                .NotEmpty()
                .NotNull();

            RuleFor(p => p.AuthorId)
             .NotEmpty()
             .NotNull();

            RuleFor(p => p.ImageUrl)
            .NotEmpty()
            .NotNull();
        }
    }
}
