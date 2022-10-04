using AutoMapper;
using MediateBookStore.Application.Contracts;
using MediateBookStore.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediateBookStore.Application.Features.Authors.Commands.CreateAuthor
{
    public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommand,Guid>
    {
        private readonly IAuthorRepos _authorRepos;
        private readonly IMapper _mapper;

        public CreateAuthorCommandHandler(IAuthorRepos authorRepos , IMapper mapper)
        {
            _authorRepos = authorRepos;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
        {
            CreateAuthorValidate validator = new CreateAuthorValidate();
            var res = await validator.ValidateAsync(request);
            if (res.Errors.Any())
            {
                throw new Exception("Complete Data First");
            }
            Author author = _mapper.Map<Author>(request);
            author = await _authorRepos.AddAsync(author);
            return author.Id;
        }
    }
}
