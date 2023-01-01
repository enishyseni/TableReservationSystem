namespace Domain
{
    public class User : Base
    {
        public string LastName { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public virtual ICollection<Restaurant> Restaurants { get; set; } = new List<Restaurant>();
    }
}
