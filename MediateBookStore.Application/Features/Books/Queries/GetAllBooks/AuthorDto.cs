using System;

namespace MediateBookStore.Application.Features.Books.Queries.GetAllBooks
{
    public class AuthorDto
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
    }
}
