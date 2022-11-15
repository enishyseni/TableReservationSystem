using Microsoft.AspNetCore.Mvc;
using Presistence;
using System.Collections.Generic;
using Domain;

namespace API.Controllers
{
    public class ReservationController : BaseApiController

    {
        private readonly DataContext _context;

        public ReservationController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]

        public async Task<ActionResult<List<Reservation>>>GetReservation()
        {
            return await _context.Reservation.ToListAsync();

        }
    }
}