using MediatR;
using Microsoft.AspNetCore.Mvc;
using Valkaria.Application.Commands.CreateUser;
using Valkaria.Application.Queries.GetUser;

namespace Valkaria.API.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {

            var query = new GetUserQuery(id);

            var result = await _mediator.Send(query);
            
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserInputModel inputModel)
        {
            var commad = new CreateUserCommand(inputModel.Name, inputModel.Email, inputModel.BirthDate);


            var result = await _mediator.Send(commad);

            return CreatedAtAction(nameof(GetUser), new { id = result.Id }, result);
        }
    }
}
