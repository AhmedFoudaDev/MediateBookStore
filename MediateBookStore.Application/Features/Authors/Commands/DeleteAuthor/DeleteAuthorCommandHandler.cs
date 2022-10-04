using AutoMapper;
using MediateBookStore.Application.Contracts;
using MediateBookStore.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediateBookStore.Application.Features.Authors.Commands.DeleteAuthor
{
    public class DeleteAuthorCommandHandler : IRequestHandler<DeleteAuthorCommand>
    {
        private readonly IAuthorRepos _authorRepos;
        public DeleteAuthorCommandHandler(IAuthorRepos authorRepos)
        {
            _authorRepos = authorRepos;
        }

        public async Task<Unit> Handle(DeleteAuthorCommand request, CancellationToken cancellationToken)
        {
            DeleteAuthorValidate validator = new DeleteAuthorValidate();
            var res = await validator.ValidateAsync(request);
            if (res.Errors.Any())
            {
                throw new Exception("Complete Data First");
            }
            Author author = await _authorRepos.GetAuthorbyIdAsync(request.Id);
            await _authorRepos.DeleteAsync(author);
            return Unit.Value;
        }
    }
}
