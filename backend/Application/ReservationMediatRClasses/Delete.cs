using Application.Core;
using Domain;
using MediatR;
using Persistence;

namespace Application.Activites
{
    public class Delete
    {
        public class Command : IRequest<Result<Unit>>
        {
            internal User user;
            public Guid Id { get; set; }
            public User User { get; internal set; }
        }
        public class Handler : IRequestHandler<Command, Result<Unit>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {
                var reservation = await _context.Reservations.FindAsync(request.Id);

                if(reservation == null) return null;

                _context.Remove(reservation);

                var result = await _context.SaveChangesAsync() > 0;

                if(!result) return Result<Unit>.Failure("Failed to delete the activity");

                return Result<Unit>.Success(Unit.Value);
            }
        }
    }
}