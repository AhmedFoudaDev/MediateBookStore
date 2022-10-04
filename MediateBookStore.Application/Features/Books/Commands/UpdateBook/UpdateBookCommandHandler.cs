using AutoMapper;
using MediatR;
using MediateBookStore.Application.Contracts;
using MediateBookStore.Domain;

namespace MediateBookStore.Application.Features.Books.Commands.UpdateBook
{
    public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommand>
    {
        private readonly IBookRepos _BookRepos;
        private readonly IMapper _mapper;

        public UpdateBookCommandHandler(IBookRepos BookRepos, IMapper mapper)
        {
            _BookRepos = BookRepos;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {


            UpdateBookValidator validator = new UpdateBookValidator();
            var result = await validator.ValidateAsync(request);

            if (result.Errors.Any())
            {
                throw new Exception("Book is not valid");
            }
            Book Book = _mapper.Map<Book>(request);
            await _BookRepos.UpdateAsync(Book);
            return Unit.Value;
        }
    }
}
