using MediatR;
using System;

namespace MediateBookStore.Application.Features.Books.Commands.CreateBook
{
    public class CreateBookCommand : IRequest<Guid>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public Guid AuthorId { get; set; }
    }
}
