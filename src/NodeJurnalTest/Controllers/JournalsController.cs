using Application.Features.Journals.Commands.CreateJournal;
using Application.Features.Journals.Commands.DeleteJournal;
using Application.Features.Journals.Commands.UpdateJournal;
using Application.Features.Journals.Queries.GetAll;
using Application.Features.Journals.Queries.GetDetail;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NodeJurnalTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class JournalsController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var dataSource = await mediator.Send(new GetAllJournalQuery());
            return Ok(dataSource.AsQueryable());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(uint id)
        {
            
            return Ok(await mediator.Send(new GetDetailJournalQuery(id)));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateJournalCommand command)
        {
            await mediator.Send(command);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(uint id, [FromBody] UpdateJournalCommand command)
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
            await mediator.Send(new DeleteJournalCommand(id));
            return NoContent();
        }
    }
}
