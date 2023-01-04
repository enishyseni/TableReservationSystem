using Newtonsoft.Json;

namespace Application.DTOs
{
    public class MediaDTO : BaseDTO
    {
        [JsonProperty("filePath")]
        public string FilePath { get; set; }

        [JsonProperty("sortOrder")]
        public int SortOrder { get; set; }
    }
}