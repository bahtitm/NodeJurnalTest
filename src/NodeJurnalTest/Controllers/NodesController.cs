using Application.Features.Nodes.Commands.CreateNode;
using Application.Features.Nodes.Commands.DeleteNode;
using Application.Features.Nodes.Commands.UpdateNode;
using Application.Features.Nodes.Queries.GetAll;
using Application.Features.Nodes.Queries.GetDetail;
using Application.Features.Users.Commands.CreateUser;
using Application.Features.Users.Commands.DeleteUser;
using Application.Features.Users.Commands.UpdateUser;
using Application.Features.Users.Queries.GetAll;
using Application.Features.Users.Queries.GetDetail;
using DSEU.Application.Common.Exceptions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NodeJurnalTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class NodesController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var dataSource = await mediator.Send(new GetAllNodeQuery());
            return Ok(dataSource.AsQueryable());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(uint id)
        {
            
            return Ok(await mediator.Send(new GetDetailNodeQuery(id)));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateNodeCommand command)
        {
            await mediator.Send(command);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(uint id, [FromBody] UpdateNodeCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest($"Check request: {id} not equals {command.Id}");
            }
            await mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(uint id)
        {
            await mediator.Send(new DeleteNodeCommand(id));
            return NoContent();
        }
    }
}
