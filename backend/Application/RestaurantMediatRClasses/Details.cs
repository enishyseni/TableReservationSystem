using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.RestaurantMediatRClasses
{
    public class Details
    {
        public class Query : IRequest<Restaurant>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Restaurant>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<Restaurant> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Restaurants.FindAsync(request.Id);
            }
        }
    }
}