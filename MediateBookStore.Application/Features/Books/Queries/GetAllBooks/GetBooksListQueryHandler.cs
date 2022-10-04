using AutoMapper;
using MediateBookStore.Application.Contracts;
using MediatR;

namespace MediateBookStore.Application.Features.Books.Queries.GetAllBooks
{
    public class GetBooksListQueryHandler : IRequestHandler<GetBooksListQuery, List<GetBooksListViewModel>>
    {
        private readonly IBookRepos _BookRepos;
        private readonly IMapper _mapper;

        public GetBooksListQueryHandler(IBookRepos BookRepos, IMapper mapper)
        {
            _BookRepos = BookRepos;
            _mapper = mapper;
        }
        public async Task<List<GetBooksListViewModel>> Handle(GetBooksListQuery request, CancellationToken cancellationToken)
        {
            var allPosts = await _BookRepos.GetAllBooksAsync(true);
            return _mapper.Map<List<GetBooksListViewModel>>(allPosts);
        }
    }
}
