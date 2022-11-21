using AutoMapper;
using Domain;

namespace Application.Core
{
    public class UserMappingProfiles : Profile
    {
         
    
        public UserMappingProfiles()
        {
            CreateMap<User, User>();
        }
    }
        
    }
