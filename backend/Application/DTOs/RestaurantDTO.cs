namespace Application.DTOs
{
    public class RestaurantDTO : BaseDTO
    {
        public string Location { get; set; }
        public string Type { get; set; }
        public string MainImage { get; set; }
        public virtual ICollection<MediaDTO> Images { get; set; } = new List<MediaDTO>();
        public virtual ICollection<UserDTO> Users { get; set; } = new List<UserDTO>();
    }
}