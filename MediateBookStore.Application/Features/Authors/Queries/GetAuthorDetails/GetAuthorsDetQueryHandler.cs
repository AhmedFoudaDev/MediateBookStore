using AutoMapper;
using MediateBookStore.Application.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediateBookStore.Application.Features.Authors.Queries.GetAuthorDetails
{
    public class GetAuthorsDetQueryHandler : IRequestHandler<GetAuthorsDetQuery, AuthorsDetVM>
    {
        private readonly IAuthorRepos authorRepos;
        private readonly IMapper mapper;

        public GetAuthorsDetQueryHandler(IAuthorRepos _AuthorRepos ,IMapper _Mapper)
        {
            authorRepos = _AuthorRepos;
            mapper = _Mapper;
        }
        public async Task<AuthorsDetVM> Handle(GetAuthorsDetQuery request, CancellationToken cancellationToken)
        {
            AuthorDetailsValidate validator = new AuthorDetailsValidate();
            var result = await validator.ValidateAsync(request.AuthorId);
            if (result.Errors.Any())
            {
                throw new Exception("Id Is Null Please Send Author ID");
            }
            var Author = await authorRepos.GetAuthorbyIdAsync(request.AuthorId);
            return mapper.Map<AuthorsDetVM>(Author);
        }
    }
}
