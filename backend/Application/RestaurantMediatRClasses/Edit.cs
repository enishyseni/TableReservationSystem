using System.Threading;
using System.Threading.Tasks;
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
        public class Command : IRequest
        {
            public Restaurant Restaurant { get; set; }
            public RestaurantDTO RestaurantDTO { get; set; }
        }
           public class CommandValidator : AbstractValidator<Command>
        {
            public CommandValidator()
            {
                RuleFor(x => x.RestaurantDTO).SetValidator(new RestaurantValidator());
              
            }
        }


      

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            private readonly IMapper _mapper;
            public Handler(DataContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var restaurant = await _context.Restaurants.FindAsync(request.Restaurant.Id);

                _mapper.Map(request.Restaurant, restaurant);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}