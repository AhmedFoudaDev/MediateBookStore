using MediateBookStore.Application.Contracts;
using MediateBookStore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediateBookStore.Persistence.Repos
{
    public class AuthorRepos : BaseRepos<Author>, IAuthorRepos
    {
        public AuthorRepos(BookStoreDBContext dbContext) : base(dbContext)
        {
        }

        public async Task<IReadOnlyList<Author>> GetAllAuthorsAsync()
        {
            List<Author> allAuthors = new List<Author>();
            allAuthors =  await _dbContext.Authors.ToListAsync();
            return allAuthors;
        }
        public async Task<Author> GetAuthorbyIdAsync(Guid Id)
        {
            Author _Author = new Author();
            _Author =  await GetByIDAsync(Id);
            return _Author;
        }
    }
}
