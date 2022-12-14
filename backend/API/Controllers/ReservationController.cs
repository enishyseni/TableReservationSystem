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
            var result = Mapper.Map<List<ReservationDTO>>(HandleResult(await Mediator.Send(new List.Query())));

            return (IActionResult)result;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetReservation(Guid id)
        {
            var result = Mapper.Map<ReservationDTO>(HandleResult(await Mediator.Send(new Details.Query { Id = id })));

            return (IActionResult)result;
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

            return HandleResult(await Mediator.Send(new Edit.Command { Reservation = Mapper.Map<Reservation>(reservationDto)}));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActivity(Guid id)
        {
            return HandleResult(await Mediator.Send(new Delete.Command { Id = id }));
        }
    }
}