namespace Application.Features.Journals.Dtos
{
    public class JournalDto
    {
        public uint Id { get; set; }
        public string? Text { get; set; }
        public uint EventId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
