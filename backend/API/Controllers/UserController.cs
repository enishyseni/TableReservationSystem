using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.DTOs;
using Application.UserMediatRClasses;
using Domain;
using Microsoft.AspNetCore.Mvc;
namespace API.Controllers
{
    public class UserController : BaseApiController
    {
        [HttpGet]

        public async Task<ActionResult<List<UserDTO>>> GetUserDTO()
        {
            return Ok( await Mediator.Send(new List.Query()));

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<UserDTO>> GetUserDTO(Guid id)
        {
            return Ok (await Mediator.Send(new Details.Query { Id = id }));
        }
        [HttpPost("{add}")]
        public async Task<IActionResult> CreateUserDTO(UserDTO userDto)
        {
            return Ok(await Mediator.Send(new Create.Command { UserDTO = userDto }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditUserDTO(Guid id, UserDTO userDto)
        {
            userDto.Id = id;
            return Ok(await Mediator.Send(new Edit.Command { UserdDTO = userDto }));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserDTO(Guid id)
        {
            return Ok(await Mediator.Send(new Delete.Command { Id = id }));
        }

    }

}
