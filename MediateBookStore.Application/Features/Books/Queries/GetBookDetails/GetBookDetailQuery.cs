using MediatR;
using System;

namespace MediateBookStore.Application.Features.Books.Queries.GetBookDetails
{
    public class GetBookDetailQuery : IRequest<GetBookDetailViewModel>
    {
        public Guid BookId { get; set; }
    }
}
