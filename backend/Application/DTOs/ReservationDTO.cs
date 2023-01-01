using Domain;

namespace Application.DTOs
{
    public class ReservationDTO : BaseDTO
    {
        public int PhoneNumber { get; set; }

        public string Email { get; set; }

        public DateTime StartDateTime { get; set; }
        public int NumberOfPersons { get; set; }

        public string Status { get; set; }

        public string Description { get; set; }

        public User User { get; set; }

        public Restaurant Restaurant { get; set; }

    }
}