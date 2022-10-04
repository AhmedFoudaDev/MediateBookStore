using MediatR;
using System.Collections.Generic;

namespace MediateBookStore.Application.Features.Books.Queries.GetAllBooks
{
    public class GetBooksListQuery : IRequest<List<GetBooksListViewModel>>
    {

    }
}
