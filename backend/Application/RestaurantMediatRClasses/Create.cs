using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using Application.DTOs;
using Application.Validators;
using Domain;
using FluentValidation;
using MediatR;
using Persistence;


namespace Application.RestaurantMediatRClasses
{
    public class Create
    {
        public class Command :  IRequest<Result<Unit>>
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

        public class Handler : IRequestHandler<Command, Result<Unit>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

           public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {
                _context.Restaurants.Add(request.Restaurant);

                var result = await _context.SaveChangesAsync() > 0;

                if(!result) return Result<Unit>.Failure("Failed to create restaurant");

                return Result<Unit>.Success(Unit.Value);
            }

    
        }

    }
}