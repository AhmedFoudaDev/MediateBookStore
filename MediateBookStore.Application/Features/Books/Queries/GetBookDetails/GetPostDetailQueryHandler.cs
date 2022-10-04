using AutoMapper;
using MediatR;
using MediateBookStore.Application.Contracts;
using System.Threading;
using System.Threading.Tasks;

namespace MediateBookStore.Application.Features.Books.Queries.GetBookDetails
{
    public class GetBookDetailQueryHandler : IRequestHandler<GetBookDetailQuery, GetBookDetailViewModel>
    {
        private readonly IBookRepos _BookRepos;
        private readonly IMapper _mapper;

        public GetBookDetailQueryHandler(IBookRepos BookRepos, IMapper mapper)
        {
            _BookRepos = BookRepos;
            _mapper = mapper;
        }
        public async Task<GetBookDetailViewModel> Handle(GetBookDetailQuery request, CancellationToken cancellationToken)
        {
            BookDetailsValidate validator = new BookDetailsValidate();
            var result = await validator.ValidateAsync(request.BookId);
            if (result.Errors.Any())
            {
                throw new Exception("Id Is Null Please Send Book ID");
            }
            var Post = await _BookRepos.GetBookbyIdAsync(request.BookId, true);
            return _mapper.Map<GetBookDetailViewModel>(Post);
        }
    }
}
