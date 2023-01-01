using AutoMapper;
using Domain.Entities;
using MediatR;
using Persistence;

namespace Application.MediaMediatRClasses
{
    public class Edit
    {
        public class Command : IRequest
        {
            public Media Media { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            private readonly IMapper _mapper;
            public Handler(DataContext context, IMapper mapper)
            {
                context = _context;
                mapper = _mapper;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var media = await _context.Medias.FindAsync(request.Media.Id);

                _mapper.Map(request.Media, media);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}