namespace Domain.Entities
{
    public class Contact : Base
    {
        public User User { get; set; }
        public Restaurant Restaurant { get; set; }
        public string Message { get; set; }
    }
}