using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.UserMediatRClasses;
using Domain;
using Microsoft.AspNetCore.Mvc;
namespace API.Controllers
{
    public class UserController : BaseApiController
    {
        [HttpGet]

        public async Task<ActionResult<List<User>>> GetUser()
        {
            return await Mediator.Send(new List.Query());

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(Guid id)
        {
            return await Mediator.Send(new Details.Query { Id = id });
        }
        [HttpPost("{add}")]
        public async Task<IActionResult> CreateUser(User user)
        {
            return Ok(await Mediator.Send(new Create.Command { User = user }));
        }
<<<<<<< HEAD
        [HttpPut("edit/{id}")]
=======
        [HttpPut("{id}")]
>>>>>>> e3589a59477a21d1f41ddfa0bf0f90c1e561f3d9
        public async Task<IActionResult> EditUser(Guid id, User user)
        {
            user.Id = id;
            return Ok(await Mediator.Send(new Edit.Command { User = user }));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            return Ok(await Mediator.Send(new Delete.Command { Id = id }));
        }

    }

}
