using MediateBookStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediateBookStore.Application.Contracts
{
    public interface IBookRepos : IAsyncRepos<Book>
    {
        Task<IReadOnlyList<Book>> GetAllBooksAsync(bool IncludeAuthor);
        Task<Book> GetBookbyIdAsync(Guid Id, bool IncludeAuthor);
    }
}
