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
    public class BookRepos : BaseRepos<Book>, IBookRepos
    {
        public BookRepos(BookStoreDBContext dbContext) : base(dbContext)
        {
        }


        public async Task<IReadOnlyList<Book>> GetAllBooksAsync(bool includeAuthor)
        {
            List<Book> allBooks = new List<Book>();
            allBooks = includeAuthor ? await _dbContext.Books.Include(x => x.Author).ToListAsync() : await _dbContext.Books.ToListAsync();
            return allBooks;
        }

        public async Task<Book> GetBookbyIdAsync(Guid Id, bool IncludeAuthor)
        {
            Book _Book = new Book();
            _Book = IncludeAuthor ? await _dbContext.Books.Include(x => x.Author).FirstOrDefaultAsync(x => x.Id == Id) : await GetByIDAsync(Id);
            return _Book;
        }
    }
}
