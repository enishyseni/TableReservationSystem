using AutoMapper;
using Domain;

namespace Application.Core
{
    public class ReservationMappingProfiles : Profile
    {
        public ReservationMappingProfiles()
        {
            CreateMap<Reservation, Reservation>();
        }
    }
}