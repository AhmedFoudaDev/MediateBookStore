using AutoMapper;
using MediateBookStore.Application.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediateBookStore.Application.Features.Authors.Queries.GetAllAuthors
{
    public class GetAuthorsListQueryHandler : IRequestHandler<GetAuthorsListQuery, List<AuthorsVM>>
    {
        private readonly IAuthorRepos authorRepos;
        private readonly IMapper mapper;

        public GetAuthorsListQueryHandler(IAuthorRepos _AuthorRepos ,IMapper _Mapper)
        {
            authorRepos = _AuthorRepos;
            mapper = _Mapper;
        }
        public async Task<List<AuthorsVM>> Handle(GetAuthorsListQuery request, CancellationToken cancellationToken)
        {
            var AllAuthors = await authorRepos.GetAllAuthorsAsync();
            return mapper.Map<List<AuthorsVM>>(AllAuthors);
        }
    }
}
