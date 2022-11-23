using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Application.DTOs
{
    public class UserDTO : BaseDTO
    {
         public string LastName { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public virtual ICollection<Restaurant> Restaurants { get; set; } = new List<Restaurant>();
        
    }
}