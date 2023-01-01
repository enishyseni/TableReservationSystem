using Domain.Entities;
using MediatR;
using Persistence;

namespace Application.MediaMediatRClasses
{
    public class Create
    {
        public class Command : IRequest
        {
            public Media Media { get; set; }
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
                _context.Medias.Add(request.Media);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}