using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediateBookStore.Application.Features.Books.Queries.GetBookDetails
{
    public class BookDetailsValidate : AbstractValidator<Guid>
    {
        public BookDetailsValidate()
        {
            RuleFor(x => x).NotNull().NotEmpty();
        }
    }
}
