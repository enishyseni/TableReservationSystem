using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.DTOs;
using Domain;
using MediatR;
using Persistence;

namespace Application.RestaurantMediatRClasses
{
    public class Create
    {
        public class Command : IRequest
        {
            public Restaurant Restaurant { get; set; }
            public RestaurantDTO RestaurantDTO { get; set; }
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
                _context.Restaurants.Add(request.Restaurant);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}