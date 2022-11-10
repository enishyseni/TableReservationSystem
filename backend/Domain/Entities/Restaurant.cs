using System;

namespace Domain
{
    public class Restaurant : Base
    {
        public string Location { get; set; }

        public string Type { get; set; }

        public virtual ICollection<User> Users { get; set; } = new List<User>();
    }
}
