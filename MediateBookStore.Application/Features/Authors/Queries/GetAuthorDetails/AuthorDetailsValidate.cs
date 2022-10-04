using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediateBookStore.Application.Features.Authors.Queries.GetAuthorDetails
{
    public class AuthorDetailsValidate:AbstractValidator<Guid>
    {
        public AuthorDetailsValidate()
        {
            RuleFor(x => x).NotNull().NotEmpty();
        }
    }
}
