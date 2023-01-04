using Newtonsoft.Json;

namespace Application.DTOs
{
    public class BaseDTO
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("dateCreated")]
        public DateTime DateCreated { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("dateDeleted")]
        public DateTime DateDeleted { get; set; }

        [JsonProperty("deletedBy")]
        public Guid DeletedBy { get; set; }
    }
}