namespace Domain.Entities
{
    public class Media : Base
    {
        public string FilePath { get; set; }

        public int SortOrder { get; set; }
    }
}