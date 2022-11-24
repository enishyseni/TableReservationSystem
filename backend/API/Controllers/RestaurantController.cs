using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.RestaurantMediatRClasses;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class RestaurantController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Restaurant>>> GetRestaurant()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Restaurant>> GetRestaurant(Guid id)
        {
            return await Mediator.Send(new Details.Query { Id = id });
        }

        [HttpPost("{add}")]
        public async Task<IActionResult> CreateRestaurant(Restaurant restaurant)
        {
            return Ok(await Mediator.Send(new Create.Command { Restaurant = restaurant }));
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> EditRestaurant(Guid id, Restaurant restaurant)
        {
            restaurant.Id = id;
            return Ok(await Mediator.Send(new Edit.Command { Restaurant = restaurant }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRestaurant(Guid id)
        {
            return Ok(await Mediator.Send(new Delete.Command {Id = id}));
        }
    }
}



