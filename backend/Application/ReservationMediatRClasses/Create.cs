using Application.Core;
using Application.DTOs;
using Application.Validators;
using Domain;
using FluentValidation;
using MediatR;
using Persistence;

namespace Application.ReservationMediatRClasses
{
    public class Create
    {
        public class Command : IRequest<Result<Unit>>
        {
            public Reservation Reservation { get; set; }

            public ReservationDTO ReservationDTO { get; set; }
        }

        public class CommandValidator : AbstractValidator<Command>
        {
            public CommandValidator()
            {
                RuleFor(x => x.ReservationDTO).SetValidator(new ReservationValidator());
            }
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
                _context.Reservations.Add(request.Reservation);

                var result = await _context.SaveChangesAsync() > 0;

                if(!result) return Result<Unit>.Failure("Failed to create reservation");

                return Result<Unit>.Success(Unit.Value);
            }

        }
    }
}





