using Application.Core;
using Application.DTOs;
using Application.Validators;
using AutoMapper;
using Domain;
using FluentValidation;
using MediatR;
using Persistence;

namespace Application.ReservationMediatRClasses
{
    public class Edit
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

            private readonly IMapper _mapper;

            public Handler(DataContext context, IMapper mapper)
            {
                _mapper = mapper;
                _context = context;
            }

            public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {
                var reservation = await _context.Reservations.FindAsync(request.Reservation.Id);

                if(reservation == null) return null;

                _mapper.Map(request.Reservation, reservation);

                var result = await _context.SaveChangesAsync() > 0;

                if(!result) return Result<Unit>.Failure("Failed to update reservation");

                return Result<Unit>.Success(Unit.Value);
            }
        }
    }
}
