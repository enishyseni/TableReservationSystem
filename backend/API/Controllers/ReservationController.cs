using Microsoft.AspNetCore.Mvc;
using Domain;
using System.Collections.Generic;
using Application.Activites;
using Application.ReservationMediatRClasses;

namespace API.Controllers
{
    public class ReservationController : BaseApiController

    {
      
        // private readonly IMediator _mediator;
        // public ReservationController(IMediator mediator)
        // {
        
        // }

        [HttpGet]

        public async Task<ActionResult<List<Reservation>>>GetReservation()
        {
            return await Mediator.Send(new List.Query());
        }
        [HttpGet("{id}")]

         public async Task<ActionResult<Reservation>>GetReservation(Guid id)
         {
              return await Mediator.Send(new Details.Query{Id = id});
         }

         [HttpPost]

         public async Task<IActionResult>CreateReservation(Reservation reservation)
         {
            return Ok(await Mediator.Send(new Create.Command{Reservation =reservation}));

         }
         [HttpPut("{id}")]

         public async Task<IActionResult>EditReservation(Guid id, Reservation reservation)
         {
            reservation.Id= id;
            return Ok(await Mediator.Send(new Edit.Command{Reservation =reservation}));

         }
         [HttpDelete("{id}")]

         public async Task<IActionResult> DeleteReservation(Guid id)
         {
            return Ok(await Mediator.Send(new Delete.Command{Id=id}));
            

         }

      

    }


}