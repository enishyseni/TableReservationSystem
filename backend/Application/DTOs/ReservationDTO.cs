using Domain;
using Newtonsoft.Json;

namespace Application.DTOs
{
    public class ReservationDTO : BaseDTO
    {
        [JsonProperty("phoneNumber")]
        public int PhoneNumber { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("startDateTime")]
        public DateTime StartDateTime { get; set; }

        [JsonProperty("numberOfPersons")]
        public int NumberOfPersons { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("restaurant")]
        public Restaurant Restaurant { get; set; }

    }
}