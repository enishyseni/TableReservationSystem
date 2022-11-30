using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;



namespace Application.Activites
{

    public class Delete
    {
        public class Command :IRequest 
        {
            internal User user;

            public Guid Id {get; set;}
            public User User { get; internal set; }
        }
        
        public class Handler :IRequestHandler<Command>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;

            }
            public async Task<Unit> Handle (Command request ,CancellationToken cancellationToken)
            {
                var reservation = await _context.Reservations.FindAsync(request.Id);

                _context.Remove(reservation);
                await _context.SaveChangesAsync();
                return Unit.Value;

            }


        }
    }

}