using MediateBookStore.Application.Features.Authors.Commands.CreateAuthor;
using MediateBookStore.Application.Features.Authors.Commands.DeleteAuthor;
using MediateBookStore.Application.Features.Authors.Commands.UpdateAuthor;
using MediateBookStore.Application.Features.Authors.Queries.GetAllAuthors;
using MediateBookStore.Application.Features.Authors.Queries.GetAuthorDetails;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MediateBookStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllAuthors")]
        public async Task<ActionResult<List<AuthorsVM>>> GetAllAuthors()
        {
            var dtos = await _mediator.Send(new GetAuthorsListQuery());
            return Ok(dtos);
        }

        [HttpGet("{id}", Name = "GetAuthorById")]
        public async Task<ActionResult<AuthorsDetVM>> GetAuthorById(Guid id)
        {
            var getEventDetailQuery = new GetAuthorsDetQuery() { AuthorId = id };
            return Ok(await _mediator.Send(getEventDetailQuery));
        }

        [HttpPost(Name = "AddAuthor")]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateAuthorCommand createAuthorCommand)
        {
            Guid id = await _mediator.Send(createAuthorCommand);
            return Ok(id);
        }

        [HttpPut(Name = "UpdateAuthor")]
        public async Task<ActionResult> Update([FromBody] UpdateAuthorCommand updateAuthorCommand)
        {
            await _mediator.Send(updateAuthorCommand);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteAuthor")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var deleteAuthorCommand = new DeleteAuthorCommand() { Id = id };
            await _mediator.Send(deleteAuthorCommand);
            return NoContent();
        }

    }
}
