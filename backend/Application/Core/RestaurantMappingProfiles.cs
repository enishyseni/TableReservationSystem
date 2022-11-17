using AutoMapper;
using Domain;

namespace Application.Core
{
    public class RestaurantMappingProfiles : Profile
    {
        public RestaurantMappingProfiles()
        {
            CreateMap<Restaurant, Restaurant>();
        }
    }
}