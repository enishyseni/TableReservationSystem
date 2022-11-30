using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.ReservationMediatRClasses
{
    public class Details
    {
        public class Query : IRequest<Reservation>
        {
            public Guid Id { get; set; }
        }
        public class Handler : IRequestHandler<Query, Reservation>
        {
            public readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<Reservation> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Reservations.FindAsync(request.Id);
            }
        }
    }
}