using Application.DTOs;
using Application.UserMediatRClasses;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class UserController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<UserDTO>>> GetUser()
        {
            return Ok(await Mediator.Send(new List.Query()));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserDTO>> GetUser(Guid id)
        {
            return Ok(await Mediator.Send(new Details.Query { Id = id }));
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(UserDTO userDto)
        {
            return Ok(await Mediator.Send(new Create.Command { User = Mapper.Map<User>(userDto) }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditUser(Guid id, UserDTO userDto)
        {
            userDto.Id = id;
            return Ok(await Mediator.Send(new Edit.Command { User = Mapper.Map<User>(userDto) }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            return Ok(await Mediator.Send(new Delete.Command { Id = id }));
        }
    }
}
