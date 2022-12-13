using System;
using System.Threading;
using System.Threading.Tasks;
using Application.DTOs;
using Domain;
using MediatR;
using Persistence;

namespace Application.UserMediatRClasses
{
    public class Create
    {
        public User User { get; set; }

        public class Command : IRequest
        {
            public User User { get; set; }
        }


        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }
                public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
                {
                    _context.Users.Add(request.User);

                    await _context.SaveChangesAsync();

                    return Unit.Value;
                }
            }
        }
    }