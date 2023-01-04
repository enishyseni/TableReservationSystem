using Newtonsoft.Json;

namespace Application.DTOs
{
    public class RestaurantDTO : BaseDTO
    {
        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("mainImage")]
        public string MainImage { get; set; }

        [JsonProperty("images")]
        public virtual ICollection<MediaDTO> Images { get; set; } = new List<MediaDTO>();

        [JsonProperty("users")]
        public virtual ICollection<UserDTO> Users { get; set; } = new List<UserDTO>();
    }
}