using Microsoft.AspNetCore.Mvc;
using Domain;
using MediatR;

namespace API.Controllers
{
    public class ReservationController : BaseApiController

    {

        private readonly IMediator _mediator;
        public ReservationController()
        {


        }
        
        [HttpGet]
        public async Task<ActionResult<List<Reservation>>> GetReservation()
        {
            return await _mediator.Send(new List.Query());
        }
        [HttpGet("{id}")]

        public async Task<ActionResult<Reservation>> GetReservation(Guid id)
        {
            return Ok();
        }
    }
}