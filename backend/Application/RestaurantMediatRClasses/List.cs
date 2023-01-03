using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.RestaurantMediatRClasses
{
    public class List
    {
        public class Query : IRequest<Result<List<Restaurant>>> { }

        public class Handler : IRequestHandler<Query, Result<List<Restaurant>>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<Result<List<Restaurant>>> Handle(Query request, CancellationToken cancellationToken)
            {
                return Result <List<Restaurant>>.Success(await _context.Restaurants.ToListAsync());
            }
        }
    }
}