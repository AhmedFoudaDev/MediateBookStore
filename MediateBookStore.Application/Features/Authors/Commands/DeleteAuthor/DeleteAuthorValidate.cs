using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediateBookStore.Application.Features.Authors.Commands.DeleteAuthor
{
    public class DeleteAuthorValidate : AbstractValidator<DeleteAuthorCommand>
    {
        public DeleteAuthorValidate()
        {
            RuleFor(x => x.Id).NotNull().NotEmpty();
        }
    }
}
