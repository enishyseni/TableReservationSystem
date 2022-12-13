using Application.Core;
using Application.DTOs;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.ReservationMediatRClasses
{
    public class Details
    {
        public class Query : IRequest<Result<Reservation>>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Result<Reservation>>
        {
            public readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Result<Reservation>> Handle(Query request, CancellationToken cancellationToken)
            {
                var reservation = await _context.Reservations.FindAsync(request.Id);

                return Result<Reservation>.Success(reservation);
            }
        }
    }
}
