using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;



namespace Application.ReservationMediatRClasses
{
    public class Create
    {
        
          public class Command : IRequest
        {
           
           public Reservation Reservation{get; set;}


        }

        public class Handler :IRequestHandler<Command>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)

            {
               _context.Reservations.Add(request.Reservation);
               await _context.SaveChangesAsync();

               return Unit.Value;

            }

            

    }
    }
}