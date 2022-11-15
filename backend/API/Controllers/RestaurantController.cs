using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class RestaurantController : BaseApiController
    {
        private readonly DataContext _context;
        public RestaurantController(DataContext context)
        {
            context = _context;  
        }

        [HttpGet]
        public async Task<ActionResult<List<Restaurant>>> GetRestaurant()
        {
            return await _context.Restaurants.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Restaurant>> GetRestaurant(Guid id)
        {
            return await _context.Restaurants.FindAsync(id);
        }

        
    }
}