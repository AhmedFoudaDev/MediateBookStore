using MediateBookStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediateBookStore.Application.Contracts
{
    public interface IAuthorRepos:IAsyncRepos<Author>
    {
        Task<IReadOnlyList<Author>> GetAllAuthorsAsync();
        Task<Author> GetAuthorbyIdAsync(Guid Id);
    }
}
