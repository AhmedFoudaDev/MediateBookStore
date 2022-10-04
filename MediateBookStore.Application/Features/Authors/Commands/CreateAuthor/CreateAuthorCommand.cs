using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediateBookStore.Application.Features.Authors.Commands.CreateAuthor
{
    public class CreateAuthorCommand:IRequest<Guid>
    {
        public string FullName { get; set; }
    }
}
