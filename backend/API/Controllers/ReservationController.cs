using Microsoft.AspNetCore.Mvc;
using Domain;
using System.Collections.Generic;
using Application.ReservationMediatRClasses;

namespace API.Controllers
{
    public class ReservationController : BaseApiController

    {
        [HttpGet]
        public async Task<ActionResult<List<Reservation>>> GetReservation()
        {
            return await Mediator.Send(new List.Query());
        }
        [HttpGet("{id}")]

        public async Task<ActionResult<Reservation>> GetReservation(Guid id)
        {
            return await Mediator.Send(new Details.Query { Id = id });
        }

        [HttpPost("{add}")]
        public async Task<IActionResult> CreateReservation(Reservation reservation)
        {
            return Ok(await Mediator.Send(new Create.Command { Reservation = reservation }));
        }
    }
}