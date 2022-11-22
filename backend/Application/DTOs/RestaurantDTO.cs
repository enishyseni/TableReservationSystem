using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Application.DTOs
{
    public class RestaurantDTO : BaseDTO
    {
         public string Location { get; set; }

        public string Type { get; set; }
        
        public string MainImage { get; set; }
        public virtual ICollection<Media> Images { get; set; } = new List<Media>();

        public virtual ICollection<User> Users { get; set; } = new List<User>();
        
    }
}