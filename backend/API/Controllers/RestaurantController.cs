using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.DTOs;
using Application.RestaurantMediatRClasses;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class RestaurantController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<RestaurantDTO>>> GetRestaurantDTO()
        {
            return Ok(await Mediator.Send(new List.Query()));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RestaurantDTO>> GetRestaurant(Guid id)
        {
          return Ok(await Mediator.Send(new Details.Query { Id = id }));

        }

      
        [HttpPost]
        public async Task<IActionResult> CreateRestaurantDTO(RestaurantDTO restaurantDto)

        {
            return Ok(await Mediator.Send(new Create.Command { RestaurantDTO = restaurantDto }));
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> EditRestaurantDTO(Guid id, RestaurantDTO restaurantDto)
        {
            restaurantDto.Id = id;
            return Ok(await Mediator.Send(new Edit.Command { RestaurantDTO = restaurantDto }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRestaurantDTO(Guid id)
        {
            return Ok(await Mediator.Send(new Delete.Command {Id = id}));
        }
    }
}



