using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediateBookStore.Application.Features.Books.Commands.DeleteBook
{
    public class DeleteBookValidate : AbstractValidator<DeleteBookCommand>
    {
        public DeleteBookValidate()
        {
            RuleFor(x => x.Id).NotNull().NotEmpty();
        }
    }
}
