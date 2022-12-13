using Microsoft.AspNetCore.Mvc;
using Application.ReservationMediatRClasses;
using Application.Activites;
using Application.DTOs;
using Domain;

namespace API.Controllers
{
    public class ReservationController : BaseApiController
    {
        [HttpGet]
        public async Task<IActionResult> GetReservation()
        {
            return HandleResult(await Mediator.Send(new List.Query()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetReservation(Guid id)
        {
            return HandleResult(await Mediator.Send(new Details.Query { Id = id }));
        }

        [HttpPost]
        public async Task<IActionResult> CreateReservation(ReservationDTO reservationDto)
        {
            return HandleResult(await Mediator.Send(new Create.Command { ReservationDTO = reservationDto }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditReservation(Guid id, ReservationDTO reservationDto)
        {
            reservationDto.Id = id;
            return Ok(await Mediator.Send(new Edit.Command { ReservationDTO = reservationDto }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActivity(Guid id)
        {
            return HandleResult(await Mediator.Send(new Delete.Command { Id = id }));
        }
    }
}