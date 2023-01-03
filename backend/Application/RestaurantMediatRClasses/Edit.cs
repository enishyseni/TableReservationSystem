using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using Application.DTOs;
using Application.Validators;
using AutoMapper;
using Domain;
using FluentValidation;
using MediatR;
using Persistence;

namespace Application.RestaurantMediatRClasses
{
    public class Edit
    {
        public class Command : IRequest<Result<Unit>>
        {
            public Restaurant Restaurant { get; set; }

            public RestaurantDTO RestaurantDTO {get; set;}
        }

        public class CommandValidator : AbstractValidator<Command>
        {
            public CommandValidator()
            {
                RuleFor(x => x.RestaurantDTO).SetValidator(new RestaurantValidator());
            }
        }

        public class Handler : IRequestHandler<Command, Result<Unit>>
        {
            private readonly DataContext _context;
            private readonly IMapper _mapper;
            public Handler(DataContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

          public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {
                var restaurant = await _context.Reservations.FindAsync(request.Restaurant.Id);

                if(restaurant == null) return null;

                _mapper.Map(request.Restaurant, restaurant);

                var result = await _context.SaveChangesAsync() > 0;

                if(!result) return Result<Unit>.Failure("Failed to update restaurant");

                return Result<Unit>.Success(Unit.Value);
            }
        }
    }
}