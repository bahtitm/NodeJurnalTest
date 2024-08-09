namespace Domain
{
    public class Journal: BaseEntity
    {
        public string? Text { get; set; }
        public uint EventId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
