using Domain;
using MediatR;

namespace Application.ReservationMediatRClasses
{
    public class Edit
    {

        public class Command :IRequest
        {
            public Reservation reservation {get; set;}
        }
        public class Handler : IRequestHandler<Command>
        {
            public Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }

    }
}