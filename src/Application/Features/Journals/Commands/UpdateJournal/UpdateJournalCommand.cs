using Application.Features.Journals.Dtos;

namespace Application.Features.Journals.Commands.UpdateJournal
{
    public class UpdateJournalCommand : IRequest<JournalDto>
    {
        public uint Id { get; set; }
        public string? Text { get; set; }
        public uint EventId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
