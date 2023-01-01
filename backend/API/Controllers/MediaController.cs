using Application.MediaMediatRClasses;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class MediaController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Media>>> GetMedia()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Media>> GetMedia(Guid id)
        {
            return await Mediator.Send(new Details.Query { Id = id });
        }

        [HttpPost]
        public async Task<IActionResult> CreateMedia(Media media)
        {
            return Ok(await Mediator.Send(new Create.Command { Media = media }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditMedia(Guid id, Media media)
        {
            media.Id = id;
            return Ok(await Mediator.Send(new Edit.Command { Media = media }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMedia(Guid id)
        {
            return Ok(await Mediator.Send(new Delete.Command { Id = id }));
        }
    }
}