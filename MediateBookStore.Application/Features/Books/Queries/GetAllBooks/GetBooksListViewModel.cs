using MediateBookStore.Domain;
using System;

namespace MediateBookStore.Application.Features.Books.Queries.GetAllBooks
{
    public class GetBooksListViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public AuthorDto Author { get; set; }
    }
}
