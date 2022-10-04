using MediateBookStore.Application.Features.Books.Commands.CreateBook;
using MediateBookStore.Application.Features.Books.Commands.DeleteBook;
using MediateBookStore.Application.Features.Books.Commands.UpdateBook;
using MediateBookStore.Application.Features.Books.Queries.GetBookDetails;
using MediateBookStore.Application.Features.Books.Queries.GetAllBooks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MediateBookStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BookController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllBooks")]
        public async Task<ActionResult<List<GetBooksListViewModel>>> GetAllBooks()
        {
            var dtos = await _mediator.Send(new GetBooksListQuery());
            return Ok(dtos);
        }

        [HttpGet("{id}", Name = "GetBookById")]
        public async Task<ActionResult<GetBookDetailViewModel>> GetBookById(Guid id)
        {
            var getEventDetailQuery = new GetBookDetailQuery() { BookId = id };
            return Ok(await _mediator.Send(getEventDetailQuery));
        }

        [HttpPost(Name = "AddBook")]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateBookCommand createBookCommand)
        {
            Guid id = await _mediator.Send(createBookCommand);
            return Ok(id);
        }

        [HttpPut(Name = "UpdateBook")]
        public async Task<ActionResult> Update([FromBody] UpdateBookCommand updateBookCommand)
        {
            await _mediator.Send(updateBookCommand);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteBook")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var deleteBookCommand = new DeleteBookCommand() { Id = id };
            await _mediator.Send(deleteBookCommand);
            return NoContent();
        }

    }
}
