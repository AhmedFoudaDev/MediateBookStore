using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediateBookStore.Application.Features.Authors.Commands.CreateAuthor
{
    public class CreateAuthorValidate:AbstractValidator<CreateAuthorCommand>
    {
        public CreateAuthorValidate()
        {
            RuleFor(x => x.FullName).NotNull().NotEmpty();
        }
    }
}
