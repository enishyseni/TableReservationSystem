using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistence;

namespace Application.MediaMediatRClasses
{
    public class List
    {
        public class Query : IRequest<List<Media>> { }

        public class Handler : IRequestHandler<Query, List<Media>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<Media>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Medias.ToListAsync(cancellationToken);
            }
        }
    }
}