using AutoMapper;
using MediatR;
using MediateBookStore.Application.Contracts;
using MediateBookStore.Domain;

namespace MediateBookStore.Application.Features.Books.Commands.CreateBook
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, Guid>
    {
        private readonly IBookRepos _BookRepos;
        private readonly IMapper _mapper;

        public CreateBookCommandHandler(IBookRepos BookRepos, IMapper mapper)
        {
            _BookRepos = BookRepos;
            _mapper = mapper;
        }
        public async Task<Guid> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
           

            CreateBookValidator validator = new CreateBookValidator();
            var result = await validator.ValidateAsync(request);

            if (result.Errors.Any())
            {
                throw new Exception("Book is not valid");
            }
            Book Book = _mapper.Map<Book>(request);
            Book = await _BookRepos.AddAsync(Book);

            return Book.Id;
        }
    }
}
