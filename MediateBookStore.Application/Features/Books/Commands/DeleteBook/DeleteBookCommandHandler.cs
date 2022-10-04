using AutoMapper;
using MediateBookStore.Application.Contracts;
using MediateBookStore.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediateBookStore.Application.Features.Books.Commands.DeleteBook
{
    public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommand>
    {
        private readonly IBookRepos _BookRepos;
        public DeleteBookCommandHandler(IBookRepos BookRepos)
        {
            _BookRepos = BookRepos;
        }

        public async Task<Unit> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            DeleteBookValidate validator = new DeleteBookValidate();
            var res = await validator.ValidateAsync(request);
            if (res.Errors.Any())
            {
                throw new Exception("Complete Data First");
            }
            Book Book = await _BookRepos.GetBookbyIdAsync(request.Id,false);
            await _BookRepos.DeleteAsync(Book);
            return Unit.Value;
        }
    }
}
