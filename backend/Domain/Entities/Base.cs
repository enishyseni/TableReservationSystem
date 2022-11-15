using System;

namespace Domain
{
    public class Base
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime DateCreated { get; set; }

        public bool Active { get; set; }

        public bool Deleted { get; set; }

        public DateTime DateDeleted { get; set; }

        public Guid DeletedBy { get; set; }
    }
}
