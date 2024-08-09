using Application.Features.Journals.Dtos;

namespace Application.Features.Journals.Commands.CreateJournal
{
    public class CreateJournalCommand : IRequest<JournalDto>
    {
        public string? Text { get; set; }
        public uint EventId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
