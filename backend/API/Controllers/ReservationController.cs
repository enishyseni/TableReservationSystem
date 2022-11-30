using Microsoft.AspNetCore.Mvc;
using Domain;
using System.Collections.Generic;
using Application.ReservationMediatRClasses;
using Application.Activites;
using Application.DTOs;

namespace API.Controllers
{
    public class ReservationController : BaseApiController

    {
        [HttpGet]
        public async Task<ActionResult<List<ReservationDTO>>> GetReservationDTO()
        {
            return Ok (await Mediator.Send(new List.Query()));
        }
        [HttpGet("{id}")]

        public async Task<ActionResult<ReservationDTO>> GetReservationDTO(Guid id)
        {
            return Ok (await Mediator.Send(new Details.Query { Id = id }));
        }

        [HttpPost("add")]
        public async Task<IActionResult> CreateReservationDTO(ReservationDTO reservationDto)
        {
            return Ok(await Mediator.Send(new Create.Command { ReservationDTO = reservationDto }));
        }

        [HttpPut("{id}")]

        public async Task<IActionResult>EditReservationDTO(Guid id, ReservationDTO reservationDto)
        {
            reservationDto.Id=id;
            return Ok(await Mediator.Send(new Edit.Command{ReservationDTO = reservationDto}));

        }
        [HttpDelete("{id}")]

        public async Task<IActionResult>DeleteActivityDTO(Guid id)
        {
            return Ok(await Mediator.Send(new Delete.Command{Id = id}));
        }
        
    }
}