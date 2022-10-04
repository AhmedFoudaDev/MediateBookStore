using AutoMapper;
using MediateBookStore.Application.Contracts;
using MediateBookStore.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediateBookStore.Application.Features.Authors.Commands.UpdateAuthor
{
    public class CreateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommand>
    {
        private readonly IAuthorRepos _authorRepos;
        private readonly IMapper _mapper;

        public CreateAuthorCommandHandler(IAuthorRepos authorRepos , IMapper mapper)
        {
            _authorRepos = authorRepos;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
        {
            UpdateAuthorValidate validator = new UpdateAuthorValidate();
            var res = await validator.ValidateAsync(request);
            if (res.Errors.Any())
            {
                throw new Exception("Complete Data First");
            }
            Author author = _mapper.Map<Author>(request);
            await _authorRepos.UpdateAsync(author);
            return Unit.Value;
        }
    }
}
