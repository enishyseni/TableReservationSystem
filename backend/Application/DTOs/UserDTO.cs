using Newtonsoft.Json;

namespace Application.DTOs
{
    public class UserDTO : BaseDTO
    {
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phoneNumber")]
        public int PhoneNumber { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("restaurants")]
        public virtual ICollection<RestaurantDTO> Restaurants { get; set; } = new List<RestaurantDTO>();
    }
}