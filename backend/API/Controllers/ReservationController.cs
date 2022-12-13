using Microsoft.AspNetCore.Mvc;
using Application.ReservationMediatRClasses;
using Application.Activites;
using Application.DTOs;
using Domain;
using System.Threading.Tasks;
using System;

namespace API.Controllers
{
    public class ReservationController : BaseApiController
    {
        [HttpGet]
        public async Task<IActionResult> GetReservation()
        {
            return Ok(Mapper.Map<List<UserDTO>>(await Mediator.Send(new List.Query())));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetReservation(Guid id)
        {
            return Ok(Mapper.Map<ReservationDTO>((await Mediator.Send(new Details.Query { Id = id }))));
        }

        [HttpPost]
        public async Task<IActionResult> CreateReservation(ReservationDTO reservationDto)
        {
            return Ok(await Mediator.Send(new Create.Command { ReservationDTO = reservationDto }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditReservation(Guid id, ReservationDTO reservationDto)
        {
            reservationDto.Id = id;
            return Ok(await Mediator.Send(new Edit.Command { Reservation = Mapper.Map<Reservation>(reservationDto)}));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActivity(Guid id)
        {
            return Ok(await Mediator.Send(new Delete.Command { Id = id }));
        }
    }
}