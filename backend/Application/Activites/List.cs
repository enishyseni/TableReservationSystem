using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Presistence;

namespace Application.Activites
{
    public class List
    {
        
        public class Query : IRequest<List<Reservation>>{}

        public class Handler : IRequestHandler<Query, List<Reservation>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                context= _context;
            }

            public async  Task<List<Reservation>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Reservations.ToListAsync();
            }
        }
    }
        
   }
    
