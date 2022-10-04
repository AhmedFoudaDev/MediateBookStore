using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediateBookStore.Application.Features.Authors.Commands.UpdateAuthor
{
    public class UpdateAuthorValidate : AbstractValidator<UpdateAuthorCommand>
    {
        public UpdateAuthorValidate()
        {
            RuleFor(x => x.Id).NotNull().NotEmpty();
            RuleFor(x => x.FullName).NotNull().NotEmpty();
        }
    }
}
