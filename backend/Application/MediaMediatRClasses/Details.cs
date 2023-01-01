using Domain.Entities;
using MediatR;
using Persistence;

namespace Application.MediaMediatRClasses
{
    public class Details
    {
        public class Query : IRequest<Media>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Media>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                context = _context;
            }
            public async Task<Media> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Medias.FindAsync(request.Id);
            }
        }
    }
}