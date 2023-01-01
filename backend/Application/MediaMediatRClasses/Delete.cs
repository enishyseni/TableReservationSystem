using MediatR;
using Persistence;
using System;

namespace Application.MediaMediatRClasses
{
    public class Delete
    {
        public class Command : IRequest
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                context = _context;
            }
            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var media = await _context.Medias.FindAsync(request.Id);

                _context.Remove(media);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}