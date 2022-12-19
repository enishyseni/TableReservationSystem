using Microsoft.AspNetCore.Mvc;
using Application.ReservationMediatRClasses;
using Application.Activites;
using Application.DTOs;
using Domain;

namespace API.Controllers
{
    public class RestaurantController : BaseApiController
    {
        [HttpGet]
        public async Task<IActionResult> GetRestaurant()
        {
            var result = Mapper.Map<List<RestaurantDTO>>(HandleResult(await Mediator.Send(new List.Query())));

            return(IActionResult)result;
        }

        [HttpGet("{id}")]
    
        public async Task<IActionResult> GetRestaurant(Guid id)
        {
            var result = Mapper.Map<RestaurantDTO>(HandleResult(await Mediator.Send(new Details.Query{Id = id})));
             
            return(IActionResult)result;
        }



        [HttpPost]

         public async Task<IActionResult> CreateRestaurant(RestaurantDTO restaurantDto)
         {
            return HandleResult(await Mediator.Send(new Create.Command { RestaurantDTO = restaurantDto}));

         }

        [HttpPut("{id}")]
        
         public async Task <IActionResult> EditRestaurant(Guid id, RestaurantDTO restaurantDto)
         {
            restaurantDto.Id = id;
            
            return HandleResult(await Mediator.Send(new Edit.Command { Restaurant = Mapper.Map<Restaurant>}(restaurantDTO)));
         }
                

        [HttpDelete("{id}")]
         public async Task<IActionResult> DeleteRestaurant(Guid id)
         {
            return HandleResult(await Mediator.Send(new Delete.Command{Id = id}));
         }
    }
}



