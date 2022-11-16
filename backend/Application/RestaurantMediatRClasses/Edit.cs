using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.RestaurantMediatRClasses
{
    public class Edit
    {
        public class Command : IRequest
        {
            public Restaurant Restaurant { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var restaurant = await _context.Restaurants.FindAsync(request.Restaurant.Id);

                restaurant.Location = request.Restaurant.Location ?? restaurant.Location;
            }
        }
    }
}